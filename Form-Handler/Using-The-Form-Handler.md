---
versionFrom: 8
meta.Title: "DT Form Handler"
meta.Description: "DT Form Handler Package Instructions"

layout: default
title: Using The Form Handler
nav_order: 2
parent: Form Handler Package
---

# Using the Form Handler

**Table of Contents**
1. TOC
{:toc}

The process for using the form handler is listed below but please make sure to read the [setup a new form](#setup-a-new-form) section before you proceed with creating new forms using the form handler. It is important to follow the naming conventions otherwise your form will not work.

## Setup A New Form

You will need to setup 3 macros for each new form with a specific file naming convention. For example, for a "Contact Form" you would setup the following macros:

1. Contact Form
2. Contact Form *User Email Template*
3. Contact Form *Email Template*

**Important Note About Form Naming Conventions**: Each form will need to have the same name in the beginning of the file, for example, "Contact Form"; and the other two files will need to be identical with the additional words "Email Template" and "User Email Template". It is important to check your spelling here. Make sure that you are following this format, otherwise the Form Handler will not be able to find the correct form macros. **The form handler is case senstive**.

The form handler setting for `FormName` requires the main form name value. Do not insert special characters into this name. At most, you can use spacing, which the Form Handler will remove to search for macro aliases. In this example, the form name would be "Contact Form". The form handler will then search for the "Contact Form User Email Template" and "Contact Form Email Template" macros automatically. This is why the naming convention process must be followed.

### Create New Macro Partial View Form Files

**Important!** Read [setting up a new form](#setup-a-new-form) before creating new macro partial view form files.

For your new form, you will find it easiest to setup the form files within the Umbraco backoffice. This is because when you create a new macro partial view file in the backoffice, Umbraco will create the macro associated with that file as well. This saves you a step.

Navigate to the Settings section, right click on the Partial View Macro Files under the Templating section and click Create. Select New Partial View Macro. Give your macro a name and Save the new file. You will need to do this 3 times for your new form following the naming conventions specified in the [setup a new form](#setup-a-new-form) section.

![Create Macro Partial View](images/v8/create-macro-partial-view.gif)


### Configure Email Template

The Contact Form Email Template is plain html markup that is rendered within the `{INNER_CONTENT}` area of the Form Email Master Template. The markup you insert here will need to be compatible with email clients.

This email is what is sent to the email recipients configured on the form settings.

### Configure User Email Template

The Contact Form User Email Template is plain html markup that is rendered within the `{INNER_CONTENT}` area of the Form Email Master Template. The markup you insert here will need to be compatible with email clients.

This email is what is sent to your user who fills out your form when an email address is provided.