---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Package Includes"

layout: default
title: Nested Address Document Type
parent: Package Includes
grand_parent: Starterkit Package
nav_exclude: true

doctype: Nested Address
---

# {{ page.doctype }} Document Type Schema

The {{ page.doctype }} Document Type is setup to be used for Content only. The node is configured to be used with Nested Content as the address property for the [Home Document Type](#).

<dl>
    <dt>Tree Structure</dt> <dd>Document Types > Content Only > {{ page.doctype }}</dd>
    <dt>Document Type Name</dt> <dd>{{ page.doctype }}</dd>
    <dt>Document Type Alias</dt> <dd>nestedAddress</dd>
    <dt>Document Type Icon</dt> <dd>icon-document</dd>
    <dt>Design Tabs</dt> <dd>Content</dd>
    <dt>List View</dt> <dd>No custom settings</dd>
    <dt>Permissions</dt> <dd>Is an Element Type</dd>
    <dt>Templates</dt> <dd>No custom settings</dd>
</dl>

**Content Tab Properties:**

| Title | Alias | Property Type |
|-------|-------|---------------|
| Street Address | streetAddress | Textstring |
| Street Address 2 | streetAddress2 | Textstring |
| City | city | Textstring |
| State | state | Textstring |
| Zip | zip | Textstring |