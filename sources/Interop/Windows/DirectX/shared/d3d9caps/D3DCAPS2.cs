// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DCAPS2
{
    /// <include file='D3DCAPS2.xml' path='doc/member[@name="D3DCAPS2.D3DCAPS2_FULLSCREENGAMMA"]/*' />
    [NativeTypeName("#define D3DCAPS2_FULLSCREENGAMMA 0x00020000L")]
    public const int D3DCAPS2_FULLSCREENGAMMA = 0x00020000;

    /// <include file='D3DCAPS2.xml' path='doc/member[@name="D3DCAPS2.D3DCAPS2_CANCALIBRATEGAMMA"]/*' />
    [NativeTypeName("#define D3DCAPS2_CANCALIBRATEGAMMA 0x00100000L")]
    public const int D3DCAPS2_CANCALIBRATEGAMMA = 0x00100000;

    /// <include file='D3DCAPS2.xml' path='doc/member[@name="D3DCAPS2.D3DCAPS2_RESERVED"]/*' />
    [NativeTypeName("#define D3DCAPS2_RESERVED 0x02000000L")]
    public const int D3DCAPS2_RESERVED = 0x02000000;

    /// <include file='D3DCAPS2.xml' path='doc/member[@name="D3DCAPS2.D3DCAPS2_CANMANAGERESOURCE"]/*' />
    [NativeTypeName("#define D3DCAPS2_CANMANAGERESOURCE 0x10000000L")]
    public const int D3DCAPS2_CANMANAGERESOURCE = 0x10000000;

    /// <include file='D3DCAPS2.xml' path='doc/member[@name="D3DCAPS2.D3DCAPS2_DYNAMICTEXTURES"]/*' />
    [NativeTypeName("#define D3DCAPS2_DYNAMICTEXTURES 0x20000000L")]
    public const int D3DCAPS2_DYNAMICTEXTURES = 0x20000000;

    /// <include file='D3DCAPS2.xml' path='doc/member[@name="D3DCAPS2.D3DCAPS2_CANAUTOGENMIPMAP"]/*' />
    [NativeTypeName("#define D3DCAPS2_CANAUTOGENMIPMAP 0x40000000L")]
    public const int D3DCAPS2_CANAUTOGENMIPMAP = 0x40000000;

    /// <include file='D3DCAPS2.xml' path='doc/member[@name="D3DCAPS2.D3DCAPS2_CANSHARERESOURCE"]/*' />
    [NativeTypeName("#define D3DCAPS2_CANSHARERESOURCE 0x80000000L")]
    public const uint D3DCAPS2_CANSHARERESOURCE = 0x80000000;
}
