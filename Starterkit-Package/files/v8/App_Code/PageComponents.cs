using System.Linq;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Events;
using Umbraco.Core.Services;
using Umbraco.Core.Services.Implement;

namespace My.PageComponents
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

        public PageComponents(ServiceContext services)
        {
            _services = services;
        }

        // initialize: runs once when Umbraco starts
        public void Initialize()
        {
            ContentService.Published += ContentService_Published;
        }

        // terminate: runs once when Umbraco stops
        public void Terminate()
        {
            ContentService.Published -= ContentService_Published;
        }

        private void ContentService_Published(IContentService sender, ContentPublishedEventArgs e)
        {
            foreach (var node in e.PublishedEntities)
            {
                if ((node.ContentType.Alias == "componentsPage" || node.ContentType.Alias == "home") &&
                    !_services.ContentService.GetPagedChildren(node.Id, 0, 1000, out _).Any(x => x.ContentType.Alias == "pcFolder"))
                {
                    var pageComponentsFolder = _services.ContentService.CreateContent("Page Components", node.GetUdi(), "pcFolder");
                    _services.ContentService.SaveAndPublish(pageComponentsFolder);
                }
            }
        }
    }
}