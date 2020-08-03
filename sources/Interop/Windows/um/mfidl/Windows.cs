// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const IID")]
        public static readonly Guid MF_WVC1_PROG_SINGLE_SLICE_CONTENT = new Guid(0x67EC2559, 0x0F2F, 0x4420, 0xA4, 0xDD, 0x2F, 0x8E, 0xE7, 0xA5, 0x73, 0x8B);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PROGRESSIVE_CODING_CONTENT = new Guid(0x8F020EEA, 0x1508, 0x471F, 0x9D, 0xA6, 0x50, 0x7D, 0x7C, 0xFA, 0x40, 0xDB);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_NALU_LENGTH_SET = new Guid(0xA7911D53, 0x12A4, 0x4965, 0xAE, 0x70, 0x6E, 0xAD, 0xD6, 0xFF, 0x05, 0x51);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_NALU_LENGTH_INFORMATION = new Guid(0x19124E7C, 0xAD4B, 0x465F, 0xBB, 0x18, 0x20, 0x18, 0x62, 0x87, 0xB6, 0xAF);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_USER_DATA_PAYLOAD = new Guid(0xd1d4985d, 0xdc92, 0x457a, 0xb3, 0xa0, 0x65, 0x1a, 0x33, 0xa3, 0x10, 0x47);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MPEG4SINK_SPSPPS_PASSTHROUGH = new Guid(0x5601a134, 0x2005, 0x4ad2, 0xb3, 0x7d, 0x22, 0xa6, 0xc5, 0x54, 0xde, 0xb2);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MPEG4SINK_MOOV_BEFORE_MDAT = new Guid(0xf672e3ac, 0xe1e6, 0x4f10, 0xb5, 0xec, 0x5f, 0x3b, 0x30, 0x82, 0x88, 0x16);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MPEG4SINK_MINIMUM_PROPERTIES_SIZE = new Guid(0xdca1ed52, 0x450e, 0x4a22, 0x8c, 0x62, 0x4e, 0xd4, 0x52, 0xf7, 0xa1, 0x87);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MPEG4SINK_MIN_FRAGMENT_DURATION = new Guid(0xa30b570c, 0x8efd, 0x45e8, 0x94, 0xfe, 0x27, 0xc8, 0x4b, 0x5b, 0xdf, 0xf6);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MPEG4SINK_MAX_CODED_SEQUENCES_PER_FRAGMENT = new Guid(0xfc1b3bd6, 0x692d, 0x4ce5, 0x92, 0x99, 0x73, 0x8a, 0xa5, 0x46, 0x3e, 0x9a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SESSION_TOPOLOADER = new Guid(0x1e83d482, 0x1f1c, 0x4571, 0x84, 0x5, 0x88, 0xf4, 0xb2, 0x18, 0x1f, 0x71);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SESSION_GLOBAL_TIME = new Guid(0x1e83d482, 0x1f1c, 0x4571, 0x84, 0x5, 0x88, 0xf4, 0xb2, 0x18, 0x1f, 0x72);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SESSION_QUALITY_MANAGER = new Guid(0x1e83d482, 0x1f1c, 0x4571, 0x84, 0x5, 0x88, 0xf4, 0xb2, 0x18, 0x1f, 0x73);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SESSION_CONTENT_PROTECTION_MANAGER = new Guid(0x1e83d482, 0x1f1c, 0x4571, 0x84, 0x5, 0x88, 0xf4, 0xb2, 0x18, 0x1f, 0x74);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SESSION_SERVER_CONTEXT = new Guid(0xafe5b291, 0x50fa, 0x46e8, 0xb9, 0xbe, 0xc, 0xc, 0x3c, 0xe4, 0xb3, 0xa5);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SESSION_REMOTE_SOURCE_MODE = new Guid(0xf4033ef4, 0x9bb3, 0x4378, 0x94, 0x1f, 0x85, 0xa0, 0x85, 0x6b, 0xc2, 0x44);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SESSION_APPROX_EVENT_OCCURRENCE_TIME = new Guid(0x190e852f, 0x6238, 0x42d1, 0xb5, 0xaf, 0x69, 0xea, 0x33, 0x8e, 0xf8, 0x50);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PMP_SERVER_CONTEXT = new Guid(0x2f00c910, 0xd2cf, 0x4278, 0x8b, 0x6a, 0xd0, 0x77, 0xfa, 0xc3, 0xa2, 0x5f);

        [DllImport("mf", EntryPoint = "MFCreateMediaSession", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaSession([NativeTypeName("IMFAttributes *")] IMFAttributes* pConfiguration, [NativeTypeName("IMFMediaSession **")] IMFMediaSession** ppMediaSession);

        [DllImport("mf", EntryPoint = "MFCreatePMPMediaSession", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePMPMediaSession([NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("IMFAttributes *")] IMFAttributes* pConfiguration, [NativeTypeName("IMFMediaSession **")] IMFMediaSession** ppMediaSession, [NativeTypeName("IMFActivate **")] IMFActivate** ppEnablerActivate);

        [DllImport("mfplat", EntryPoint = "MFCreateSourceResolver", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSourceResolver([NativeTypeName("IMFSourceResolver **")] IMFSourceResolver** ppISourceResolver);

        [DllImport("mfplat", EntryPoint = "CreatePropertyStore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreatePropertyStore([NativeTypeName("IPropertyStore **")] IPropertyStore** ppStore);

        [DllImport("mf", EntryPoint = "MFGetSupportedSchemes", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetSupportedSchemes([NativeTypeName("PROPVARIANT *")] PROPVARIANT* pPropVarSchemeArray);

        [DllImport("mf", EntryPoint = "MFGetSupportedMimeTypes", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetSupportedMimeTypes([NativeTypeName("PROPVARIANT *")] PROPVARIANT* pPropVarMimeTypeArray);

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_SourceOpenMonitor = new PROPERTYKEY
        {
            fmtid = new Guid(0x074d4637, 0xb5ae, 0x465d, 0xaf, 0x17, 0x1a, 0x53, 0x8d, 0x28, 0x59, 0xdd),
            pid = 0x02,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_ASFMediaSource_ApproxSeek = new PROPERTYKEY
        {
            fmtid = new Guid(0xb4cd270f, 0x244d, 0x4969, 0xbb, 0x92, 0x3f, 0x0f, 0xb8, 0x31, 0x6f, 0x10),
            pid = 0x01,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_ASFMediaSource_IterativeSeekIfNoIndex = new PROPERTYKEY
        {
            fmtid = new Guid(0x170b65dc, 0x4a4e, 0x407a, 0xac, 0x22, 0x57, 0x7f, 0x50, 0xe4, 0xa3, 0x7c),
            pid = 0x01,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_ASFMediaSource_IterativeSeek_Max_Count = new PROPERTYKEY
        {
            fmtid = new Guid(0x170b65dc, 0x4a4e, 0x407a, 0xac, 0x22, 0x57, 0x7f, 0x50, 0xe4, 0xa3, 0x7c),
            pid = 0x02,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecond = new PROPERTYKEY
        {
            fmtid = new Guid(0x170b65dc, 0x4a4e, 0x407a, 0xac, 0x22, 0x57, 0x7f, 0x50, 0xe4, 0xa3, 0x7c),
            pid = 0x03,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_Content_DLNA_Profile_ID = new PROPERTYKEY
        {
            fmtid = new Guid(0xcfa31b45, 0x525d, 0x4998, 0xbb, 0x44, 0x3f, 0x7d, 0x81, 0x54, 0x2f, 0xa4),
            pid = 0x01,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_MediaSource_DisableReadAhead = new PROPERTYKEY
        {
            fmtid = new Guid(0x26366c14, 0xc5bf, 0x4c76, 0x88, 0x7b, 0x9f, 0x17, 0x54, 0xdb, 0x5f, 0x9),
            pid = 0x01,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_SBESourceMode = new PROPERTYKEY
        {
            fmtid = new Guid(0x3fae10bb, 0xf859, 0x4192, 0xb5, 0x62, 0x18, 0x68, 0xd3, 0xda, 0x3a, 0x02),
            pid = 0x01,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_PMP_Creation_Callback = new PROPERTYKEY
        {
            fmtid = new Guid(0x28bb4de2, 0x26a2, 0x4870, 0xb7, 0x20, 0xd2, 0x6b, 0xbe, 0xb1, 0x49, 0x42),
            pid = 0x01,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Enable_Urlmon = new PROPERTYKEY
        {
            fmtid = new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92),
            pid = 0x01,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Urlmon_Bind_Flags = new PROPERTYKEY
        {
            fmtid = new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92),
            pid = 0x02,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Urlmon_Security_Id = new PROPERTYKEY
        {
            fmtid = new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92),
            pid = 0x03,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Urlmon_Window = new PROPERTYKEY
        {
            fmtid = new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92),
            pid = 0x04,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Urlmon_Callback_QueryService = new PROPERTYKEY
        {
            fmtid = new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92),
            pid = 0x05,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_MediaProtectionSystemId = new PROPERTYKEY
        {
            fmtid = new Guid(0x636b271d, 0xddc7, 0x49e9, 0xa6, 0xc6, 0x47, 0x38, 0x59, 0x62, 0xe5, 0xbd),
            pid = 0x01,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_MediaProtectionSystemContext = new PROPERTYKEY
        {
            fmtid = new Guid(0x636b271d, 0xddc7, 0x49e9, 0xa6, 0xc6, 0x47, 0x38, 0x59, 0x62, 0xe5, 0xbd),
            pid = 0x02,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_MediaProtectionSystemIdMapping = new PROPERTYKEY
        {
            fmtid = new Guid(0x636b271d, 0xddc7, 0x49e9, 0xa6, 0xc6, 0x47, 0x38, 0x59, 0x62, 0xe5, 0xbd),
            pid = 0x03,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_MediaProtectionContainerGuid = new PROPERTYKEY
        {
            fmtid = new Guid(0x42af3d7c, 0xcf, 0x4a0f, 0x81, 0xf0, 0xad, 0xf5, 0x24, 0xa5, 0xa5, 0xb5),
            pid = 0x1,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_MediaProtectionSystemContextsPerTrack = new PROPERTYKEY
        {
            fmtid = new Guid(0x4454b092, 0xd3da, 0x49b0, 0x84, 0x52, 0x68, 0x50, 0xc7, 0xdb, 0x76, 0x4d),
            pid = 0x03,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Download_Mode = new PROPERTYKEY
        {
            fmtid = new Guid(0x817f11b7, 0xa982, 0x46ec, 0xa4, 0x49, 0xef, 0x58, 0xae, 0xd5, 0x3c, 0xa8),
            pid = 0x01,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Caching_Mode = new PROPERTYKEY
        {
            fmtid = new Guid(0x86a2403e, 0xc78b, 0x44d7, 0x8b, 0xc8, 0xff, 0x72, 0x58, 0x11, 0x75, 0x08),
            pid = 0x01,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Cache_Limit = new PROPERTYKEY
        {
            fmtid = new Guid(0x86a2403e, 0xc78b, 0x44d7, 0x8b, 0xc8, 0xff, 0x72, 0x58, 0x11, 0x75, 0x08),
            pid = 0x02,
        };

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TIME_FORMAT_ENTRY_RELATIVE = new Guid(0x4399f178, 0x46d3, 0x4504, 0xaf, 0xda, 0x20, 0xd3, 0x2e, 0x9b, 0xa3, 0x60);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SOURCE_STREAM_SUPPORTS_HW_CONNECTION = new Guid(0xa38253aa, 0x6314, 0x42fd, 0xa3, 0xce, 0xbb, 0x27, 0xb6, 0x85, 0x99, 0x46);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_STREAM_SINK_SUPPORTS_HW_CONNECTION = new Guid(0x9b465cbf, 0x597, 0x4f9e, 0x9f, 0x3c, 0xb9, 0x7e, 0xee, 0xf9, 0x3, 0x59);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_STREAM_SINK_SUPPORTS_ROTATION = new Guid(0xb3e96280, 0xbd05, 0x41a5, 0x97, 0xad, 0x8a, 0x7f, 0xee, 0x24, 0xb9, 0x12);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SINK_VIDEO_PTS = new Guid(0x2162bde7, 0x421e, 0x4b90, 0x9b, 0x33, 0xe5, 0x8f, 0xbf, 0x1d, 0x58, 0xb6);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SINK_VIDEO_NATIVE_WIDTH = new Guid(0xe6d6a707, 0x1505, 0x4747, 0x9b, 0x10, 0x72, 0xd2, 0xd1, 0x58, 0xcb, 0x3a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SINK_VIDEO_NATIVE_HEIGHT = new Guid(0xf0ca6705, 0x490c, 0x43e8, 0x94, 0x1c, 0xc0, 0xb3, 0x20, 0x6b, 0x9a, 0x65);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SINK_VIDEO_DISPLAY_ASPECT_RATIO_NUMERATOR = new Guid(0xd0f33b22, 0xb78a, 0x4879, 0xb4, 0x55, 0xf0, 0x3e, 0xf3, 0xfa, 0x82, 0xcd);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SINK_VIDEO_DISPLAY_ASPECT_RATIO_DENOMINATOR = new Guid(0x6ea1eb97, 0x1fe0, 0x4f10, 0xa6, 0xe4, 0x1f, 0x4f, 0x66, 0x15, 0x64, 0xe0);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_BD_MVC_PLANE_OFFSET_METADATA = new Guid(0x62a654e4, 0xb76c, 0x4901, 0x98, 0x23, 0x2c, 0xb6, 0x15, 0xd4, 0x73, 0x18);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_LUMA_KEY_ENABLE = new Guid(0x7369820f, 0x76de, 0x43ca, 0x92, 0x84, 0x47, 0xb8, 0xf3, 0x7e, 0x06, 0x49);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_LUMA_KEY_LOWER = new Guid(0x93d7b8d5, 0x0b81, 0x4715, 0xae, 0xa0, 0x87, 0x25, 0x87, 0x16, 0x21, 0xe9);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_LUMA_KEY_UPPER = new Guid(0xd09f39bb, 0x4602, 0x4c31, 0xa7, 0x06, 0xa1, 0x21, 0x71, 0xa5, 0x11, 0x0a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_USER_EXTENDED_ATTRIBUTES = new Guid(0xc02abac6, 0xfeb2, 0x4541, 0x92, 0x2f, 0x92, 0x0b, 0x43, 0x70, 0x27, 0x22);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_INDEPENDENT_STILL_IMAGE = new Guid(0xea12af41, 0x0710, 0x42c9, 0xa1, 0x27, 0xda, 0xa3, 0xe7, 0x84, 0x83, 0xa5);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_XVP_SAMPLE_LOCK_TIMEOUT = new Guid(0xaa4ddb29, 0x5134, 0x4363, 0xac, 0x72, 0x83, 0xec, 0x4b, 0xc1, 0x4, 0x26);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPOLOGY_PROJECTSTART = new Guid(0x7ed3f802, 0x86bb, 0x4b3f, 0xb7, 0xe4, 0x7c, 0xb4, 0x3a, 0xfd, 0x4b, 0x80);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPOLOGY_PROJECTSTOP = new Guid(0x7ed3f803, 0x86bb, 0x4b3f, 0xb7, 0xe4, 0x7c, 0xb4, 0x3a, 0xfd, 0x4b, 0x80);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPOLOGY_NO_MARKIN_MARKOUT = new Guid(0x7ed3f804, 0x86bb, 0x4b3f, 0xb7, 0xe4, 0x7c, 0xb4, 0x3a, 0xfd, 0x4b, 0x80);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPOLOGY_DXVA_MODE = new Guid(0x1e8d34f6, 0xf5ab, 0x4e23, 0xbb, 0x88, 0x87, 0x4a, 0xa3, 0xa1, 0xa7, 0x4d);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPOLOGY_ENABLE_XVP_FOR_PLAYBACK = new Guid(0x1967731f, 0xcd78, 0x42fc, 0xb0, 0x26, 0x9, 0x92, 0xa5, 0x6e, 0x56, 0x93);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPOLOGY_STATIC_PLAYBACK_OPTIMIZATIONS = new Guid(0xb86cac42, 0x41a6, 0x4b79, 0x89, 0x7a, 0x1a, 0xb0, 0xe5, 0x2b, 0x4a, 0x1b);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPOLOGY_PLAYBACK_MAX_DIMS = new Guid(0x5715cf19, 0x5768, 0x44aa, 0xad, 0x6e, 0x87, 0x21, 0xf1, 0xb0, 0xf9, 0xbb);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPOLOGY_HARDWARE_MODE = new Guid(0xd2d362fd, 0x4e4f, 0x4191, 0xa5, 0x79, 0xc6, 0x18, 0xb6, 0x67, 0x6, 0xaf);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPOLOGY_PLAYBACK_FRAMERATE = new Guid(0xc164737a, 0xc2b1, 0x4553, 0x83, 0xbb, 0x5a, 0x52, 0x60, 0x72, 0x44, 0x8f);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPOLOGY_DYNAMIC_CHANGE_NOT_ALLOWED = new Guid(0xd529950b, 0xd484, 0x4527, 0xa9, 0xcd, 0xb1, 0x90, 0x95, 0x32, 0xb5, 0xb0);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPOLOGY_ENUMERATE_SOURCE_TYPES = new Guid(0x6248c36d, 0x5d0b, 0x4f40, 0xa0, 0xbb, 0xb0, 0xb3, 0x05, 0xf7, 0x76, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPOLOGY_START_TIME_ON_PRESENTATION_SWITCH = new Guid(0xc8cc113f, 0x7951, 0x4548, 0xaa, 0xd6, 0x9e, 0xd6, 0x20, 0x2e, 0x62, 0xb3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DISABLE_LOCALLY_REGISTERED_PLUGINS = new Guid(0x66b16da9, 0xadd4, 0x47e0, 0xa1, 0x6b, 0x5a, 0xf1, 0xfb, 0x48, 0x36, 0x34);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_LOCAL_PLUGIN_CONTROL_POLICY = new Guid(0xd91b0085, 0xc86d, 0x4f81, 0x88, 0x22, 0x8c, 0x68, 0xe1, 0xd7, 0xfa, 0x04);

        [DllImport("mf", EntryPoint = "MFCreateTopology", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTopology([NativeTypeName("IMFTopology **")] IMFTopology** ppTopo);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_FLUSH = new Guid(0x494bbce8, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_DRAIN = new Guid(0x494bbce9, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_D3DAWARE = new Guid(0x494bbced, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPOLOGY_RESOLUTION_STATUS = new Guid(0x494bbcde, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_ERRORCODE = new Guid(0x494bbcee, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_CONNECT_METHOD = new Guid(0x494bbcf1, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_LOCKED = new Guid(0x494bbcf7, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_WORKQUEUE_ID = new Guid(0x494bbcf8, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_WORKQUEUE_MMCSS_CLASS = new Guid(0x494bbcf9, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_DECRYPTOR = new Guid(0x494bbcfa, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_DISCARDABLE = new Guid(0x494bbcfb, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_ERROR_MAJORTYPE = new Guid(0x494bbcfd, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_ERROR_SUBTYPE = new Guid(0x494bbcfe, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_WORKQUEUE_MMCSS_TASKID = new Guid(0x494bbcff, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_WORKQUEUE_MMCSS_PRIORITY = new Guid(0x5001f840, 0x2816, 0x48f4, 0x93, 0x64, 0xad, 0x1e, 0xf6, 0x61, 0xa1, 0x23);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_WORKQUEUE_ITEM_PRIORITY = new Guid(0xa1ff99be, 0x5e97, 0x4a53, 0xb4, 0x94, 0x56, 0x8c, 0x64, 0x2c, 0x0f, 0xf3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_MARKIN_HERE = new Guid(0x494bbd00, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_MARKOUT_HERE = new Guid(0x494bbd01, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_DECODER = new Guid(0x494bbd02, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_MEDIASTART = new Guid(0x835c58ea, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_MEDIASTOP = new Guid(0x835c58eb, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_SOURCE = new Guid(0x835c58ec, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_PRESENTATION_DESCRIPTOR = new Guid(0x835c58ed, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_STREAM_DESCRIPTOR = new Guid(0x835c58ee, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_SEQUENCE_ELEMENTID = new Guid(0x835c58ef, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_TRANSFORM_OBJECTID = new Guid(0x88dcc0c9, 0x293e, 0x4e8b, 0x9a, 0xeb, 0xa, 0xd6, 0x4c, 0xc0, 0x16, 0xb0);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_STREAMID = new Guid(0x14932f9b, 0x9087, 0x4bb4, 0x84, 0x12, 0x51, 0x67, 0x14, 0x5c, 0xbe, 0x04);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_NOSHUTDOWN_ON_REMOVE = new Guid(0x14932f9c, 0x9087, 0x4bb4, 0x84, 0x12, 0x51, 0x67, 0x14, 0x5c, 0xbe, 0x04);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_RATELESS = new Guid(0x14932f9d, 0x9087, 0x4bb4, 0x84, 0x12, 0x51, 0x67, 0x14, 0x5c, 0xbe, 0x04);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_DISABLE_PREROLL = new Guid(0x14932f9e, 0x9087, 0x4bb4, 0x84, 0x12, 0x51, 0x67, 0x14, 0x5c, 0xbe, 0x04);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_PRIMARYOUTPUT = new Guid(0x6304ef99, 0x16b2, 0x4ebe, 0x9d, 0x67, 0xe4, 0xc5, 0x39, 0xb3, 0xa2, 0x59);

        [DllImport("mf", EntryPoint = "MFCreateTopologyNode", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTopologyNode(MF_TOPOLOGY_TYPE NodeType, [NativeTypeName("IMFTopologyNode **")] IMFTopologyNode** ppNode);

        [DllImport("mf", EntryPoint = "MFGetTopoNodeCurrentType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetTopoNodeCurrentType([NativeTypeName("IMFTopologyNode *")] IMFTopologyNode* pNode, [NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL")] int fOutput, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppType);

        [DllImport("mf", EntryPoint = "MFGetService", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetService([NativeTypeName("IUnknown *")] IUnknown* punkObject, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);

        [DllImport("mfplat", EntryPoint = "MFGetSystemTime", ExactSpelling = true)]
        [return: NativeTypeName("MFTIME")]
        public static extern long MFGetSystemTime();

        [DllImport("mf", EntryPoint = "MFCreatePresentationClock", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePresentationClock([NativeTypeName("IMFPresentationClock **")] IMFPresentationClock** ppPresentationClock);

        [DllImport("mfplat", EntryPoint = "MFCreateSystemTimeSource", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSystemTimeSource([NativeTypeName("IMFPresentationTimeSource **")] IMFPresentationTimeSource** ppSystemTimeSource);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PD_PMPHOST_CONTEXT = new Guid(0x6c990d31, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PD_APP_CONTEXT = new Guid(0x6c990d32, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PD_DURATION = new Guid(0x6c990d33, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PD_TOTAL_FILE_SIZE = new Guid(0x6c990d34, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PD_AUDIO_ENCODING_BITRATE = new Guid(0x6c990d35, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PD_VIDEO_ENCODING_BITRATE = new Guid(0x6c990d36, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PD_MIME_TYPE = new Guid(0x6c990d37, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PD_LAST_MODIFIED_TIME = new Guid(0x6c990d38, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PD_PLAYBACK_ELEMENT_ID = new Guid(0x6c990d39, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PD_PREFERRED_LANGUAGE = new Guid(0x6c990d3A, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PD_PLAYBACK_BOUNDARY_TIME = new Guid(0x6c990d3b, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PD_AUDIO_ISVARIABLEBITRATE = new Guid(0x33026ee0, 0xe387, 0x4582, 0xae, 0x0a, 0x34, 0xa2, 0xad, 0x3b, 0xaa, 0x18);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_PD_ADAPTIVE_STREAMING = new Guid(0xEA0D5D97, 0x29F9, 0x488B, 0xAE, 0x6B, 0x7D, 0x6B, 0x41, 0x36, 0x11, 0x2B);

        [DllImport("mfplat", EntryPoint = "MFCreatePresentationDescriptor", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePresentationDescriptor([NativeTypeName("DWORD")] uint cStreamDescriptors, [NativeTypeName("IMFStreamDescriptor **")] IMFStreamDescriptor** apStreamDescriptors, [NativeTypeName("IMFPresentationDescriptor **")] IMFPresentationDescriptor** ppPresentationDescriptor);

        [DllImport("mf", EntryPoint = "MFRequireProtectedEnvironment", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRequireProtectedEnvironment([NativeTypeName("IMFPresentationDescriptor *")] IMFPresentationDescriptor* pPresentationDescriptor);

        [DllImport("mfplat", EntryPoint = "MFSerializePresentationDescriptor", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFSerializePresentationDescriptor([NativeTypeName("IMFPresentationDescriptor *")] IMFPresentationDescriptor* pPD, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BYTE **")] byte** ppbData);

        [DllImport("mfplat", EntryPoint = "MFDeserializePresentationDescriptor", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFDeserializePresentationDescriptor([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("IMFPresentationDescriptor **")] IMFPresentationDescriptor** ppPD);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SD_LANGUAGE = new Guid(0xaf2180, 0xbdc2, 0x423c, 0xab, 0xca, 0xf5, 0x3, 0x59, 0x3b, 0xc1, 0x21);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SD_PROTECTED = new Guid(0xaf2181, 0xbdc2, 0x423c, 0xab, 0xca, 0xf5, 0x3, 0x59, 0x3b, 0xc1, 0x21);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SD_STREAM_NAME = new Guid(0x4f1b099d, 0xd314, 0x41e5, 0xa7, 0x81, 0x7f, 0xef, 0xaa, 0x4c, 0x50, 0x1f);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SD_MUTUALLY_EXCLUSIVE = new Guid(0x23ef79c, 0x388d, 0x487f, 0xac, 0x17, 0x69, 0x6c, 0xd6, 0xe3, 0xc6, 0xf5);

        [DllImport("mfplat", EntryPoint = "MFCreateStreamDescriptor", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateStreamDescriptor([NativeTypeName("DWORD")] uint dwStreamIdentifier, [NativeTypeName("DWORD")] uint cMediaTypes, [NativeTypeName("IMFMediaType **")] IMFMediaType** apMediaTypes, [NativeTypeName("IMFStreamDescriptor **")] IMFStreamDescriptor** ppDescriptor);

        [DllImport("mf", EntryPoint = "MFCreateSimpleTypeHandler", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSimpleTypeHandler([NativeTypeName("IMFMediaTypeHandler **")] IMFMediaTypeHandler** ppHandler);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_MIXER_CLSID = new Guid(0xba491360, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_MIXER_ACTIVATE = new Guid(0xba491361, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_MIXER_FLAGS = new Guid(0xba491362, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_CLSID = new Guid(0xba491364, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_ACTIVATE = new Guid(0xba491365, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_FLAGS = new Guid(0xba491366, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_ACTIVATE_MFT_LOCKED = new Guid(0xc1f6093c, 0x7f65, 0x4fbd, 0x9e, 0x39, 0x5f, 0xae, 0xc3, 0xc4, 0xfb, 0xd7);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_ACTIVATE_VIDEO_WINDOW = new Guid(0x9a2dbbdd, 0xf57e, 0x4162, 0x82, 0xb9, 0x68, 0x31, 0x37, 0x76, 0x82, 0xd3);

        [DllImport("mf", EntryPoint = "MFShutdownObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFShutdownObject([NativeTypeName("IUnknown *")] IUnknown* pUnk);

        [DllImport("mf", EntryPoint = "MFCreateAudioRenderer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAudioRenderer([NativeTypeName("IMFAttributes *")] IMFAttributes* pAudioAttributes, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppSink);

        [DllImport("mf", EntryPoint = "MFCreateAudioRendererActivate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAudioRendererActivate([NativeTypeName("IMFActivate **")] IMFActivate** ppActivate);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS = new Guid(0xede4b5e0, 0xf805, 0x4d6c, 0x99, 0xb3, 0xdb, 0x01, 0xbf, 0x95, 0xdf, 0xab);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_SESSION_ID = new Guid(0xede4b5e3, 0xf805, 0x4d6c, 0x99, 0xb3, 0xdb, 0x01, 0xbf, 0x95, 0xdf, 0xab);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ID = new Guid(0xb10aaec3, 0xef71, 0x4cc3, 0xb8, 0x73, 0x5, 0xa9, 0xa0, 0x8b, 0x9f, 0x8e);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ROLE = new Guid(0x6ba644ff, 0x27c5, 0x4d02, 0x98, 0x87, 0xc2, 0x86, 0x19, 0xfd, 0xb9, 0x1b);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_STREAM_CATEGORY = new Guid(0xa9770471, 0x92ec, 0x4df4, 0x94, 0xfe, 0x81, 0xc3, 0x6f, 0xc, 0x3a, 0x7a);

        [DllImport("mf", EntryPoint = "MFCreateVideoRendererActivate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoRendererActivate([NativeTypeName("HWND")] IntPtr hwndVideo, [NativeTypeName("IMFActivate **")] IMFActivate** ppActivate);

        [DllImport("mf", EntryPoint = "MFCreateMPEG4MediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMPEG4MediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pIByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pVideoMediaType, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppIMediaSink);

        [DllImport("mf", EntryPoint = "MFCreate3GPMediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreate3GPMediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pIByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pVideoMediaType, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppIMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateMP3MediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMP3MediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pTargetByteStream, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateAC3MediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAC3MediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pTargetByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateADTSMediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateADTSMediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pTargetByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateMuxSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMuxSink([NativeTypeName("GUID")] Guid guidOutputSubType, [NativeTypeName("IMFAttributes *")] IMFAttributes* pOutputAttributes, [NativeTypeName("IMFByteStream *")] IMFByteStream* pOutputByteStream, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppMuxSink);

        [DllImport("mf", EntryPoint = "MFCreateFMPEG4MediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateFMPEG4MediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pIByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pVideoMediaType, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppIMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateAVIMediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAVIMediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pIByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pVideoMediaType, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppIMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateWAVEMediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateWAVEMediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pTargetByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateTopoLoader", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTopoLoader([NativeTypeName("IMFTopoLoader **")] IMFTopoLoader** ppObj);

        [NativeTypeName("const IID")]
        public static readonly Guid MFENABLETYPE_WMDRMV1_LicenseAcquisition = new Guid(0x4ff6eeaf, 0xb43, 0x4797, 0x9b, 0x85, 0xab, 0xf3, 0x18, 0x15, 0xe7, 0xb0);

        [NativeTypeName("const IID")]
        public static readonly Guid MFENABLETYPE_WMDRMV7_LicenseAcquisition = new Guid(0x3306df, 0x4a06, 0x4884, 0xa0, 0x97, 0xef, 0x6d, 0x22, 0xec, 0x84, 0xa3);

        [NativeTypeName("const IID")]
        public static readonly Guid MFENABLETYPE_WMDRMV7_Individualization = new Guid(0xacd2c84a, 0xb303, 0x4f65, 0xbc, 0x2c, 0x2c, 0x84, 0x8d, 0x1, 0xa9, 0x89);

        [NativeTypeName("const IID")]
        public static readonly Guid MFENABLETYPE_MF_UpdateRevocationInformation = new Guid(0xe558b0b5, 0xb3c4, 0x44a0, 0x92, 0x4c, 0x50, 0xd1, 0x78, 0x93, 0x23, 0x85);

        [NativeTypeName("const IID")]
        public static readonly Guid MFENABLETYPE_MF_UpdateUntrustedComponent = new Guid(0x9879f3d6, 0xcee2, 0x48e6, 0xb5, 0x73, 0x97, 0x67, 0xab, 0x17, 0x2f, 0x16);

        [NativeTypeName("const IID")]
        public static readonly Guid MFENABLETYPE_MF_RebootRequired = new Guid(0x6d4d3d4b, 0x0ece, 0x4652, 0x8b, 0x3a, 0xf2, 0xd2, 0x42, 0x60, 0xd8, 0x87);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_METADATA_PROVIDER_SERVICE = new Guid(0xdb214084, 0x58a4, 0x4d2e, 0xb8, 0x4f, 0x6f, 0x75, 0x5b, 0x2f, 0x7a, 0xd);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PROPERTY_HANDLER_SERVICE = new Guid(0xa3face02, 0x32b8, 0x41dd, 0x90, 0xe7, 0x5f, 0xef, 0x7c, 0x89, 0x91, 0xb5);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_RATE_CONTROL_SERVICE = new Guid(0x866fa297, 0xb802, 0x4bf8, 0x9d, 0xc9, 0x5e, 0x3b, 0x6a, 0x9f, 0x53, 0xc9);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TIMECODE_SERVICE = new Guid(0xa0d502a7, 0x0eb3, 0x4885, 0xb1, 0xb9, 0x9f, 0xeb, 0x0d, 0x08, 0x34, 0x54);

        [NativeTypeName("const IID")]
        public static readonly Guid MR_POLICY_VOLUME_SERVICE = new Guid(0x1abaa2ac, 0x9d3b, 0x47c6, 0xab, 0x48, 0xc5, 0x95, 0x6, 0xde, 0x78, 0x4d);

        [NativeTypeName("const IID")]
        public static readonly Guid MR_CAPTURE_POLICY_VOLUME_SERVICE = new Guid(0x24030acd, 0x107a, 0x4265, 0x97, 0x5c, 0x41, 0x4e, 0x33, 0xe6, 0x5f, 0x2a);

        [NativeTypeName("const IID")]
        public static readonly Guid MR_STREAM_VOLUME_SERVICE = new Guid(0xf8b5fa2f, 0x32ef, 0x46f5, 0xb1, 0x72, 0x13, 0x21, 0x21, 0x2f, 0xb2, 0xc4);

        [NativeTypeName("const IID")]
        public static readonly Guid MR_AUDIO_POLICY_SERVICE = new Guid(0x911fd737, 0x6775, 0x4ab0, 0xa6, 0x14, 0x29, 0x78, 0x62, 0xfd, 0xac, 0x88);

        [DllImport("mf", EntryPoint = "MFCreateSampleGrabberSinkActivate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSampleGrabberSinkActivate([NativeTypeName("IMFMediaType *")] IMFMediaType* pIMFMediaType, [NativeTypeName("IMFSampleGrabberSinkCallback *")] IMFSampleGrabberSinkCallback* pIMFSampleGrabberSinkCallback, [NativeTypeName("IMFActivate **")] IMFActivate** ppIActivate);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SAMPLEGRABBERSINK_SAMPLE_TIME_OFFSET = new Guid(0x62e3d776, 0x8100, 0x4e03, 0xa6, 0xe8, 0xbd, 0x38, 0x57, 0xac, 0x9c, 0x47);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SAMPLEGRABBERSINK_IGNORE_CLOCK = new Guid(0x0efda2c0, 0x2b69, 0x4e2e, 0xab, 0x8d, 0x46, 0xdc, 0xbf, 0xf7, 0xd2, 0x5d);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_QUALITY_SERVICES = new Guid(0xb7e2be11, 0x2f96, 0x4640, 0xb5, 0x2c, 0x28, 0x23, 0x65, 0xbd, 0xf1, 0x6c);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_WORKQUEUE_SERVICES = new Guid(0x8e37d489, 0x41e0, 0x413a, 0x90, 0x68, 0x28, 0x7c, 0x88, 0x6d, 0x8d, 0xda);

        [DllImport("mf", EntryPoint = "MFCreateStandardQualityManager", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateStandardQualityManager([NativeTypeName("IMFQualityManager **")] IMFQualityManager** ppQualityManager);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_QUALITY_NOTIFY_PROCESSING_LATENCY = new Guid(0xf6b44af8, 0x604d, 0x46fe, 0xa9, 0x5d, 0x45, 0x47, 0x9b, 0x10, 0xc9, 0xbc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_QUALITY_NOTIFY_SAMPLE_LAG = new Guid(0x30d15206, 0xed2a, 0x4760, 0xbe, 0x17, 0xeb, 0x4a, 0x9f, 0x12, 0x29, 0x5c);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TIME_FORMAT_SEGMENT_OFFSET = new Guid(0xc8b8be77, 0x869c, 0x431d, 0x81, 0x2e, 0x16, 0x96, 0x93, 0xf6, 0x5a, 0x39);

        [DllImport("mf", EntryPoint = "MFCreateSequencerSource", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSequencerSource([NativeTypeName("IUnknown *")] IUnknown* pReserved, [NativeTypeName("IMFSequencerSource **")] IMFSequencerSource** ppSequencerSource);

        [DllImport("mf", EntryPoint = "MFCreateSequencerSegmentOffset", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSequencerSegmentOffset([NativeTypeName("MFSequencerElementId")] uint dwId, [NativeTypeName("MFTIME")] long hnsOffset, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarSegmentOffset);

        [DllImport("mf", EntryPoint = "MFCreateAggregateSource", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAggregateSource([NativeTypeName("IMFCollection *")] IMFCollection* pSourceCollection, [NativeTypeName("IMFMediaSource **")] IMFMediaSource** ppAggSource);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SOURCE_PRESENTATION_PROVIDER_SERVICE = new Guid(0xe002aadc, 0xf4af, 0x4ee5, 0x98, 0x47, 0x05, 0x3e, 0xdf, 0x84, 0x04, 0x26);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TOPONODE_ATTRIBUTE_EDITOR_SERVICE = new Guid(0x65656e1a, 0x077f, 0x4472, 0x83, 0xef, 0x31, 0x6f, 0x11, 0xd5, 0x08, 0x7a);

        [DllImport("mf", EntryPoint = "MFCreateCredentialCache", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateCredentialCache([NativeTypeName("IMFNetCredentialCache **")] IMFNetCredentialCache** ppCache);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_SSLCERTIFICATE_MANAGER = new Guid(0x55e6cb27, 0xe69b, 0x4267, 0x94, 0x0c, 0x2d, 0x7e, 0xc5, 0xbb, 0x8a, 0x0f);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_RESOURCE_FILTER = new Guid(0x815d0ff6, 0x265a, 0x4477, 0x9e, 0x46, 0x7b, 0x80, 0xad, 0x80, 0xb5, 0xfb);

        [DllImport("mf", EntryPoint = "MFCreateProxyLocator", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateProxyLocator([NativeTypeName("LPCWSTR")] ushort* pszProtocol, [NativeTypeName("IPropertyStore *")] IPropertyStore* pProxyConfig, [NativeTypeName("IMFNetProxyLocator **")] IMFNetProxyLocator** ppProxyLocator);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNET_SAVEJOB_SERVICE = new Guid(0xb85a587f, 0x3d02, 0x4e52, 0x95, 0x65, 0x55, 0xd3, 0xec, 0x1e, 0x7f, 0xf7);

        [DllImport("mf", EntryPoint = "MFCreateNetSchemePlugin", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateNetSchemePlugin([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvHandler);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_STATISTICS_SERVICE = new Guid(0x3cb1f275, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_STATISTICS = new Guid(0x3cb1f274, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_BUFFERINGTIME = new Guid(0x3cb1f276, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_ACCELERATEDSTREAMINGDURATION = new Guid(0x3cb1f277, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_MAXUDPACCELERATEDSTREAMINGDURATION = new Guid(0x4aab2879, 0xbbe1, 0x4994, 0x9f, 0xf0, 0x54, 0x95, 0xbd, 0x25, 0x1, 0x29);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_MAXBUFFERTIMEMS = new Guid(0x408b24e6, 0x4038, 0x4401, 0xb5, 0xb2, 0xfe, 0x70, 0x1a, 0x9e, 0xbf, 0x10);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_CONNECTIONBANDWIDTH = new Guid(0x3cb1f278, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_CACHEENABLED = new Guid(0x3cb1f279, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_AUTORECONNECTLIMIT = new Guid(0x3cb1f27a, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_RESENDSENABLED = new Guid(0x3cb1f27b, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_THINNINGENABLED = new Guid(0x3cb1f27c, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PROTOCOL = new Guid(0x3cb1f27d, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_TRANSPORT = new Guid(0x3cb1f27e, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PREVIEWMODEENABLED = new Guid(0x3cb1f27f, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_CREDENTIAL_MANAGER = new Guid(0x3cb1f280, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PPBANDWIDTH = new Guid(0x3cb1f281, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_AUTORECONNECTPROGRESS = new Guid(0x3cb1f282, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PROXYLOCATORFACTORY = new Guid(0x3cb1f283, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_BROWSERUSERAGENT = new Guid(0x3cb1f28b, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_BROWSERWEBPAGE = new Guid(0x3cb1f28c, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PLAYERVERSION = new Guid(0x3cb1f28d, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PLAYERID = new Guid(0x3cb1f28e, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_HOSTEXE = new Guid(0x3cb1f28f, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_HOSTVERSION = new Guid(0x3cb1f291, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PLAYERUSERAGENT = new Guid(0x3cb1f292, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_CLIENTGUID = new Guid(0x60a2c4a6, 0xf197, 0x4c14, 0xa5, 0xbf, 0x88, 0x83, 0xd, 0x24, 0x58, 0xaf);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_LOGURL = new Guid(0x3cb1f293, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_ENABLE_UDP = new Guid(0x3cb1f294, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_ENABLE_TCP = new Guid(0x3cb1f295, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_ENABLE_MSB = new Guid(0x3cb1f296, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_ENABLE_RTSP = new Guid(0x3cb1f298, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_ENABLE_HTTP = new Guid(0x3cb1f299, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_ENABLE_STREAMING = new Guid(0x3cb1f29c, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_ENABLE_DOWNLOAD = new Guid(0x3cb1f29d, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_ENABLE_PRIVATEMODE = new Guid(0x824779d8, 0xf18b, 0x4405, 0x8c, 0xf1, 0x46, 0x4f, 0xb5, 0xaa, 0x8f, 0x71);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_UDP_PORT_RANGE = new Guid(0x3cb1f29a, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PROXYINFO = new Guid(0x3cb1f29b, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_DRMNET_LICENSE_REPRESENTATION = new Guid(0x47eae1bd, 0xbdfe, 0x42e2, 0x82, 0xf3, 0x54, 0xa4, 0x8c, 0x17, 0x96, 0x2d);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PROXYSETTINGS = new Guid(0x3cb1f287, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PROXYHOSTNAME = new Guid(0x3cb1f284, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PROXYPORT = new Guid(0x3cb1f288, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PROXYEXCEPTIONLIST = new Guid(0x3cb1f285, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PROXYBYPASSFORLOCAL = new Guid(0x3cb1f286, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PROXYRERUNAUTODETECTION = new Guid(0x3cb1f289, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_STREAM_LANGUAGE = new Guid(0x9ab44318, 0xf7cd, 0x4f2d, 0x8d, 0x6d, 0xfa, 0x35, 0xb4, 0x92, 0xce, 0xcb);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_LOGPARAMS = new Guid(0x64936ae8, 0x9418, 0x453a, 0x8c, 0xda, 0x3e, 0xa, 0x66, 0x8b, 0x35, 0x3b);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_PEERMANAGER = new Guid(0x48b29adb, 0xfebf, 0x45ee, 0xa9, 0xbf, 0xef, 0xb8, 0x1c, 0x49, 0x2e, 0xfc);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_FRIENDLYNAME = new Guid(0x5b2a7757, 0xbc6b, 0x447e, 0xaa, 0x06, 0x0d, 0xda, 0x1c, 0x64, 0x6e, 0x2f);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_BYTESTREAMHANDLER_ACCEPTS_SHARE_WRITE = new Guid(0xa6e1f733, 0x3001, 0x4915, 0x81, 0x50, 0x15, 0x58, 0xa2, 0x18, 0xe, 0xc8);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_BYTESTREAM_SERVICE = new Guid(0xab025e2b, 0x16d9, 0x4180, 0xa1, 0x27, 0xba, 0x6c, 0x70, 0x15, 0x61, 0x61);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_PROTECTION_MANAGER_PROPERTIES = new Guid(0x38BD81A9, 0xACEA, 0x4C73, 0x89, 0xB2, 0x55, 0x32, 0xC0, 0xAE, 0xCA, 0x79);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_SPDIF = new Guid(0xb94a712, 0xad3e, 0x4cee, 0x83, 0xce, 0xce, 0x32, 0xe3, 0xdb, 0x65, 0x22);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_UNKNOWN = new Guid(0xac3aef5c, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_PCI = new Guid(0xac3aef5d, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_PCIX = new Guid(0xac3aef5e, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_PCI_Express = new Guid(0xac3aef5f, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_AGP = new Guid(0xac3aef60, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_VGA = new Guid(0x57cd5968, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_SVIDEO = new Guid(0x57cd5969, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_COMPOSITE = new Guid(0x57cd596a, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_COMPONENT = new Guid(0x57cd596b, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_DVI = new Guid(0x57cd596c, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_HDMI = new Guid(0x57cd596d, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_LVDS = new Guid(0x57cd596e, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_D_JPN = new Guid(0x57cd5970, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_SDI = new Guid(0x57cd5971, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_DISPLAYPORT_EXTERNAL = new Guid(0x57cd5972, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_DISPLAYPORT_EMBEDDED = new Guid(0x57cd5973, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_UDI_EXTERNAL = new Guid(0x57cd5974, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_UDI_EMBEDDED = new Guid(0x57cd5975, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_MIRACAST = new Guid(0x57cd5977, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_A = new Guid(0x57cd5978, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_B = new Guid(0x57cd5979, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_POLICY_ID = new Guid(0xb160c24d, 0xc059, 0x48f1, 0xa9, 0x1, 0x9e, 0xe2, 0x98, 0xa9, 0xa8, 0xc3);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_DISABLE = new Guid(0x8cc6d81b, 0xfec6, 0x4d8f, 0x96, 0x4b, 0xcf, 0xba, 0x0b, 0x0d, 0xad, 0x0d);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_CONSTRICTVIDEO = new Guid(0x193370ce, 0xc5e4, 0x4c3a, 0x8a, 0x66, 0x69, 0x59, 0xb4, 0xda, 0x44, 0x42);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_CONSTRICTVIDEO_NOOPM = new Guid(0xa580e8cd, 0xc247, 0x4957, 0xb9, 0x83, 0x3c, 0x2e, 0xeb, 0xd1, 0xff, 0x59);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_CONSTRICTAUDIO = new Guid(0xffc99b44, 0xdf48, 0x4e16, 0x8e, 0x66, 0x09, 0x68, 0x92, 0xc1, 0x57, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_TRUSTEDAUDIODRIVERS = new Guid(0x65bdf3d2, 0x0168, 0x4816, 0xa5, 0x33, 0x55, 0xd4, 0x7b, 0x02, 0x71, 0x01);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_HDCP = new Guid(0xAE7CC03D, 0xC828, 0x4021, 0xac, 0xb7, 0xd5, 0x78, 0xd2, 0x7a, 0xaf, 0x13);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_CGMSA = new Guid(0xE57E69E9, 0x226B, 0x4d31, 0xB4, 0xE3, 0xD3, 0xDB, 0x00, 0x87, 0x36, 0xDD);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_ACP = new Guid(0xc3fd11c6, 0xf8b7, 0x4d20, 0xb0, 0x08, 0x1d, 0xb1, 0x7d, 0x61, 0xf2, 0xda);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_WMDRMOTA = new Guid(0xa267a6a1, 0x362e, 0x47d0, 0x88, 0x05, 0x46, 0x28, 0x59, 0x8a, 0x23, 0xe4);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_FFT = new Guid(0x462a56b2, 0x2866, 0x4bb6, 0x98, 0x0d, 0x6d, 0x8d, 0x9e, 0xdb, 0x1a, 0x8c);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_PROTECTED_SURFACE = new Guid(0x4f5d9566, 0xe742, 0x4a25, 0x8d, 0x1f, 0xd2, 0x87, 0xb5, 0xfa, 0x0a, 0xde);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_DISABLE_SCREEN_SCRAPE = new Guid(0xa21179a4, 0xb7cd, 0x40d8, 0x96, 0x14, 0x8e, 0xf2, 0x37, 0x1b, 0xa7, 0x8d);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_VIDEO_FRAMES = new Guid(0x36a59cbc, 0x7401, 0x4a8c, 0xbc, 0x20, 0x46, 0xa7, 0xc9, 0xe5, 0x97, 0xf0);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_HARDWARE = new Guid(0x4ee7f0c1, 0x9ed7, 0x424f, 0xb6, 0xbe, 0x99, 0x6b, 0x33, 0x52, 0x88, 0x56);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_HDCP_WITH_TYPE_ENFORCEMENT = new Guid(0xa4a585e8, 0xed60, 0x442d, 0x81, 0x4d, 0xdb, 0x4d, 0x42, 0x20, 0xa0, 0x6d);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTIONATTRIBUTE_BEST_EFFORT = new Guid(0xc8e06331, 0x75f0, 0x4ec1, 0x8e, 0x77, 0x17, 0x57, 0x8f, 0x77, 0x3b, 0x46);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTIONATTRIBUTE_FAIL_OVER = new Guid(0x8536abc5, 0x38f1, 0x4151, 0x9c, 0xce, 0xf5, 0x5d, 0x94, 0x12, 0x29, 0xac);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTION_GRAPHICS_TRANSFER_AES_ENCRYPTION = new Guid(0xc873de64, 0xd8a5, 0x49e6, 0x88, 0xbb, 0xfb, 0x96, 0x3f, 0xd3, 0xd4, 0xce);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTIONATTRIBUTE_CONSTRICTVIDEO_IMAGESIZE = new Guid(0x8476fc, 0x4b58, 0x4d80, 0xa7, 0x90, 0xe7, 0x29, 0x76, 0x73, 0x16, 0x1d);

        [NativeTypeName("const IID")]
        public static readonly Guid MFPROTECTIONATTRIBUTE_HDCP_SRM = new Guid(0x6f302107, 0x3477, 0x4468, 0x8a, 0x8, 0xee, 0xf9, 0xdb, 0x10, 0xe2, 0xf);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SampleProtectionSalt = new Guid(0x5403deee, 0xb9ee, 0x438f, 0xaa, 0x83, 0x38, 0x4, 0x99, 0x7e, 0x56, 0x9d);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_REMOTE_PROXY = new Guid(0x2f00c90e, 0xd2cf, 0x4278, 0x8b, 0x6a, 0xd0, 0x77, 0xfa, 0xc3, 0xa2, 0x5f);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_CreateMediaExtensionObject = new Guid(0xef65a54d, 0x0788, 0x45b8, 0x8b, 0x14, 0xbc, 0x0f, 0x6a, 0x6b, 0x51, 0x37);

        [DllImport("mf", EntryPoint = "MFCreatePMPServer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePMPServer([NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("IMFPMPServer **")] IMFPMPServer** ppPMPServer);

        [DllImport("mf", EntryPoint = "MFCreateRemoteDesktopPlugin", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateRemoteDesktopPlugin([NativeTypeName("IMFRemoteDesktopPlugin **")] IMFRemoteDesktopPlugin** ppPlugin);

        [DllImport("mf", EntryPoint = "CreateNamedPropertyStore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateNamedPropertyStore([NativeTypeName("INamedPropertyStore **")] INamedPropertyStore** ppStore);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SAMI_SERVICE = new Guid(0x49a89ae7, 0xb4d9, 0x4ef2, 0xaa, 0x5c, 0xf6, 0x5a, 0x3e, 0x5, 0xae, 0x4e);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_PD_SAMI_STYLELIST = new Guid(0xe0b73c7f, 0x486d, 0x484e, 0x98, 0x72, 0x4d, 0xe5, 0x19, 0x2a, 0x7b, 0xf8);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SD_SAMI_LANGUAGE = new Guid(0x36fcb98a, 0x6cd0, 0x44cb, 0xac, 0xb9, 0xa8, 0xf5, 0x60, 0xd, 0xd0, 0xbb);

        [DllImport("mf", EntryPoint = "MFCreateSampleCopierMFT", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSampleCopierMFT([NativeTypeName("IMFTransform **")] IMFTransform** ppCopierMFT);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TRANSCODE_CONTAINERTYPE = new Guid(0x150ff23f, 0x4abc, 0x478b, 0xac, 0x4f, 0xe1, 0x91, 0x6f, 0xba, 0x1c, 0xca);

        [NativeTypeName("const IID")]
        public static readonly Guid MFTranscodeContainerType_ASF = new Guid(0x430f6f6e, 0xb6bf, 0x4fc1, 0xa0, 0xbd, 0x9e, 0xe4, 0x6e, 0xee, 0x2a, 0xfb);

        [NativeTypeName("const IID")]
        public static readonly Guid MFTranscodeContainerType_MPEG4 = new Guid(0xdc6cd05d, 0xb9d0, 0x40ef, 0xbd, 0x35, 0xfa, 0x62, 0x2c, 0x1a, 0xb2, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MFTranscodeContainerType_MP3 = new Guid(0xe438b912, 0x83f1, 0x4de6, 0x9e, 0x3a, 0x9f, 0xfb, 0xc6, 0xdd, 0x24, 0xd1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFTranscodeContainerType_FLAC = new Guid(0x31344aa3, 0x05a9, 0x42b5, 0x90, 0x1b, 0x8e, 0x9d, 0x42, 0x57, 0xf7, 0x5e);

        [NativeTypeName("const IID")]
        public static readonly Guid MFTranscodeContainerType_3GP = new Guid(0x34c50167, 0x4472, 0x4f34, 0x9e, 0xa0, 0xc4, 0x9f, 0xba, 0xcf, 0x03, 0x7d);

        [NativeTypeName("const IID")]
        public static readonly Guid MFTranscodeContainerType_AC3 = new Guid(0x6d8d91c3, 0x8c91, 0x4ed1, 0x87, 0x42, 0x8c, 0x34, 0x7d, 0x5b, 0x44, 0xd0);

        [NativeTypeName("const IID")]
        public static readonly Guid MFTranscodeContainerType_ADTS = new Guid(0x132fd27d, 0x0f02, 0x43de, 0xa3, 0x01, 0x38, 0xfb, 0xbb, 0xb3, 0x83, 0x4e);

        [NativeTypeName("const IID")]
        public static readonly Guid MFTranscodeContainerType_MPEG2 = new Guid(0xbfc2dbf9, 0x7bb4, 0x4f8f, 0xaf, 0xde, 0xe1, 0x12, 0xc4, 0x4b, 0xa8, 0x82);

        [NativeTypeName("const IID")]
        public static readonly Guid MFTranscodeContainerType_WAVE = new Guid(0x64c3453c, 0x0f26, 0x4741, 0xbe, 0x63, 0x87, 0xbd, 0xf8, 0xbb, 0x93, 0x5b);

        [NativeTypeName("const IID")]
        public static readonly Guid MFTranscodeContainerType_AVI = new Guid(0x7edfe8af, 0x402f, 0x4d76, 0xa3, 0x3c, 0x61, 0x9f, 0xd1, 0x57, 0xd0, 0xf1);

        [NativeTypeName("const IID")]
        public static readonly Guid MFTranscodeContainerType_FMPEG4 = new Guid(0x9ba876f1, 0x419f, 0x4b77, 0xa1, 0xe0, 0x35, 0x95, 0x9d, 0x9d, 0x40, 0x4);

        [NativeTypeName("const IID")]
        public static readonly Guid MFTranscodeContainerType_AMR = new Guid(0x25d5ad3, 0x621a, 0x475b, 0x96, 0x4d, 0x66, 0xb1, 0xc8, 0x24, 0xf0, 0x79);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TRANSCODE_SKIP_METADATA_TRANSFER = new Guid(0x4e4469ef, 0xb571, 0x4959, 0x8f, 0x83, 0x3d, 0xcf, 0xba, 0x33, 0xa3, 0x93);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TRANSCODE_TOPOLOGYMODE = new Guid(0x3e3df610, 0x394a, 0x40b2, 0x9d, 0xea, 0x3b, 0xab, 0x65, 0xb, 0xeb, 0xf2);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TRANSCODE_ADJUST_PROFILE = new Guid(0x9c37c21b, 0x60f, 0x487c, 0xa6, 0x90, 0x80, 0xd7, 0xf5, 0xd, 0x1c, 0x72);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TRANSCODE_ENCODINGPROFILE = new Guid(0x6947787c, 0xf508, 0x4ea9, 0xb1, 0xe9, 0xa1, 0xfe, 0x3a, 0x49, 0xfb, 0xc9);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TRANSCODE_QUALITYVSSPEED = new Guid(0x98332df8, 0x03cd, 0x476b, 0x89, 0xfa, 0x3f, 0x9e, 0x44, 0x2d, 0xec, 0x9f);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_TRANSCODE_DONOT_INSERT_ENCODER = new Guid(0xf45aa7ce, 0xab24, 0x4012, 0xa1, 0x1b, 0xdc, 0x82, 0x20, 0x20, 0x14, 0x10);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_VIDEO_PROCESSOR_ALGORITHM = new Guid(0x4a0a1e1f, 0x272c, 0x4fb6, 0x9e, 0xb1, 0xdb, 0x33, 0xc, 0xbc, 0x97, 0xca);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_XVP_DISABLE_FRC = new Guid(0x2c0afa19, 0x7a97, 0x4d5a, 0x9e, 0xe8, 0x16, 0xd4, 0xfc, 0x51, 0x8d, 0x8c);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_XVP_CALLER_ALLOCATES_OUTPUT = new Guid(0x4a2cabc, 0xcab, 0x40b1, 0xa1, 0xb9, 0x75, 0xbc, 0x36, 0x58, 0xf0, 0x0);

        [DllImport("mf", EntryPoint = "MFCreateTranscodeProfile", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTranscodeProfile([NativeTypeName("IMFTranscodeProfile **")] IMFTranscodeProfile** ppTranscodeProfile);

        [DllImport("mf", EntryPoint = "MFCreateTranscodeTopology", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTranscodeTopology([NativeTypeName("IMFMediaSource *")] IMFMediaSource* pSrc, [NativeTypeName("LPCWSTR")] ushort* pwszOutputFilePath, [NativeTypeName("IMFTranscodeProfile *")] IMFTranscodeProfile* pProfile, [NativeTypeName("IMFTopology **")] IMFTopology** ppTranscodeTopo);

        [DllImport("mf", EntryPoint = "MFCreateTranscodeTopologyFromByteStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTranscodeTopologyFromByteStream([NativeTypeName("IMFMediaSource *")] IMFMediaSource* pSrc, [NativeTypeName("IMFByteStream *")] IMFByteStream* pOutputStream, [NativeTypeName("IMFTranscodeProfile *")] IMFTranscodeProfile* pProfile, [NativeTypeName("IMFTopology **")] IMFTopology** ppTranscodeTopo);

        [DllImport("mf", EntryPoint = "MFTranscodeGetAudioOutputAvailableTypes", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTranscodeGetAudioOutputAvailableTypes([NativeTypeName("const GUID &")] Guid* guidSubType, [NativeTypeName("DWORD")] uint dwMFTFlags, [NativeTypeName("IMFAttributes *")] IMFAttributes* pCodecConfig, [NativeTypeName("IMFCollection **")] IMFCollection** ppAvailableTypes);

        [DllImport("mf", EntryPoint = "MFCreateTranscodeSinkActivate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTranscodeSinkActivate([NativeTypeName("IMFActivate **")] IMFActivate** ppActivate);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_LOCAL_MFT_REGISTRATION_SERVICE = new Guid(0xddf5cf9c, 0x4506, 0x45aa, 0xab, 0xf0, 0x6d, 0x5d, 0x94, 0xdd, 0x1b, 0x4a);

        [DllImport("mfplat", EntryPoint = "MFCreateTrackedSample", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTrackedSample([NativeTypeName("IMFTrackedSample **")] IMFTrackedSample** ppMFSample);

        [DllImport("mfplat", EntryPoint = "MFCreateMFByteStreamOnStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMFByteStreamOnStream([NativeTypeName("IStream *")] IStream* pStream, [NativeTypeName("IMFByteStream **")] IMFByteStream** ppByteStream);

        [DllImport("mfplat", EntryPoint = "MFCreateStreamOnMFByteStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateStreamOnMFByteStream([NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("IStream **")] IStream** ppStream);

        [DllImport("mfplat", EntryPoint = "MFCreateMFByteStreamOnStreamEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMFByteStreamOnStreamEx([NativeTypeName("IUnknown *")] IUnknown* punkStream, [NativeTypeName("IMFByteStream **")] IMFByteStream** ppByteStream);

        [DllImport("mfplat", EntryPoint = "MFCreateStreamOnMFByteStreamEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateStreamOnMFByteStreamEx([NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("mfplat", EntryPoint = "MFCreateMediaTypeFromProperties", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaTypeFromProperties([NativeTypeName("IUnknown *")] IUnknown* punkStream, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType);

        [DllImport("mfplat", EntryPoint = "MFCreatePropertiesFromMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePropertiesFromMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_WRAPPED_BUFFER_SERVICE = new Guid(0xab544072, 0xc269, 0x4ebc, 0xa5, 0x52, 0x1c, 0x3b, 0x32, 0xbe, 0xd5, 0xca);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_WRAPPED_SAMPLE_SERVICE = new Guid(0x31f52bf2, 0xd03e, 0x4048, 0x80, 0xd0, 0x9c, 0x10, 0x46, 0xd8, 0x7c, 0x61);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_WRAPPED_OBJECT = new Guid(0x2b182c4c, 0xd6ac, 0x49f4, 0x89, 0x15, 0xf7, 0x18, 0x87, 0xdb, 0x70, 0xcd);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_HttpSchemePlugin = new Guid(0x44cb442b, 0x9da9, 0x49df, 0xb3, 0xfd, 0x2, 0x37, 0x77, 0xb1, 0x6e, 0x50);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_UrlmonSchemePlugin = new Guid(0x9ec4b4f9, 0x3029, 0x45ad, 0x94, 0x7b, 0x34, 0x4d, 0xe2, 0xa2, 0x49, 0xe2);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_NetSchemePlugin = new Guid(0xe9f4ebab, 0xd97b, 0x463e, 0xa2, 0xb1, 0xc5, 0x4e, 0xe3, 0xf9, 0x41, 0x4d);

        [DllImport("mf", EntryPoint = "MFEnumDeviceSources", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFEnumDeviceSources([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFActivate ***")] IMFActivate*** pppSourceActivate, [NativeTypeName("UINT32 *")] uint* pcSourceActivate);

        [DllImport("mf", EntryPoint = "MFCreateDeviceSource", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDeviceSource([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFMediaSource **")] IMFMediaSource** ppSource);

        [DllImport("mf", EntryPoint = "MFCreateDeviceSourceActivate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDeviceSourceActivate([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFActivate **")] IMFActivate** ppActivate);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE = new Guid(0xc60ac5fe, 0x252a, 0x478f, 0xa0, 0xef, 0xbc, 0x8f, 0xa5, 0xf7, 0xca, 0xd3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_HW_SOURCE = new Guid(0xde7046ba, 0x54d6, 0x4487, 0xa2, 0xa4, 0xec, 0x7c, 0xd, 0x1b, 0xd1, 0x63);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_FRIENDLY_NAME = new Guid(0x60d0e559, 0x52f8, 0x4fa2, 0xbb, 0xce, 0xac, 0xdb, 0x34, 0xa8, 0xec, 0x1);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_MEDIA_TYPE = new Guid(0x56a819ca, 0xc78, 0x4de4, 0xa0, 0xa7, 0x3d, 0xda, 0xba, 0xf, 0x24, 0xd4);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_CATEGORY = new Guid(0x77f0ae69, 0xc3bd, 0x4509, 0x94, 0x1d, 0x46, 0x7e, 0x4d, 0x24, 0x89, 0x9e);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_SYMBOLIC_LINK = new Guid(0x58f0aad8, 0x22bf, 0x4f8a, 0xbb, 0x3d, 0xd2, 0xc4, 0x97, 0x8c, 0x6e, 0x2f);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_SYMBOLIC_LINK = new Guid(0x98d24b5e, 0x5930, 0x4614, 0xb5, 0xa1, 0xf6, 0x0, 0xf9, 0x35, 0x5a, 0x78);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_MAX_BUFFERS = new Guid(0x7dd9b730, 0x4f2d, 0x41d5, 0x8f, 0x95, 0xc, 0xc9, 0xa9, 0x12, 0xba, 0x26);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ENDPOINT_ID = new Guid(0x30da9258, 0xfeb9, 0x47a7, 0xa4, 0x53, 0x76, 0x3a, 0x7a, 0x8e, 0x1c, 0x5f);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ROLE = new Guid(0xbc9d118e, 0x8c67, 0x4a18, 0x85, 0xd4, 0x12, 0xd3, 0x0, 0x40, 0x5, 0x52);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_PROVIDER_DEVICE_ID = new Guid(0x36689d42, 0xa06c, 0x40ae, 0x84, 0xcf, 0xf5, 0xa0, 0x34, 0x6, 0x7c, 0xc4);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_XADDRESS = new Guid(0xbca0be52, 0xc327, 0x44c7, 0x9b, 0x7d, 0x7f, 0xa8, 0xd9, 0xb5, 0xbc, 0xda);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_STREAM_URL = new Guid(0x9d7b40d2, 0x3617, 0x4043, 0x93, 0xe3, 0x8d, 0x6d, 0xa9, 0xbb, 0x34, 0x92);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_USERNAME = new Guid(0x5d01add, 0x949f, 0x46eb, 0xbc, 0x8e, 0x8b, 0xd, 0x2b, 0x32, 0xd7, 0x9d);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_PASSWORD = new Guid(0xa0fd7e16, 0x42d9, 0x49df, 0x84, 0xc0, 0xe8, 0x2c, 0x5e, 0xab, 0x88, 0x74);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_FrameServerNetworkCameraSource = new Guid(0x7a213aa7, 0x866f, 0x414a, 0x8c, 0x1a, 0x27, 0x5c, 0x72, 0x83, 0xa3, 0x95);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_GUID = new Guid(0x14dd9a1c, 0x7cff, 0x41be, 0xb1, 0xb9, 0xba, 0x1a, 0xc6, 0xec, 0xb5, 0x71);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_GUID = new Guid(0x8ac3587a, 0x4ae7, 0x42d8, 0x99, 0xe0, 0x0a, 0x60, 0x13, 0xee, 0xf9, 0x0f);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_IMAGE_STREAM = new Guid(0xa7ffb865, 0xe7b2, 0x43b0, 0x9f, 0x6f, 0x9a, 0xf2, 0xa0, 0xe5, 0xf, 0xc0);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_INDEPENDENT_IMAGE_STREAM = new Guid(0x3eeec7e, 0xd605, 0x4576, 0x8b, 0x29, 0x65, 0x80, 0xb4, 0x90, 0xd7, 0xd3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_STREAM_ID = new Guid(0x11bd5120, 0xd124, 0x446b, 0x88, 0xe6, 0x17, 0x6, 0x2, 0x57, 0xff, 0xf9);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_STREAM_CATEGORY = new Guid(0x2939e7b8, 0xa62e, 0x4579, 0xb6, 0x74, 0xd4, 0x7, 0x3d, 0xfa, 0xbb, 0xba);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_FRAMESERVER_SHARED = new Guid(0x1CB378E9, 0xB279, 0x41D4, 0xAF, 0x97, 0x34, 0xA2, 0x43, 0xE6, 0x83, 0x20);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_TRANSFORM_STREAM_ID = new Guid(0xe63937b7, 0xdaaf, 0x4d49, 0x81, 0x5f, 0xd8, 0x26, 0xf8, 0xad, 0x31, 0xe7);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_EXTENSION_PLUGIN_CLSID = new Guid(0x048e6558, 0x60c4, 0x4173, 0xbd, 0x5b, 0x6a, 0x3c, 0xa2, 0x89, 0x6a, 0xee);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICEMFT_EXTENSION_PLUGIN_CLSID = new Guid(0x844dbae, 0x34fa, 0x48a0, 0xa7, 0x83, 0x8e, 0x69, 0x6f, 0xb1, 0xc9, 0xa8);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_EXTENSION_PLUGIN_CONNECTION_POINT = new Guid(0x37f9375c, 0xe664, 0x4ea4, 0xaa, 0xe4, 0xcb, 0x6d, 0x1d, 0xac, 0xa1, 0xf4);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_TAKEPHOTO_TRIGGER = new Guid(0x1d180e34, 0x538c, 0x4fbb, 0xa7, 0x5a, 0x85, 0x9a, 0xf7, 0xd2, 0x61, 0xa6);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_MAX_FRAME_BUFFERS = new Guid(0x1684cebe, 0x3175, 0x4985, 0x88, 0x2c, 0x0e, 0xfd, 0x3e, 0x8a, 0xc1, 0x1e);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICEMFT_CONNECTED_FILTER_KSCONTROL = new Guid(0x6a2c4fa6, 0xd179, 0x41cd, 0x95, 0x23, 0x82, 0x23, 0x71, 0xea, 0x40, 0xe5);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICEMFT_CONNECTED_PIN_KSCONTROL = new Guid(0xe63310f7, 0xb244, 0x4ef8, 0x9a, 0x7d, 0x24, 0xc7, 0x4e, 0x32, 0xeb, 0xd0);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICE_THERMAL_STATE_CHANGED = new Guid(0x70ccd0af, 0xfc9f, 0x4deb, 0xa8, 0x75, 0x9f, 0xec, 0xd1, 0x6c, 0x5b, 0xd4);

        [NativeTypeName("const IID")]
        public static readonly Guid MFSampleExtension_DeviceTimestamp = new Guid(0x8f3e35e7, 0x2dcd, 0x4887, 0x86, 0x22, 0x2a, 0x58, 0xba, 0xa6, 0x52, 0xb0);

        [NativeTypeName("const IID")]
        public static readonly Guid MFSampleExtension_Spatial_CameraViewTransform = new Guid(0x4e251fa4, 0x830f, 0x4770, 0x85, 0x9a, 0x4b, 0x8d, 0x99, 0xaa, 0x80, 0x9b);

        [NativeTypeName("const IID")]
        public static readonly Guid MFSampleExtension_Spatial_CameraCoordinateSystem = new Guid(0x9d13c82f, 0x2199, 0x4e67, 0x91, 0xcd, 0xd1, 0xa4, 0x18, 0x1f, 0x25, 0x34);

        [NativeTypeName("const IID")]
        public static readonly Guid MFSampleExtension_Spatial_CameraProjectionTransform = new Guid(0x47f9fcb5, 0x2a02, 0x4f26, 0xa4, 0x77, 0x79, 0x2f, 0xdf, 0x95, 0x88, 0x6a);

        [DllImport("mf", EntryPoint = "MFCreateProtectedEnvironmentAccess", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateProtectedEnvironmentAccess([NativeTypeName("IMFProtectedEnvironmentAccess **")] IMFProtectedEnvironmentAccess** ppAccess);

        [DllImport("mf", EntryPoint = "MFLoadSignedLibrary", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLoadSignedLibrary([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("IMFSignedLibrary **")] IMFSignedLibrary** ppLib);

        [DllImport("mf", EntryPoint = "MFGetSystemId", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetSystemId([NativeTypeName("IMFSystemId **")] IMFSystemId** ppId);

        [DllImport("mf", EntryPoint = "MFGetLocalId", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetLocalId([NativeTypeName("const BYTE *")] byte* verifier, [NativeTypeName("UINT32")] uint size, [NativeTypeName("LPWSTR *")] ushort** id);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_MPEG2ByteStreamPlugin = new Guid(0x40871c59, 0xab40, 0x471f, 0x8d, 0xc3, 0x1f, 0x25, 0x9d, 0x86, 0x24, 0x79);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIASOURCE_SERVICE = new Guid(0xf09992f7, 0x9fba, 0x4c4a, 0xa3, 0x7f, 0x8c, 0x47, 0xb4, 0xe1, 0xdf, 0xe7);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_ACCESS_CONTROLLED_MEDIASOURCE_SERVICE = new Guid(0x14a5031, 0x2f05, 0x4c6a, 0x9f, 0x9c, 0x7d, 0xd, 0xc4, 0xed, 0xa5, 0xf4);

        [DllImport("mfplat", EntryPoint = "MFCreateContentProtectionDevice", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateContentProtectionDevice([NativeTypeName("const GUID &")] Guid* ProtectionSystemId, [NativeTypeName("IMFContentProtectionDevice **")] IMFContentProtectionDevice** ContentProtectionDevice);

        [DllImport("mfplat", EntryPoint = "MFIsContentProtectionDeviceSupported", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFIsContentProtectionDeviceSupported([NativeTypeName("const GUID &")] Guid* ProtectionSystemId, [NativeTypeName("BOOL *")] int* isSupported);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_CONTENT_DECRYPTOR_SERVICE = new Guid(0x68a72927, 0xfc7b, 0x44ee, 0x85, 0xf4, 0x7c, 0x51, 0xbd, 0x55, 0xa6, 0x59);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_CONTENT_PROTECTION_DEVICE_SERVICE = new Guid(0xff58436f, 0x76a0, 0x41fe, 0xb5, 0x66, 0x10, 0xcc, 0x53, 0x96, 0x2e, 0xdd);

        [DllImport("mfplat", EntryPoint = "MFCreateContentDecryptorContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateContentDecryptorContext([NativeTypeName("const GUID &")] Guid* guidMediaProtectionSystemId, [NativeTypeName("IMFDXGIDeviceManager *")] IMFDXGIDeviceManager* pD3DManager, [NativeTypeName("IMFContentProtectionDevice *")] IMFContentProtectionDevice* pContentProtectionDevice, [NativeTypeName("IMFContentDecryptorContext **")] IMFContentDecryptorContext** ppContentDecryptorContext);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SD_AUDIO_ENCODER_DELAY = new Guid(0x8e85422c, 0x73de, 0x403f, 0x9a, 0x35, 0x55, 0x0a, 0xd6, 0xe8, 0xb9, 0x51);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SD_AUDIO_ENCODER_PADDING = new Guid(0x529c7f2c, 0xac4b, 0x4e3f, 0xbf, 0xc3, 0x09, 0x02, 0x19, 0x49, 0x82, 0xcb);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MSH264DecoderMFT = new Guid(0x62CE7E72, 0x4C71, 0x4d20, 0xB1, 0x5D, 0x45, 0x28, 0x31, 0xA8, 0x7D, 0x9D);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MSH264EncoderMFT = new Guid(0x6ca50344, 0x051a, 0x4ded, 0x97, 0x79, 0xa4, 0x33, 0x05, 0x16, 0x5e, 0x35);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MSDDPlusDecMFT = new Guid(0x177C0AFE, 0x900B, 0x48d4, 0x9E, 0x4C, 0x57, 0xAD, 0xD2, 0x50, 0xB3, 0xD4);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MP3DecMediaObject = new Guid(0xbbeea841, 0x0a63, 0x4f52, 0xa7, 0xab, 0xa9, 0xb3, 0xa8, 0x4e, 0xd3, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MSAACDecMFT = new Guid(0x32d186a7, 0x218f, 0x4c75, 0x88, 0x76, 0xdd, 0x77, 0x27, 0x3a, 0x89, 0x99);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MSH265DecoderMFT = new Guid(0x420A51A3, 0xD605, 0x430C, 0xB4, 0xFC, 0x45, 0x27, 0x4F, 0xA6, 0xC5, 0x62);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_WMVDecoderMFT = new Guid(0x82d353df, 0x90bd, 0x4382, 0x8b, 0xc2, 0x3f, 0x61, 0x92, 0xb7, 0x6e, 0x34);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_WMADecMediaObject = new Guid(0x2eeb4adf, 0x4578, 0x4d10, 0xbc, 0xa7, 0xbb, 0x95, 0x5f, 0x56, 0x32, 0x0a);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MSMPEGAudDecMFT = new Guid(0x70707B39, 0xB2CA, 0x4015, 0xAB, 0xEA, 0xF8, 0x44, 0x7D, 0x22, 0xD8, 0x8B);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MSMPEGDecoderMFT = new Guid(0x2D709E52, 0x123F, 0x49b5, 0x9C, 0xBC, 0x9A, 0xF5, 0xCD, 0xE2, 0x8F, 0xB9);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_AudioResamplerMediaObject = new Guid(0xf447b69e, 0x1884, 0x4a7e, 0x80, 0x55, 0x34, 0x6f, 0x74, 0xd6, 0xed, 0xb3);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MSVPxDecoder = new Guid(0xE3AAF548, 0xC9A4, 0x4C6E, 0x23, 0x4D, 0x5A, 0xDA, 0x37, 0x4B, 0x00, 0x00);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MSOpusDecoder = new Guid(0x63e17c10, 0x2d43, 0x4c42, 0x8f, 0xe3, 0x8d, 0x8b, 0x63, 0xe4, 0x6a, 0x6a);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_VideoProcessorMFT = new Guid(0x88753b26, 0x5b24, 0x49bd, 0xb2, 0xe7, 0xc, 0x44, 0x5c, 0x78, 0xc9, 0x82);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_CROSS_ORIGIN_SUPPORT = new Guid(0x9842207c, 0xb02c, 0x4271, 0xa2, 0xfc, 0x72, 0xe4, 0x93, 0x8, 0xe5, 0xc2);

        [NativeTypeName("const IID")]
        public static readonly Guid MFNETSOURCE_HTTP_DOWNLOAD_SESSION_PROVIDER = new Guid(0x7d55081e, 0x307d, 0x4d6d, 0xa6, 0x63, 0xa9, 0x3b, 0xe9, 0x7c, 0x4b, 0x5c);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SD_MEDIASOURCE_STATUS = new Guid(0x1913678b, 0xfc0f, 0x44da, 0x8f, 0x43, 0x1b, 0xa3, 0xb5, 0x26, 0xf4, 0xae);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SD_VIDEO_SPHERICAL = new Guid(0xa51da449, 0x3fdc, 0x478c, 0xbc, 0xb5, 0x30, 0xbe, 0x76, 0x59, 0x5f, 0x55);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SD_VIDEO_SPHERICAL_FORMAT = new Guid(0x4a8fc407, 0x6ea1, 0x46c8, 0xb5, 0x67, 0x69, 0x71, 0xd4, 0xa1, 0x39, 0xc3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SD_VIDEO_SPHERICAL_INITIAL_VIEWDIRECTION = new Guid(0x11d25a49, 0xbb62, 0x467f, 0x9d, 0xb1, 0xc1, 0x71, 0x65, 0x71, 0x6c, 0x49);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIASOURCE_EXPOSE_ALL_STREAMS = new Guid(0xe7f250b8, 0x8fd9, 0x4a09, 0xb6, 0xc1, 0x6a, 0x31, 0x5c, 0x7c, 0x72, 0xe);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_ST_MEDIASOURCE_COLLECTION = new Guid(0x616DE972, 0x83AD, 0x4950, 0x81, 0x70, 0x63, 0x0D, 0x19, 0xCB, 0xE3, 0x07);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_FILTER_KSCONTROL = new Guid(0x46783CCA, 0x3DF5, 0x4923, 0xA9, 0xEF, 0x36, 0xB7, 0x22, 0x3E, 0xDD, 0xE0);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_PIN_KSCONTROL = new Guid(0xEF3EF9A7, 0x87F2, 0x48CA, 0xBE, 0x02, 0x67, 0x48, 0x78, 0x91, 0x8E, 0x98);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_SOURCE_ATTRIBUTES = new Guid(0x2F8CB617, 0x361B, 0x434F, 0x85, 0xEA, 0x99, 0xA0, 0x3E, 0x1C, 0xE4, 0xE0);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_FRAMESERVER_HIDDEN = new Guid(0xF402567B, 0x4D91, 0x4179, 0x96, 0xD1, 0x74, 0xC8, 0x48, 0x0C, 0x20, 0x34);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_STF_VERSION_INFO = new Guid(0x6770BD39, 0xEF82, 0x44EE, 0xA4, 0x9B, 0x93, 0x4B, 0xEB, 0x24, 0xAE, 0xF7);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_STF_VERSION_DATE = new Guid(0x31A165D5, 0xDF67, 0x4095, 0x8E, 0x44, 0x88, 0x68, 0xFC, 0x20, 0xDB, 0xFD);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_REQUIRED_CAPABILITIES = new Guid(0x6D8B957E, 0x7CF6, 0x43F4, 0xAF, 0x56, 0x9C, 0x0E, 0x1E, 0x4F, 0xCB, 0xE1);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_REQUIRED_SDDL = new Guid(0x331AE85D, 0xC0D3, 0x49BA, 0x83, 0xBA, 0x82, 0xA1, 0x2D, 0x63, 0xCD, 0xD6);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICEMFT_SENSORPROFILE_COLLECTION = new Guid(0x36EBDC44, 0xB12C, 0x441B, 0x89, 0xF4, 0x08, 0xB2, 0xF4, 0x1A, 0x9C, 0xFC);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_DEVICESTREAM_SENSORSTREAM_ID = new Guid(0xE35B9FE4, 0x0659, 0x4CAD, 0xBB, 0x51, 0x33, 0x16, 0x0B, 0xE7, 0xE4, 0x13);

        [DllImport("mf", EntryPoint = "MFCreateSensorGroup", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorGroup([NativeTypeName("LPCWSTR")] ushort* SensorGroupSymbolicLink, [NativeTypeName("IMFSensorGroup **")] IMFSensorGroup** ppSensorGroup);

        [DllImport("mf", EntryPoint = "MFCreateSensorStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorStream([NativeTypeName("DWORD")] uint StreamId, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFCollection *")] IMFCollection* pMediaTypeCollection, [NativeTypeName("IMFSensorStream **")] IMFSensorStream** ppStream);

        [DllImport("mfsensorgroup", EntryPoint = "MFCreateSensorProfile", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorProfile([NativeTypeName("const GUID &")] Guid* ProfileType, [NativeTypeName("UINT32")] uint ProfileIndex, [NativeTypeName("LPCWSTR")] ushort* Constraints, [NativeTypeName("IMFSensorProfile **")] IMFSensorProfile** ppProfile);

        [DllImport("mfsensorgroup", EntryPoint = "MFCreateSensorProfileCollection", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorProfileCollection([NativeTypeName("IMFSensorProfileCollection **")] IMFSensorProfileCollection** ppSensorProfile);

        [DllImport("mfsensorgroup", EntryPoint = "MFCreateSensorActivityMonitor", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorActivityMonitor([NativeTypeName("IMFSensorActivitiesReportCallback *")] IMFSensorActivitiesReportCallback* pCallback, [NativeTypeName("IMFSensorActivityMonitor **")] IMFSensorActivityMonitor** ppActivityMonitor);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFStreamExtension_ExtendedCameraIntrinsics = new Guid(0xaa74b3df, 0x9a2c, 0x48d6, 0x83, 0x93, 0x5b, 0xd1, 0xc1, 0xa8, 0x1e, 0x6e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_ExtendedCameraIntrinsics = new Guid(0x560bc4a5, 0x4de0, 0x4113, 0x9c, 0xdc, 0x83, 0x2d, 0xb9, 0x74, 0xf, 0x3d);

        [DllImport("mf", EntryPoint = "MFCreateExtendedCameraIntrinsics", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateExtendedCameraIntrinsics([NativeTypeName("IMFExtendedCameraIntrinsics **")] IMFExtendedCameraIntrinsics** ppExtendedCameraIntrinsics);

        [DllImport("mf", EntryPoint = "MFCreateExtendedCameraIntrinsicModel", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateExtendedCameraIntrinsicModel([NativeTypeName("const MFCameraIntrinsic_DistortionModelType")] MFCameraIntrinsic_DistortionModelType distortionModelType, [NativeTypeName("IMFExtendedCameraIntrinsicModel **")] IMFExtendedCameraIntrinsicModel** ppExtendedCameraIntrinsicModel);

        [DllImport("mf", EntryPoint = "MFCreateRelativePanelWatcher", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateRelativePanelWatcher([NativeTypeName("PCWSTR")] ushort* videoDeviceId, [NativeTypeName("PCWSTR")] ushort* displayMonitorDeviceId, [NativeTypeName("IMFRelativePanelWatcher **")] IMFRelativePanelWatcher** ppRelativePanelWatcher);

        [NativeTypeName("#define MEDIASINK_FIXED_STREAMS 0x00000001")]
        public const int MEDIASINK_FIXED_STREAMS = 0x00000001;

        [NativeTypeName("#define MEDIASINK_CANNOT_MATCH_CLOCK 0x00000002")]
        public const int MEDIASINK_CANNOT_MATCH_CLOCK = 0x00000002;

        [NativeTypeName("#define MEDIASINK_RATELESS 0x00000004")]
        public const int MEDIASINK_RATELESS = 0x00000004;

        [NativeTypeName("#define MEDIASINK_CLOCK_REQUIRED 0x00000008")]
        public const int MEDIASINK_CLOCK_REQUIRED = 0x00000008;

        [NativeTypeName("#define MEDIASINK_CAN_PREROLL 0x00000010")]
        public const int MEDIASINK_CAN_PREROLL = 0x00000010;

        [NativeTypeName("#define MEDIASINK_REQUIRE_REFERENCE_MEDIATYPE 0x00000020")]
        public const int MEDIASINK_REQUIRE_REFERENCE_MEDIATYPE = 0x00000020;

        [NativeTypeName("#define MFCLOCK_FREQUENCY_HNS 10000000")]
        public const int MFCLOCK_FREQUENCY_HNS = 10000000;

        [NativeTypeName("#define MFCLOCK_TOLERANCE_UNKNOWN 50000")]
        public const int MFCLOCK_TOLERANCE_UNKNOWN = 50000;

        [NativeTypeName("#define MFCLOCK_JITTER_ISR 1000")]
        public const int MFCLOCK_JITTER_ISR = 1000;

        [NativeTypeName("#define MFCLOCK_JITTER_DPC 4000")]
        public const int MFCLOCK_JITTER_DPC = 4000;

        [NativeTypeName("#define MFCLOCK_JITTER_PASSIVE 10000")]
        public const int MFCLOCK_JITTER_PASSIVE = 10000;

        [NativeTypeName("#define PRESENTATION_CURRENT_POSITION 0x7fffffffffffffff")]
        public const long PRESENTATION_CURRENT_POSITION = 0x7fffffffffffffff;

        [NativeTypeName("#define MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_CROSSPROCESS 0x00000001")]
        public const int MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_CROSSPROCESS = 0x00000001;

        [NativeTypeName("#define MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_NOPERSIST 0x00000002")]
        public const int MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_NOPERSIST = 0x00000002;

        [NativeTypeName("#define MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_DONT_ALLOW_FORMAT_CHANGES 0x00000004")]
        public const int MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_DONT_ALLOW_FORMAT_CHANGES = 0x00000004;

        [NativeTypeName("#define MFRR_INFO_VERSION 0")]
        public const int MFRR_INFO_VERSION = 0;

        [NativeTypeName("#define MF_USER_MODE_COMPONENT_LOAD 0x00000001")]
        public const int MF_USER_MODE_COMPONENT_LOAD = 0x00000001;

        [NativeTypeName("#define MF_KERNEL_MODE_COMPONENT_LOAD 0x00000002")]
        public const int MF_KERNEL_MODE_COMPONENT_LOAD = 0x00000002;

        [NativeTypeName("#define MF_GRL_LOAD_FAILED 0x00000010")]
        public const int MF_GRL_LOAD_FAILED = 0x00000010;

        [NativeTypeName("#define MF_INVALID_GRL_SIGNATURE 0x00000020")]
        public const int MF_INVALID_GRL_SIGNATURE = 0x00000020;

        [NativeTypeName("#define MF_GRL_ABSENT 0x00001000")]
        public const int MF_GRL_ABSENT = 0x00001000;

        [NativeTypeName("#define MF_COMPONENT_REVOKED 0x00002000")]
        public const int MF_COMPONENT_REVOKED = 0x00002000;

        [NativeTypeName("#define MF_COMPONENT_INVALID_EKU 0x00004000")]
        public const int MF_COMPONENT_INVALID_EKU = 0x00004000;

        [NativeTypeName("#define MF_COMPONENT_CERT_REVOKED 0x00008000")]
        public const int MF_COMPONENT_CERT_REVOKED = 0x00008000;

        [NativeTypeName("#define MF_COMPONENT_INVALID_ROOT 0x00010000")]
        public const int MF_COMPONENT_INVALID_ROOT = 0x00010000;

        [NativeTypeName("#define MF_COMPONENT_HS_CERT_REVOKED 0x00020000")]
        public const int MF_COMPONENT_HS_CERT_REVOKED = 0x00020000;

        [NativeTypeName("#define MF_COMPONENT_LS_CERT_REVOKED 0x00040000")]
        public const int MF_COMPONENT_LS_CERT_REVOKED = 0x00040000;

        [NativeTypeName("#define MF_BOOT_DRIVER_VERIFICATION_FAILED 0x00100000")]
        public const int MF_BOOT_DRIVER_VERIFICATION_FAILED = 0x00100000;

        [NativeTypeName("#define MF_TEST_SIGNED_COMPONENT_LOADING 0x01000000")]
        public const int MF_TEST_SIGNED_COMPONENT_LOADING = 0x01000000;

        [NativeTypeName("#define MF_MINCRYPT_FAILURE 0x10000000")]
        public const int MF_MINCRYPT_FAILURE = 0x10000000;

        [NativeTypeName("#define SHA_HASH_LEN 20")]
        public const int SHA_HASH_LEN = 20;

        [NativeTypeName("#define STR_HASH_LEN (SHA_HASH_LEN*2 + 3)")]
        public const int STR_HASH_LEN = (20 * 2 + 3);

        [NativeTypeName("#define MFSEQUENCER_INVALID_ELEMENT_ID ( 0xffffffff )")]
        public const uint MFSEQUENCER_INVALID_ELEMENT_ID = (0xffffffff);

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_DIGITAL ((DWORD) 0x00000001)")]
        public const uint MFOUTPUTATTRIBUTE_DIGITAL = ((uint)(0x00000001));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_NONSTANDARDIMPLEMENTATION ((DWORD) 0x00000002)")]
        public const uint MFOUTPUTATTRIBUTE_NONSTANDARDIMPLEMENTATION = ((uint)(0x00000002));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_VIDEO ((DWORD) 0x00000004)")]
        public const uint MFOUTPUTATTRIBUTE_VIDEO = ((uint)(0x00000004));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_COMPRESSED ((DWORD) 0x00000008)")]
        public const uint MFOUTPUTATTRIBUTE_COMPRESSED = ((uint)(0x00000008));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_SOFTWARE ((DWORD) 0x00000010)")]
        public const uint MFOUTPUTATTRIBUTE_SOFTWARE = ((uint)(0x00000010));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_BUS ((DWORD) 0x00000020)")]
        public const uint MFOUTPUTATTRIBUTE_BUS = ((uint)(0x00000020));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_BUSIMPLEMENTATION ((DWORD) 0x0000FF00)")]
        public const uint MFOUTPUTATTRIBUTE_BUSIMPLEMENTATION = ((uint)(0x0000FF00));

        [NativeTypeName("#define MFCONTENTPROTECTIONDEVICE_FUNCTIONID_START 0x04000000")]
        public const int MFCONTENTPROTECTIONDEVICE_FUNCTIONID_START = 0x04000000;

        [NativeTypeName("#define MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA_FUNCTIONID MFCONTENTPROTECTIONDEVICE_FUNCTIONID_START")]
        public const int MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA_FUNCTIONID = 0x04000000;

        [NativeTypeName("#define MF_UNKNOWN_DURATION 0")]
        public const int MF_UNKNOWN_DURATION = 0;
    }
}
