// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDSCL
{
    /// <include file='DDSCL.xml' path='doc/member[@name="DDSCL.DDSCL_FULLSCREEN"]/*' />
    [NativeTypeName("#define DDSCL_FULLSCREEN 0x00000001l")]
    public const int DDSCL_FULLSCREEN = 0x00000001;

    /// <include file='DDSCL.xml' path='doc/member[@name="DDSCL.DDSCL_ALLOWREBOOT"]/*' />
    [NativeTypeName("#define DDSCL_ALLOWREBOOT 0x00000002l")]
    public const int DDSCL_ALLOWREBOOT = 0x00000002;

    /// <include file='DDSCL.xml' path='doc/member[@name="DDSCL.DDSCL_NOWINDOWCHANGES"]/*' />
    [NativeTypeName("#define DDSCL_NOWINDOWCHANGES 0x00000004l")]
    public const int DDSCL_NOWINDOWCHANGES = 0x00000004;

    /// <include file='DDSCL.xml' path='doc/member[@name="DDSCL.DDSCL_NORMAL"]/*' />
    [NativeTypeName("#define DDSCL_NORMAL 0x00000008l")]
    public const int DDSCL_NORMAL = 0x00000008;

    /// <include file='DDSCL.xml' path='doc/member[@name="DDSCL.DDSCL_EXCLUSIVE"]/*' />
    [NativeTypeName("#define DDSCL_EXCLUSIVE 0x00000010l")]
    public const int DDSCL_EXCLUSIVE = 0x00000010;

    /// <include file='DDSCL.xml' path='doc/member[@name="DDSCL.DDSCL_ALLOWMODEX"]/*' />
    [NativeTypeName("#define DDSCL_ALLOWMODEX 0x00000040l")]
    public const int DDSCL_ALLOWMODEX = 0x00000040;

    /// <include file='DDSCL.xml' path='doc/member[@name="DDSCL.DDSCL_SETFOCUSWINDOW"]/*' />
    [NativeTypeName("#define DDSCL_SETFOCUSWINDOW 0x00000080l")]
    public const int DDSCL_SETFOCUSWINDOW = 0x00000080;

    /// <include file='DDSCL.xml' path='doc/member[@name="DDSCL.DDSCL_SETDEVICEWINDOW"]/*' />
    [NativeTypeName("#define DDSCL_SETDEVICEWINDOW 0x00000100l")]
    public const int DDSCL_SETDEVICEWINDOW = 0x00000100;

    /// <include file='DDSCL.xml' path='doc/member[@name="DDSCL.DDSCL_CREATEDEVICEWINDOW"]/*' />
    [NativeTypeName("#define DDSCL_CREATEDEVICEWINDOW 0x00000200l")]
    public const int DDSCL_CREATEDEVICEWINDOW = 0x00000200;

    /// <include file='DDSCL.xml' path='doc/member[@name="DDSCL.DDSCL_MULTITHREADED"]/*' />
    [NativeTypeName("#define DDSCL_MULTITHREADED 0x00000400l")]
    public const int DDSCL_MULTITHREADED = 0x00000400;

    /// <include file='DDSCL.xml' path='doc/member[@name="DDSCL.DDSCL_FPUSETUP"]/*' />
    [NativeTypeName("#define DDSCL_FPUSETUP 0x00000800l")]
    public const int DDSCL_FPUSETUP = 0x00000800;

    /// <include file='DDSCL.xml' path='doc/member[@name="DDSCL.DDSCL_FPUPRESERVE"]/*' />
    [NativeTypeName("#define DDSCL_FPUPRESERVE 0x00001000l")]
    public const int DDSCL_FPUPRESERVE = 0x00001000;
}
