// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDirectManipulationUpdateManager" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IDirectManipulationUpdateManagerTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDirectManipulationUpdateManager" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirectManipulationUpdateManager).GUID, Is.EqualTo(IID_IDirectManipulationUpdateManager));
    }
}
