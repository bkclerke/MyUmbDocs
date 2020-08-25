---
versionFrom: 8
meta.Title: "Components Library"
meta.Description: "Page Components Development Guidelines"

layout: default
title: Development Guidelines
parent: Components Library
nav_order: 1
---

# Development Guidelines



## Document Types

Make sure to add the Document Type Alias for each page that requires the Page Components Folder to the code in the `~/App_Code/PageComponents.cs` file. This will auto generate the Page Components Folder for new pages.

## Page Component Permissions

Generally, page components will be children of the Page Components Folder. The Page Components Folder Document Type is included with the DT Starterkit that you've installed. 

To add or remove a page component, navigate to the Page Components Folder Document Type and click the Permissions section. The "Allow child node types" area is where you can add or remove page components.

_**Tip:** For better usability for content editors, make all your page components are one color and use different icons that best relate to what the component renders._

## Page Component File Naming Conventions

Page components should be created in the Document Types > Page Components folder within the Settings Section of Umbraco. New page components should have a descriptive and distinctive name while trying to keep it as short as possible. 

_**Tip:** You can enter a description for the different page components on the Document Type itself if you need to have more details._
	
For example if you were to create a new page component called "Banner Section" you would then setup the alias of that Document Type as "pcBannerSection". Page component alias' should be camel cased and prefixed with "pc" before the title. 

Partial view files for page components are in the Umbraco Settings Section in the Partial Views > Page Components folder. You can find these files in the ~/Views/Partials/PageComponents/ folder in Umbraco file system. To create a new partial view, right click the PageComponents folder in Umbraco, click Create and select "New empty partial view". The proper naming convention for page component partial views appends "_PC_" before the title of the page component. Using the banner section example, the partial view used to render it would be named "_PC_BannerSection.cshtml". 

Learn More About [Document Type Naming Conventions](/Starterkit-Package/v8/Document-Types.html#document-type-naming-conventions){: .btn .btn-purple}

## Page Component Configuration

To improve editor experience, make page components stand out in the content tree by using a different color icon. For example, our default page component setup uses the color orange for page components and a different color for all other page types.

**List View**

The List View tab can be configured based on each components needs. 

**Permissions**

Permissions are customized based on each component needs.

**Templates**

Page Components utilize the Parent Redirect template included in the Starterkit. This ensures that in the case a component page is landed on, it will redirect to the actual page that utilizes the content.

## Page Component Code File Conventions

You will notice that the current library of page components sticks to a similar setup for the code file. This setup requires that your new page component utilizes the [component settings](/Starterkit-Package/v8/doctypes/Doctype-Comp-Settings-Schema.html) document type schema as a composition. These are the properties we are writing code for initially in our file. If you do not utilize this and your page component is completely custom, disregard the code listed specifically but keep in mind that this convention may be helpful for your developers to setup styles for this page component.

### Step 1: Component ID

The initial code implements a unique component ID based off of the component name and Model Id. The unique ID is for use by the developer in case they need to target this area specifically. The naming convention for the ID follows this method: `pc-component-name-` followed by the `Model.Id` as shown below.

```
// SETUP COMPONENT ID
string componentName = "pc-grid-layout";
string componentId = componentName + "-" + Model.Id;
```

This would output an ID similar to `pc-grid-layout-1931` where the `Model.Id` changes based on the component's unique ID and allows the developer to target this item specifically in a page's markup.

The `componentName` is the base component name css class utilized in the css to setup the base layout and styles for the component.

### Step 2: Component Background Settings

The next area sets up the component background settings and color theme. These are the base settings setup in the [DocType Composition Component Settings](/Starterkit-Package/v8/doctypes/Doctype-Comp-Settings-Schema.html). 

Typically the page components allow for a custom background image, thus setting up the css for the `background-image`, `background-size`, `background-position`, and `background-repeat` values.

```
// COMPONENT BG SETTINGS
bool hasAreaBgImage = Model.HasValue("areaBgImage");
string areaBgImagePosition = Model.HasValue("areaBgImagePosition") ? Model.Value("areaBgImagePosition").ToString().ToLower() : "center center";
string areaBgSize = Model.HasValue("areaBgSize") ? Model.Value("areaBgSize").ToString().ToLower() : "auto";
string areaBgRepeat = Model.HasValue("areaBgRepeat") ? Model.Value("areaBgRepeat").ToString().ToLower() : "no-repeat";
```

The color theme is setup based on your design evaluation. Basic page components include a light and dark theme. This must be manually configured based on your design theme to set the light and dark values. 

```
// COMPONENT BG COLOR THEME
string areaBgColor = Model.HasValue("areaBgColor") ? "#" + Model.Value("areaBgColor").ToString() : "transparent";
string theme = string.Empty;
if (areaBgColor != "transparent")
{
    // TODO: THIS WILL NEED TO BE CONFIGURED MANUALLY BASED ON YOUR THEME
    switch (areaBgColor)
    {
        case "#000000":
            theme = "theme-light";
            break;
        case "#FFFFFF":
            theme = "theme-dark";
            break;
        default:
            theme = "theme-dark";
            break;
    }
}
```
It is important to note that **the theme is adjusting the text color values here**. This means that when your banner component has a dark theme by default, we are assuming the background is a light color (ie. White) and the text theme will be dark (ie. Black). This theme assures that we have proper contrast between our text and background color values on our website. This also ensures that we can manually set a light or dark theme based on our background images to make sure that our text is readable.

***Tip:** When setting up page component styles in your css files, a `theme-light` or `theme-dark` class will be added to your page component. Utilize this to setup overrides for your header tags, font colors and link colors.*

The next area will setup your background image styles *if* there is a background image selected on the page component. Otherwise a flat background color will be displayed *if* a color is selected.

```
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
```

### Step 3: Component Spacing

The component spacing is setup utilizing a dropdown list that allows the user to setup Small, Medium or Large spacing values. This is utilized for all page component spacing. It is broken down into top and bottom spacing for page components to allow the content editors to have control over the spacing within components on a page. 

Since the content editors are in charge of their content, they also have to be educated on the importance of maintaining the design as well. *With great power comes great responsibility!*

```
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
```

### Step 4: Add Custom Functionality

Once you have your base component settings covered, this is where you would begin adding any custom functionality needed for your new page component.

For example if you have multiple child items of a specific type that you need to create a list for, do it here. You can check if the list has items later, this is where you want to setup your vairables that you need for your page component.

### Step 5: Component Setup

It is time to setup your markup for your custom page component. Inside of the main component `div` tag is where you begin building your new page component.

```
<div id="@componentId" class="pc-grid-layout @theme @topSpace @btmSpace">
    ...
</div>
```

***Tip:** The [grid layout](/Components-Library/v8/Page-Components/Grid-Layout.html) utilzes the most basic setup with the [component settings](/Starterkit-Package/v8/doctypes/Doctype-Comp-Settings-Schema.html) composition. To save time setting up new page component files, we use the gird layout code file to start our new page component files. In the new files, we remove the `GetGridHtml` method since this is specific to the grid layout component, but we leave the outter div. The outter div is what we need to wrap our new page component in.*

When rendered on the website you would see a div with a unique ID and multiple classes including the base component name class (for general styling purposes), the theme (light or dark) and the top and bottom spacing.

The rendered div would look something like this:

```
<div id="pc-grid-layout-1931" class="pc-grid-layout theme-dark pt-sm pb-sm">
    ...
</div>
```

This allows your developer to setup a base set of styles for the component and a unique target to the specific component on a page. It also allows for theming based off of the light or dark settings for the general component and sets up the spacing for the top and bottom of the page component giving the editor more contorl over the look for page.