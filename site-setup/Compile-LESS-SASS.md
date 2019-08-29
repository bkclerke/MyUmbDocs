---
layout: default
title: Compilining LESS and SASS
---

# Compiling LESS and SASS

## Visual Studio Code (MAC)

- For LESS - Use the [Easy Less](https://marketplace.visualstudio.com/items?itemName=mrcrowl.easy-less) plugin for compiling LESS.
- For SASS - Use the [Live Sass Compiler](https://marketplace.visualstudio.com/items?itemName=ritwickdey.live-sass) for compiling SASS.
  - Use the [settings.json](site-setup/files/Compiler-Settings/settings.json) file in your root project folder. 
    - For example, if you open a site folder in VS Code, that will be your root folder and the location of the settings.json file (ie: /scripts/scss/settings.json).

**Minify css files on MAC**

Use [Minify](https://marketplace.visualstudio.com/items?itemName=HookyQR.minify) extension for VS Code. Open the CSS file in VS Code and hit F1 > Minify and this will minify your css file for you as the other plugins do not natively minify your files and sometimes this is needed.

For Umbraco use, typically the built in client dependency handles bundling and minifying the resource files and we typically just reference the normal css file here. Older sites not using the client dependency will need the css file minified.

## Visual Studio (PC)

- Use the [Web Compiler](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebCompiler) plugin for Visual Studio to compile your scripts. This is part of the [Web Essentials](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebEssentials2019) package.
  - Use the [compilerconfig.json](site-setup/files/Compiler-Settings/compilerconfig.json) and [compilerconfig.json.defaults](site-setup/files/Compiler-Settings/compilerconfig.json.defaults) file in the root project folder. For example, if you open a the scripts less/scss folder, that will be your root folder. If you open an entire website, the root of the website will be where you place your config files.