# Contributing

This file goes over the overall structure of the template

## Building

First run `dotnet restore`.

Then run `dotnet pack --no-build`.

The `--no-build` is bc we don't want to compile anything (technically you *can* build but it'll just make a bunch of junk files).

### Releasing

Bump the version in `OuterWildsModTemplate.csproj` and dispatch the "Publish Package" action. 

## Layout

### templates/OuterWildsModTemplate

This has the actual template in it, in the future we might want to add more (like maybe an alpha mod template?).  It's better adding it here since then they only need to install one package and they'll get both templates.

### templates/OuterWildsModTemplate/.template.config/template.json

This holds the configuration for the template, here's where you'll go to update OWML and the GameLibs, I made them symbols because then we only have to change this file when OWML or the game libs update and not have to worry about anything else.

#### Symbols

- `$safeprojectname$`: The name the user set for the project
- `$username$`: The author name the user entered
- `$year$`: The current year
- `$owmlVersion$` The current OWML version
- `$gameLibsVersion$`: The current game libs version
- `usesNH`: Whether the user wants to add New Horizons to the project

### templates/OuterWildsModTemplate/nh-stuff

Everything in this folder is only copied if `usesNH` is true.

### templates/OuterWildsModTemplate/.github/workflows/release.yml

A convenient workflow that allows people to generate a release with the correct tag, version, etc. automatically. Also refuses to run if the version in `manifest.json` is already released.

## Helpful Links

- [Getting Started With Templates](https://learn.microsoft.com/en-us/dotnet/core/tools/custom-templates)
- [Creating a Project Template for dotnet new](https://learn.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-project-template?source=recommendations)
- [Creating Template Packages](https://learn.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-template-package)
- [Conditional Processing Syntax](https://github.com/dotnet/templating/wiki/Conditional-processing-and-comment-syntax)

