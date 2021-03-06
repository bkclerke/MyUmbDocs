---
layout: default
title: Read Me
nav_exclude: true
---

# Introduction

This project contains documentation on my Umbraco process for buildouts.


## Process Flow

The process documentation found here goes in a particular order.

1. [Site Setup Checklist](Site-Setup/Introduction.md)
2. [Starterkit Package](Starterkit-Package/Introduction.md)
   - This installs the files for the Form Handler and the base data types and files needed for the Component Library
3. [Form Handler Package](Form-Handler/Introduction.md)
   - Handles form submissions for the entire site
4. [Component Library](Component-Library/Introduction.md)

## The Method

These Umbraco builds are based around a theory of building pages with components. This method gives the content editors a lot of flexibility within Umbraco when building out pages.

The starterkit installed the base files required for handling form submissions and general page component builds with the grid layout.

Our builds use the latest version of Bootstrap 4 which makes using the Umbraco Grid editor an easy choice for handling general content and page layouts.


___

#### How to run this repo project locally
1. To setup your local dev environment run `bundle install` OR 
2. You may need to update your project, run `bundle update` to update your gems to the latest version
3. To test the theme and run the project locally run `bundle exec jekyll serve` and open your browser to `http://localhost:4000`