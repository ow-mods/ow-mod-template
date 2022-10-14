# OuterWildsModTemplateNuget

A nuget package that contains a template for creating outer wilds mods

## Installation

Run

```ps
dotnet new --install Bwc9876.OuterWildsModTemplate
```

## Usage

Run

```ps
dotnet new sln --name MySolutionName
dotnet new OuterWildsMod -n MyProjectName --AuthorName MyName
dotnet sln add MyProjectName/
```

This creates a new solution file in the current folder, generates the project, and then adds the project to the solution.

You can also make a new git repo by running `git init` if you have the git cli installed.

## Options

### AuthorName

The author of the mod. Default: `Ernesto`

### Use New Horizons

Whether to turn this mod into a New Horizons addon:

- Adds the INewHorizons Interface
- Gets the API and loads config in `Start`
- Adds New Horizons as a dependency

Defaults to `false`.
