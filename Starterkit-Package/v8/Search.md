---
versionFrom: 8
meta.Title: "DT Starterkit Package"
meta.Description: "DT Starterkit Search"

layout: default
title: Search
parent: Package Includes
grand_parent: Starterkit Package
---

# Search
{: .no_toc }

## TOC
{: .no_toc .text-delta }

1. TOC
{:toc}

## All Files

| File Type | Title | Umbraco File Path | Github Link |
|-------|-------|-------|-------|
| Template | Search Page | `~/Views/SearchPage.cshtml` | [View on Github](#) |
| Partial View | Search Form | `~/Views/Partials/Search/_SearchForm.cshtml` | [View on Github](#) |
| Partial View | Search Results | `~/Views/Partials/Search/_SearchResults.cshtml` | [View on Github](#) |

## How It Works

The Search content page utilizes the Search Template. The starterkit includes two partial views on this template for the search form and the search results. The default site search is very basic and returns a list of content items matching the users search with a link to the content page.

For more details on how the search results code works, [checkout the partial view on github](#).


## Setup

1. Setup a content page using the [Search Page Document Type](#) and name the page "Search"
   - The page needs to be called search in order for the URL to be correct and the search functionality to work.
2. Make sure the search page is utilizing the included [Search Template](#)
   - By default the starterkit includes the search form and search results partial views on the search template.

When trying to utilize the site search in other areas of the site, the `_SearchForm.cshtml` partial view can be used to render an input field that will return search results on the Search page. 

**Important Note:** The search results requires that the search page URL be `/search` in order to work properly.