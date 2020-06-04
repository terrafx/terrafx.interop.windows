// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_TILED_RESOURCE_COORDINATE
    {
        public D3D12_TILED_RESOURCE_COORDINATE([NativeTypeName("UINT")] uint x, [NativeTypeName("UINT")] uint y, [NativeTypeName("UINT")] uint z, [NativeTypeName("UINT")] uint subresource)
        {
            X = x;
            Y = y;
            Z = z;
            Subresource = subresource;
        }
    }
}
