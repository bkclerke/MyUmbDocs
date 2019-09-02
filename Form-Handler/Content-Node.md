---
versionFrom: 8
meta.Title: "DT Form Handler"
meta.Description: "DT Form Handler Package Instructions"

layout: default
title: Using the Form Handler on a Content Node
nav_order: 5
parent: Form Handler Package
---

# Using the Form Handler on a Content Node

Once you have [applied the form settings doctype composition](Doctype-Composition.md#applying-the-form-settings-doctype-composition) to your content node, the [form settings](How-It-Works.md#form-settings-explained) will be available to configure and you can insert the Form Handler macro onto the page. The macro can be inserted on the page in multiple ways depending on your Umbraco setup. The simplest way to insert a macro on a page is to navigate to the Rich Text Editor and use the Insert Macro icon to insert the form handler macro and configure the [developer settings](How-It-Works.md#developer-settings-explained).

![Insert Form Handler Macro In RTE](images/v8/insert-form-handler-macro-rte.gif)

Note that if your macro is configured and setup on a node that does not have the Form Settings applied, make sure you set the Inherit From setting on your Form Handler macro to the correct node containing your form settings.