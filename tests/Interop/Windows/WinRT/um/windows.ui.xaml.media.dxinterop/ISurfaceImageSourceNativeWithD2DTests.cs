// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="ISurfaceImageSourceNativeWithD2D" /> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class ISurfaceImageSourceNativeWithD2DTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISurfaceImageSourceNativeWithD2D" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISurfaceImageSourceNativeWithD2D).GUID, Is.EqualTo(IID_ISurfaceImageSourceNativeWithD2D));
    }
}
