// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_SUBRESOURCE_RANGE_UINT64
    {
        public D3D12_SUBRESOURCE_RANGE_UINT64([NativeTypeName("UINT")] uint subresource, [NativeTypeName("const D3D12_RANGE_UINT64 &")] D3D12_RANGE_UINT64* range)
        {
            Subresource = subresource;
            Range = *range;
        }

        public D3D12_SUBRESOURCE_RANGE_UINT64([NativeTypeName("UINT")] uint subresource, [NativeTypeName("UINT64")] ulong begin, [NativeTypeName("UINT64")] ulong end)
        {
            Subresource = subresource;
            Range.Begin = begin;
            Range.End = end;
        }
    }
}
