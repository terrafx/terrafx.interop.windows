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

As workflow for Pull Requests (PR) it is recommended to follow [these steps]
(https://help.github.com/en/github/collaborating-with-issues-and-pull-requests)

#### Coding Conventions

TerraFX follows most of [these recommend practices] 
(https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions).
Those proactices and a few desirable deviations are specified via the .editorconfig file.
Hence, they are and as enforced by the messages in Visual Studio 2019 
when configured as *build + intellisense* .  
Commits should be done such that under these settings there are no warnings.
Due to limitations of .editorconfig syntax some required rules can not be specified. 
Check with the project owner when in doubt about your commit.
   