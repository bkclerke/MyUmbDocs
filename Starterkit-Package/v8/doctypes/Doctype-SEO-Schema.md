---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Package Includes"

layout: default
title: SEO Document Type Composition
parent: Package Includes
grand_parent: Starterkit Package
nav_exclude: true

doctype: SEO
---

# {{ page.doctype }} Document Type Composition Schema

The {{ page.doctype }} Document Type is setup to be used as a Composition Document Type only. This is used for all nodes within the site that act as pages and require meta data that includes schema and open graph information. 

<dl>
    <dt>Tree Structure</dt> <dd>Document Types > Compositions > {{ page.doctype }}</dd>
    <dt>Document Type Name</dt> <dd>{{ page.doctype }}</dd>
    <dt>Document Type Alias</dt> <dd>compSEO</dd>
    <dt>Document Type Icon</dt> <dd>icon-settings</dd>
    <dt>Design Tabs</dt> <dd>{{ page.doctype }}</dd>
    <dt>List View</dt> <dd>No custom settings</dd>
    <dt>Permissions</dt> <dd>No custom settings</dd>
    <dt>Templates</dt> <dd>No custom settings</dd>
</dl>

**{{ page.doctype }} Tab Properties:**

| Title | Alias | Property Type |
|-------|-------|---------------|
| Page Title Tag | pageTitleTag | Textstring |
| Meta Description | metaDescription | Textarea |
| Open Graph Image | ogImage | Open Graph Image Cropper |
| Canonical URL | canonicalTag | Textstring |