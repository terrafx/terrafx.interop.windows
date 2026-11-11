// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DTA
{
    /// <include file='D3DTA.xml' path='doc/member[@name="D3DTA.D3DTA_SELECTMASK"]/*' />
    [NativeTypeName("#define D3DTA_SELECTMASK 0x0000000f")]
    public const int D3DTA_SELECTMASK = 0x0000000f;

    /// <include file='D3DTA.xml' path='doc/member[@name="D3DTA.D3DTA_DIFFUSE"]/*' />
    [NativeTypeName("#define D3DTA_DIFFUSE 0x00000000")]
    public const int D3DTA_DIFFUSE = 0x00000000;

    /// <include file='D3DTA.xml' path='doc/member[@name="D3DTA.D3DTA_CURRENT"]/*' />
    [NativeTypeName("#define D3DTA_CURRENT 0x00000001")]
    public const int D3DTA_CURRENT = 0x00000001;

    /// <include file='D3DTA.xml' path='doc/member[@name="D3DTA.D3DTA_TEXTURE"]/*' />
    [NativeTypeName("#define D3DTA_TEXTURE 0x00000002")]
    public const int D3DTA_TEXTURE = 0x00000002;

    /// <include file='D3DTA.xml' path='doc/member[@name="D3DTA.D3DTA_TFACTOR"]/*' />
    [NativeTypeName("#define D3DTA_TFACTOR 0x00000003")]
    public const int D3DTA_TFACTOR = 0x00000003;

    /// <include file='D3DTA.xml' path='doc/member[@name="D3DTA.D3DTA_SPECULAR"]/*' />
    [NativeTypeName("#define D3DTA_SPECULAR 0x00000004")]
    public const int D3DTA_SPECULAR = 0x00000004;

    /// <include file='D3DTA.xml' path='doc/member[@name="D3DTA.D3DTA_TEMP"]/*' />
    [NativeTypeName("#define D3DTA_TEMP 0x00000005")]
    public const int D3DTA_TEMP = 0x00000005;

    /// <include file='D3DTA.xml' path='doc/member[@name="D3DTA.D3DTA_CONSTANT"]/*' />
    [NativeTypeName("#define D3DTA_CONSTANT 0x00000006")]
    public const int D3DTA_CONSTANT = 0x00000006;

    /// <include file='D3DTA.xml' path='doc/member[@name="D3DTA.D3DTA_COMPLEMENT"]/*' />
    [NativeTypeName("#define D3DTA_COMPLEMENT 0x00000010")]
    public const int D3DTA_COMPLEMENT = 0x00000010;

    /// <include file='D3DTA.xml' path='doc/member[@name="D3DTA.D3DTA_ALPHAREPLICATE"]/*' />
    [NativeTypeName("#define D3DTA_ALPHAREPLICATE 0x00000020")]
    public const int D3DTA_ALPHAREPLICATE = 0x00000020;
}
