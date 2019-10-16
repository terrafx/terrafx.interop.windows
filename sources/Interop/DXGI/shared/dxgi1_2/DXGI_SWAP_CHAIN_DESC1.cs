// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DXGI_SWAP_CHAIN_DESC1
    {
        [NativeTypeName("UINT")]
        public uint Width;

        [NativeTypeName("UINT")]
        public uint Height;

        public DXGI_FORMAT Format;

        [NativeTypeName("BOOL")]
        public int Stereo;

        public DXGI_SAMPLE_DESC SampleDesc;

        [NativeTypeName("DXGI_USAGE")]
        public uint BufferUsage;

        [NativeTypeName("UINT")]
        public uint BufferCount;

        public DXGI_SCALING Scaling;

        public DXGI_SWAP_EFFECT SwapEffect;

        public DXGI_ALPHA_MODE AlphaMode;

        [NativeTypeName("UINT")]
        public uint Flags;
    }
}
