// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D11_VIDEO_DECODER_BUFFER_DESC2
{
    public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;

    public uint DataOffset;

    public uint DataSize;

    public void* pIV;

    public uint IVSize;

    public D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK* pSubSampleMappingBlock;

    public uint SubSampleMappingCount;

    public uint cBlocksStripeEncrypted;

    public uint cBlocksStripeClear;
}
