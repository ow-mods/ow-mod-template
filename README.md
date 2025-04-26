# Outer Wilds Mod Template

A [nuget package](https://www.nuget.org/packages/Bwc9876.OuterWildsModTemplate) that contains a template for creating outer wilds mods

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
- Ensures `planets`, `translations`, `systems`, `addon-manifest.json`, `title-screen.json`, and `subtitle.png` are copied to the output folder

Defaults to `false`.

## Adding The Workflow To Existing Projects

If you have an existing project and want to add the workflow to it, follow this guide.

1. Copy `templates/Outer-Wilds-Mod-Template/parent-stuff/.github/workflows/release.yml`.
2. Change `PROJ_USERNAME` near the top to the safe author name (the string in the `uniqueName` before the `.`).
3. Change the `PROJ_NAME` near the top to the safe project name (the string in the `uniqueName` after the `.`). **Important: The project name must also be the project folder's name. Meaning the folder your .csproj file is in must be both at the root of the repo and have the same name as your project. (Most IDEs set it up this way by default)**
4. That's it! Simply push the new workflow and run it.
