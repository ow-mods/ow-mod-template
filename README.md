# Outer Wilds Mod Template

A nuget package that contains a template for creating outer wilds mods

## Installation

Run

```ps
dotnet new --install Bwc9876.OuterWildsModTemplate
```

## Usage

Check the [getting started](https://owml.outerwildsmods.com/guides/getting_started.html) page on the OWML docs for a more thorough guide.

## Command Line Usage

Run

```ps
dotnet new sln --name MySolutionName
dotnet new OuterWildsMod -n MyProjectName --AuthorName MyName
dotnet sln add MyProjectName/
```

This creates a new solution file in the current folder, generates the project, and then adds the project to the solution.

You can also make a new git repo by running `git init` if you have the git cli installed.

### Using New Horizons

To set up a New Horizons addon do

```shell
dotnet new OuterWildsMod -n MyProjectName --AuthorName MyName --usesNH true
```

## Options

### Author Name (AuthorName)

The author of the mod. Default: `Ernesto`

### Use New Horizons (usesNH)

Whether to turn this mod into a New Horizons addon:

- Adds the INewHorizons Interface
- Gets the API and loads config in `Start`
- Adds New Horizons as a dependency
- Ensures `planets`, `translations`, `systems`, and `addon-manifest.json` are copied to the output folder

Defaults to `false`.
