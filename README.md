<img src="resources/logo.png" width = "100">

# ECLP.Net
Easy CommandLine Parser for .Net Standard

[![MIT License](https://img.shields.io/apm/l/atomic-design-ui.svg?)](https://github.com/melharfi/ECLP/blob/master/LICENSE)
[![Version](https://badge.fury.io/gh/tterb%2FHyde.svg)](https://github.com/melharfi/ECLP)
![GitHub Release Date](https://img.shields.io/github/release-date/melharfi/ECLP?color=Green)
[![GitHub Release](https://img.shields.io/github/v/release/melharfi/ECLP)](https://github.com/melharfi/ECLP/releases) 
[![PayPal](https://img.shields.io/badge/paypal-donate-yellow.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=VN92ND2CDMX92)
![GitHub language count](https://img.shields.io/github/languages/count/melharfi/ECLP?color=red)

This command Line parser use 2 ways of parsing.

Either from a string command or from an array like the one passed to the main method as parameters.

just reference ECLP by nuget or be dowloading the latest release and add it to your references.

ECLP defin 5 types of arguments as Verbs

**Type 1)** Args are arguments could be any referenced primitif type like string, int, bool, float, and char ex "hello 5 true 3,5 T".
Argument is parsed to it's appropriate type, otherwize it return the default value as string
Make attention that positions of arguments is necessary so you can identify them in the Args list by there index.

**Type 2)** Flags are string type arguments without values, prefixed with double dash -- "--verbose --start --friendlyfire".
Value is not parsed and it's a string type.

**Type 3)** Properties are a property with value prefixed with -p "-p driver=steave -p age=30".
Value is parsed to appropriate type, otherwize the default format is 'string'

**Type 4)** Collections is a property with a collection of values separated by Pipe |.
Should be prefixed with -c "-c players=steave|john|clark -c ages=21|15|30" players is the name of the property, and steave,john,clark are a list of object values.

**Type 5)** ExCollections for Extanded Collections, it's a property with a collection of sub properties that have a value.
Should be prefixed with -xc "-xc players=steave:21|john:15|clark:30 -xc adresses=Japan:Tokyo|USA:Washington".
Properties are separated by Pipe |, and sub property name and it's values are separated by double point : .

## *Tutorial*

See tutorials section
[https://melharfi.github.io/repos/ECLP/description.html](https://melharfi.github.io/repos/ECLP/description.html)


## .Net Standard
this repo is for Net standard, there's another repo for .net framework 4.0
https://github.com/melharfi/ECLP
