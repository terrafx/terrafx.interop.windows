// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_VIDEO_DECODER_EXTENSION
    {
        [NativeTypeName("UINT")]
        public uint Function;

        [NativeTypeName("void *")]
        public void* pPrivateInputData;

        [NativeTypeName("UINT")]
        public uint PrivateInputDataSize;

        [NativeTypeName("void *")]
        public void* pPrivateOutputData;

        [NativeTypeName("UINT")]
        public uint PrivateOutputDataSize;

        [NativeTypeName("UINT")]
        public uint ResourceCount;

        [NativeTypeName("ID3D11Resource **")]
        public ID3D11Resource** ppResourceList;
    }
}
