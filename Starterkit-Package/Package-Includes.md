---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Package Includes"

layout: default
title: Package Includes
nav_order: 4
parent: Starterkit Package
has_children: true
---

# Starterkit Package Includes

Listed below are all the items included in the DT Starterkit Package.

**Table of Contents**
1. TOC
{:toc}

## Templates

The below templates are included in the DT Starterkit Package. The list below reflects the master template structure it should be reflected in the Umbraco Templates folder.

- Master
  - Components Page
  - Article Page
- Parent Redirect
- XML Sitemap

## Partial Views

- /Views/Partials/_MetaData.cshtml
- /Views/Partials/_Header.cshtml
- /Views/Partials/_Footer.cshtml
- /Views/Partials/_PageComponents.cshtml
- /Views/Partials/_PC_Switch.cshtml
- /Views/Partials/PageComponents/_PC_GridLayout.cshtml

## Macros

- Form Handler
  - Parameters: 
    - Title: `Inherit From` Alias: `InheritFrom` Type: `Textarea`
- Form Email Master
- Contact Form
- Contact Email Template
- Contact User Email Template

## Macro Partial Views

- /Views/MacroPartials/FormHandler.cshtml
- /Views/MacroPartials/FormEmailMaster.cshtml
- /Views/MacroPartials/ContactForm.cshtml
- /Views/MacroPartials/ContactEmailTemplate.cshtml
- /Views/MacroPartials/ContactUserEmailTemplate.cshtml

## Stylesheets

The user stylesheet will need to be configured to be used by the rich text editor in Umbraco. It is typically an empty file that just imports the main css file to display some of the styling into the rich text editor within Umbraco. The fonts folder in the /css/ directory includes font awesome webfont files. 

- /css/user.css
- /css/bootstrap.css
- /css/fa-all.css
- /css/fonts/ [Directory]

## Scripts

In the scripts folder, there is a `/scss/` or `/less/` directory to store the files used to generate the website stylesheets with the preprocessor you want to use. Typically SASS is the preferred method. You will need to add your sass files in this directory. This makes it so that a backoffice user cannot modify the stylesheet directly from the Umbraco backoffice and forces this type of development to be done by a developer. 

The main.js file is the default file for storing the javascript used by the site. This file would be customized based on what plugins and resources your site needs.

- /scripts/scss/ [Directory]
- /scripts/main.js

## DocumentTypes

- Home
- Blog Page
- Article Page
- Components Page
- Page Components Folder
- Page Components [Organizational Folder]
  - Grid Layout
- Compositions [Organizational Folder]
  - Form Settings
  - Page Settings
  - [SEO](Doctype-SEO-Schema.md)
  - Component Settings
- Content Only [Organizational Folder]
  - Global Settings
  - Nested Address

## DataTypes

- Starterkit [Organizational Folder]
  - Nested Address
  - Better Label
  - Image Picker
  - Navigation MNTP
  - Open Graph Image Cropper
  - Schema Markup Type
  - Simple Editor
  - Single Link
- Page Components [Organizational Folder]
  - Article Image Cropper
  - Grid Layout
- Component Settings [Organizational Folder]
  - Background Position Dropdown
  - Background Repeat Dropdown
  - Background Size Dropdown
  - Horizontal Alignment Dropdown
  - Size Dropdown
  - Text Markup Dropdown
  - Vertical Alignment Dropdown
  - Video Aspect Ratio Dropdown

## Custom Code

PageComponents.cs needs to be updated during buildout with various doctype aliases that allow page components to build out the page.

- /App_Code/PageComponents.cs
- /App_Plugins/BetterLabel/ [Directory]
- /Robots.txt