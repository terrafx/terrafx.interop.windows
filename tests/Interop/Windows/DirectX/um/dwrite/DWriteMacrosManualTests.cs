// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Validates manually ported DirectWrite tag helpers.</summary>
public static class DWriteMacrosManualTests
{
    /// <summary>Feature and OpenType tag helpers use the native little-endian tag encoding.</summary>
    [Test]
    public static void FontFeatureTagUsesOpenTypeEncoding()
    {
        Assert.That(DirectX.DWRITE_MAKE_FONT_FEATURE_TAG((byte)'c', (byte)'c', (byte)'m', (byte)'p'), Is.EqualTo(DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_GLYPH_COMPOSITION_DECOMPOSITION));
        Assert.That(DirectX.DWRITE_MAKE_OPENTYPE_TAG((byte)'D', (byte)'X', (byte)'I', (byte)'L'), Is.EqualTo(0x4C495844u));
    }
}
