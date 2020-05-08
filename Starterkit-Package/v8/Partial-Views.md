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

| Title | Umbraco File Path | Github Link |
|-------|-------|-------|
| Meta Data | `~/Views/Partials/_MetaData.cshtml` | [View on Github](https://github.com/bkclerke/MyUmbDocs/blob/master/Starterkit-Package/v8/files/Views/Partials/_MetaData.cshtml) |
| Header | `~/Views/Partials/_Header.cshtml` | [View on Github](#) |
| Footer | `~/Views/Partials/_Footer.cshtml` | [View on Github](#) |
| Page Components | `~/Views/Partials/_PageComponents_.cshtml` | [View on Github](#) |
| Page Components Switch | `~/Views/Partials/_PC_Switch_.cshtml` | [View on Github](#) |
| Page Components Grid Layout | `~/Views/Partials/_PC_GridLayout.cshtml` | [View on Github](#) |


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

## Header

## Footer

## Page Components

## Page Components Switch

## Page Components Grid Layout
