---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Package Includes"

layout: default
title: Page Settings Document Type Composition
parent: Document Types
grand_parent: Package Includes
nav_exclude: true

doctype: Page Settings
---

# {{ page.doctype }} Document Type Composition Schema

The {{ page.doctype }} Document Type is setup to be used as a Composition Document Type only. This is used for all nodes within the site that have a page template.

<dl>
    <dt>Tree Structure</dt> <dd>Document Types > Compositions > {{ page.doctype }}</dd>
    <dt>Document Type Name</dt> <dd>{{ page.doctype }}</dd>
    <dt>Document Type Alias</dt> <dd>compPageSettings</dd>
    <dt>Document Type Icon</dt> <dd>icon-settings</dd>
    <dt>Design Tabs</dt> <dd>{{ page.doctype }}, Markup</dd>
    <dt>List View</dt> <dd>No custom settings</dd>
    <dt>Permissions</dt> <dd>No custom settings</dd>
    <dt>Templates</dt> <dd>No custom settings</dd>
</dl>

**{{ page.doctype }} Tab Properties:**

| Title | Alias | Property Type |
|-------|-------|---------------|
| Hide In Navigation | umbracoNaviHide | True/false |
| Umbraco Redirect | umbracoRedirect | Content Picker |
| Umbraco Url Alias | umbracoUrlAlias | Textstring |
| Hide In Sitemap | hideInSitemap | True/false |
| No Index | noIndex | True/false |

**Markup Tab Properties:**

| Title | Alias | Property Type | Description |
|-------|-------|---------------|-------------|
| Head Tag | cpHead | Textarea | Inserted in the head tag markup. |
| Scripts | cpScripts | Textarea | Inserted at the bottom of the body tag markup. |