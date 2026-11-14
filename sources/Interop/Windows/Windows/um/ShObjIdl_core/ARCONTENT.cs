// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ARCONTENT
{
    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_AUTORUNINF"]/*' />
    [NativeTypeName("#define ARCONTENT_AUTORUNINF 0x00000002")]
    public const int ARCONTENT_AUTORUNINF = 0x00000002;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_AUDIOCD"]/*' />
    [NativeTypeName("#define ARCONTENT_AUDIOCD 0x00000004")]
    public const int ARCONTENT_AUDIOCD = 0x00000004;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_DVDMOVIE"]/*' />
    [NativeTypeName("#define ARCONTENT_DVDMOVIE 0x00000008")]
    public const int ARCONTENT_DVDMOVIE = 0x00000008;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_BLANKCD"]/*' />
    [NativeTypeName("#define ARCONTENT_BLANKCD 0x00000010")]
    public const int ARCONTENT_BLANKCD = 0x00000010;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_BLANKDVD"]/*' />
    [NativeTypeName("#define ARCONTENT_BLANKDVD 0x00000020")]
    public const int ARCONTENT_BLANKDVD = 0x00000020;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_UNKNOWNCONTENT"]/*' />
    [NativeTypeName("#define ARCONTENT_UNKNOWNCONTENT 0x00000040")]
    public const int ARCONTENT_UNKNOWNCONTENT = 0x00000040;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_AUTOPLAYPIX"]/*' />
    [NativeTypeName("#define ARCONTENT_AUTOPLAYPIX 0x00000080")]
    public const int ARCONTENT_AUTOPLAYPIX = 0x00000080;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_AUTOPLAYMUSIC"]/*' />
    [NativeTypeName("#define ARCONTENT_AUTOPLAYMUSIC 0x00000100")]
    public const int ARCONTENT_AUTOPLAYMUSIC = 0x00000100;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_AUTOPLAYVIDEO"]/*' />
    [NativeTypeName("#define ARCONTENT_AUTOPLAYVIDEO 0x00000200")]
    public const int ARCONTENT_AUTOPLAYVIDEO = 0x00000200;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_VCD"]/*' />
    [NativeTypeName("#define ARCONTENT_VCD 0x00000400")]
    public const int ARCONTENT_VCD = 0x00000400;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_SVCD"]/*' />
    [NativeTypeName("#define ARCONTENT_SVCD 0x00000800")]
    public const int ARCONTENT_SVCD = 0x00000800;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_DVDAUDIO"]/*' />
    [NativeTypeName("#define ARCONTENT_DVDAUDIO 0x00001000")]
    public const int ARCONTENT_DVDAUDIO = 0x00001000;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_BLANKBD"]/*' />
    [NativeTypeName("#define ARCONTENT_BLANKBD 0x00002000")]
    public const int ARCONTENT_BLANKBD = 0x00002000;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_BLURAY"]/*' />
    [NativeTypeName("#define ARCONTENT_BLURAY 0x00004000")]
    public const int ARCONTENT_BLURAY = 0x00004000;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_CAMERASTORAGE"]/*' />
    [NativeTypeName("#define ARCONTENT_CAMERASTORAGE 0x00008000")]
    public const int ARCONTENT_CAMERASTORAGE = 0x00008000;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_CUSTOMEVENT"]/*' />
    [NativeTypeName("#define ARCONTENT_CUSTOMEVENT 0x00010000")]
    public const int ARCONTENT_CUSTOMEVENT = 0x00010000;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_NONE"]/*' />
    [NativeTypeName("#define ARCONTENT_NONE 0x00000000")]
    public const int ARCONTENT_NONE = 0x00000000;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_MASK"]/*' />
    [NativeTypeName("#define ARCONTENT_MASK 0x0001FFFE")]
    public const int ARCONTENT_MASK = 0x0001FFFE;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_PHASE_UNKNOWN"]/*' />
    [NativeTypeName("#define ARCONTENT_PHASE_UNKNOWN 0x00000000")]
    public const int ARCONTENT_PHASE_UNKNOWN = 0x00000000;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_PHASE_PRESNIFF"]/*' />
    [NativeTypeName("#define ARCONTENT_PHASE_PRESNIFF 0x10000000")]
    public const int ARCONTENT_PHASE_PRESNIFF = 0x10000000;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_PHASE_SNIFFING"]/*' />
    [NativeTypeName("#define ARCONTENT_PHASE_SNIFFING 0x20000000")]
    public const int ARCONTENT_PHASE_SNIFFING = 0x20000000;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_PHASE_FINAL"]/*' />
    [NativeTypeName("#define ARCONTENT_PHASE_FINAL 0x40000000")]
    public const int ARCONTENT_PHASE_FINAL = 0x40000000;

    /// <include file='ARCONTENT.xml' path='doc/member[@name="ARCONTENT.ARCONTENT_PHASE_MASK"]/*' />
    [NativeTypeName("#define ARCONTENT_PHASE_MASK 0x70000000")]
    public const int ARCONTENT_PHASE_MASK = 0x70000000;
}
