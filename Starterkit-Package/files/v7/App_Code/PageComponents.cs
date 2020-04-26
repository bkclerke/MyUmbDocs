using Umbraco.Core;
using Umbraco.Core.Events;
using Umbraco.Core.Models;
using Umbraco.Core.Publishing;
using Umbraco.Core.Services;
using System.Linq;

namespace My.PageComponents
{
    public class PageComponents : ApplicationEventHandler
    {

        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            ContentService.Saved += ContentServiceSaved;
            ContentService.Published += ContentServicePublished;
        }

        private void ContentServicePublished(IPublishingStrategy sender, PublishEventArgs<IContent> args)
        {
            foreach (var node in args.PublishedEntities)
            {
                if ((node.ContentType.Alias == "home" || node.ContentType.Alias == "componentsLandingPage" || node.ContentType.Alias == "componentsTextPage" || node.ContentType.Alias == "showDetailPage" || node.ContentType.Alias == "searchPage") &&
                    node.Children().Where(x => x.ContentType.Alias == "pcFolder").FirstOrDefault() == null)
                {
                    var contentService = ApplicationContext.Current.Services.ContentService;
                    var pageComponentsFolder = contentService.CreateContent("Page Components", node.Id, "pcFolder");
                    contentService.SaveAndPublishWithStatus(pageComponentsFolder);
                }
            }
        }

        private void ContentServiceSaved(IContentService sender, SaveEventArgs<IContent> args)
        {
            foreach (var node in args.SavedEntities)
            {
                if ((node.ContentType.Alias == "home" || node.ContentType.Alias == "componentsLandingPage" || node.ContentType.Alias == "componentsTextPage" || node.ContentType.Alias == "showDetailPage" || node.ContentType.Alias == "searchPage") &&
                    node.Children().Where(x => x.ContentType.Alias == "pcFolder").FirstOrDefault() == null)
                {
                    var contentService = ApplicationContext.Current.Services.ContentService;
                    var pageComponentsFolder = contentService.CreateContent("Page Components", node.Id, "pcFolder");
                    contentService.Save(pageComponentsFolder);
                }
            }
        }
    }
}