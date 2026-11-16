// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DPRESENTFLAG
{
    /// <include file='D3DPRESENTFLAG.xml' path='doc/member[@name="D3DPRESENTFLAG.D3DPRESENTFLAG_LOCKABLE_BACKBUFFER"]/*' />
    [NativeTypeName("#define D3DPRESENTFLAG_LOCKABLE_BACKBUFFER 0x00000001")]
    public const int D3DPRESENTFLAG_LOCKABLE_BACKBUFFER = 0x00000001;

    /// <include file='D3DPRESENTFLAG.xml' path='doc/member[@name="D3DPRESENTFLAG.D3DPRESENTFLAG_DISCARD_DEPTHSTENCIL"]/*' />
    [NativeTypeName("#define D3DPRESENTFLAG_DISCARD_DEPTHSTENCIL 0x00000002")]
    public const int D3DPRESENTFLAG_DISCARD_DEPTHSTENCIL = 0x00000002;

    /// <include file='D3DPRESENTFLAG.xml' path='doc/member[@name="D3DPRESENTFLAG.D3DPRESENTFLAG_DEVICECLIP"]/*' />
    [NativeTypeName("#define D3DPRESENTFLAG_DEVICECLIP 0x00000004")]
    public const int D3DPRESENTFLAG_DEVICECLIP = 0x00000004;

    /// <include file='D3DPRESENTFLAG.xml' path='doc/member[@name="D3DPRESENTFLAG.D3DPRESENTFLAG_VIDEO"]/*' />
    [NativeTypeName("#define D3DPRESENTFLAG_VIDEO 0x00000010")]
    public const int D3DPRESENTFLAG_VIDEO = 0x00000010;

    /// <include file='D3DPRESENTFLAG.xml' path='doc/member[@name="D3DPRESENTFLAG.D3DPRESENTFLAG_NOAUTOROTATE"]/*' />
    [NativeTypeName("#define D3DPRESENTFLAG_NOAUTOROTATE 0x00000020")]
    public const int D3DPRESENTFLAG_NOAUTOROTATE = 0x00000020;

    /// <include file='D3DPRESENTFLAG.xml' path='doc/member[@name="D3DPRESENTFLAG.D3DPRESENTFLAG_UNPRUNEDMODE"]/*' />
    [NativeTypeName("#define D3DPRESENTFLAG_UNPRUNEDMODE 0x00000040")]
    public const int D3DPRESENTFLAG_UNPRUNEDMODE = 0x00000040;

    /// <include file='D3DPRESENTFLAG.xml' path='doc/member[@name="D3DPRESENTFLAG.D3DPRESENTFLAG_OVERLAY_LIMITEDRGB"]/*' />
    [NativeTypeName("#define D3DPRESENTFLAG_OVERLAY_LIMITEDRGB 0x00000080")]
    public const int D3DPRESENTFLAG_OVERLAY_LIMITEDRGB = 0x00000080;

    /// <include file='D3DPRESENTFLAG.xml' path='doc/member[@name="D3DPRESENTFLAG.D3DPRESENTFLAG_OVERLAY_YCbCr_BT709"]/*' />
    [NativeTypeName("#define D3DPRESENTFLAG_OVERLAY_YCbCr_BT709 0x00000100")]
    public const int D3DPRESENTFLAG_OVERLAY_YCbCr_BT709 = 0x00000100;

    /// <include file='D3DPRESENTFLAG.xml' path='doc/member[@name="D3DPRESENTFLAG.D3DPRESENTFLAG_OVERLAY_YCbCr_xvYCC"]/*' />
    [NativeTypeName("#define D3DPRESENTFLAG_OVERLAY_YCbCr_xvYCC 0x00000200")]
    public const int D3DPRESENTFLAG_OVERLAY_YCbCr_xvYCC = 0x00000200;

    /// <include file='D3DPRESENTFLAG.xml' path='doc/member[@name="D3DPRESENTFLAG.D3DPRESENTFLAG_RESTRICTED_CONTENT"]/*' />
    [NativeTypeName("#define D3DPRESENTFLAG_RESTRICTED_CONTENT 0x00000400")]
    public const int D3DPRESENTFLAG_RESTRICTED_CONTENT = 0x00000400;

    /// <include file='D3DPRESENTFLAG.xml' path='doc/member[@name="D3DPRESENTFLAG.D3DPRESENTFLAG_RESTRICT_SHARED_RESOURCE_DRIVER"]/*' />
    [NativeTypeName("#define D3DPRESENTFLAG_RESTRICT_SHARED_RESOURCE_DRIVER 0x00000800")]
    public const int D3DPRESENTFLAG_RESTRICT_SHARED_RESOURCE_DRIVER = 0x00000800;
}
