// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS
    {
        [NativeTypeName("UINT")]
        public uint IndexCountPerInstance;

        [NativeTypeName("UINT")]
        public uint InstanceCount;

        [NativeTypeName("UINT")]
        public uint StartIndexLocation;

        [NativeTypeName("INT")]
        public int BaseVertexLocation;

        [NativeTypeName("UINT")]
        public uint StartInstanceLocation;
    }
}
