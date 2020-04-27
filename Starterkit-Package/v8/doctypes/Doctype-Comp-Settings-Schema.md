---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Package Includes"

layout: default
title: Component Settings Document Type Composition
parent: Package Includes
grand_parent: Starterkit Package
nav_exclude: true

doctype: Component Settings
---

# {{ page.doctype }} Document Type Composition Schema

The {{ page.doctype }} Document Type is setup to be used as a Composition Document Type only. This is used for all nodes within the site that have a page template.

<dl>
    <dt>Tree Structure</dt> <dd>Document Types > Compositions > {{ page.doctype }}</dd>
    <dt>Document Type Name</dt> <dd>{{ page.doctype }}</dd>
    <dt>Document Type Alias</dt> <dd>compComponentSettings</dd>
    <dt>Document Type Icon</dt> <dd>icon-settings</dd>
    <dt>Design Tabs</dt> <dd>{{ page.doctype }}</dd>
    <dt>List View</dt> <dd>No custom settings</dd>
    <dt>Permissions</dt> <dd>No custom settings</dd>
    <dt>Templates</dt> <dd>No custom settings</dd>
</dl>

**{{ page.doctype }} Tab Properties:**

| Title | Alias | Property Type | Description |
|-------|-------|---------------|-------------|
| Settings Label | settingsLabel | Better Label | `<div class="bl-title">Instructions</div><div class="bl-text">Configure your component settings here. Make sure to adjust the top and bottom space to accommodate your content and design.</div>` |
| Top Space | areaTopSpace | Size Dropdown |  |
| Bottom Space | areaBottomSpace | Size Dropdown |  |
| Background Color | areaBgColor | Approved Color |  |
| Background Image | areaBgImage | Image Picker |  |
| Background Image Position | areaBgImagePosition | Background Position Dropdown |  |
| Background Size | areaBgSize | Background Size Dropdown |  |
| Background Repeat | areaBgRepeat | Background Repeat Dropdown |  |