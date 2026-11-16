// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DCPCAPS
{
    /// <include file='D3DCPCAPS.xml' path='doc/member[@name="D3DCPCAPS.D3DCPCAPS_SOFTWARE"]/*' />
    [NativeTypeName("#define D3DCPCAPS_SOFTWARE 0x00000001")]
    public const int D3DCPCAPS_SOFTWARE = 0x00000001;

    /// <include file='D3DCPCAPS.xml' path='doc/member[@name="D3DCPCAPS.D3DCPCAPS_HARDWARE"]/*' />
    [NativeTypeName("#define D3DCPCAPS_HARDWARE 0x00000002")]
    public const int D3DCPCAPS_HARDWARE = 0x00000002;

    /// <include file='D3DCPCAPS.xml' path='doc/member[@name="D3DCPCAPS.D3DCPCAPS_PROTECTIONALWAYSON"]/*' />
    [NativeTypeName("#define D3DCPCAPS_PROTECTIONALWAYSON 0x00000004")]
    public const int D3DCPCAPS_PROTECTIONALWAYSON = 0x00000004;

    /// <include file='D3DCPCAPS.xml' path='doc/member[@name="D3DCPCAPS.D3DCPCAPS_PARTIALDECRYPTION"]/*' />
    [NativeTypeName("#define D3DCPCAPS_PARTIALDECRYPTION 0x00000008")]
    public const int D3DCPCAPS_PARTIALDECRYPTION = 0x00000008;

    /// <include file='D3DCPCAPS.xml' path='doc/member[@name="D3DCPCAPS.D3DCPCAPS_CONTENTKEY"]/*' />
    [NativeTypeName("#define D3DCPCAPS_CONTENTKEY 0x00000010")]
    public const int D3DCPCAPS_CONTENTKEY = 0x00000010;

    /// <include file='D3DCPCAPS.xml' path='doc/member[@name="D3DCPCAPS.D3DCPCAPS_FRESHENSESSIONKEY"]/*' />
    [NativeTypeName("#define D3DCPCAPS_FRESHENSESSIONKEY 0x00000020")]
    public const int D3DCPCAPS_FRESHENSESSIONKEY = 0x00000020;

    /// <include file='D3DCPCAPS.xml' path='doc/member[@name="D3DCPCAPS.D3DCPCAPS_ENCRYPTEDREADBACK"]/*' />
    [NativeTypeName("#define D3DCPCAPS_ENCRYPTEDREADBACK 0x00000040")]
    public const int D3DCPCAPS_ENCRYPTEDREADBACK = 0x00000040;

    /// <include file='D3DCPCAPS.xml' path='doc/member[@name="D3DCPCAPS.D3DCPCAPS_ENCRYPTEDREADBACKKEY"]/*' />
    [NativeTypeName("#define D3DCPCAPS_ENCRYPTEDREADBACKKEY 0x00000080")]
    public const int D3DCPCAPS_ENCRYPTEDREADBACKKEY = 0x00000080;

    /// <include file='D3DCPCAPS.xml' path='doc/member[@name="D3DCPCAPS.D3DCPCAPS_SEQUENTIAL_CTR_IV"]/*' />
    [NativeTypeName("#define D3DCPCAPS_SEQUENTIAL_CTR_IV 0x00000100")]
    public const int D3DCPCAPS_SEQUENTIAL_CTR_IV = 0x00000100;

    /// <include file='D3DCPCAPS.xml' path='doc/member[@name="D3DCPCAPS.D3DCPCAPS_ENCRYPTSLICEDATAONLY"]/*' />
    [NativeTypeName("#define D3DCPCAPS_ENCRYPTSLICEDATAONLY 0x00000200")]
    public const int D3DCPCAPS_ENCRYPTSLICEDATAONLY = 0x00000200;
}
