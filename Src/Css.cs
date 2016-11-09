﻿namespace KtaneWeb
{
    sealed partial class KtanePropellerModule 
    {
        public static string Css = @"

body {
    max-width: 65em;
    margin: 0 auto 10em;
    font-family: 'Special Elite', serif;
}

div.heading {
    margin: 3em 0 1.5em;
    overflow: auto;
}

img.logo {
    float: left;
}

div.filters {
    float: right;
    font-size: 10pt;
    text-align: left;
    margin-left: 2em;
}

div.filters .filter-section {
    margin-top: .5em;
}

div.heading div.selectables {
    float: right;
    font-size: 10pt;
    text-align: right;
}

div.head {
    font-size: 11pt;
    font-weight: bold;
    text-decoration: underline;
}

.selectables label.selected {
    font-weight: bold;
}

table {
    border-collapse: collapse;
    border: 1px solid black;
    width: 100%;
}

td, th {
    border: 1px solid black;
    vertical-align: middle;    
    padding: .3em .7em 0;
}

td.icons {
}

img.icon {
    width: 32px;
}

img.mod-icon {
    width: 32px;
    margin: -.5em .5em -.25em 0;
    vertical-align: bottom;
}

.json-link {
    float: right;
    margin-top: 1em;
}

.credits {
    margin-top: 1em;
}

.credits .credited {
    text-decoration: dotted underline;
}

kbd {
    font-family: inherit;
    font-size: inherit;
    font-weight: inherit;
    font-style: inherit;
    text-decoration: underline;
}

textarea { width: 100%; height: 50em; }

div.error {
    background: #fee;
    text-align: center;
    border: 1px solid black;
    font-size: 15pt;
    padding: 1em 3em;
    margin: .5em 0;
}

";
    }
}
