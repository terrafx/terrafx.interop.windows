// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_STREAM_OUTPUT_DESC
    {
        [NativeTypeName("D3D12_SO_DECLARATION_ENTRY[]")]
        public D3D12_SO_DECLARATION_ENTRY* pSODeclaration;

        [NativeTypeName("UINT")]
        public uint NumEntries;

        [NativeTypeName("UINT[]")]
        public uint* pBufferStrides;

        [NativeTypeName("UINT")]
        public uint NumStrides;

        [NativeTypeName("UINT")]
        public uint RasterizedStream;
    }
}
