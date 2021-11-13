// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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

        [NativeTypeName("#define JIFMK_SOF0 0xFFC0")]
        public const int JIFMK_SOF0 = 0xFFC0;

        [NativeTypeName("#define JIFMK_SOF1 0xFFC1")]
        public const int JIFMK_SOF1 = 0xFFC1;

        [NativeTypeName("#define JIFMK_SOF2 0xFFC2")]
        public const int JIFMK_SOF2 = 0xFFC2;

        [NativeTypeName("#define JIFMK_SOF3 0xFFC3")]
        public const int JIFMK_SOF3 = 0xFFC3;

        [NativeTypeName("#define JIFMK_SOF5 0xFFC5")]
        public const int JIFMK_SOF5 = 0xFFC5;

        [NativeTypeName("#define JIFMK_SOF6 0xFFC6")]
        public const int JIFMK_SOF6 = 0xFFC6;

        [NativeTypeName("#define JIFMK_SOF7 0xFFC7")]
        public const int JIFMK_SOF7 = 0xFFC7;

        [NativeTypeName("#define JIFMK_JPG 0xFFC8")]
        public const int JIFMK_JPG = 0xFFC8;

        [NativeTypeName("#define JIFMK_SOF9 0xFFC9")]
        public const int JIFMK_SOF9 = 0xFFC9;

        [NativeTypeName("#define JIFMK_SOF10 0xFFCA")]
        public const int JIFMK_SOF10 = 0xFFCA;

        [NativeTypeName("#define JIFMK_SOF11 0xFFCB")]
        public const int JIFMK_SOF11 = 0xFFCB;

        [NativeTypeName("#define JIFMK_SOF13 0xFFCD")]
        public const int JIFMK_SOF13 = 0xFFCD;

        [NativeTypeName("#define JIFMK_SOF14 0xFFCE")]
        public const int JIFMK_SOF14 = 0xFFCE;

        [NativeTypeName("#define JIFMK_SOF15 0xFFCF")]
        public const int JIFMK_SOF15 = 0xFFCF;

        [NativeTypeName("#define JIFMK_DHT 0xFFC4")]
        public const int JIFMK_DHT = 0xFFC4;

        [NativeTypeName("#define JIFMK_DAC 0xFFCC")]
        public const int JIFMK_DAC = 0xFFCC;

        [NativeTypeName("#define JIFMK_RST0 0xFFD0")]
        public const int JIFMK_RST0 = 0xFFD0;

        [NativeTypeName("#define JIFMK_RST1 0xFFD1")]
        public const int JIFMK_RST1 = 0xFFD1;

        [NativeTypeName("#define JIFMK_RST2 0xFFD2")]
        public const int JIFMK_RST2 = 0xFFD2;

        [NativeTypeName("#define JIFMK_RST3 0xFFD3")]
        public const int JIFMK_RST3 = 0xFFD3;

        [NativeTypeName("#define JIFMK_RST4 0xFFD4")]
        public const int JIFMK_RST4 = 0xFFD4;

        [NativeTypeName("#define JIFMK_RST5 0xFFD5")]
        public const int JIFMK_RST5 = 0xFFD5;

        [NativeTypeName("#define JIFMK_RST6 0xFFD6")]
        public const int JIFMK_RST6 = 0xFFD6;

        [NativeTypeName("#define JIFMK_RST7 0xFFD7")]
        public const int JIFMK_RST7 = 0xFFD7;

        [NativeTypeName("#define JIFMK_SOI 0xFFD8")]
        public const int JIFMK_SOI = 0xFFD8;

        [NativeTypeName("#define JIFMK_EOI 0xFFD9")]
        public const int JIFMK_EOI = 0xFFD9;

        [NativeTypeName("#define JIFMK_SOS 0xFFDA")]
        public const int JIFMK_SOS = 0xFFDA;

        [NativeTypeName("#define JIFMK_DQT 0xFFDB")]
        public const int JIFMK_DQT = 0xFFDB;

        [NativeTypeName("#define JIFMK_DNL 0xFFDC")]
        public const int JIFMK_DNL = 0xFFDC;

        [NativeTypeName("#define JIFMK_DRI 0xFFDD")]
        public const int JIFMK_DRI = 0xFFDD;

        [NativeTypeName("#define JIFMK_DHP 0xFFDE")]
        public const int JIFMK_DHP = 0xFFDE;

        [NativeTypeName("#define JIFMK_EXP 0xFFDF")]
        public const int JIFMK_EXP = 0xFFDF;

        [NativeTypeName("#define JIFMK_APP0 0xFFE0")]
        public const int JIFMK_APP0 = 0xFFE0;

        [NativeTypeName("#define JIFMK_APP1 0xFFE1")]
        public const int JIFMK_APP1 = 0xFFE1;

        [NativeTypeName("#define JIFMK_APP2 0xFFE2")]
        public const int JIFMK_APP2 = 0xFFE2;

        [NativeTypeName("#define JIFMK_APP3 0xFFE3")]
        public const int JIFMK_APP3 = 0xFFE3;

        [NativeTypeName("#define JIFMK_APP4 0xFFE4")]
        public const int JIFMK_APP4 = 0xFFE4;

        [NativeTypeName("#define JIFMK_APP5 0xFFE5")]
        public const int JIFMK_APP5 = 0xFFE5;

        [NativeTypeName("#define JIFMK_APP6 0xFFE6")]
        public const int JIFMK_APP6 = 0xFFE6;

        [NativeTypeName("#define JIFMK_APP7 0xFFE7")]
        public const int JIFMK_APP7 = 0xFFE7;

        [NativeTypeName("#define JIFMK_JPG0 0xFFF0")]
        public const int JIFMK_JPG0 = 0xFFF0;

        [NativeTypeName("#define JIFMK_JPG1 0xFFF1")]
        public const int JIFMK_JPG1 = 0xFFF1;

        [NativeTypeName("#define JIFMK_JPG2 0xFFF2")]
        public const int JIFMK_JPG2 = 0xFFF2;

        [NativeTypeName("#define JIFMK_JPG3 0xFFF3")]
        public const int JIFMK_JPG3 = 0xFFF3;

        [NativeTypeName("#define JIFMK_JPG4 0xFFF4")]
        public const int JIFMK_JPG4 = 0xFFF4;

        [NativeTypeName("#define JIFMK_JPG5 0xFFF5")]
        public const int JIFMK_JPG5 = 0xFFF5;

        [NativeTypeName("#define JIFMK_JPG6 0xFFF6")]
        public const int JIFMK_JPG6 = 0xFFF6;

        [NativeTypeName("#define JIFMK_JPG7 0xFFF7")]
        public const int JIFMK_JPG7 = 0xFFF7;

        [NativeTypeName("#define JIFMK_JPG8 0xFFF8")]
        public const int JIFMK_JPG8 = 0xFFF8;

        [NativeTypeName("#define JIFMK_JPG9 0xFFF9")]
        public const int JIFMK_JPG9 = 0xFFF9;

        [NativeTypeName("#define JIFMK_JPG10 0xFFFA")]
        public const int JIFMK_JPG10 = 0xFFFA;

        [NativeTypeName("#define JIFMK_JPG11 0xFFFB")]
        public const int JIFMK_JPG11 = 0xFFFB;

        [NativeTypeName("#define JIFMK_JPG12 0xFFFC")]
        public const int JIFMK_JPG12 = 0xFFFC;

        [NativeTypeName("#define JIFMK_JPG13 0xFFFD")]
        public const int JIFMK_JPG13 = 0xFFFD;

        [NativeTypeName("#define JIFMK_COM 0xFFFE")]
        public const int JIFMK_COM = 0xFFFE;

        [NativeTypeName("#define JIFMK_TEM 0xFF01")]
        public const int JIFMK_TEM = 0xFF01;

        [NativeTypeName("#define JIFMK_RES 0xFF02")]
        public const int JIFMK_RES = 0xFF02;

        [NativeTypeName("#define JIFMK_00 0xFF00")]
        public const int JIFMK_00 = 0xFF00;

        [NativeTypeName("#define JIFMK_FF 0xFFFF")]
        public const int JIFMK_FF = 0xFFFF;

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

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_SRS_MTS (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 6)")]
        public const int MIXERCONTROL_CONTROLTYPE_SRS_MTS = ((0x20000000 | 0x00000000 | 0x00010000) + 6);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_SRS_ONOFF (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 7)")]
        public const int MIXERCONTROL_CONTROLTYPE_SRS_ONOFF = ((0x20000000 | 0x00000000 | 0x00010000) + 7);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_SRS_SYNTHSELECT (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 8)")]
        public const int MIXERCONTROL_CONTROLTYPE_SRS_SYNTHSELECT = ((0x20000000 | 0x00000000 | 0x00010000) + 8);

        public static ref readonly Guid IID_KSDATAFORMAT_SUBTYPE_PCM
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_KSDATAFORMAT_SUBTYPE_IEEE_FLOAT
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_KSDATAFORMAT_SUBTYPE_WAVEFORMATEX
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
