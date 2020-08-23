---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Package Includes"

layout: default
title: Global Settings Document Type
parent: Document Types
grand_parent: Package Includes
nav_exclude: true

doctype: Global Settings
---

# {{ page.doctype }} Document Type Schema

The {{ page.doctype }} Document Type is setup to be used for Content only. The single node lives under the homepage in the site and typically handles the site navigation settings.

<dl>
    <dt>Tree Structure</dt> <dd>Document Types > Content Only > {{ page.doctype }}</dd>
    <dt>Document Type Name</dt> <dd>{{ page.doctype }}</dd>
    <dt>Document Type Alias</dt> <dd>globalSettings</dd>
    <dt>Document Type Icon</dt> <dd>icon-globe-alt</dd>
    <dt>Design Tabs</dt> <dd>Header, Global Markup</dd>
    <dt>List View</dt> <dd>No custom settings</dd>
    <dt>Permissions</dt> <dd>No custom settings</dd>
    <dt>Templates</dt> <dd>Parent Redirect</dd>
</dl>

**Header Tab Properties:**

| Title | Alias | Property Type |
|-------|-------|---------------|
| Logo Desktop | headerLogoLg | Image Picker **Mandatory* |
| Main Navigation | mainNav | Navigation MNTP |
| Show Dropdown | showDropdown | True/false |

**Global Markup Tab Properties:**

| Title | Alias | Property Type | Description |
|-------|-------|---------------|-------------|
| Head Tag | globalHeadTag | Textarea | Inserted in the head tag tag markup. |
| Body Tag | globalBodyTag | Textarea | Inserted at the beginning of body tag markup. |
| Scripts | globalScripts | Textarea | Inserted at the bottom of body tag markup. |