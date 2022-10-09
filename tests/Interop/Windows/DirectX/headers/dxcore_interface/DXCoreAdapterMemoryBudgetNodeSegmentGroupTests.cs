// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="DXCoreAdapterMemoryBudgetNodeSegmentGroup" /> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class DXCoreAdapterMemoryBudgetNodeSegmentGroupTests
{
    /// <summary>Validates that the <see cref="DXCoreAdapterMemoryBudgetNodeSegmentGroup" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXCoreAdapterMemoryBudgetNodeSegmentGroup>(), Is.EqualTo(sizeof(DXCoreAdapterMemoryBudgetNodeSegmentGroup)));
    }

    /// <summary>Validates that the <see cref="DXCoreAdapterMemoryBudgetNodeSegmentGroup" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXCoreAdapterMemoryBudgetNodeSegmentGroup).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DXCoreAdapterMemoryBudgetNodeSegmentGroup" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DXCoreAdapterMemoryBudgetNodeSegmentGroup), Is.EqualTo(8));
    }
}
