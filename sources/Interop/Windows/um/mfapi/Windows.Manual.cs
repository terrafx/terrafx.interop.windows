// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int MF_SDK_VERSION = 0x0002;

        public const int MF_API_VERSION = 0x0070;

        public const int MF_VERSION = (MF_SDK_VERSION << 16 | MF_API_VERSION);

        public const int MFSTARTUP_NOSOCKET = 0x1;

        public const int MFSTARTUP_LITE = (MFSTARTUP_NOSOCKET);

        public const int MFSTARTUP_FULL = 0;

        public const int MF_E_DXGI_DEVICE_NOT_INITIALIZED = unchecked((int)0x80041000);

        public const int MF_E_DXGI_NEW_VIDEO_DEVICE = unchecked((int)0x80041001);

        public const int MF_E_DXGI_VIDEO_DEVICE_LOCKED = unchecked((int)0x80041002);

        public const int MF_1_BYTE_ALIGNMENT = 0x00000000;

        public const int MF_2_BYTE_ALIGNMENT = 0x00000001;

        public const int MF_4_BYTE_ALIGNMENT = 0x00000003;

        public const int MF_8_BYTE_ALIGNMENT = 0x00000007;

        public const int MF_16_BYTE_ALIGNMENT = 0x0000000F;

        public const int MF_32_BYTE_ALIGNMENT = 0x0000001F;

        public const int MF_64_BYTE_ALIGNMENT = 0x0000003F;

        public const int MF_128_BYTE_ALIGNMENT = 0x0000007F;

        public const int MF_256_BYTE_ALIGNMENT = 0x000000FF;

        public const int MF_512_BYTE_ALIGNMENT = 0x000001FF;

        public const int MF_1024_BYTE_ALIGNMENT = 0x000003FF;

        public const int MF_2048_BYTE_ALIGNMENT = 0x000007FF;

        public const int MF_4096_BYTE_ALIGNMENT = 0x00000FFF;

        public const int MF_8192_BYTE_ALIGNMENT = 0x00001FFF;

        public const int MFSESSIONCAP_START = 0x00000001;

        public const int MFSESSIONCAP_SEEK = 0x00000002;

        public const int MFSESSIONCAP_PAUSE = 0x00000004;

        public const int MFSESSIONCAP_RATE_FORWARD = 0x00000010;

        public const int MFSESSIONCAP_RATE_REVERSE = 0x00000020;

        public const int MFSESSIONCAP_DOES_NOT_USE_NETWORK = 0x00000040;

        public const int MFSampleExtension_ClosedCaption_CEA708_MAX_SIZE = 256;

        public const int MACROBLOCK_FLAG_SKIP = 0x00000001;

        public const int MACROBLOCK_FLAG_DIRTY = 0x00000002;

        public const int MACROBLOCK_FLAG_MOTION = 0x00000004;

        public const int MACROBLOCK_FLAG_VIDEO = 0x00000008;

        public const int MACROBLOCK_FLAG_HAS_MOTION_VECTOR = 0x00000010;

        public const int MACROBLOCK_FLAG_HAS_QP = 0x00000020;

        public const int MFCAPTURE_METADATA_SCAN_RIGHT_LEFT = 0x00000001;

        public const int MFCAPTURE_METADATA_SCAN_BOTTOM_TOP = 0x00000002;

        public const int MFCAPTURE_METADATA_SCANLINE_VERTICAL = 0x00000004;

        public const int MF_METADATAFACIALEXPRESSION_SMILE = 0x00000001;

        public const int MF_METADATATIMESTAMPS_DEVICE = 0x00000001;

        public const int MF_METADATATIMESTAMPS_PRESENTATION = 0x00000002;

        public const int MF_HISTOGRAM_CHANNEL_Y = 0x00000001;

        public const int MF_HISTOGRAM_CHANNEL_R = 0x00000002;

        public const int MF_HISTOGRAM_CHANNEL_G = 0x00000004;

        public const int MF_HISTOGRAM_CHANNEL_B = 0x00000008;

        public const int MF_HISTOGRAM_CHANNEL_Cb = 0x00000010;

        public const int MF_HISTOGRAM_CHANNEL_Cr = 0x00000020;

        public static uint FCC(uint ch4) => ((((uint)(ch4) & 0xFF) << 24) | (((uint)(ch4) & 0xFF00) << 8) | (((uint)(ch4) & 0xFF0000) >> 8) | (((uint)(ch4) & 0xFF000000) >> 24));

        public const int D3DFMT_R8G8B8 = 20;

        public const int D3DFMT_A8R8G8B8 = 21;

        public const int D3DFMT_X8R8G8B8 = 22;

        public const int D3DFMT_R5G6B5 = 23;

        public const int D3DFMT_X1R5G5B5 = 24;

        public const int D3DFMT_A2B10G10R10 = 31;

        public const int D3DFMT_P8 = 41;

        public const int D3DFMT_L8 = 50;

        public const int D3DFMT_D16 = 80;

        public const int D3DFMT_L16 = 81;

        public const int D3DFMT_A16B16G16R16F = 113;

        public const int LOCAL_D3DFMT_DEFINES = 1;
    }
}
