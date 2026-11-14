// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DPRESENT
{
    /// <include file='D3DPRESENT.xml' path='doc/member[@name="D3DPRESENT.D3DPRESENT_BACK_BUFFERS_MAX"]/*' />
    [NativeTypeName("#define D3DPRESENT_BACK_BUFFERS_MAX 3L")]
    public const int D3DPRESENT_BACK_BUFFERS_MAX = 3;

    /// <include file='D3DPRESENT.xml' path='doc/member[@name="D3DPRESENT.D3DPRESENT_BACK_BUFFERS_MAX_EX"]/*' />
    [NativeTypeName("#define D3DPRESENT_BACK_BUFFERS_MAX_EX 30L")]
    public const int D3DPRESENT_BACK_BUFFERS_MAX_EX = 30;

    /// <include file='D3DPRESENT.xml' path='doc/member[@name="D3DPRESENT.D3DPRESENT_DONOTWAIT"]/*' />
    [NativeTypeName("#define D3DPRESENT_DONOTWAIT 0x00000001L")]
    public const int D3DPRESENT_DONOTWAIT = 0x00000001;

    /// <include file='D3DPRESENT.xml' path='doc/member[@name="D3DPRESENT.D3DPRESENT_LINEAR_CONTENT"]/*' />
    [NativeTypeName("#define D3DPRESENT_LINEAR_CONTENT 0x00000002L")]
    public const int D3DPRESENT_LINEAR_CONTENT = 0x00000002;

    /// <include file='D3DPRESENT.xml' path='doc/member[@name="D3DPRESENT.D3DPRESENT_DONOTFLIP"]/*' />
    [NativeTypeName("#define D3DPRESENT_DONOTFLIP 0x00000004L")]
    public const int D3DPRESENT_DONOTFLIP = 0x00000004;

    /// <include file='D3DPRESENT.xml' path='doc/member[@name="D3DPRESENT.D3DPRESENT_FLIPRESTART"]/*' />
    [NativeTypeName("#define D3DPRESENT_FLIPRESTART 0x00000008L")]
    public const int D3DPRESENT_FLIPRESTART = 0x00000008;

    /// <include file='D3DPRESENT.xml' path='doc/member[@name="D3DPRESENT.D3DPRESENT_VIDEO_RESTRICT_TO_MONITOR"]/*' />
    [NativeTypeName("#define D3DPRESENT_VIDEO_RESTRICT_TO_MONITOR 0x00000010L")]
    public const int D3DPRESENT_VIDEO_RESTRICT_TO_MONITOR = 0x00000010;

    /// <include file='D3DPRESENT.xml' path='doc/member[@name="D3DPRESENT.D3DPRESENT_UPDATEOVERLAYONLY"]/*' />
    [NativeTypeName("#define D3DPRESENT_UPDATEOVERLAYONLY 0x00000020L")]
    public const int D3DPRESENT_UPDATEOVERLAYONLY = 0x00000020;

    /// <include file='D3DPRESENT.xml' path='doc/member[@name="D3DPRESENT.D3DPRESENT_HIDEOVERLAY"]/*' />
    [NativeTypeName("#define D3DPRESENT_HIDEOVERLAY 0x00000040L")]
    public const int D3DPRESENT_HIDEOVERLAY = 0x00000040;

    /// <include file='D3DPRESENT.xml' path='doc/member[@name="D3DPRESENT.D3DPRESENT_UPDATECOLORKEY"]/*' />
    [NativeTypeName("#define D3DPRESENT_UPDATECOLORKEY 0x00000080L")]
    public const int D3DPRESENT_UPDATECOLORKEY = 0x00000080;

    /// <include file='D3DPRESENT.xml' path='doc/member[@name="D3DPRESENT.D3DPRESENT_FORCEIMMEDIATE"]/*' />
    [NativeTypeName("#define D3DPRESENT_FORCEIMMEDIATE 0x00000100L")]
    public const int D3DPRESENT_FORCEIMMEDIATE = 0x00000100;
}
