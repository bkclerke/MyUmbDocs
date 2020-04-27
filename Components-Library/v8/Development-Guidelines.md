---
versionFrom: 8
meta.Title: "Components Library"
meta.Description: "Page Components Development Guidelines"

layout: default
title: Development Guidelines
parent: Components Library
nav_order: 1
---

# Development Guidelines



## Document Types

Make sure to add the Document Type Alias for each page that requires the Page Components Folder to the code in the `~/App_Code/PageComponents.cs` file. This will auto generate the Page Components Folder for new pages.

## Page Component Permissions

Generally, page components will be children of the Page Components Folder. The Page Components Folder Document Type is included with the DT Starterkit that you've installed. 

To add or remove a page component, navigate to the Page Components Folder Document Type and click the Permissions section. The "Allow child node types" area is where you can add or remove page components.

_**Tip:** For better usability for content editors, make all your page components are one color and use different icons that best relate to what the component renders._

## Page Component File Naming Conventions

Page components should be created in the Document Types > Page Components folder within the Settings Section of Umbraco. New page components should have a descriptive and distinctive name while trying to keep it as short as possible. 

_**Tip:** You can enter a description for the different page components on the Document Type itself if you need to have more details._
	
For example if you were to create a new page component called "Banner Section" you would then setup the alias of that Document Type as "pcBannerSection". Page component alias' should be camel cased and prefixed with "pc" before the title. 

Partial view files for page components are in the Umbraco Settings Section in the Partial Views > Page Components folder. You can find these files in the ~/Views/Partials/PageComponents/ folder in Umbraco file system. To create a new partial view, right click the PageComponents folder in Umbraco, click Create and select "New empty partial view". The proper naming convention for page component partial views appends "_PC_" before the title of the page component. Using the banner section example, the partial view used to render it would be named "_PC_BannerSection.cshtml". 

## Page Component Configuration

To improve editor experience, make page components stand out in the content tree by using a different color icon. For example, our default page component setup uses the color orange for page components and a different color for all other page types.

**List View**
The List View tab can be configured based on each components needs. 

**Permissions**
Permissions are customized based on each component needs.

**Templates**
Page Components utilize the Parent Redirect template included in the Starterkit. This ensures that in the case a component page is landed on, it will redirect to the actual page that utilizes the content. 