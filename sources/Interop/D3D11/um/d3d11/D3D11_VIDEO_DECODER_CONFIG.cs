// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D3D11_VIDEO_DECODER_CONFIG
    {
        [NativeTypeName("GUID")]
        public Guid guidConfigBitstreamEncryption;

        [NativeTypeName("GUID")]
        public Guid guidConfigMBcontrolEncryption;

        [NativeTypeName("GUID")]
        public Guid guidConfigResidDiffEncryption;

        [NativeTypeName("UINT")]
        public uint ConfigBitstreamRaw;

        [NativeTypeName("UINT")]
        public uint ConfigMBcontrolRasterOrder;

        [NativeTypeName("UINT")]
        public uint ConfigResidDiffHost;

        [NativeTypeName("UINT")]
        public uint ConfigSpatialResid8;

        [NativeTypeName("UINT")]
        public uint ConfigResid8Subtraction;

        [NativeTypeName("UINT")]
        public uint ConfigSpatialHost8or9Clipping;

        [NativeTypeName("UINT")]
        public uint ConfigSpatialResidInterleaved;

        [NativeTypeName("UINT")]
        public uint ConfigIntraResidUnsigned;

        [NativeTypeName("UINT")]
        public uint ConfigResidDiffAccelerator;

        [NativeTypeName("UINT")]
        public uint ConfigHostInverseScan;

        [NativeTypeName("UINT")]
        public uint ConfigSpecificIDCT;

        [NativeTypeName("UINT")]
        public uint Config4GroupedCoefs;

        [NativeTypeName("USHORT")]
        public ushort ConfigMinRenderTargetBuffCount;

        [NativeTypeName("USHORT")]
        public ushort ConfigDecoderSpecific;
    }
}
