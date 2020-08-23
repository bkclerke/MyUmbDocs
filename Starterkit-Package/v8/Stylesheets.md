---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Stylesheets"

layout: default
title: Stylesheets
parent: Package Includes
grand_parent: Starterkit Package
---

# Starterkit Stylesheets
{: .no_toc }

## Table of Contents
{: .no_toc .text-delta }

1. TOC
{:toc}

## File Structure

```
 └──   base/
 │  ├────   _base.scss
 │  ├────   _navbar.scss
 │  ├────   _spacing.scss
 │  └────   _type.scss
 └──   images/
 │  └────   logo.png
 ├──   main.css
 ├──   main.css.map
 ├──   main.scss
 └──   settings.json
```


[View on Github](https://github.com/bkclerke/MyUmbDocs/tree/master/Starterkit-Package/v8/files/scripts/scss){: .btn .btn-purple}

## How It Works

The starterkit has base styles included for themeing layouts and utilizing functionality for the included bootstrap header and for typical page component structure.

The `_base.scss` file has the main site variables, extends, mixins and Umbraco grid and rich text editor layout styling and features.

The `_navbar.scss` includes functionality that is overviewed in the [header partial views](/Starterkit-Package/v8/Partial-Views.html#header) documentation. This file is not meant to be adjusted. Making changes to his file can result in undesired effects to the navigation in the different views available.

The `_spacing.scss` includes general layout spacing utilizations for umbraco page components and layout. Page components allow for small, medium and large spacing. The base variables for the small, medium and large sizes are defined here as well as the various classes for margin and padding spacing options.

The `_type.scss` includes a basic setup for header styles and font sizing options available in the site. These are recommended for use but this file is meant to be customized to your site design needs.

The `logo.png` file in the `~/scripts/scss/images/` folder is meant to be the site default logo image that would render in the header area.

The `main.scss` file is where all the partial stylesheets are combined to create the final website `main.css` file. This final file gets bundled and minified into the client dependency resources on the master template. 

## Adding Custom Stylesheets

When adding new styles to your site, create a `/theme/` folder in the `~/scripts/scss/` folder to put your new styles in. You can then import the files into the `main.scss` to include them into your `main.css` compiled file.