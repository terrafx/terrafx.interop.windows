// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows._INC_MMREG"]/*' />
    [NativeTypeName("#define _INC_MMREG 158")]
    public const int _INC_MMREG = 158;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CRYSTAL_NET_SFM_CODEC"]/*' />
    [NativeTypeName("#define CRYSTAL_NET_SFM_CODEC 1")]
    public const int CRYSTAL_NET_SFM_CODEC = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MPEGLAYER3_WFX_EXTRA_BYTES"]/*' />
    [NativeTypeName("#define MPEGLAYER3_WFX_EXTRA_BYTES 12")]
    public const int MPEGLAYER3_WFX_EXTRA_BYTES = 12;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MPEGLAYER3_ID_UNKNOWN"]/*' />
    [NativeTypeName("#define MPEGLAYER3_ID_UNKNOWN 0")]
    public const int MPEGLAYER3_ID_UNKNOWN = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MPEGLAYER3_ID_MPEG"]/*' />
    [NativeTypeName("#define MPEGLAYER3_ID_MPEG 1")]
    public const int MPEGLAYER3_ID_MPEG = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MPEGLAYER3_ID_CONSTANTFRAMESIZE"]/*' />
    [NativeTypeName("#define MPEGLAYER3_ID_CONSTANTFRAMESIZE 2")]
    public const int MPEGLAYER3_ID_CONSTANTFRAMESIZE = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MPEGLAYER3_FLAG_PADDING_ISO"]/*' />
    [NativeTypeName("#define MPEGLAYER3_FLAG_PADDING_ISO 0x00000000")]
    public const int MPEGLAYER3_FLAG_PADDING_ISO = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MPEGLAYER3_FLAG_PADDING_ON"]/*' />
    [NativeTypeName("#define MPEGLAYER3_FLAG_PADDING_ON 0x00000001")]
    public const int MPEGLAYER3_FLAG_PADDING_ON = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MPEGLAYER3_FLAG_PADDING_OFF"]/*' />
    [NativeTypeName("#define MPEGLAYER3_FLAG_PADDING_OFF 0x00000002")]
    public const int MPEGLAYER3_FLAG_PADDING_OFF = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WMAUDIO_BITS_PER_SAMPLE"]/*' />
    [NativeTypeName("#define WMAUDIO_BITS_PER_SAMPLE 16")]
    public const int WMAUDIO_BITS_PER_SAMPLE = 16;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WMAUDIO_MAX_CHANNELS"]/*' />
    [NativeTypeName("#define WMAUDIO_MAX_CHANNELS 2")]
    public const int WMAUDIO_MAX_CHANNELS = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MSAUDIO1_BITS_PER_SAMPLE"]/*' />
    [NativeTypeName("#define MSAUDIO1_BITS_PER_SAMPLE WMAUDIO_BITS_PER_SAMPLE")]
    public const int MSAUDIO1_BITS_PER_SAMPLE = 16;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MSAUDIO1_MAX_CHANNELS"]/*' />
    [NativeTypeName("#define MSAUDIO1_MAX_CHANNELS WMAUDIO_MAX_CHANNELS")]
    public const int MSAUDIO1_MAX_CHANNELS = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WMAUDIO2_BITS_PER_SAMPLE"]/*' />
    [NativeTypeName("#define WMAUDIO2_BITS_PER_SAMPLE WMAUDIO_BITS_PER_SAMPLE")]
    public const int WMAUDIO2_BITS_PER_SAMPLE = 16;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WMAUDIO2_MAX_CHANNELS"]/*' />
    [NativeTypeName("#define WMAUDIO2_MAX_CHANNELS WMAUDIO_MAX_CHANNELS")]
    public const int WMAUDIO2_MAX_CHANNELS = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RIFFWAVE_inst"]/*' />
    [NativeTypeName("#define RIFFWAVE_inst mmioFOURCC('i','n','s','t')")]
    public const uint RIFFWAVE_inst = ((uint)((byte)('i')) | ((uint)((byte)('n')) << 8) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('t')) << 24));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RIFFCPPO"]/*' />
    [NativeTypeName("#define RIFFCPPO mmioFOURCC('C','P','P','O')")]
    public const uint RIFFCPPO = ((uint)((byte)('C')) | ((uint)((byte)('P')) << 8) | ((uint)((byte)('P')) << 16) | ((uint)((byte)('O')) << 24));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BICOMP_IBMULTIMOTION"]/*' />
    [NativeTypeName("#define BICOMP_IBMULTIMOTION mmioFOURCC('U', 'L', 'T', 'I')")]
    public const uint BICOMP_IBMULTIMOTION = ((uint)((byte)('U')) | ((uint)((byte)('L')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('I')) << 24));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BICOMP_IBMPHOTOMOTION"]/*' />
    [NativeTypeName("#define BICOMP_IBMPHOTOMOTION mmioFOURCC('P', 'H', 'M', 'O')")]
    public const uint BICOMP_IBMPHOTOMOTION = ((uint)((byte)('P')) | ((uint)((byte)('H')) << 8) | ((uint)((byte)('M')) << 16) | ((uint)((byte)('O')) << 24));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BICOMP_CREATIVEYUV"]/*' />
    [NativeTypeName("#define BICOMP_CREATIVEYUV mmioFOURCC('c', 'y', 'u', 'v')")]
    public const uint BICOMP_CREATIVEYUV = ((uint)((byte)('c')) | ((uint)((byte)('y')) << 8) | ((uint)((byte)('u')) << 16) | ((uint)((byte)('v')) << 24));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.JPEG_DIB"]/*' />
    [NativeTypeName("#define JPEG_DIB mmioFOURCC('J','P','E','G')")]
    public const uint JPEG_DIB = ((uint)((byte)('J')) | ((uint)((byte)('P')) << 8) | ((uint)((byte)('E')) << 16) | ((uint)((byte)('G')) << 24));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MJPG_DIB"]/*' />
    [NativeTypeName("#define MJPG_DIB mmioFOURCC('M','J','P','G')")]
    public const uint MJPG_DIB = ((uint)((byte)('M')) | ((uint)((byte)('J')) << 8) | ((uint)((byte)('P')) << 16) | ((uint)((byte)('G')) << 24));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.JPEG_PROCESS_BASELINE"]/*' />
    [NativeTypeName("#define JPEG_PROCESS_BASELINE 0")]
    public const int JPEG_PROCESS_BASELINE = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AVIIF_CONTROLFRAME"]/*' />
    [NativeTypeName("#define AVIIF_CONTROLFRAME 0x00000200L")]
    public const int AVIIF_CONTROLFRAME = 0x00000200;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.JPEG_Y"]/*' />
    [NativeTypeName("#define JPEG_Y 1")]
    public const int JPEG_Y = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.JPEG_YCbCr"]/*' />
    [NativeTypeName("#define JPEG_YCbCr 2")]
    public const int JPEG_YCbCr = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.JPEG_RGB"]/*' />
    [NativeTypeName("#define JPEG_RGB 3")]
    public const int JPEG_RGB = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ICTYPE_VIDEO"]/*' />
    [NativeTypeName("#define ICTYPE_VIDEO mmioFOURCC('v', 'i', 'd', 'c')")]
    public const uint ICTYPE_VIDEO = ((uint)((byte)('v')) | ((uint)((byte)('i')) << 8) | ((uint)((byte)('d')) << 16) | ((uint)((byte)('c')) << 24));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ICTYPE_AUDIO"]/*' />
    [NativeTypeName("#define ICTYPE_AUDIO mmioFOURCC('a', 'u', 'd', 'c')")]
    public const uint ICTYPE_AUDIO = ((uint)((byte)('a')) | ((uint)((byte)('u')) << 8) | ((uint)((byte)('d')) << 16) | ((uint)((byte)('c')) << 24));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FOURCC_RDSP"]/*' />
    [NativeTypeName("#define FOURCC_RDSP mmioFOURCC('R', 'D', 'S', 'P')")]
    public const uint FOURCC_RDSP = ((uint)((byte)('R')) | ((uint)((byte)('D')) << 8) | ((uint)((byte)('S')) << 16) | ((uint)((byte)('P')) << 24));
}
