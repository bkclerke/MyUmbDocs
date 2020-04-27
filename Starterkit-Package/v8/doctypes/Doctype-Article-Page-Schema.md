---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Package Includes"

layout: default
title: Article Page Document Type
parent: Package Includes
grand_parent: Starterkit Package
nav_exclude: true

doctype: Article Page
---

# {{ page.doctype }} Document Type Schema

The {{ page.doctype }} Document Type is confugred to be a base starter for the article page and populate the schema markup included on the article template. 

<dl>
    <dt>Tree Structure</dt> <dd>Document Types > {{ page.doctype }}</dd>
    <dt>Document Type Name</dt> <dd>{{ page.doctype }}</dd>
    <dt>Document Type Alias</dt> <dd>articlePage</dd>
    <dt>Document Type Icon</dt> <dd>icon-newspaper-alt</dd>
    <dt>Design Tabs</dt> <dd>Content</dd>
    <dt>Design Tab Compositions</dt> <dd>SEO, Page Settings</dd>
    <dt>List View</dt> <dd>No custom settings</dd>
    <dt>Permissions</dt> <dd>No custom settings</dd>
    <dt>Templates</dt> <dd>Article Page</dd>
</dl>

**Content Tab Properties:**

| Title | Alias | Property Type |
|-------|-------|---------------|
| Title | articleTitle | Textstring |
| Date | articleDate | Date Picker *Mandatory |
| Author | articleAuthor | Textstring |
| Article Image | articleImage | Article Image Cropper |
| Preview Text | previewText | Textarea |