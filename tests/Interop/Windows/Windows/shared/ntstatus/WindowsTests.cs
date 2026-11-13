// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ntstatus.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
public static partial class WindowsTests
{
    /// <summary>Validates NTSTATUS conversion helpers.</summary>
    [Test]
    public static void NtStatusMacrosTest()
    {
        Assert.That(NTSTATUS_FROM_WIN32(0), Is.EqualTo(0));
        Assert.That(NTSTATUS_FROM_WIN32(5), Is.EqualTo(unchecked((int)0xC0070005)));
        Assert.That(__NTSTATUS_FROM_WIN32(5), Is.EqualTo(unchecked((int)0xC0070005)));
        Assert.That(NTSTATUS_FROM_WIN32(unchecked((int)0xC0000005)), Is.EqualTo(unchecked((int)0xC0000005)));
        Assert.That(FILTER_FLT_NTSTATUS_FROM_HRESULT(unchecked((int)0x801F0001)), Is.EqualTo(unchecked((int)0xC01C0001)));
        Assert.That(IS_CAMERA_NTSTATUS(unchecked((int)0xC01F0001)), Is.True);
        Assert.That(IS_CAMERA_NTSTATUS(unchecked((int)0xC01E0001)), Is.False);
    }
}
