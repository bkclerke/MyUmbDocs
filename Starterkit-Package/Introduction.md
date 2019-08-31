---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Package Includes"

layout: default
title: Starterkit Package
nav_order: 4
---

# DT Starterkit Package

This package setup begins after the [Site Setup Checklist](../Site-Setup/Site-Setup-Checklist.md) has been completed.

The starterkit package assumes that the build out will follow the [page components method](/Components-Library/Developer/Component-Library-Explained.md) of setting up a website and therefore includes the initial basic components for setting up the page components and installing the [grid layout page component](#).

The package includes meta data setup for basic SEO data, Open Graph data, and schema markup. There is an article page included assuming that the site will use a blog of some sort and need the schema markup implemented for that as well. The schema markup for the article is within the article template itself. The doctype with the basic properties setup is also included.

The partial view files included have pre-existing markup. The _Header.cshtml file includes header markup that has been slightly modified from Bootstrap v4 to have multiple styling options based on variables for arrows or hovering while remaining usable for keyboard only users. You can read more about individual files on their detailed pages referenced below.

The starterkit also includes the **DT Form Handler** package to handle form submissions. Documentation for the form handler [can be found here](../Form-Handler/Introduction.md).

## Setup Instructions

1. Install the DT Starterkit package via the Install Local option the Umbraco Packages section.
2. Configure Data Types
   - Configure rich text editor stylesheets and toolbar settings
   - Configure grid layout and rich text editor stylesheet and toolbar settings
3. Adjust template inheritance in settings section - This is because the files come into umbraco with the proper code but the tree structure doesnt appear to register that some templates are using the Master template for the master. 
   - ![Set template master template](images/v8/page-set-master-temp.png)

## Package Includes

Listed below are all the items included in the DT Starterkit Package.

### Templates

The below templates are included in the DT Starterkit Package. The list below reflects the master template structure it should be reflected in the Umbraco Templates folder.

- Master
  - Components Page
  - Article Page
- Parent Redirect
- XML Sitemap

### Partial Views

- /Views/Partials/_MetaData.cshtml
- /Views/Partials/_Header.cshtml
- /Views/Partials/_Footer.cshtml
- /Views/Partials/_PageComponents.cshtml
- /Views/Partials/_PC_Switch.cshtml
- /Views/Partials/PageComponents/_PC_GridLayout.cshtml
- /Views/Partials/PageComponents/_PC_FormSection.cshtml (*requires form handler*)

### Macros

- Form Handler
- Form Email Master
- Contact Form
- Contact Email Template
- Contact User Email Template

### Macro Partial Views

- /Views/MacroPartials/FormHandler.cshtml
- /Views/MacroPartials/FormEmailMaster.cshtml
- /Views/MacroPartials/ContactForm.cshtml
- /Views/MacroPartials/ContactEmailTemplate.cshtml
- /Views/MacroPartials/ContactUserEmailTemplate.cshtml

### Stylesheets

The user stylesheet will need to be configured to be used by the rich text editor in Umbraco. It is typically an empty file that just imports the main css file to display some of the styling into the rich text editor within Umbraco. The fonts folder in the /css/ directory includes font awesome webfont files. 

- /css/user.css
- /css/bootstrap.css
- /css/fa-all.css
- /css/fonts/...

### Scripts

In the scripts folder, we include a `/scss/` or `/less/` directory to store the files used to generate the website stylesheets with the preprocessor you want to use. Typically we use SASS so you will need to add your sass files in this directory. This makes it so that a backoffice user cannot modify the stylesheet directly from the Umbraco backoffice and forces this type of development to be done by a developer. 

The main.js file is the default file for storing the javascript used by the site. This file would be customized based on what plugins and resources your site needs.

- /scripts/scss/ [Directory]
- /scripts/main.js

### DocumentTypes

- Home
- Blog Page
- Article Page
- Components Page
- Page Components Folder
- Page Components [Organizational Folder]
  - Grid Layout
  - Form Section
- Compositions [Organizational Folder]
  - Form Settings
  - Page Settings
  - SEO
  - Component Settings
- Content Only [Organizational Folder]
  - Global Settings
  - Nested Address

### DataTypes

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

### Custom Code

PageComponents.cs needs to be updated during buildout with various doctype aliases that allow page components to build out the page.

- /App_Code/PageComponents.cs
- /App_Plugins/BetterLabel/ [Directory]
- /Robots.txt