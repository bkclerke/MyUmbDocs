---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Package Includes"

layout: default
title: Package Includes
nav_order: 1
parent: Starterkit Package
has_children: true

packageVersion: 2
---

# Starterkit Package Includes
{: .no_toc }

*Version {{ page.packageVersion }} Compatible with Umbraco {{ page.versionFrom }}+*

Listed below are all the items included in the Starterkit Package.

## Table of Contents
{: .no_toc .text-delta }

1. TOC
{:toc}

## Templates

The below templates are included in the Starterkit Package.

{% include starterkit-views.md %}


## Partial Views

The below partial views are included in the Starterkit Package.

{% include starterkit-partialviews.md %}

[Partial View Files Explained](/Starterkit-Package/v8/Partial-Views.html){: .btn .btn-purple}

## Macros

The macros included in the starterkit listed below are features directly related to the form handler to handle all form submissions within Umbraco. [View Form Handler Documentation](/Form-Handler.html).

- Form Handler
  - Macro partial view: `~/Views/MacroPartials/FormHandler.cshtml`
  - Parameters: 
    1. Title: `Inherit From` Alias: `InheritFrom` Type: `Textarea`
- Form Email Master
  - Macro partial view: `~/Views/MacroPartials/FormEmailMaster.cshtml`
- Contact Form
  - Macro partial view: `~/Views/MacroPartials/ContactForm.cshtml`
- Contact Email Template
  - Macro partial view: `~/Views/MacroPartials/ContactEmailTemplate.cshtml`
- Contact User Email Template
  - Macro partial view: `~/Views/MacroPartials/ContactUserEmailTemplate.cshtml`

## Stylesheets

Basic unmodified vendor stylesheets are included in the starterkit. These files are located in the `/css/` folder. 

The master template utilizes these stylesheets by default with the client dependency to bundle and minify these resources. You can update these to use the latest version of the plugin when you start a site.

- `~/css/user.css`
  - The user stylesheet will need to be configured to be used by the rich text editor in Umbraco. It is typically an empty file that just imports the main css file to display some of the styling into the rich text editor within Umbraco. [View on Github](https://github.com/bkclerke/MyUmbDocs/blob/master/Starterkit-Package/v8/files/css/user.css).
- `~/css/bootstrap.css`
  - The starterkit includes an unmodified version of the vendor <a href="https://getbootstrap.com" target="_blank">Bootstrap</a> stylesheet.
- `~/css/fa-all.css`
  - The starterkit includes the vendor <a href="https://fontawesome.com" target="_blank">FontAwesome</a> stylesheet. The stylesheet name has been updated and the webfonts file path has been updated to reflect the new directory location but the styles remain untouched.
- `~/css/fonts/` [Directory]
  - The fonts directory includes unmodified vendor <a href="https://fontawesome.com" target="_blank">FontAwesome</a> webfont files.

### Base Stylesheet Structure

The starterkit base stylesheets are located in the `~/scripts/scss/` folder. Using this directory makes it so that a backoffice user cannot modify the compiled stylesheet directly from the Umbraco backoffice.


[View Base Stylesheet Structure](/Starterkit-Package/v8/Stylesheets.html){: .btn .btn-purple}

## Scripts

The starterkit includes the following for getting started:

- `~/scripts/scss/` [Directory]
  - In the scripts folder, there is a `/scss/` or `/less/` directory to store the files used to generate the website stylesheets with the preprocessor you want to use. 
  - Using this directory makes it so that a backoffice user cannot modify the compiled stylesheet directly from the Umbraco backoffice.
  - Learn More about the [Base Stylesheet Structure](/Starterkit-Package/v8/Stylesheets.html).
- `~/scripts/main.js`
  - The main.js file includes a custom function for linking directly to bootstrap accordion items and opening them on page load. [View on Github](https://github.com/bkclerke/MyUmbDocs/blob/master/Starterkit-Package/v8/files/scripts/main.js).
  - This file is intended for initializing custom scripts, plugins and resources your site needs.
  - This file is included in the master template client dependency to bundle and minify this resource. 
- `~/scripts/bootstrap.bundle.min.js`
  - The starterkit includes an unmodified version of the vendor <a href="https://getbootstrap.com" target="_blank">Bootstrap</a> javascript.
- `~/scripts/jquery-3.5.1.slim.min.js`
  - The starterkit includes an unmodified version of the vendor jquery library that <a href="https://getbootstrap.com" target="_blank">Bootstrap</a> requires.
- `~/scripts/jquery.validate-1.15.0.min.js`
  - The starterkit includes an unmodified version of the vendor jquery validate library. This is utilized when building custom forms with the [form handler](/Form-Handler.html).

### Recommended Scripts and Plugins

- `~/scripts/matchheight.min.js`
  - A jquery plugin called <a href="https://brm.io/jquery-match-height/" target="_blank">Match Heights</a> is used frequently in builds.

## DocumentTypes

{% include starterkit-doctypes.md %}

There are important practices to follow to keep your site organized and easy for editors to use when setting up your Umbraco website. **Please read the doctype setup instructions and important notes about doctype naming conventions.**

[Doctype Setup Instructions](/Starterkit-Package/v8/Document-Types.html){: .btn .btn-purple}

## DataTypes

{% include starterkit-datatypes.md %}

## Custom Code

| File Path | Description | Learn More |
|-----|-----|-----|
| `~/App_Code/PageComponents.cs` | PageComponents.cs needs to be updated during buildout with various document type aliases in order to auto generate the Page Components Folder child node type. | [View Docs](/Components-Library.html#how-it-works) |
| `~/App_Plugins/BetterLabel/`  [*Directory*]| This is a custom property type for more detailed labels within the Umbraco backoffice. | *N/A* |
| `~/Robots.txt` | Basic configured robots.txt file for search engines configured to ignore certail folder structure for Umbraco. | [View File](files/robots.txt) |
