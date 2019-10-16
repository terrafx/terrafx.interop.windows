// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_VIDEO_DECODER_BUFFER_DESC
    {
        public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;

        [NativeTypeName("UINT")]
        public uint BufferIndex;

        [NativeTypeName("UINT")]
        public uint DataOffset;

        [NativeTypeName("UINT")]
        public uint DataSize;

        [NativeTypeName("UINT")]
        public uint FirstMBaddress;

        [NativeTypeName("UINT")]
        public uint NumMBsInBuffer;

        [NativeTypeName("UINT")]
        public uint Width;

        [NativeTypeName("UINT")]
        public uint Height;

        [NativeTypeName("UINT")]
        public uint Stride;

        [NativeTypeName("UINT")]
        public uint ReservedBits;

        [NativeTypeName("void *")]
        public void* pIV;

        [NativeTypeName("UINT")]
        public uint IVSize;

        [NativeTypeName("BOOL")]
        public int PartialEncryption;

        public D3D11_ENCRYPTED_BLOCK_INFO EncryptedBlockInfo;
    }
}
