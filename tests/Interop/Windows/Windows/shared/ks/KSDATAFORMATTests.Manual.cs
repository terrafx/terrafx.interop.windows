// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ks.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="KSDATAFORMAT" /> struct.</summary>
public static unsafe class KSDATAFORMATTests
{
    /// <summary>Validates that the <see cref="KSDATAFORMAT" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<KSDATAFORMAT>(), Is.EqualTo(sizeof(KSDATAFORMAT)));
    }

    /// <summary>Validates that the <see cref="KSDATAFORMAT" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(KSDATAFORMAT).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref="KSDATAFORMAT" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(KSDATAFORMAT), Is.EqualTo(64));
    }
}
