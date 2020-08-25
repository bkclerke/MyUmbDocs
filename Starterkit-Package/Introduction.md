---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Package Includes"

layout: default
title: Starterkit Package
nav_order: 4
permalink: /Starterkit-Package
has_children: true

packageVersion: 2
---

# Starterkit Package
{: .no_toc }

## Table of Contents
{: .no_toc .text-delta }

1. TOC
{:toc}

## Requirements

**Package Version:** {{ page.packageVersion }} <br />
**Umbraco Version:** {{ page.versionFrom }}



## Setup

### Step 1 - Complete Site Setup Checklist

First, run through the [Site Setup Checklist](site-setup/Site-Setup-Checklist.html#site-setup-checklist). Once this has been completed it is time to Install the Starterkit Package.

### Step 2 - Install Starterkit Package

1. Install the Starterkit Package via the Install Local option the Umbraco Packages section.
   - ![Install Local Package](/Starterkit-Package/v8/images/umbraco-packages-install-screen.png)
2. Configure the following Data Types
   - Richtext editor
     - Adjust toolbar options as needed
     - Assign user stylesheet
     - Turn off image resizing by setting 'Maximium size for inserted images' to 0 Pixels.
   - Grid Layout Richtext editor
     - Adjust toolbar options as needed
     - Assign user stylesheet
     - Turn off image resizing by setting 'Maximium size for inserted images' to 0 Pixels.
3. Adjust template inheritance in settings section - This is because the files come into umbraco with the proper code but the tree structure doesnt appear to register that some templates are using the Master template for the master. 
   - ![Set template master template](/Starterkit-Package/v8/images/page-set-master-temp.png)

The rest of the starterkit setup starts with customzing your page components based off your design evaluation. 

## Package Includes

The Starterkit Package includes various, document types, templates, partial views, search and sitemap functionality to get websites up and running quicker.

[View Package Includes](/Starterkit-Package/v8/Package-Includes.html){: .btn .btn-purple}