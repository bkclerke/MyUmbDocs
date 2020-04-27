---
versionFrom: 8
meta.Title: "Components Library"
meta.Description: "Page Components Document Type Composition"

layout: default
title: Grid Layout Document Type
parent: Page Components
grand_parent: Components Library
nav_exclude: true

doctype: Grid Layout
---

# {{ page.doctype }} Document Type Schema

The {{ page.doctype }} Document Type is used for general content entry in the website. 

<dl>
    <dt>Tree Structure</dt> <dd>Page Components > {{ page.doctype }}</dd>
    <dt>Document Type Name</dt> <dd>{{ page.doctype }}</dd>
    <dt>Document Type Alias</dt> <dd>pcGridLayout</dd>
    <dt>Document Type Icon</dt> <dd>icon-grid</dd>
    <dt>Design Tabs</dt> <dd>Content</dd>
    <dt>Design Tab Compositions</dt> <dd>Component Settings</dd>
    <dt>List View</dt> <dd>No custom settings</dd>
    <dt>Permissions</dt> <dd>No custom settings</dd>
    <dt>Templates</dt> <dd>Parent Redirect</dd>
</dl>

**Content Tab Properties:**

| Title | Alias | Property Editor | Property Editor Alias |
|-------|-------|---------------|-------------|
| Grid | grid | Grid layout | Umbraco.Grid |

## Data Type References

The Grid layout property editor used for the Grid property is configured based off of the initial design evaluation with different row configurations as needed.

To learn about configuring the grid layout data type built in umbraco, [refer to the docs here](https://our.umbraco.com/documentation/getting-started/backoffice/property-editors/built-in-property-editors/grid-layout/Configuring-The-Grid-Layout-Datatype).

## Page Component Code

**File location:** `~/Views/Partials/PageComponents/_PC_GridLayout.cshtml`

[View code file on GitHub](https://github.com/bkclerke/MyUmbDocs/blob/master/Components-Library/v8/files/Views/Partials/PageComponents/_PC_GridLayout.cshtml){: .btn .btn-purple }

**Details:**
In most cases, the Grid Layout page component has only the basic customization settings that all page components utilize. This component is used to define the base functionality for the [DocType Composition Component Settings](/Starterkit-Package/Doctype-Comp-Settings-Schema.md).