// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IAcousticEchoCancellationControl" /> struct.</summary>
[SupportedOSPlatform("windows10.0.22621.0")]
public static unsafe partial class IAcousticEchoCancellationControlTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAcousticEchoCancellationControl" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAcousticEchoCancellationControl).GUID, Is.EqualTo(IID_IAcousticEchoCancellationControl));
    }
}
