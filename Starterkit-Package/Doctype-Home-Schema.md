---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Package Includes"

layout: default
title: Home Document Type
parent: Package Includes
grand_parent: Starterkit Package
nav_exclude: true

doctype: Home
---

# {{ page.doctype }} Document Type Schema

The {{ page.doctype }} Document Type is setup to be the root of the website. 

<dl>
    <dt>Tree Structure</dt> <dd>Document Types > {{ page.doctype }}</dd>
    <dt>Document Type Name</dt> <dd>{{ page.doctype }}</dd>
    <dt>Document Type Alias</dt> <dd>home</dd>
    <dt>Document Type Icon</dt> <dd>icon-home</dd>
    <dt>Design Tabs</dt> <dd>SEO Composition</dd>
    <dt>List View</dt> <dd>No custom settings</dd>
    <dt>Permissions</dt> <dd>Allow as root</dd>
    <dt>Permissions - Allowed child node types</dt> <dd>Components Page, Global Settings</dd>
    <dt>Templates</dt> <dd>Components Page</dd>
</dl>

**SEO Composition Tab Properties:**

Apply the SEO Document Type Composition to the Home Document Type. In addition to the inheritied properties, marked as "Inherited from SEO", add the following:

| Title | Alias | Property Type |
|-------|-------|---------------|
| Twitter Handle | twitterHandle | Textstring |
| Schema Markup Type | schemaMarkupType | Schema Markup Type |
| Business Name | businessName | Textstring |
| Business Address | businessAddress | Nested Address |
| Business Phone | businessPhone | Textstring |