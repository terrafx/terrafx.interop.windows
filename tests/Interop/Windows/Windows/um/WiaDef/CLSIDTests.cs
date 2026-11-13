// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CLSID" /> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref="CLSID_WiaDefaultSegFilter" /> property is correct.</summary>
    [Test]
    public static void CLSID_WiaDefaultSegFilterTest()
    {
        Assert.That(CLSID_WiaDefaultSegFilter, Is.EqualTo(new Guid(0xD4F4D30B, 0x0B29, 0x4508, 0x89, 0x22, 0x0C, 0x57, 0x97, 0xD4, 0x27, 0x65)));
    }
}
