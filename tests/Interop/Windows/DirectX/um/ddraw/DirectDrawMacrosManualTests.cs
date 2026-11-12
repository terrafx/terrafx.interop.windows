// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Validates manually ported DirectDraw helper macros.</summary>
public static class DirectDrawMacrosManualTests
{
    /// <summary>WHQL date extraction and HRESULT packing match the native macros.</summary>
    [Test]
    public static void WhqlDateAndHResultMacrosPreserveValues()
    {
        uint whqlLevel = (2024u << 16) | (9u << 8) | 17u;

        Assert.That(DirectX.GET_WHQL_YEAR(whqlLevel), Is.EqualTo(2024u));
        Assert.That(DirectX.GET_WHQL_MONTH(whqlLevel), Is.EqualTo(9u));
        Assert.That(DirectX.GET_WHQL_DAY(whqlLevel), Is.EqualTo(17u));
        Assert.That((int)DirectX.MAKE_DDHRESULT(5), Is.EqualTo(DDERR.DDERR_ALREADYINITIALIZED));
        Assert.That((int)TerraFX.Interop.Windows.Windows.MAKE_HRESULT(1, 0x876, 5), Is.EqualTo(DDERR.DDERR_ALREADYINITIALIZED));
        Assert.That((int)TerraFX.Interop.Windows.Windows.MAKE_SCODE(1, 0x876, 5), Is.EqualTo(DDERR.DDERR_ALREADYINITIALIZED));
    }
}
