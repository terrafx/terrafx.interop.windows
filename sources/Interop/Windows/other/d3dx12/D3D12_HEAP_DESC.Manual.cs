// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.D3D12_HEAP_FLAGS;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_HEAP_DESC : IEquatable<D3D12_HEAP_DESC>
    {
        public D3D12_HEAP_DESC([NativeTypeName("UINT64")] ulong size, D3D12_HEAP_PROPERTIES properties, [NativeTypeName("UINT64")] ulong alignment = 0, D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
        {
            SizeInBytes = size;
            Properties = properties;
            Alignment = alignment;
            Flags = flags;
        }

        public D3D12_HEAP_DESC([NativeTypeName("UINT64")] ulong size, D3D12_HEAP_TYPE type, [NativeTypeName("UINT64")] ulong alignment = 0, D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
        {
            SizeInBytes = size;
            Properties = new D3D12_HEAP_PROPERTIES(type);
            Alignment = alignment;
            Flags = flags;
        }

        public D3D12_HEAP_DESC([NativeTypeName("UINT64")] ulong size, D3D12_CPU_PAGE_PROPERTY cpuPageProperty, D3D12_MEMORY_POOL memoryPoolPreference, [NativeTypeName("UINT64")] ulong alignment = 0, D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
        {
            SizeInBytes = size;
            Properties = new D3D12_HEAP_PROPERTIES(cpuPageProperty, memoryPoolPreference);
            Alignment = alignment;
            Flags = flags;
        }

        public D3D12_HEAP_DESC([NativeTypeName("const D3D12_RESOURCE_ALLOCATION_INFO &")] in D3D12_RESOURCE_ALLOCATION_INFO resAllocInfo, D3D12_HEAP_PROPERTIES properties, D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
        {
            SizeInBytes = resAllocInfo.SizeInBytes;
            Properties = properties;
            Alignment = resAllocInfo.Alignment;
            Flags = flags;
        }

        public D3D12_HEAP_DESC([NativeTypeName("const D3D12_RESOURCE_ALLOCATION_INFO &")] in D3D12_RESOURCE_ALLOCATION_INFO resAllocInfo, D3D12_HEAP_TYPE type, D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
        {
            SizeInBytes = resAllocInfo.SizeInBytes;
            Properties = new D3D12_HEAP_PROPERTIES(type);
            Alignment = resAllocInfo.Alignment;
            Flags = flags;
        }

        public D3D12_HEAP_DESC([NativeTypeName("const D3D12_RESOURCE_ALLOCATION_INFO &")] in D3D12_RESOURCE_ALLOCATION_INFO resAllocInfo, D3D12_CPU_PAGE_PROPERTY cpuPageProperty, D3D12_MEMORY_POOL memoryPoolPreference, D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
        {
            SizeInBytes = resAllocInfo.SizeInBytes;
            Properties = new D3D12_HEAP_PROPERTIES(cpuPageProperty, memoryPoolPreference);
            Alignment = resAllocInfo.Alignment;
            Flags = flags;
        }

        public bool IsCPUAccessible
        {
            get
            {
                return Properties.IsCPUAccessible;
            }
        }

        public static bool operator ==([NativeTypeName("const D3D12_HEAP_DESC &")] in D3D12_HEAP_DESC l, [NativeTypeName("const D3D12_HEAP_DESC &")] in D3D12_HEAP_DESC r)
        {
            return l.SizeInBytes == r.SizeInBytes && l.Properties == r.Properties && l.Alignment == r.Alignment && l.Flags == r.Flags;
        }

        public static bool operator !=([NativeTypeName("const D3D12_HEAP_DESC &")] in D3D12_HEAP_DESC l, [NativeTypeName("const D3D12_HEAP_DESC &")] in D3D12_HEAP_DESC r)
        {
            return !(l == r);
        }

        public override bool Equals(object? obj) => (obj is D3D12_HEAP_DESC other) && Equals(other);

        public bool Equals(D3D12_HEAP_DESC other) => this == other;

        public override int GetHashCode() => HashCode.Combine(SizeInBytes, Properties, Alignment, Flags);
    }
}
