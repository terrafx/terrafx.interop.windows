// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using NUnit.Framework;
using static TerraFX.Interop.Windows.LIBID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of IMAPI2 type library identifiers.</summary>
public static partial class LIBIDTests
{
    /// <summary>Validates the IMAPI2 library identifier and its legacy alias.</summary>
    [Test]
    public static void LIBID_IMAPI2Test()
    {
        Guid expected = new(0x2735412F, 0x7F64, 0x5B0F, 0x8F, 0x00, 0x5D, 0x77, 0xAF, 0xBE, 0x26, 0x1E);
        Assert.That(LIBID_IMAPI2, Is.EqualTo(expected));
        Assert.That(LIBID_IMAPILib2, Is.EqualTo(expected));
    }
}
