// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmp2dlna.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MPEG2DLNASink = new Guid(0xfa5fe7c5, 0x6a1d, 0x4b11, 0xb4, 0x1f, 0xf9, 0x59, 0xd6, 0xc7, 0x65, 0x00);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MP2DLNA_USE_MMCSS = new Guid(0x54f3e2ee, 0xa2a2, 0x497d, 0x98, 0x34, 0x97, 0x3a, 0xfd, 0xe5, 0x21, 0xeb);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MP2DLNA_VIDEO_BIT_RATE = new Guid(0xe88548de, 0x73b4, 0x42d7, 0x9c, 0x75, 0xad, 0xfa, 0xa, 0x2a, 0x6e, 0x4c);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MP2DLNA_AUDIO_BIT_RATE = new Guid(0x2d1c070e, 0x2b5f, 0x4ab3, 0xa7, 0xe6, 0x8d, 0x94, 0x3b, 0xa8, 0xd0, 0x0a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MP2DLNA_ENCODE_QUALITY = new Guid(0xb52379d7, 0x1d46, 0x4fb6, 0xa3, 0x17, 0xa4, 0xa5, 0xf6, 0x09, 0x59, 0xf8);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MP2DLNA_STATISTICS = new Guid(0x75e488a3, 0xd5ad, 0x4898, 0x85, 0xe0, 0xbc, 0xce, 0x24, 0xa7, 0x22, 0xd7);

        public static readonly Guid IID_IMFDLNASinkInit = new Guid(0x0C012799, 0x1B61, 0x4C10, 0xBD, 0xA9, 0x04, 0x44, 0x5B, 0xE5, 0xF5, 0x61);
    }
}
