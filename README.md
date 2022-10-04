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
dotnet new sln --new MySolutionName
dotnet new OuterWildsMod -n MyProjectName --AuthorName MyName
dotnet sln add MyProjectName/
```

This creates a new solution file in the current folder, generates the project, and then adds the project to the solution.

You can also make a new git repo by running `git init` if you have the git cli installed.

## Options

### AuthorName

The author of the mod, you cannot edit this value in Rider.
