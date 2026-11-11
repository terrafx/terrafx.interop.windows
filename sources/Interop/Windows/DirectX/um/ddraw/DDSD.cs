// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDSD
{
    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_CAPS"]/*' />
    [NativeTypeName("#define DDSD_CAPS 0x00000001l")]
    public const int DDSD_CAPS = 0x00000001;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_HEIGHT"]/*' />
    [NativeTypeName("#define DDSD_HEIGHT 0x00000002l")]
    public const int DDSD_HEIGHT = 0x00000002;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_WIDTH"]/*' />
    [NativeTypeName("#define DDSD_WIDTH 0x00000004l")]
    public const int DDSD_WIDTH = 0x00000004;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_PITCH"]/*' />
    [NativeTypeName("#define DDSD_PITCH 0x00000008l")]
    public const int DDSD_PITCH = 0x00000008;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_BACKBUFFERCOUNT"]/*' />
    [NativeTypeName("#define DDSD_BACKBUFFERCOUNT 0x00000020l")]
    public const int DDSD_BACKBUFFERCOUNT = 0x00000020;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_ZBUFFERBITDEPTH"]/*' />
    [NativeTypeName("#define DDSD_ZBUFFERBITDEPTH 0x00000040l")]
    public const int DDSD_ZBUFFERBITDEPTH = 0x00000040;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_ALPHABITDEPTH"]/*' />
    [NativeTypeName("#define DDSD_ALPHABITDEPTH 0x00000080l")]
    public const int DDSD_ALPHABITDEPTH = 0x00000080;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_LPSURFACE"]/*' />
    [NativeTypeName("#define DDSD_LPSURFACE 0x00000800l")]
    public const int DDSD_LPSURFACE = 0x00000800;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_PIXELFORMAT"]/*' />
    [NativeTypeName("#define DDSD_PIXELFORMAT 0x00001000l")]
    public const int DDSD_PIXELFORMAT = 0x00001000;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_CKDESTOVERLAY"]/*' />
    [NativeTypeName("#define DDSD_CKDESTOVERLAY 0x00002000l")]
    public const int DDSD_CKDESTOVERLAY = 0x00002000;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_CKDESTBLT"]/*' />
    [NativeTypeName("#define DDSD_CKDESTBLT 0x00004000l")]
    public const int DDSD_CKDESTBLT = 0x00004000;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_CKSRCOVERLAY"]/*' />
    [NativeTypeName("#define DDSD_CKSRCOVERLAY 0x00008000l")]
    public const int DDSD_CKSRCOVERLAY = 0x00008000;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_CKSRCBLT"]/*' />
    [NativeTypeName("#define DDSD_CKSRCBLT 0x00010000l")]
    public const int DDSD_CKSRCBLT = 0x00010000;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_MIPMAPCOUNT"]/*' />
    [NativeTypeName("#define DDSD_MIPMAPCOUNT 0x00020000l")]
    public const int DDSD_MIPMAPCOUNT = 0x00020000;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_REFRESHRATE"]/*' />
    [NativeTypeName("#define DDSD_REFRESHRATE 0x00040000l")]
    public const int DDSD_REFRESHRATE = 0x00040000;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_LINEARSIZE"]/*' />
    [NativeTypeName("#define DDSD_LINEARSIZE 0x00080000l")]
    public const int DDSD_LINEARSIZE = 0x00080000;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_TEXTURESTAGE"]/*' />
    [NativeTypeName("#define DDSD_TEXTURESTAGE 0x00100000l")]
    public const int DDSD_TEXTURESTAGE = 0x00100000;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_FVF"]/*' />
    [NativeTypeName("#define DDSD_FVF 0x00200000l")]
    public const int DDSD_FVF = 0x00200000;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_SRCVBHANDLE"]/*' />
    [NativeTypeName("#define DDSD_SRCVBHANDLE 0x00400000l")]
    public const int DDSD_SRCVBHANDLE = 0x00400000;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_DEPTH"]/*' />
    [NativeTypeName("#define DDSD_DEPTH 0x00800000l")]
    public const int DDSD_DEPTH = 0x00800000;

    /// <include file='DDSD.xml' path='doc/member[@name="DDSD.DDSD_ALL"]/*' />
    [NativeTypeName("#define DDSD_ALL 0x00fff9eel")]
    public const int DDSD_ALL = 0x00fff9ee;
}
