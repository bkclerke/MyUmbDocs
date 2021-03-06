---
versionFrom: 8
meta.Title: "Components Library"
meta.Description: "Page Components Document Type Composition"

layout: default
title: Page Components Folder Document Type
parent: Page Components
grand_parent: Components Library
nav_exclude: true

doctype: Page Components Folder
---

# {{ page.doctype }}
{: .no_toc }

## Table of Contents
{: .no_toc .text-delta }

1. TOC
{:toc}

## {{ page.doctype }} Document Type Schema

The {{ page.doctype }} Document Type is used for organizing various page components in the content tree. This node is auto-generated by the custom code `~/App_Data/PageComponents.cs` file when a content editor saves a node that uses the page components configured.

<dl>
    <dt>Tree Structure</dt> <dd>Document Types > {{ page.doctype }}</dd>
    <dt>Document Type Name</dt> <dd>{{ page.doctype }}</dd>
    <dt>Document Type Alias</dt> <dd>pcFolder</dd>
    <dt>Document Type Icon</dt> <dd>icon-folder-close color-orange</dd>
    <dt>Design Tabs</dt> <dd>No custom settings</dd>
    <dt>List View</dt> <dd>No custom settings</dd>
    <dt>Permissions - Allowed child node types</dt> <dd>Site Specific Page Components</dd>
    <dt>Templates</dt> <dd>None</dd>
</dl>


## How It Works