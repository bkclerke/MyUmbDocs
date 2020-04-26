---
versionFrom: 8
meta.Title: "Components Library"
meta.Description: "Page Components Document Type Composition"

layout: default
title: Component Settings
parent: Components Library
nav_order: 2
---

# Component Settings Document Type Composition

The [Component Settings Document Type Composition](/MyUmbDocs/Starterkit-Package/Doctype-Comp-Settings-Schema.html) is installed with the Starterkit Package.

This document type is intended to be a base composition doctype to *most* page components in the component library however there will be some exceptions to this based on the site requirements. 

All of the page component partial view files that use this composition doctype will have the code in it to reference these basic general settings for the page component.

## Component Settings Document Type Schema

The Component Settings Document Type is setup with standard properties to adjust the background styling and spacing of the page component.

[View Component Settings Doctype Schema](/MyUmbDocs/Starterkit-Package/Doctype-Comp-Settings-Schema.html){: .btn .btn-purple }

### Component Settings Composition Code

Base code for the component settings are located in the `~/Views/Partials/PageComponents/_pcGridLayout.cshtml` file that is included in the starterkit. Copied below is the base code to render the standard component settings.

```c#
@{
    // SETUP COMPONENT ID
    string componentId = "pc-my-component-" + Model.Id;

    // COMPONENT BG SETTINGS
    bool hasAreaBgImage = Model.HasValue("areaBgImage");
    string areaBgImagePosition = Model.HasValue("areaBgImagePosition") ? Model.Value("areaBgImagePosition").ToString().ToLower() : "center center";
    string areaBgSize = Model.HasValue("areaBgSize") ? Model.Value("areaBgSize").ToString().ToLower() : "auto";
    string areaBgRepeat = Model.HasValue("areaBgRepeat") ? Model.Value("areaBgRepeat").ToString().ToLower() : "no-repeat";

    // COMPONENT BG COLOR THEME
    string areaBgColor = Model.HasValue("areaBgColor") ? "#" + Model.Value("areaBgColor").ToString() : "transparent";
    string theme = string.Empty;
    if (areaBgColor != "transparent")
    {
        switch (areaBgColor)
        {
            // TO DO: SETUP APPROVED COLOR PICKERS
            case "#":
                theme = "theme-light";
                break;
            default:
                theme = "theme-dark";
                break;
        }
    }

    // SETUP STYLES FOR IMAGE BACKGROUND
    if (hasAreaBgImage)
    {
        var media = Model.Value<IPublishedContent>("areaBgImage");
        if (media != null)
        {
            string areaBgUrl = Model.Value<IPublishedContent>("areaBgImage").Url;

            <text>
                <style>
                    .@(componentId) {
                        background-image:url("@(areaBgUrl)");
                        background-color: @(areaBgColor);
                        background-position: @(areaBgImagePosition);
                        background-size: @(areaBgSize);
                        background-repeat: @(areaBgRepeat);
                    }
                </style>
            </text>
        }
    }
    else if (areaBgColor != "transparent")
    {
        // SETUP STYLES FOR BACKGROUND COLOR ONLY
        <text>
            <style>
                .@(componentId) {
                    background-color: @(areaBgColor);
                }
            </style>
        </text>
    }

    // COMPONENT SPACING
    string topSpace = Model.HasValue("areaTopSpace") ? Model.AreaTopSpace.ToString() : string.Empty;
    if (!string.IsNullOrEmpty(topSpace))
    {
        switch (topSpace)
        {
            case "Small":
                topSpace = "pt-sm";
                break;
            case "Medium":
                topSpace = "pt-md";
                break;
            case "Large":
                topSpace = "pt-lg";
                break;
            default:
                topSpace = string.Empty;
                break;
        }
    }
    string btmSpace = Model.HasValue("areaBottomSpace") ? Model.AreaBottomSpace.ToString() : string.Empty;
    if (!string.IsNullOrEmpty(btmSpace))
    {
        switch (btmSpace)
        {
            case "Small":
                btmSpace = "pb-sm";
                break;
            case "Medium":
                btmSpace = "pb-md";
                break;
            case "Large":
                btmSpace = "pb-lg";
                break;
            default:
                btmSpace = string.Empty;
                break;
        }
    }

    <div id="@componentId" class="pc-my-component-name @theme @topSpace @btmSpace">
        <!-- CONTENT GOES HERE -->
    </div>
}

```