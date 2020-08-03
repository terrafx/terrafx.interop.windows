// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const IID")]
        public static readonly Guid MF_MSE_CALLBACK = new Guid(0x9063a7c0, 0x42c5, 0x4ffd, 0xa8, 0xa8, 0x6f, 0xcf, 0x9e, 0xa3, 0xd0, 0x0c);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MSE_ACTIVELIST_CALLBACK = new Guid(0x949bda0f, 0x4549, 0x46d5, 0xad, 0x7f, 0xb8, 0x46, 0xe1, 0xab, 0x16, 0x52);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MSE_BUFFERLIST_CALLBACK = new Guid(0x42e669b0, 0xd60e, 0x4afb, 0xa8, 0x5b, 0xd8, 0xe5, 0xfe, 0x6b, 0xda, 0xb5);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MSE_VP9_SUPPORT = new Guid(0x92d78429, 0xd88b, 0x4ff0, 0x83, 0x22, 0x80, 0x3e, 0xfa, 0x6e, 0x96, 0x26);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MSE_OPUS_SUPPORT = new Guid(0x4d224cc1, 0x8cc4, 0x48a3, 0xa7, 0xa7, 0xe4, 0xc1, 0x6c, 0xe6, 0x38, 0x8a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_NEEDKEY_CALLBACK = new Guid(0x7ea80843, 0xb6e4, 0x432c, 0x8e, 0xa4, 0x78, 0x48, 0xff, 0xe4, 0x22, 0x0e);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_CALLBACK = new Guid(0xc60381b8, 0x83a4, 0x41f8, 0xa3, 0xd0, 0xde, 0x05, 0x07, 0x68, 0x49, 0xa9);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_DXGI_MANAGER = new Guid(0x065702da, 0x1094, 0x486d, 0x86, 0x17, 0xee, 0x7c, 0xc4, 0xee, 0x46, 0x48);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_EXTENSION = new Guid(0x3109fd46, 0x060d, 0x4b62, 0x8d, 0xcf, 0xfa, 0xff, 0x81, 0x13, 0x18, 0xd2);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_PLAYBACK_HWND = new Guid(0xd988879b, 0x67c9, 0x4d92, 0xba, 0xa7, 0x6e, 0xad, 0xd4, 0x46, 0x03, 0x9d);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_OPM_HWND = new Guid(0xa0be8ee7, 0x0572, 0x4f2c, 0xa8, 0x01, 0x2a, 0x15, 0x1b, 0xd3, 0xe7, 0x26);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_PLAYBACK_VISUAL = new Guid(0x6debd26f, 0x6ab9, 0x4d7e, 0xb0, 0xee, 0xc6, 0x1a, 0x73, 0xff, 0xad, 0x15);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_COREWINDOW = new Guid(0xfccae4dc, 0x0b7f, 0x41c2, 0x9f, 0x96, 0x46, 0x59, 0x94, 0x8a, 0xcd, 0xdc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_VIDEO_OUTPUT_FORMAT = new Guid(0x5066893c, 0x8cf9, 0x42bc, 0x8b, 0x8a, 0x47, 0x22, 0x12, 0xe5, 0x27, 0x26);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_CONTENT_PROTECTION_FLAGS = new Guid(0xe0350223, 0x5aaf, 0x4d76, 0xa7, 0xc3, 0x06, 0xde, 0x70, 0x89, 0x4d, 0xb4);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_CONTENT_PROTECTION_MANAGER = new Guid(0xfdd6dfaa, 0xbd85, 0x4af3, 0x9e, 0x0f, 0xa0, 0x1d, 0x53, 0x9d, 0x87, 0x6a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_AUDIO_ENDPOINT_ROLE = new Guid(0xd2cb93d1, 0x116a, 0x44f2, 0x93, 0x85, 0xf7, 0xd0, 0xfd, 0xa2, 0xfb, 0x46);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_AUDIO_CATEGORY = new Guid(0xc8d4c51d, 0x350e, 0x41f2, 0xba, 0x46, 0xfa, 0xeb, 0xbb, 0x08, 0x57, 0xf6);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_STREAM_CONTAINS_ALPHA_CHANNEL = new Guid(0x5cbfaf44, 0xd2b2, 0x4cfb, 0x80, 0xa7, 0xd4, 0x29, 0xc7, 0x4c, 0x78, 0x9d);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE = new Guid(0x4e0212e2, 0xe18f, 0x41e1, 0x95, 0xe5, 0xc0, 0xe7, 0xe9, 0x23, 0x5b, 0xc3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE9 = new Guid(0x052c2d39, 0x40c0, 0x4188, 0xab, 0x86, 0xf8, 0x28, 0x27, 0x3b, 0x75, 0x22);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE10 = new Guid(0x11a47afd, 0x6589, 0x4124, 0xb3, 0x12, 0x61, 0x58, 0xec, 0x51, 0x7f, 0xc3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE11 = new Guid(0x1cf1315f, 0xce3f, 0x4035, 0x93, 0x91, 0x16, 0x14, 0x2f, 0x77, 0x51, 0x89);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE_EDGE = new Guid(0xa6f3e465, 0x3aca, 0x442c, 0xa3, 0xf0, 0xad, 0x6d, 0xda, 0xd8, 0x39, 0xae);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_COMPATIBILITY_MODE = new Guid(0x3ef26ad4, 0xdc54, 0x45de, 0xb9, 0xaf, 0x76, 0xc8, 0xc6, 0x6b, 0xfa, 0x8e);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_COMPATIBILITY_MODE_WWA_EDGE = new Guid(0x15b29098, 0x9f01, 0x4e4d, 0xb6, 0x5a, 0xc0, 0x6c, 0x6c, 0x89, 0xda, 0x2a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_COMPATIBILITY_MODE_WIN10 = new Guid(0x5b25e089, 0x6ca7, 0x4139, 0xa2, 0xcb, 0xfc, 0xaa, 0xb3, 0x95, 0x52, 0xa3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_SOURCE_RESOLVER_CONFIG_STORE = new Guid(0x0ac0c497, 0xb3c4, 0x48c9, 0x9c, 0xde, 0xbb, 0x8c, 0xa2, 0x44, 0x2c, 0xa3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_TRACK_ID = new Guid(0x65bea312, 0x4043, 0x4815, 0x8e, 0xab, 0x44, 0xdc, 0xe2, 0xef, 0x8f, 0x2a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_TELEMETRY_APPLICATION_ID = new Guid(0x1e7b273b, 0xa7e4, 0x402a, 0x8f, 0x51, 0xc4, 0x8e, 0x88, 0xa2, 0xca, 0xbc);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_SYNCHRONOUS_CLOSE = new Guid(0xc3c2e12f, 0x7e0e, 0x4e43, 0xb9, 0x1c, 0xdc, 0x99, 0x2c, 0xcd, 0xfa, 0x5e);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_MEDIA_PLAYER_MODE = new Guid(0x3ddd8d45, 0x5aa1, 0x4112, 0x82, 0xe5, 0x36, 0xf6, 0xa2, 0x19, 0x7e, 0x6e);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MFMediaEngineClassFactory = new Guid(0xb44392da, 0x499b, 0x446b, 0xa4, 0xcb, 0x0, 0x5f, 0xea, 0xd0, 0xe6, 0xd5);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_TIMEDTEXT = new Guid(0x805ea411, 0x92e0, 0x4e59, 0x9b, 0x6e, 0x5c, 0x7d, 0x79, 0x15, 0xe6, 0x4f);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_CONTINUE_ON_CODEC_ERROR = new Guid(0xdbcdb7f9, 0x48e4, 0x4295, 0xb7, 0x0d, 0xd5, 0x18, 0x23, 0x4e, 0xeb, 0x38);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIA_ENGINE_EME_CALLBACK = new Guid(0x494553a7, 0xa481, 0x4cb7, 0xbe, 0xc5, 0x38, 0x09, 0x03, 0x51, 0x37, 0x31);

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_INITDATATYPES = new PROPERTYKEY
        {
            fmtid = new Guid(0x497d231b, 0x4eb9, 0x4df0, 0xb4, 0x74, 0xb9, 0xaf, 0xeb, 0x0a, 0xdf, 0x38),
            pid = (0x2) + 0x00000001,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_DISTINCTIVEID = new PROPERTYKEY
        {
            fmtid = new Guid(0x7dc9c4a5, 0x12be, 0x497e, 0x8b, 0xff, 0x9b, 0x60, 0xb2, 0xdc, 0x58, 0x45),
            pid = (0x2) + 0x00000002,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_PERSISTEDSTATE = new PROPERTYKEY
        {
            fmtid = new Guid(0x5d4df6ae, 0x9af1, 0x4e3d, 0x95, 0x5b, 0x0e, 0x4b, 0xd2, 0x2f, 0xed, 0xf0),
            pid = (0x2) + 0x00000003,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_AUDIOCAPABILITIES = new PROPERTYKEY
        {
            fmtid = new Guid(0x980fbb84, 0x297d, 0x4ea7, 0x89, 0x5f, 0xbc, 0xf2, 0x8a, 0x46, 0x28, 0x81),
            pid = (0x2) + 0x00000004,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_VIDEOCAPABILITIES = new PROPERTYKEY
        {
            fmtid = new Guid(0xb172f83d, 0x30dd, 0x4c10, 0x80, 0x06, 0xed, 0x53, 0xda, 0x4d, 0x3b, 0xdb),
            pid = (0x2) + 0x00000005,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_LABEL = new PROPERTYKEY
        {
            fmtid = new Guid(0x9eae270e, 0xb2d7, 0x4817, 0xb8, 0x8f, 0x54, 0x00, 0x99, 0xf2, 0xef, 0x4e),
            pid = (0x2) + 0x00000006,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_SESSIONTYPES = new PROPERTYKEY
        {
            fmtid = new Guid(0x7623384f, 0x00f5, 0x4376, 0x86, 0x98, 0x34, 0x58, 0xdb, 0x03, 0x0e, 0xd5),
            pid = (0x2) + 0x00000007,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_ROBUSTNESS = new PROPERTYKEY
        {
            fmtid = new Guid(0x9d3d2b9e, 0x7023, 0x4944, 0xa8, 0xf5, 0xec, 0xca, 0x52, 0xa4, 0x69, 0x90),
            pid = (0x2) + 0x00000001,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_CONTENTTYPE = new PROPERTYKEY
        {
            fmtid = new Guid(0x289fb1fc, 0xd9c4, 0x4cc7, 0xb2, 0xbe, 0x97, 0x2b, 0x0e, 0x9b, 0x28, 0x3a),
            pid = (0x2) + 0x00000002,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_CDM_INPRIVATESTOREPATH = new PROPERTYKEY
        {
            fmtid = new Guid(0xec305fd9, 0x039f, 0x4ac8, 0x98, 0xda, 0xe7, 0x92, 0x1e, 0x00, 0x6a, 0x90),
            pid = (0x2) + 0x00000001,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_EME_CDM_STOREPATH = new PROPERTYKEY
        {
            fmtid = new Guid(0xf795841e, 0x99f9, 0x44d7, 0xaf, 0xc0, 0xd3, 0x09, 0xc0, 0x4c, 0x94, 0xab),
            pid = (0x2) + 0x00000002,
        };

        [NativeTypeName("#define MF_INVALID_PRESENTATION_TIME 0x8000000000000000")]
        public const ulong MF_INVALID_PRESENTATION_TIME = 0x8000000000000000;
    }
}
