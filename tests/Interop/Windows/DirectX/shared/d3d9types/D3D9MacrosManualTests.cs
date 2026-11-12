// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Validates manually ported Direct3D 9 macros.</summary>
public static class D3D9MacrosManualTests
{
    /// <summary>Color macros pack and truncate channels like the native definitions.</summary>
    [Test]
    public static void D3DCOLOR_MacrosPackChannels()
    {
        Assert.That(DirectX.D3DCOLOR_ARGB(0x12, 0x134, 0x256, 0x378), Is.EqualTo(0x12345678u));
        Assert.That(DirectX.D3DCOLOR_RGBA(0x12, 0x34, 0x56, 0x78), Is.EqualTo(0x78123456u));
        Assert.That(DirectX.D3DCOLOR_XRGB(0x12, 0x34, 0x56), Is.EqualTo(0xFF123456u));
        Assert.That(DirectX.D3DCOLOR_XYUV(0x12, 0x34, 0x56), Is.EqualTo(0xFF123456u));
        Assert.That(DirectX.D3DCOLOR_AYUV(0x78, 0x12, 0x34, 0x56), Is.EqualTo(0x78123456u));
        Assert.That(DirectX.D3DCOLOR_COLORVALUE(1.0f, 0.5f, 0.0f, 1.0f), Is.EqualTo(0xFFFF7F00u));
    }

    /// <summary>Flexible vertex format macros encode coordinate dimensions and indices.</summary>
    [Test]
    public static void D3DFVF_TEXCOORDSIZES_EncodeCoordinateIndex()
    {
        Assert.That(D3DFVF.D3DFVF_TEXCOORDSIZE1(0), Is.EqualTo(0x00030000));
        Assert.That(D3DFVF.D3DFVF_TEXCOORDSIZE2(0), Is.Zero);
        Assert.That(D3DFVF.D3DFVF_TEXCOORDSIZE3(0), Is.EqualTo(0x00010000));
        Assert.That(D3DFVF.D3DFVF_TEXCOORDSIZE4(0), Is.EqualTo(0x00020000));
        Assert.That(D3DFVF.D3DFVF_TEXCOORDSIZE1(3), Is.EqualTo(0x00C00000));
        Assert.That(D3DFVF.D3DFVF_TEXCOORDSIZE2(3), Is.Zero);
        Assert.That(D3DFVF.D3DFVF_TEXCOORDSIZE3(3), Is.EqualTo(0x00400000));
        Assert.That(D3DFVF.D3DFVF_TEXCOORDSIZE4(3), Is.EqualTo(0x00800000));
    }

    /// <summary>Shader macros encode version, end, and comment tokens.</summary>
    [Test]
    public static void D3DShaderMacrosEncodeVersionAndCommentTokens()
    {
        Assert.That(D3DPS.D3DPS_VERSION(3, 0), Is.EqualTo(0xFFFF0300u));
        Assert.That(D3DVS.D3DVS_VERSION(3, 0), Is.EqualTo(0xFFFE0300u));
        Assert.That(D3DPS.D3DPS_END(), Is.EqualTo(0x0000FFFFu));
        Assert.That(D3DVS.D3DVS_END(), Is.EqualTo(0x0000FFFFu));
        Assert.That(D3DSHADER.D3DSHADER_VERSION_MAJOR(0xFFFF0304u), Is.EqualTo(3u));
        Assert.That(D3DSHADER.D3DSHADER_VERSION_MINOR(0xFFFF0304u), Is.EqualTo(4u));
        Assert.That(D3DSHADER.D3DSHADER_COMMENT(0xFFFFu), Is.EqualTo(0x7FFFFFFEu));
    }

    /// <summary>Declaration and world-matrix macros return their native descriptor values.</summary>
    [Test]
    public static void D3DDeclarationAndTransformMacrosReturnNativeValues()
    {
        D3DVERTEXELEMENT9 end = DirectX.D3DDECL_END();

        Assert.That(end.Stream, Is.EqualTo(0xFF));
        Assert.That(end.Offset, Is.Zero);
        Assert.That(end.Type, Is.EqualTo((byte)(D3DDECLTYPE.D3DDECLTYPE_UNUSED)));
        Assert.That(end.Method, Is.Zero);
        Assert.That(end.Usage, Is.Zero);
        Assert.That(end.UsageIndex, Is.Zero);
        Assert.That(D3DTS.D3DTS_WORLDMATRIX(4), Is.EqualTo((D3DTRANSFORMSTATETYPE)260));
    }
}
