---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Partial Views"

layout: default
title: Partial Views
parent: Package Includes
grand_parent: Starterkit Package
---

# Starterkit Partial Views
{: .no_toc }

## PARTIAL VIEWS
{: .no_toc .text-delta }

1. TOC
{:toc}

## All Files
{: .no_toc }

{% include starterkit-partialviews.md %}


## Meta Data

The meta data partial view sets up general meta data for all pages within the Umbraco website that inherit from the Master template.

For the open graph data, the meta data on the home page will need to be filled out at the very least to allow for default values to be set if pages do not have data entered.

- `title` sets the Page Title Tag from the pageTitleTag property. If empty, the value will default to the page Name.
- `ogTitle` sets the Open Graph Title from the ogTitle property. If empty, the value will default to the title value.
- `description` sets the page meta description from the metaDescription property. If empty, the value will default to the home page metaDescription property.
- `siteDomain` generates the current site domain.
- `pageUrl` generates the raw url without the trailing "/".
  - The page url will check for the umbracoUrlAlias property to see if there are any url alias' and will update the pageUrl value to the page url instead of the raw url.
- `canonicalTag` sets the canonical tag value if specified. If empty, this will not be populated.
- `imgUrl` checks for the ogImage property on the current page or the home page. If the current page does not have an ogImage, the home page ogImage will be used for the open graph image. 
- `twitter` sets the twitter site and creator for the twitter card data. If empty, this will be blank.
- `schemaType` sets the schema type from the schemaType property. If empty, the value will be blank.
- `bussinessName` sets the schema business name from the businessName property. If empty, the value will be blank.
- `businessPhone` sets the schema business phone number from the businessPhone property. If empty, the value will be blank.
- `businessAddress` sets the schema business address from the businessAddress property. If empty, no address information will be shown.

[View on Github](https://github.com/bkclerke/MyUmbDocs/blob/master/Starterkit-Package/v8/files/Views/Partials/_MetaData.cshtml){: .btn .btn-purple}

## Header

The header partial view will render a customized Bootstrap navbar within a header element. If the global settings document type is available in the content tree, the logo will pull from the media picker `headerLogoLg` property otherwise it will default to use a logo located in `/scripts/scss/images/logo.png`.

The navbar can be configured to:
1. Show/Hide the dropdown menu
2. Show/Hide the dropdown arrows
3. Have the dropdown menu display when hovered or when clicking dropdown arrows

The included styles and markup have been modified to configure the entire navigation to have clickable links for pages, even if the page has a dropdown menu. The responsive navigation is also keyboard accesible and will display arrows when tabbing through the navigation.

The header partial contains a `navHasArrows` variable that is by default set to false to not show the navbar dropdown arrows. This is a manual setting that needs to be set in the partial view file. The global settings document type, if available, has a setting to show or hide the dropdown menu. If there is no global settings in the content tree the `showDropdown` variable will default to false and not show the dropdown menu.

The navigation pages displayed in the navbar will default to visible child pages of the home page. By default it is configured to to ignore the following document types:
1. Page Components Folder
2. Global Settings
3. XML Sitemap

If the global settings document type is available in the content tree, the `mainNav` content picker is where the navigation pages are selected to be displayed within the navbar. 

[View on Github](https://github.com/bkclerke/MyUmbDocs/blob/master/Starterkit-Package/v8/files/Views/Partials/_Header.cshtml){: .btn .btn-purple}

## Footer

The footer partial view is setup as a placeholder with a container row.

[View on Github](https://github.com/bkclerke/MyUmbDocs/blob/master/Starterkit-Package/v8/files/Views/Partials/_Footer.cshtml){: .btn .btn-purple}

## Page Components

The page components partial view is setup to handle rendering of the page components on a page. The functionality is explained in detail in the [page components documentation](/Components-Library.html).

[Learn More About Page Components](/Components-Library.html){: .btn .btn-purple}

## Page Components Grid Layout

The grid layout page component is included in the starterkit for general content pages. The functionality is explained in detail in the [grid layout page component](/Components-Library/Page-Components.html) documentation.

[Learn More About Page Components](/Components-Library.html){: .btn .btn-purple}