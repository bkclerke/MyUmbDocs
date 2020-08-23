---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Dynamic XML Sitemap"

layout: default
title: Dynamic XML Sitemap
parent: Package Includes
grand_parent: Starterkit Package
---

# Dynamic XML Sitemap
{: .no_toc }

## Table of Contents
{: .no_toc .text-delta }

1. TOC
{:toc}

## All Files

| File Type | Title | Umbraco File Path | Github Link |
|-------|-------|-------|-------|
| Template | XML Sitemap | `~/Views/xmlSitemap.cshtml` | [View on Github](https://github.com/bkclerke/MyUmbDocs/blob/master/Starterkit-Package/v8/files/Views/xmlSitemap.cshtml) |

## How It Works

The XML Sitemap template generates a dynamicly updated XML Sitemap to submit to search engies. This updates based on the content structure within Umbraco and is kept updated as new content is published or unpublished.

By default the XML Sitemap excludes the following:
1. `hideInSitemap` property is checked true - this is included on the [Page Settings Document Type](/Starterkit-Package/v8/doctypes/Doctype-Page-Settings-Schema.html)
2. Document Types with the alias `pcFolder` - this is used for the page components buildout
3. Document Types with the alias `altLink` - typically this is used for alternative links for navigation purposes
4. Document Types with the alias `xmlSitemap` - so not to include the sitemap in the sitemap
5. Document Types with the template alias `parentRedirect`
6. Document Types with no template

**Please Note:** The page URLs are generated with the trailing slash "/" removed from the page URL.

## Setup

1. Setup a content page using the [XML Sitemap Document Type](/Starterkit-Package/v8/doctypes/Doctype-XML-Sitemap-Schema.html) and name the page "XML Sitemap"
2. Make sure the XML Sitemap page is utilizing the included [XML Sitemap Template](https://github.com/bkclerke/MyUmbDocs/blob/master/Starterkit-Package/v8/files/Views/xmlSitemap.cshtml)

That is it. Once you have your page utilizing your sitemap template, you should be able to hit the `/xml-sitemap` URL and view your XML Sitemap. This is the URL that you can submit to search engies and utilize in your [robots.txt](../v8/files/robots.txt) file.