# SharpFTC - A .NET Port of the FTC SDK and Robot Controller

SharpFTC allows teams and developers to communicate with the First Tech Challenge Robot Controller interface using C# and the .NET runtime. This repository contains the libraries needed for SharpFTC; the actual quickstart project can be found at [](not_added_yet).

The core functionality of the project has been implemented but untested. To run the project, deploy the `SharpFTC.App` project to an Android device.

Currently **untested**. If something breaks, please report it as a GitHub issue. Contributing by running tests on real FTC robots and environments is encouraged and is a **huge help to the project**.

## Components

SharpFTC is published as a set of .NET Class Libraries, including
- `SharpFTC.AndroidBindings` - A direct port of most of the FTC SDK with C# bindings [used internally by other SharpFTC libraries]
- `SharpFTC.Core` - A core utility library written on top of `SharpFTC.AndroidBindings` to make writing robot core easier
- `SharpFTC.App` - The actual android app built on top of `SharpFTC.Core`, partially written in Java and partially written in C#. Enables the registering of C# OpModes
- `SharpFTC.Tool` - A command line tool that makes it easier to work with the SharpFTC ecosystem


## Future Plans

- Having `SharpFTC.Tool` easily create bindings for existing JVM-based utilities for FTC, such as Roadrunner
- Make SharpFTC easily compatible with existing JVM-based OpModes


## Contributing

There are a number of ways to contribute to the SharpFTC project, including:

Reporting issues - Please report any issues stemming from SharpFTC on GitHub as a GitHub issue.

Testing the framework - Testing the SharpFTC ecosystem on real FTC robots is crucial to the project and is a huge help.

Contributing via pull requests - To be formalized soon...