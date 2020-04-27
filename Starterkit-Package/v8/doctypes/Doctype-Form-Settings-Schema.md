---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Package Includes"

layout: default
title: Form Settings Document Type Composition
parent: Package Includes
grand_parent: Starterkit Package
nav_exclude: true

doctype: Form Settings
---

# {{ page.doctype }} Document Type Composition Schema

The {{ page.doctype }} Document Type is setup to be used as a Composition Document Type only. There are no custom settings for the List View, Permission or Templates areas. This is used for all nodes within the site that use a form that requires settings. 

<dl>
    <dt>Tree Structure</dt> <dd>Document Types > Compositions > {{ page.doctype }}</dd>
    <dt>Document Type Name</dt> <dd>{{ page.doctype }}</dd>
    <dt>Document Type Alias</dt> <dd>compFormSettings</dd>
    <dt>Document Type Icon</dt> <dd>icon-settings</dd>
    <dt>Design Tabs</dt> <dd>{{ page.doctype }}</dd>
    <dt>List View</dt> <dd>No custom settings</dd>
    <dt>Permissions</dt> <dd>No custom settings</dd>
    <dt>Templates</dt> <dd>No custom settings</dd>
</dl>

**{{ page.doctype }} Tab Properties:**

| Title | Alias | Property Type | Description |
|-------|-------|---------------|-------------|
| Email From | emailFrom | Textstring | The FROM address of the email. Defaults to no-reply@domain.com|
| Email Recipients | emailRecipients | Textarea | The list of recipient email addresses. One per line. |
| Email Subject | emailSubject | Textstring | Defaults to "Form Submission Received". |
| Success Redirect Page | successRedirectPage | Content Picker | The page to display after a successful submission. |
| Error Redirect Page | errorRedirectPage | Content Picker | The page to display when an error occurs. |