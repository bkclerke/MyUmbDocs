---
versionFrom: 8
meta.Title: "DT Form Handler"
meta.Description: "DT Form Handler Package Instructions"

layout: default
title: Render Form Handler Macro on a Template
nav_order: 4
parent: Form Handler Package
---

# Using the Form Handler Macro Directly on a Template

The Form Handler macro can be used directly on a template by navigating to the template within Umbraco, clicking Insert and selecting the Form Handler macro. 

![Form Handler Macro On Template](images/v8/form-handler-macro-template.gif)

Once you have selected the form handler, the [developer settings](How-It-Works.html#developer-settings-explained) will be available to configure in the dialog window. You must configure these settings in order for the Form Handler to work. Once configured on your template, the form handler macro will appear like this:

`@Umbraco.RenderMacro("FormHandler", new {InheritFrom="", FormName="ContactForm", FormClass="", RequiredFields="Name, Email", SendUserEmail="1", UserEmailField="Email", UserEmailSubject="Thank you for contacting us!"})`

You will also need to make sure that the content node using this template has the [Form Settings doctype composition assigned](Doctype-Composition.html#applying-the-form-settings-doctype-composition) to it so that the content editor can set the [form settings](How-It-Works.html#form-settings-explained).