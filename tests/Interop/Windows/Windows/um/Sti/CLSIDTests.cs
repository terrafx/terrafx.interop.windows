// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CLSID" /> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref="CLSID_Sti" /> property is correct.</summary>
    [Test]
    public static void CLSID_StiTest()
    {
        Assert.That(CLSID_Sti, Is.EqualTo(new Guid(0xB323F8E0, 0x2E68, 0x11D0, 0x90, 0xEA, 0x00, 0xAA, 0x00, 0x60, 0xF8, 0x6C)));
    }
}
