using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Events;
using Umbraco.Core.Services;
using Umbraco.Core.Services.Implement;

namespace DiscoverTec.Umbraco.Components.v8.App_Code
{
    public class PageComponentsComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            // Append our component to the collection of Components
            // It will be the last one to be run
            composition.Components().Append<PageComponents>();
        }
    }

    public class PageComponents : IComponent
    {
        private readonly ServiceContext _services;
        private readonly List<string> _aliases;

        public PageComponents(ServiceContext services)
        {
            _services = services;
            // This could be configurable in web.config.
            _aliases = new List<string> { "home", "componentsPage", "blogPage", "articlePage" };
        }

        // initialize: runs once when Umbraco starts
        public void Initialize()
        {
            ContentService.Published += ContentService_Published;
            ContentService.Saved += ContentService_Saved;
        }

        // terminate: runs once when Umbraco stops
        public void Terminate()
        {
            ContentService.Published -= ContentService_Published;
            ContentService.Saved -= ContentService_Saved;
        }

        private void ContentService_Published(IContentService sender, ContentPublishedEventArgs e)
        {
            foreach (var node in e.PublishedEntities)
            {
                if (NodeHasPcFolder(node.Id))
                {
                    continue;
                }

                if (IsValidContentTypeAlias(node.ContentType.Alias))
                {
                    var pageComponentsFolder = _services.ContentService.CreateContent("Page Components", node.GetUdi(), "pcFolder");
                    _services.ContentService.SaveAndPublish(pageComponentsFolder);
                }
            }
        }

        private void ContentService_Saved(IContentService sender, ContentSavedEventArgs e)
        {
            foreach (var node in e.SavedEntities)
            {
                if (NodeHasPcFolder(node.Id))
                {
                    continue;
                }

                if (IsValidContentTypeAlias(node.ContentType.Alias))
                {
                    var pageComponentsFolder = _services.ContentService.CreateContent("Page Components", node.GetUdi(), "pcFolder");
                    _services.ContentService.Save(pageComponentsFolder);
                }
            }
        }

        private bool NodeHasPcFolder(int nodeId)
        {
            return _services.ContentService.GetPagedChildren(nodeId, 0, 1000, out _).Any(x => x.ContentType.Alias == "pcFolder");
        }

        private bool IsValidContentTypeAlias(string contentTypeAlias)
        {
            return _aliases.Contains(contentTypeAlias, StringComparer.OrdinalIgnoreCase);
        }
    }
}