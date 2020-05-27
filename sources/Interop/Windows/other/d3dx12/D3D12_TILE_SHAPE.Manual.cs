// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_TILE_SHAPE
    {
        public D3D12_TILE_SHAPE([NativeTypeName("UINT")] uint widthInTexels, [NativeTypeName("UINT")] uint heightInTexels, [NativeTypeName("UINT")] uint depthInTexels)
        {
            WidthInTexels = widthInTexels;
            HeightInTexels = heightInTexels;
            DepthInTexels = depthInTexels;
        }
    }
}
