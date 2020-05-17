# Contributing to TerraFX

The following is a set of guidelines for contributing to TerraFX.

## Table of Contents

* [Code of Conduct](#code-of-conduct)
* [License](#license)
* [What should I know?](#what-should-i-know)
* [Issues](#issues)
* [Questions](#questions)
* [Pull Requests](#pull-requests)

### Code of Conduct

TerraFX and everyone contributing (this includes issues, pull requests, the
wiki, etc) must abide by the [CODE_OF_CONDUCT](CODE_OF_CONDUCT.md).
Instances of abusive, harassing, or otherwise unacceptable behavior may be
reported by contacting the project team at admin@terrafx.dev.

### License

Copyright © Tanner Gooding and Contributors. Licensed under the MIT License
(MIT). See [LICENSE](../LICENSE.md) in the repository root for more information.

### What should I know?

Most of the basics of the project, such as what it is about, and its goals are
covered in our [README](README.md).

### Issues

All issues should follow our [ISSUE_TEMPLATE](ISSUE_TEMPLATE.md). It is
additionaly recommended to prefix your issue with an appriopriate "tag" such as
`[QUESTION]`, `[BUG]`, `[REGRESSION]`, `[IDEA]`, or `[PROPOSAL]`.

### Questions

Feel free to open an issue prefixed with `[QUESTION]`.

### Pull Requests

All pull requests should follow our
[PULL_REQUEST_TEMPLATE](PULL_REQUEST_TEMPLATE.md). It is additionally
recommended that an issue be opened, discussed, and approved first to ensure
that the change will be accepted. Any pull requests not following pull request
template will be requested to be updated. Any pull requests opened without a
corresponding issue may be delayed or be required to undergo further changes
before being accepted.

#### Pull Request Workflow

As workflow for Pull Requests (PR) it is recommended to 

1. Fork the [repository](https://github.com/terrafx/terrafx.interop.windows) 
Make sure the git configuration has the upstream master set, 
e.g. run `git remote add upstream https://github.com/terrafx/terrafx.interop.windows`

2. Create a branch with name reflecting the issue/proposal you are planning to work on.

3. Implement your PR

4. git Commit, Fetch --all, Rebase, Push, and then submit your PR. 
The submit can be done via git commandline, or from your git gui tool 
or with the button on the github page of your fork. 

5. If on your own or prompted by a PR review you make further changes, 
then you can update your PR via Commit, Fetch --all, Rebase, Push. 
The push will be automatically recognized by github and github 
will update the PR on the main upstream repository.

6. While one PR is in the works like this and maybe you are waiting on 
a review you can make another branch for another PR and work on that in parallel.

7. When a PR is approved and closed your code becomes part of the upstream code base 
and there is no need to keep the branch. 
Feel free to delete the branch to reduce clutter in your git log, 
but this step is not required.

#### Coding Conventions

TerraFX follows the industry standard 
[C# coding conventions as published by Microsoft]
(https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions) 
and as enforced by the messages in Visual Studio 2019 
when configured as *build + intellisense* .  
Commits should be done such that under these settings there are no warnings.

In addition, there are a few more conventions:

1. **Property vs Method:** a property is auto evaluated by Visual Studio 
when stopping at a breakpoint for items in the watch/autos/locals panel. 
If that takes long Visual Studio becomes laggy. 
So if your property would take long to evaluate then better make it a method.

2. **Compound Names:** Auto completion is very useful to use unfamiliar APIs. 
Often there are multiple methods that do similar things. 
It helps a lot if they show up next to each other in the auto completion lists. 
That means they need to be next to each other in alphabetic order. 
So here is the naming rule for compound names: 
*Object followed by action* and *general followed by specific*. 
So a method that sorts distances ascending should be `DistancesSortAscending`.  
That way it fits right in with the other related ones:

   ```c#
   DistancesMax
   DistancesMin
   DistancesSortAscending
   DistancesSortDescending    
   ```

3. **Coordinate Variables**: 3d graphics code has to deal with different coordinate systems. 
Confusing which one a vector variable is associated with is causes difficult to trace errors. 
Thus every coordinate vector variable should have a coordinate system indicating postfix. 
Use `Wo` for world coordinates, 
`Sc` for screen coordinates 
and `Me` for mesh coordinates. 
So you would write for example:

    ```c#
   // map the ball center from mesh to world to screen
   var ballCenterWo = meshToWorld4x4 * ballCenterMe;
   var ballCenterSc = WorldToScreen4x4 * ballCenterWo;
    ```

   