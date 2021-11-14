// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define _INC_MMREG 158")]
        public const int _INC_MMREG = 158;

        [NativeTypeName("#define ROCKWELL_WA1_WAVEIN 100")]
        public const int ROCKWELL_WA1_WAVEIN = 100;

        [NativeTypeName("#define ROCKWELL_WA1_WAVEOUT 101")]
        public const int ROCKWELL_WA1_WAVEOUT = 101;

        [NativeTypeName("#define ROCKWELL_WA1_SYNTH 102")]
        public const int ROCKWELL_WA1_SYNTH = 102;

        [NativeTypeName("#define ROCKWELL_WA1_MIXER 103")]
        public const int ROCKWELL_WA1_MIXER = 103;

        [NativeTypeName("#define ROCKWELL_WA1_MPU401_IN 104")]
        public const int ROCKWELL_WA1_MPU401_IN = 104;

        [NativeTypeName("#define ROCKWELL_WA1_MPU401_OUT 105")]
        public const int ROCKWELL_WA1_MPU401_OUT = 105;

        [NativeTypeName("#define ROCKWELL_WA2_WAVEIN 200")]
        public const int ROCKWELL_WA2_WAVEIN = 200;

        [NativeTypeName("#define ROCKWELL_WA2_WAVEOUT 201")]
        public const int ROCKWELL_WA2_WAVEOUT = 201;

        [NativeTypeName("#define ROCKWELL_WA2_SYNTH 202")]
        public const int ROCKWELL_WA2_SYNTH = 202;

        [NativeTypeName("#define ROCKWELL_WA2_MIXER 203")]
        public const int ROCKWELL_WA2_MIXER = 203;

        [NativeTypeName("#define ROCKWELL_WA2_MPU401_IN 204")]
        public const int ROCKWELL_WA2_MPU401_IN = 204;

        [NativeTypeName("#define ROCKWELL_WA2_MPU401_OUT 205")]
        public const int ROCKWELL_WA2_MPU401_OUT = 205;

        [NativeTypeName("#define CRYSTAL_NET_SFM_CODEC 1")]
        public const int CRYSTAL_NET_SFM_CODEC = 1;

        [NativeTypeName("#define RIFFINFO_IARL mmioFOURCC ('I', 'A', 'R', 'L')")]
        public const uint RIFFINFO_IARL = ((uint)((byte)('I')) | ((uint)((byte)('A')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('L')) << 24));

        [NativeTypeName("#define RIFFINFO_IART mmioFOURCC ('I', 'A', 'R', 'T')")]
        public const uint RIFFINFO_IART = ((uint)((byte)('I')) | ((uint)((byte)('A')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('T')) << 24));

        [NativeTypeName("#define RIFFINFO_ICMS mmioFOURCC ('I', 'C', 'M', 'S')")]
        public const uint RIFFINFO_ICMS = ((uint)((byte)('I')) | ((uint)((byte)('C')) << 8) | ((uint)((byte)('M')) << 16) | ((uint)((byte)('S')) << 24));

        [NativeTypeName("#define RIFFINFO_ICMT mmioFOURCC ('I', 'C', 'M', 'T')")]
        public const uint RIFFINFO_ICMT = ((uint)((byte)('I')) | ((uint)((byte)('C')) << 8) | ((uint)((byte)('M')) << 16) | ((uint)((byte)('T')) << 24));

        [NativeTypeName("#define RIFFINFO_ICOP mmioFOURCC ('I', 'C', 'O', 'P')")]
        public const uint RIFFINFO_ICOP = ((uint)((byte)('I')) | ((uint)((byte)('C')) << 8) | ((uint)((byte)('O')) << 16) | ((uint)((byte)('P')) << 24));

        [NativeTypeName("#define RIFFINFO_ICRD mmioFOURCC ('I', 'C', 'R', 'D')")]
        public const uint RIFFINFO_ICRD = ((uint)((byte)('I')) | ((uint)((byte)('C')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('D')) << 24));

        [NativeTypeName("#define RIFFINFO_ICRP mmioFOURCC ('I', 'C', 'R', 'P')")]
        public const uint RIFFINFO_ICRP = ((uint)((byte)('I')) | ((uint)((byte)('C')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('P')) << 24));

        [NativeTypeName("#define RIFFINFO_IDIM mmioFOURCC ('I', 'D', 'I', 'M')")]
        public const uint RIFFINFO_IDIM = ((uint)((byte)('I')) | ((uint)((byte)('D')) << 8) | ((uint)((byte)('I')) << 16) | ((uint)((byte)('M')) << 24));

        [NativeTypeName("#define RIFFINFO_IDPI mmioFOURCC ('I', 'D', 'P', 'I')")]
        public const uint RIFFINFO_IDPI = ((uint)((byte)('I')) | ((uint)((byte)('D')) << 8) | ((uint)((byte)('P')) << 16) | ((uint)((byte)('I')) << 24));

        [NativeTypeName("#define RIFFINFO_IENG mmioFOURCC ('I', 'E', 'N', 'G')")]
        public const uint RIFFINFO_IENG = ((uint)((byte)('I')) | ((uint)((byte)('E')) << 8) | ((uint)((byte)('N')) << 16) | ((uint)((byte)('G')) << 24));

        [NativeTypeName("#define RIFFINFO_IGNR mmioFOURCC ('I', 'G', 'N', 'R')")]
        public const uint RIFFINFO_IGNR = ((uint)((byte)('I')) | ((uint)((byte)('G')) << 8) | ((uint)((byte)('N')) << 16) | ((uint)((byte)('R')) << 24));

        [NativeTypeName("#define RIFFINFO_IKEY mmioFOURCC ('I', 'K', 'E', 'Y')")]
        public const uint RIFFINFO_IKEY = ((uint)((byte)('I')) | ((uint)((byte)('K')) << 8) | ((uint)((byte)('E')) << 16) | ((uint)((byte)('Y')) << 24));

        [NativeTypeName("#define RIFFINFO_ILGT mmioFOURCC ('I', 'L', 'G', 'T')")]
        public const uint RIFFINFO_ILGT = ((uint)((byte)('I')) | ((uint)((byte)('L')) << 8) | ((uint)((byte)('G')) << 16) | ((uint)((byte)('T')) << 24));

        [NativeTypeName("#define RIFFINFO_IMED mmioFOURCC ('I', 'M', 'E', 'D')")]
        public const uint RIFFINFO_IMED = ((uint)((byte)('I')) | ((uint)((byte)('M')) << 8) | ((uint)((byte)('E')) << 16) | ((uint)((byte)('D')) << 24));

        [NativeTypeName("#define RIFFINFO_INAM mmioFOURCC ('I', 'N', 'A', 'M')")]
        public const uint RIFFINFO_INAM = ((uint)((byte)('I')) | ((uint)((byte)('N')) << 8) | ((uint)((byte)('A')) << 16) | ((uint)((byte)('M')) << 24));

        [NativeTypeName("#define RIFFINFO_IPLT mmioFOURCC ('I', 'P', 'L', 'T')")]
        public const uint RIFFINFO_IPLT = ((uint)((byte)('I')) | ((uint)((byte)('P')) << 8) | ((uint)((byte)('L')) << 16) | ((uint)((byte)('T')) << 24));

        [NativeTypeName("#define RIFFINFO_IPRD mmioFOURCC ('I', 'P', 'R', 'D')")]
        public const uint RIFFINFO_IPRD = ((uint)((byte)('I')) | ((uint)((byte)('P')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('D')) << 24));

        [NativeTypeName("#define RIFFINFO_ISBJ mmioFOURCC ('I', 'S', 'B', 'J')")]
        public const uint RIFFINFO_ISBJ = ((uint)((byte)('I')) | ((uint)((byte)('S')) << 8) | ((uint)((byte)('B')) << 16) | ((uint)((byte)('J')) << 24));

        [NativeTypeName("#define RIFFINFO_ISFT mmioFOURCC ('I', 'S', 'F', 'T')")]
        public const uint RIFFINFO_ISFT = ((uint)((byte)('I')) | ((uint)((byte)('S')) << 8) | ((uint)((byte)('F')) << 16) | ((uint)((byte)('T')) << 24));

        [NativeTypeName("#define RIFFINFO_ISHP mmioFOURCC ('I', 'S', 'H', 'P')")]
        public const uint RIFFINFO_ISHP = ((uint)((byte)('I')) | ((uint)((byte)('S')) << 8) | ((uint)((byte)('H')) << 16) | ((uint)((byte)('P')) << 24));

        [NativeTypeName("#define RIFFINFO_ISRC mmioFOURCC ('I', 'S', 'R', 'C')")]
        public const uint RIFFINFO_ISRC = ((uint)((byte)('I')) | ((uint)((byte)('S')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('C')) << 24));

        [NativeTypeName("#define RIFFINFO_ISRF mmioFOURCC ('I', 'S', 'R', 'F')")]
        public const uint RIFFINFO_ISRF = ((uint)((byte)('I')) | ((uint)((byte)('S')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('F')) << 24));

        [NativeTypeName("#define RIFFINFO_ITCH mmioFOURCC ('I', 'T', 'C', 'H')")]
        public const uint RIFFINFO_ITCH = ((uint)((byte)('I')) | ((uint)((byte)('T')) << 8) | ((uint)((byte)('C')) << 16) | ((uint)((byte)('H')) << 24));

        [NativeTypeName("#define RIFFINFO_ISMP mmioFOURCC ('I', 'S', 'M', 'P')")]
        public const uint RIFFINFO_ISMP = ((uint)((byte)('I')) | ((uint)((byte)('S')) << 8) | ((uint)((byte)('M')) << 16) | ((uint)((byte)('P')) << 24));

        [NativeTypeName("#define RIFFINFO_IDIT mmioFOURCC ('I', 'D', 'I', 'T')")]
        public const uint RIFFINFO_IDIT = ((uint)((byte)('I')) | ((uint)((byte)('D')) << 8) | ((uint)((byte)('I')) << 16) | ((uint)((byte)('T')) << 24));

        [NativeTypeName("#define RIFFINFO_ITRK mmioFOURCC ('I', 'T', 'R', 'K')")]
        public const uint RIFFINFO_ITRK = ((uint)((byte)('I')) | ((uint)((byte)('T')) << 8) | ((uint)((byte)('R')) << 16) | ((uint)((byte)('K')) << 24));

        [NativeTypeName("#define RIFFINFO_ITOC mmioFOURCC ('I', 'T', 'O', 'C')")]
        public const uint RIFFINFO_ITOC = ((uint)((byte)('I')) | ((uint)((byte)('T')) << 8) | ((uint)((byte)('O')) << 16) | ((uint)((byte)('C')) << 24));

        [NativeTypeName("#define SPEAKER_FRONT_LEFT 0x1")]
        public const int SPEAKER_FRONT_LEFT = 0x1;

        [NativeTypeName("#define SPEAKER_FRONT_RIGHT 0x2")]
        public const int SPEAKER_FRONT_RIGHT = 0x2;

        [NativeTypeName("#define SPEAKER_FRONT_CENTER 0x4")]
        public const int SPEAKER_FRONT_CENTER = 0x4;

        [NativeTypeName("#define SPEAKER_LOW_FREQUENCY 0x8")]
        public const int SPEAKER_LOW_FREQUENCY = 0x8;

        [NativeTypeName("#define SPEAKER_BACK_LEFT 0x10")]
        public const int SPEAKER_BACK_LEFT = 0x10;

        [NativeTypeName("#define SPEAKER_BACK_RIGHT 0x20")]
        public const int SPEAKER_BACK_RIGHT = 0x20;

        [NativeTypeName("#define SPEAKER_FRONT_LEFT_OF_CENTER 0x40")]
        public const int SPEAKER_FRONT_LEFT_OF_CENTER = 0x40;

        [NativeTypeName("#define SPEAKER_FRONT_RIGHT_OF_CENTER 0x80")]
        public const int SPEAKER_FRONT_RIGHT_OF_CENTER = 0x80;

        [NativeTypeName("#define SPEAKER_BACK_CENTER 0x100")]
        public const int SPEAKER_BACK_CENTER = 0x100;

        [NativeTypeName("#define SPEAKER_SIDE_LEFT 0x200")]
        public const int SPEAKER_SIDE_LEFT = 0x200;

        [NativeTypeName("#define SPEAKER_SIDE_RIGHT 0x400")]
        public const int SPEAKER_SIDE_RIGHT = 0x400;

        [NativeTypeName("#define SPEAKER_TOP_CENTER 0x800")]
        public const int SPEAKER_TOP_CENTER = 0x800;

        [NativeTypeName("#define SPEAKER_TOP_FRONT_LEFT 0x1000")]
        public const int SPEAKER_TOP_FRONT_LEFT = 0x1000;

        [NativeTypeName("#define SPEAKER_TOP_FRONT_CENTER 0x2000")]
        public const int SPEAKER_TOP_FRONT_CENTER = 0x2000;

        [NativeTypeName("#define SPEAKER_TOP_FRONT_RIGHT 0x4000")]
        public const int SPEAKER_TOP_FRONT_RIGHT = 0x4000;

        [NativeTypeName("#define SPEAKER_TOP_BACK_LEFT 0x8000")]
        public const int SPEAKER_TOP_BACK_LEFT = 0x8000;

        [NativeTypeName("#define SPEAKER_TOP_BACK_CENTER 0x10000")]
        public const int SPEAKER_TOP_BACK_CENTER = 0x10000;

        [NativeTypeName("#define SPEAKER_TOP_BACK_RIGHT 0x20000")]
        public const int SPEAKER_TOP_BACK_RIGHT = 0x20000;

        [NativeTypeName("#define SPEAKER_RESERVED 0x7FFC0000")]
        public const int SPEAKER_RESERVED = 0x7FFC0000;

        [NativeTypeName("#define SPEAKER_ALL 0x80000000")]
        public const uint SPEAKER_ALL = 0x80000000;

        [NativeTypeName("#define ACM_MPEG_LAYER1 (0x0001)")]
        public const int ACM_MPEG_LAYER1 = (0x0001);

        [NativeTypeName("#define ACM_MPEG_LAYER2 (0x0002)")]
        public const int ACM_MPEG_LAYER2 = (0x0002);

        [NativeTypeName("#define ACM_MPEG_LAYER3 (0x0004)")]
        public const int ACM_MPEG_LAYER3 = (0x0004);

        [NativeTypeName("#define ACM_MPEG_STEREO (0x0001)")]
        public const int ACM_MPEG_STEREO = (0x0001);

        [NativeTypeName("#define ACM_MPEG_JOINTSTEREO (0x0002)")]
        public const int ACM_MPEG_JOINTSTEREO = (0x0002);

        [NativeTypeName("#define ACM_MPEG_DUALCHANNEL (0x0004)")]
        public const int ACM_MPEG_DUALCHANNEL = (0x0004);

        [NativeTypeName("#define ACM_MPEG_SINGLECHANNEL (0x0008)")]
        public const int ACM_MPEG_SINGLECHANNEL = (0x0008);

        [NativeTypeName("#define ACM_MPEG_PRIVATEBIT (0x0001)")]
        public const int ACM_MPEG_PRIVATEBIT = (0x0001);

        [NativeTypeName("#define ACM_MPEG_COPYRIGHT (0x0002)")]
        public const int ACM_MPEG_COPYRIGHT = (0x0002);

        [NativeTypeName("#define ACM_MPEG_ORIGINALHOME (0x0004)")]
        public const int ACM_MPEG_ORIGINALHOME = (0x0004);

        [NativeTypeName("#define ACM_MPEG_PROTECTIONBIT (0x0008)")]
        public const int ACM_MPEG_PROTECTIONBIT = (0x0008);

        [NativeTypeName("#define ACM_MPEG_ID_MPEG1 (0x0010)")]
        public const int ACM_MPEG_ID_MPEG1 = (0x0010);

        [NativeTypeName("#define MPEGLAYER3_WFX_EXTRA_BYTES 12")]
        public const int MPEGLAYER3_WFX_EXTRA_BYTES = 12;

        [NativeTypeName("#define MPEGLAYER3_ID_UNKNOWN 0")]
        public const int MPEGLAYER3_ID_UNKNOWN = 0;

        [NativeTypeName("#define MPEGLAYER3_ID_MPEG 1")]
        public const int MPEGLAYER3_ID_MPEG = 1;

        [NativeTypeName("#define MPEGLAYER3_ID_CONSTANTFRAMESIZE 2")]
        public const int MPEGLAYER3_ID_CONSTANTFRAMESIZE = 2;

        [NativeTypeName("#define MPEGLAYER3_FLAG_PADDING_ISO 0x00000000")]
        public const int MPEGLAYER3_FLAG_PADDING_ISO = 0x00000000;

        [NativeTypeName("#define MPEGLAYER3_FLAG_PADDING_ON 0x00000001")]
        public const int MPEGLAYER3_FLAG_PADDING_ON = 0x00000001;

        [NativeTypeName("#define MPEGLAYER3_FLAG_PADDING_OFF 0x00000002")]
        public const int MPEGLAYER3_FLAG_PADDING_OFF = 0x00000002;

        [NativeTypeName("#define WMAUDIO_BITS_PER_SAMPLE 16")]
        public const int WMAUDIO_BITS_PER_SAMPLE = 16;

        [NativeTypeName("#define WMAUDIO_MAX_CHANNELS 2")]
        public const int WMAUDIO_MAX_CHANNELS = 2;

        [NativeTypeName("#define MSAUDIO1_BITS_PER_SAMPLE WMAUDIO_BITS_PER_SAMPLE")]
        public const int MSAUDIO1_BITS_PER_SAMPLE = 16;

        [NativeTypeName("#define MSAUDIO1_MAX_CHANNELS WMAUDIO_MAX_CHANNELS")]
        public const int MSAUDIO1_MAX_CHANNELS = 2;

        [NativeTypeName("#define WMAUDIO2_BITS_PER_SAMPLE WMAUDIO_BITS_PER_SAMPLE")]
        public const int WMAUDIO2_BITS_PER_SAMPLE = 16;

        [NativeTypeName("#define WMAUDIO2_MAX_CHANNELS WMAUDIO_MAX_CHANNELS")]
        public const int WMAUDIO2_MAX_CHANNELS = 2;

        [NativeTypeName("#define RIFFWAVE_inst mmioFOURCC('i','n','s','t')")]
        public const uint RIFFWAVE_inst = ((uint)((byte)('i')) | ((uint)((byte)('n')) << 8) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('t')) << 24));

        [NativeTypeName("#define RIFFCPPO mmioFOURCC('C','P','P','O')")]
        public const uint RIFFCPPO = ((uint)((byte)('C')) | ((uint)((byte)('P')) << 8) | ((uint)((byte)('P')) << 16) | ((uint)((byte)('O')) << 24));

        [NativeTypeName("#define RIFFCPPO_objr mmioFOURCC('o','b','j','r')")]
        public const uint RIFFCPPO_objr = ((uint)((byte)('o')) | ((uint)((byte)('b')) << 8) | ((uint)((byte)('j')) << 16) | ((uint)((byte)('r')) << 24));

        [NativeTypeName("#define RIFFCPPO_obji mmioFOURCC('o','b','j','i')")]
        public const uint RIFFCPPO_obji = ((uint)((byte)('o')) | ((uint)((byte)('b')) << 8) | ((uint)((byte)('j')) << 16) | ((uint)((byte)('i')) << 24));

        [NativeTypeName("#define RIFFCPPO_clsr mmioFOURCC('c','l','s','r')")]
        public const uint RIFFCPPO_clsr = ((uint)((byte)('c')) | ((uint)((byte)('l')) << 8) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('r')) << 24));

        [NativeTypeName("#define RIFFCPPO_clsi mmioFOURCC('c','l','s','i')")]
        public const uint RIFFCPPO_clsi = ((uint)((byte)('c')) | ((uint)((byte)('l')) << 8) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('i')) << 24));

        [NativeTypeName("#define RIFFCPPO_mbr mmioFOURCC('m','b','r',' ')")]
        public const uint RIFFCPPO_mbr = ((uint)((byte)('m')) | ((uint)((byte)('b')) << 8) | ((uint)((byte)('r')) << 16) | ((uint)((byte)(' ')) << 24));

        [NativeTypeName("#define RIFFCPPO_char mmioFOURCC('c','h','a','r')")]
        public const uint RIFFCPPO_char = ((uint)((byte)('c')) | ((uint)((byte)('h')) << 8) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('r')) << 24));

        [NativeTypeName("#define RIFFCPPO_byte mmioFOURCC('b','y','t','e')")]
        public const uint RIFFCPPO_byte = ((uint)((byte)('b')) | ((uint)((byte)('y')) << 8) | ((uint)((byte)('t')) << 16) | ((uint)((byte)('e')) << 24));

        [NativeTypeName("#define RIFFCPPO_int mmioFOURCC('i','n','t',' ')")]
        public const uint RIFFCPPO_int = ((uint)((byte)('i')) | ((uint)((byte)('n')) << 8) | ((uint)((byte)('t')) << 16) | ((uint)((byte)(' ')) << 24));

        [NativeTypeName("#define RIFFCPPO_word mmioFOURCC('w','o','r','d')")]
        public const uint RIFFCPPO_word = ((uint)((byte)('w')) | ((uint)((byte)('o')) << 8) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('d')) << 24));

        [NativeTypeName("#define RIFFCPPO_long mmioFOURCC('l','o','n','g')")]
        public const uint RIFFCPPO_long = ((uint)((byte)('l')) | ((uint)((byte)('o')) << 8) | ((uint)((byte)('n')) << 16) | ((uint)((byte)('g')) << 24));

        [NativeTypeName("#define RIFFCPPO_dwrd mmioFOURCC('d','w','r','d')")]
        public const uint RIFFCPPO_dwrd = ((uint)((byte)('d')) | ((uint)((byte)('w')) << 8) | ((uint)((byte)('r')) << 16) | ((uint)((byte)('d')) << 24));

        [NativeTypeName("#define RIFFCPPO_flt mmioFOURCC('f','l','t',' ')")]
        public const uint RIFFCPPO_flt = ((uint)((byte)('f')) | ((uint)((byte)('l')) << 8) | ((uint)((byte)('t')) << 16) | ((uint)((byte)(' ')) << 24));

        [NativeTypeName("#define RIFFCPPO_dbl mmioFOURCC('d','b','l',' ')")]
        public const uint RIFFCPPO_dbl = ((uint)((byte)('d')) | ((uint)((byte)('b')) << 8) | ((uint)((byte)('l')) << 16) | ((uint)((byte)(' ')) << 24));

        [NativeTypeName("#define RIFFCPPO_str mmioFOURCC('s','t','r',' ')")]
        public const uint RIFFCPPO_str = ((uint)((byte)('s')) | ((uint)((byte)('t')) << 8) | ((uint)((byte)('r')) << 16) | ((uint)((byte)(' ')) << 24));

        [NativeTypeName("#define BICOMP_IBMULTIMOTION mmioFOURCC('U', 'L', 'T', 'I')")]
        public const uint BICOMP_IBMULTIMOTION = ((uint)((byte)('U')) | ((uint)((byte)('L')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('I')) << 24));

        [NativeTypeName("#define BICOMP_IBMPHOTOMOTION mmioFOURCC('P', 'H', 'M', 'O')")]
        public const uint BICOMP_IBMPHOTOMOTION = ((uint)((byte)('P')) | ((uint)((byte)('H')) << 8) | ((uint)((byte)('M')) << 16) | ((uint)((byte)('O')) << 24));

        [NativeTypeName("#define BICOMP_CREATIVEYUV mmioFOURCC('c', 'y', 'u', 'v')")]
        public const uint BICOMP_CREATIVEYUV = ((uint)((byte)('c')) | ((uint)((byte)('y')) << 8) | ((uint)((byte)('u')) << 16) | ((uint)((byte)('v')) << 24));

        [NativeTypeName("#define JPEG_DIB mmioFOURCC('J','P','E','G')")]
        public const uint JPEG_DIB = ((uint)((byte)('J')) | ((uint)((byte)('P')) << 8) | ((uint)((byte)('E')) << 16) | ((uint)((byte)('G')) << 24));

        [NativeTypeName("#define MJPG_DIB mmioFOURCC('M','J','P','G')")]
        public const uint MJPG_DIB = ((uint)((byte)('M')) | ((uint)((byte)('J')) << 8) | ((uint)((byte)('P')) << 16) | ((uint)((byte)('G')) << 24));

        [NativeTypeName("#define JPEG_PROCESS_BASELINE 0")]
        public const int JPEG_PROCESS_BASELINE = 0;

        [NativeTypeName("#define AVIIF_CONTROLFRAME 0x00000200L")]
        public const int AVIIF_CONTROLFRAME = 0x00000200;

        [NativeTypeName("#define JPEG_Y 1")]
        public const int JPEG_Y = 1;

        [NativeTypeName("#define JPEG_YCbCr 2")]
        public const int JPEG_YCbCr = 2;

        [NativeTypeName("#define JPEG_RGB 3")]
        public const int JPEG_RGB = 3;

        [NativeTypeName("#define ICTYPE_VIDEO mmioFOURCC('v', 'i', 'd', 'c')")]
        public const uint ICTYPE_VIDEO = ((uint)((byte)('v')) | ((uint)((byte)('i')) << 8) | ((uint)((byte)('d')) << 16) | ((uint)((byte)('c')) << 24));

        [NativeTypeName("#define ICTYPE_AUDIO mmioFOURCC('a', 'u', 'd', 'c')")]
        public const uint ICTYPE_AUDIO = ((uint)((byte)('a')) | ((uint)((byte)('u')) << 8) | ((uint)((byte)('d')) << 16) | ((uint)((byte)('c')) << 24));

        [NativeTypeName("#define FOURCC_RDSP mmioFOURCC('R', 'D', 'S', 'P')")]
        public const uint FOURCC_RDSP = ((uint)((byte)('R')) | ((uint)((byte)('D')) << 8) | ((uint)((byte)('S')) << 16) | ((uint)((byte)('P')) << 24));
    }
}
