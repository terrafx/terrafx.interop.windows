// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDCAPS2
{
    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_CERTIFIED"]/*' />
    [NativeTypeName("#define DDCAPS2_CERTIFIED 0x00000001l")]
    public const int DDCAPS2_CERTIFIED = 0x00000001;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_NO2DDURING3DSCENE"]/*' />
    [NativeTypeName("#define DDCAPS2_NO2DDURING3DSCENE 0x00000002l")]
    public const int DDCAPS2_NO2DDURING3DSCENE = 0x00000002;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_VIDEOPORT"]/*' />
    [NativeTypeName("#define DDCAPS2_VIDEOPORT 0x00000004l")]
    public const int DDCAPS2_VIDEOPORT = 0x00000004;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_AUTOFLIPOVERLAY"]/*' />
    [NativeTypeName("#define DDCAPS2_AUTOFLIPOVERLAY 0x00000008l")]
    public const int DDCAPS2_AUTOFLIPOVERLAY = 0x00000008;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_CANBOBINTERLEAVED"]/*' />
    [NativeTypeName("#define DDCAPS2_CANBOBINTERLEAVED 0x00000010l")]
    public const int DDCAPS2_CANBOBINTERLEAVED = 0x00000010;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_CANBOBNONINTERLEAVED"]/*' />
    [NativeTypeName("#define DDCAPS2_CANBOBNONINTERLEAVED 0x00000020l")]
    public const int DDCAPS2_CANBOBNONINTERLEAVED = 0x00000020;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_COLORCONTROLOVERLAY"]/*' />
    [NativeTypeName("#define DDCAPS2_COLORCONTROLOVERLAY 0x00000040l")]
    public const int DDCAPS2_COLORCONTROLOVERLAY = 0x00000040;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_COLORCONTROLPRIMARY"]/*' />
    [NativeTypeName("#define DDCAPS2_COLORCONTROLPRIMARY 0x00000080l")]
    public const int DDCAPS2_COLORCONTROLPRIMARY = 0x00000080;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_CANDROPZ16BIT"]/*' />
    [NativeTypeName("#define DDCAPS2_CANDROPZ16BIT 0x00000100l")]
    public const int DDCAPS2_CANDROPZ16BIT = 0x00000100;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_NONLOCALVIDMEM"]/*' />
    [NativeTypeName("#define DDCAPS2_NONLOCALVIDMEM 0x00000200l")]
    public const int DDCAPS2_NONLOCALVIDMEM = 0x00000200;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_NONLOCALVIDMEMCAPS"]/*' />
    [NativeTypeName("#define DDCAPS2_NONLOCALVIDMEMCAPS 0x00000400l")]
    public const int DDCAPS2_NONLOCALVIDMEMCAPS = 0x00000400;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_NOPAGELOCKREQUIRED"]/*' />
    [NativeTypeName("#define DDCAPS2_NOPAGELOCKREQUIRED 0x00000800l")]
    public const int DDCAPS2_NOPAGELOCKREQUIRED = 0x00000800;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_WIDESURFACES"]/*' />
    [NativeTypeName("#define DDCAPS2_WIDESURFACES 0x00001000l")]
    public const int DDCAPS2_WIDESURFACES = 0x00001000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_CANFLIPODDEVEN"]/*' />
    [NativeTypeName("#define DDCAPS2_CANFLIPODDEVEN 0x00002000l")]
    public const int DDCAPS2_CANFLIPODDEVEN = 0x00002000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_CANBOBHARDWARE"]/*' />
    [NativeTypeName("#define DDCAPS2_CANBOBHARDWARE 0x00004000l")]
    public const int DDCAPS2_CANBOBHARDWARE = 0x00004000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_COPYFOURCC"]/*' />
    [NativeTypeName("#define DDCAPS2_COPYFOURCC 0x00008000l")]
    public const int DDCAPS2_COPYFOURCC = 0x00008000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_PRIMARYGAMMA"]/*' />
    [NativeTypeName("#define DDCAPS2_PRIMARYGAMMA 0x00020000l")]
    public const int DDCAPS2_PRIMARYGAMMA = 0x00020000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_CANRENDERWINDOWED"]/*' />
    [NativeTypeName("#define DDCAPS2_CANRENDERWINDOWED 0x00080000l")]
    public const int DDCAPS2_CANRENDERWINDOWED = 0x00080000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_CANCALIBRATEGAMMA"]/*' />
    [NativeTypeName("#define DDCAPS2_CANCALIBRATEGAMMA 0x00100000l")]
    public const int DDCAPS2_CANCALIBRATEGAMMA = 0x00100000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_FLIPINTERVAL"]/*' />
    [NativeTypeName("#define DDCAPS2_FLIPINTERVAL 0x00200000l")]
    public const int DDCAPS2_FLIPINTERVAL = 0x00200000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_FLIPNOVSYNC"]/*' />
    [NativeTypeName("#define DDCAPS2_FLIPNOVSYNC 0x00400000l")]
    public const int DDCAPS2_FLIPNOVSYNC = 0x00400000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_CANMANAGETEXTURE"]/*' />
    [NativeTypeName("#define DDCAPS2_CANMANAGETEXTURE 0x00800000l")]
    public const int DDCAPS2_CANMANAGETEXTURE = 0x00800000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_TEXMANINNONLOCALVIDMEM"]/*' />
    [NativeTypeName("#define DDCAPS2_TEXMANINNONLOCALVIDMEM 0x01000000l")]
    public const int DDCAPS2_TEXMANINNONLOCALVIDMEM = 0x01000000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_STEREO"]/*' />
    [NativeTypeName("#define DDCAPS2_STEREO 0x02000000L")]
    public const int DDCAPS2_STEREO = 0x02000000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_SYSTONONLOCAL_AS_SYSTOLOCAL"]/*' />
    [NativeTypeName("#define DDCAPS2_SYSTONONLOCAL_AS_SYSTOLOCAL 0x04000000L")]
    public const int DDCAPS2_SYSTONONLOCAL_AS_SYSTOLOCAL = 0x04000000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_RESERVED1"]/*' />
    [NativeTypeName("#define DDCAPS2_RESERVED1 0x08000000L")]
    public const int DDCAPS2_RESERVED1 = 0x08000000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_CANMANAGERESOURCE"]/*' />
    [NativeTypeName("#define DDCAPS2_CANMANAGERESOURCE 0x10000000L")]
    public const int DDCAPS2_CANMANAGERESOURCE = 0x10000000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_DYNAMICTEXTURES"]/*' />
    [NativeTypeName("#define DDCAPS2_DYNAMICTEXTURES 0x20000000L")]
    public const int DDCAPS2_DYNAMICTEXTURES = 0x20000000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_CANAUTOGENMIPMAP"]/*' />
    [NativeTypeName("#define DDCAPS2_CANAUTOGENMIPMAP 0x40000000L")]
    public const int DDCAPS2_CANAUTOGENMIPMAP = 0x40000000;

    /// <include file='DDCAPS2.xml' path='doc/member[@name="DDCAPS2.DDCAPS2_CANSHARERESOURCE"]/*' />
    [NativeTypeName("#define DDCAPS2_CANSHARERESOURCE 0x80000000L")]
    public const uint DDCAPS2_CANSHARERESOURCE = 0x80000000;
}
