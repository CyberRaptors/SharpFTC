# SharpFTC - A .NET Port of the FTC SDK and Robot Controller

SharpFTC allows teams and developers to communicate with the First Tech Challenge Robot Controller interface using C# and the .NET runtime. This repository contains the libraries needed for SharpFTC; the actual quickstart project can be found at [](not_added_yet).

Currently still under heavy testing. If something breaks, please report it as a Github issue.

## Components

SharpFTC is published as a set of .NET Class Libraries, including
- `SharpFTC.AndroidBindings` - A direct port of most of the FTC SDK with C# bindings
- `SharpFTC.Core` - A core utility library written on top of `SharpFTC.AndroidBindings` to make writing robot core easier
- `SharpFTC.App` - The actual android app built on top of `SharpFTC.Core`, partially written in Java and partially written in C#. Enables the registering of C# OpModes
- `SharpFTC.Tool` - A command line tool that makes it easier to work with the SharpFTC ecosystem


## Future Plans

- Having `SharpFTC.Tool` easily create bindings for existing JVM-based utilities for FTC, such as Roadrunner
- Make SharpFTC easily compatible with existing JVM-based OpModes
