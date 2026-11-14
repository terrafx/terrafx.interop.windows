// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDEF_CLASS_DEFAULT"]/*' />
    [NativeTypeName("#define CDEF_CLASS_DEFAULT 0x0001")]
    public const int CDEF_CLASS_DEFAULT = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDEF_BYPASS_CLASS_MANAGER"]/*' />
    [NativeTypeName("#define CDEF_BYPASS_CLASS_MANAGER 0x0002")]
    public const int CDEF_BYPASS_CLASS_MANAGER = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDEF_MERIT_ABOVE_DO_NOT_USE"]/*' />
    [NativeTypeName("#define CDEF_MERIT_ABOVE_DO_NOT_USE 0x0008")]
    public const int CDEF_MERIT_ABOVE_DO_NOT_USE = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDEF_DEVMON_CMGR_DEVICE"]/*' />
    [NativeTypeName("#define CDEF_DEVMON_CMGR_DEVICE 0x0010")]
    public const int CDEF_DEVMON_CMGR_DEVICE = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDEF_DEVMON_DMO"]/*' />
    [NativeTypeName("#define CDEF_DEVMON_DMO 0x0020")]
    public const int CDEF_DEVMON_DMO = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDEF_DEVMON_PNP_DEVICE"]/*' />
    [NativeTypeName("#define CDEF_DEVMON_PNP_DEVICE 0x0040")]
    public const int CDEF_DEVMON_PNP_DEVICE = 0x0040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDEF_DEVMON_FILTER"]/*' />
    [NativeTypeName("#define CDEF_DEVMON_FILTER 0x0080")]
    public const int CDEF_DEVMON_FILTER = 0x0080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDEF_DEVMON_SELECTIVE_MASK"]/*' />
    [NativeTypeName("#define CDEF_DEVMON_SELECTIVE_MASK 0x00f0")]
    public const int CDEF_DEVMON_SELECTIVE_MASK = 0x00f0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CHARS_IN_GUID"]/*' />
    [NativeTypeName("#define CHARS_IN_GUID 39")]
    public const int CHARS_IN_GUID = 39;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ADVISE_ALL"]/*' />
    [NativeTypeName("#define ADVISE_ALL ( ( ( ( ADVISE_CLIPPING | ADVISE_PALETTE )  | ADVISE_COLORKEY )  | ADVISE_POSITION )  )")]
    public const int ADVISE_ALL = (((((int)(ADVISE_CLIPPING) | (int)(ADVISE_PALETTE)) | (int)(ADVISE_COLORKEY)) | (int)(ADVISE_POSITION)));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ADVISE_ALL2"]/*' />
    [NativeTypeName("#define ADVISE_ALL2 ( ( ADVISE_ALL | ADVISE_DISPLAY_CHANGE )  )")]
    public const int ADVISE_ALL2 = (((((((int)(ADVISE_CLIPPING) | (int)(ADVISE_PALETTE)) | (int)(ADVISE_COLORKEY)) | (int)(ADVISE_POSITION))) | (int)(ADVISE_DISPLAY_CHANGE)));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AMF_AUTOMATICGAIN"]/*' />
    [NativeTypeName("#define AMF_AUTOMATICGAIN -1.0")]
    public const double AMF_AUTOMATICGAIN = -1.0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AnalogVideo_NTSC_Mask"]/*' />
    [NativeTypeName("#define AnalogVideo_NTSC_Mask 0x00000007")]
    public const int AnalogVideo_NTSC_Mask = 0x00000007;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AnalogVideo_PAL_Mask"]/*' />
    [NativeTypeName("#define AnalogVideo_PAL_Mask 0x00100FF0")]
    public const int AnalogVideo_PAL_Mask = 0x00100FF0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AnalogVideo_SECAM_Mask"]/*' />
    [NativeTypeName("#define AnalogVideo_SECAM_Mask 0x000FF000")]
    public const int AnalogVideo_SECAM_Mask = 0x000FF000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KSPROPERTY_SUPPORT_GET"]/*' />
    [NativeTypeName("#define KSPROPERTY_SUPPORT_GET 1")]
    public const int KSPROPERTY_SUPPORT_GET = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KSPROPERTY_SUPPORT_SET"]/*' />
    [NativeTypeName("#define KSPROPERTY_SUPPORT_SET 2")]
    public const int KSPROPERTY_SUPPORT_SET = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MPEG2_PROGRAM_STREAM_MAP"]/*' />
    [NativeTypeName("#define MPEG2_PROGRAM_STREAM_MAP 0x00000000")]
    public const int MPEG2_PROGRAM_STREAM_MAP = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MPEG2_PROGRAM_ELEMENTARY_STREAM"]/*' />
    [NativeTypeName("#define MPEG2_PROGRAM_ELEMENTARY_STREAM 0x00000001")]
    public const int MPEG2_PROGRAM_ELEMENTARY_STREAM = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MPEG2_PROGRAM_DIRECTORY_PES_PACKET"]/*' />
    [NativeTypeName("#define MPEG2_PROGRAM_DIRECTORY_PES_PACKET 0x00000002")]
    public const int MPEG2_PROGRAM_DIRECTORY_PES_PACKET = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MPEG2_PROGRAM_PACK_HEADER"]/*' />
    [NativeTypeName("#define MPEG2_PROGRAM_PACK_HEADER 0x00000003")]
    public const int MPEG2_PROGRAM_PACK_HEADER = 0x00000003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MPEG2_PROGRAM_PES_STREAM"]/*' />
    [NativeTypeName("#define MPEG2_PROGRAM_PES_STREAM 0x00000004")]
    public const int MPEG2_PROGRAM_PES_STREAM = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MPEG2_PROGRAM_SYSTEM_HEADER"]/*' />
    [NativeTypeName("#define MPEG2_PROGRAM_SYSTEM_HEADER 0x00000005")]
    public const int MPEG2_PROGRAM_SYSTEM_HEADER = 0x00000005;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SUBSTREAM_FILTER_VAL_NONE"]/*' />
    [NativeTypeName("#define SUBSTREAM_FILTER_VAL_NONE 0x10000000")]
    public const int SUBSTREAM_FILTER_VAL_NONE = 0x10000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VMR_NOTSUPPORTED"]/*' />
    [NativeTypeName("#define VMR_NOTSUPPORTED 0x00000000")]
    public const int VMR_NOTSUPPORTED = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VMR_SUPPORTED"]/*' />
    [NativeTypeName("#define VMR_SUPPORTED 0x00000001")]
    public const int VMR_SUPPORTED = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DECODER_CAP_NOTSUPPORTED"]/*' />
    [NativeTypeName("#define DECODER_CAP_NOTSUPPORTED 0x00000000")]
    public const int DECODER_CAP_NOTSUPPORTED = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DECODER_CAP_SUPPORTED"]/*' />
    [NativeTypeName("#define DECODER_CAP_SUPPORTED 0x00000001")]
    public const int DECODER_CAP_SUPPORTED = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VMRBITMAP_DISABLE"]/*' />
    [NativeTypeName("#define VMRBITMAP_DISABLE 0x00000001")]
    public const int VMRBITMAP_DISABLE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VMRBITMAP_HDC"]/*' />
    [NativeTypeName("#define VMRBITMAP_HDC 0x00000002")]
    public const int VMRBITMAP_HDC = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VMRBITMAP_ENTIREDDS"]/*' />
    [NativeTypeName("#define VMRBITMAP_ENTIREDDS 0x00000004")]
    public const int VMRBITMAP_ENTIREDDS = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VMRBITMAP_SRCCOLORKEY"]/*' />
    [NativeTypeName("#define VMRBITMAP_SRCCOLORKEY 0x00000008")]
    public const int VMRBITMAP_SRCCOLORKEY = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VMRBITMAP_SRCRECT"]/*' />
    [NativeTypeName("#define VMRBITMAP_SRCRECT 0x00000010")]
    public const int VMRBITMAP_SRCRECT = 0x00000010;
}
