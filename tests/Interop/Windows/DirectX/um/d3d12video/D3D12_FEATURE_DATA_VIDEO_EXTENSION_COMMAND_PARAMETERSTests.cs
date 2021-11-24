// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS" /> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERSTests
{
    /// <summary>Validates that the <see cref="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS>(), Is.EqualTo(sizeof(D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS)));
    }

    /// <summary>Validates that the <see cref="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS), Is.EqualTo(28));
        }
    }
}
