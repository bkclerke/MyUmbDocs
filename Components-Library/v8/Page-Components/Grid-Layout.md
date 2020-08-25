---
versionFrom: 8
meta.Title: "Components Library"
meta.Description: "Page Components Document Type Composition"

layout: default
title: Grid Layout Page Component
parent: Page Components
grand_parent: Components Library
nav_exclude: true

doctype: Grid Layout
---

# {{ page.doctype }}
{: .no_toc }

## Table of Contents
{: .no_toc .text-delta }

1. TOC
{:toc}

## Introduction to the {{ page.doctype }} Page Component

The {{ page.doctype }} Page Component allows an editor to easily setup a grid content area for their website. The content allowed within the grid layout is completely customizable and configured by a developer during the buildout.

![Grid Layout Content Example](/Components-Library/v8/images/grid-layout-content-example.gif)

To learn more about the default Grid Layout property editor included in Umbraco, <a href="https://our.umbraco.com/documentation/getting-started/backoffice/property-editors/built-in-property-editors/grid-layout/" target="_blank">refer to the Umbraco docs here</a>.

## {{ page.doctype }} Document Type Schema

The {{ page.doctype }} Document Type is used for general content entry in the website. 

<dl>
    <dt>Tree Structure</dt> <dd>Document Types > Page Components > {{ page.doctype }}</dd>
    <dt>Document Type Name</dt> <dd>{{ page.doctype }}</dd>
    <dt>Document Type Alias</dt> <dd>pcGridLayout</dd>
    <dt>Document Type Icon</dt> <dd>icon-grid color-orange</dd>
    <dt>Design Tabs</dt> <dd>Content</dd>
    <dt>Design Tab Compositions</dt> <dd>Component Settings</dd>
    <dt>List View</dt> <dd>No custom settings</dd>
    <dt>Permissions - Allowed child node types</dt> <dd>Site Specific Macro Items</dd>
    <dt>Templates</dt> <dd>None</dd>
</dl>

### Design Tabs

**Content Tab Properties:**

| Title | Alias | Property Editor | Property Editor Alias |
|-------|-------|---------------|-------------|
| Grid | grid | Grid layout | Umbraco.Grid |

### Data Type References

The Grid layout property editor used for the Grid property is configured based off of the initial design evaluation with different row configurations as needed.

To learn about configuring the grid layout data type built in umbraco, <a href="https://our.umbraco.com/documentation/getting-started/backoffice/property-editors/built-in-property-editors/grid-layout/Configuring-The-Grid-Layout-Datatype" target="_blank">refer to the Umbraco docs here</a>.

## Page Component Code

| Page Component | File Path | Github Link |
|-------|-------|-------|
| {{ page.doctype }} | `~/Views/Partials/PageComponents/_pcGridLayout.cshtml` | [View on Github](https://github.com/bkclerke/MyUmbDocs/blob/master/Starterkit-Package/v8/files/Views/Partials/PageComponents/_pcGridLayout.cshtml) |

### How It Works

The {{ page.doctype }} Page Component acts as a base for all page components. The [Starterkit Package](/Starterkit-Package.html) installs the base page components functionality along with the {{ page.doctype }} Page Component. 

Because the {{ page.doctype }} Page Component utilizes the most basic settings for page components, this sets the standard for the doctype composition [Component Settings](/Starterkit-Package/v8/doctypes/Doctype-Comp-Settings-Schema.html) as well as the partial view code when creating new page components.

To learn more about how page components work, see the Components Library [How It Works](/Components-Library.html#how-it-works) documentation.