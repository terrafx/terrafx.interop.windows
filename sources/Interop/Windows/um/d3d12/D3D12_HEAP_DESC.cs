// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.D3D12_HEAP_FLAGS;

namespace TerraFX.Interop
{
    public unsafe struct D3D12_HEAP_DESC
    {
        [NativeTypeName("UINT64")]
        public ulong SizeInBytes;

        public D3D12_HEAP_PROPERTIES Properties;

        [NativeTypeName("UINT64")]
        public ulong Alignment;

        public D3D12_HEAP_FLAGS Flags;

        public D3D12_HEAP_DESC(ulong size, D3D12_HEAP_PROPERTIES properties, ulong alignment = 0, D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
        {
            SizeInBytes = size;
            Properties = properties;
            Alignment = alignment;
            Flags = flags;
        }

        public D3D12_HEAP_DESC(ulong size, D3D12_HEAP_TYPE type, ulong alignment = 0, D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
        {
            SizeInBytes = size;
            Properties = new D3D12_HEAP_PROPERTIES(type);
            Alignment = alignment;
            Flags = flags;
        }

        public D3D12_HEAP_DESC(ulong size, D3D12_CPU_PAGE_PROPERTY cpuPageProperty, D3D12_MEMORY_POOL memoryPoolPreference, ulong alignment = 0, D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
        {
            SizeInBytes = size;
            Properties = new D3D12_HEAP_PROPERTIES(cpuPageProperty, memoryPoolPreference);
            Alignment = alignment;
            Flags = flags;
        }

        public D3D12_HEAP_DESC(D3D12_RESOURCE_ALLOCATION_INFO* resAllocInfo, D3D12_HEAP_PROPERTIES properties, D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE )
        {
            SizeInBytes = resAllocInfo->SizeInBytes;
            Properties = properties;
            Alignment = resAllocInfo->Alignment;
            Flags = flags;
        }

        public D3D12_HEAP_DESC(D3D12_RESOURCE_ALLOCATION_INFO* resAllocInfo, D3D12_HEAP_TYPE type, D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
        {
            SizeInBytes = resAllocInfo->SizeInBytes;
            Properties = new D3D12_HEAP_PROPERTIES(type);
            Alignment = resAllocInfo->Alignment;
            Flags = flags;
        }

        public D3D12_HEAP_DESC(D3D12_RESOURCE_ALLOCATION_INFO* resAllocInfo, D3D12_CPU_PAGE_PROPERTY cpuPageProperty, D3D12_MEMORY_POOL memoryPoolPreference, D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
        {
            SizeInBytes = resAllocInfo->SizeInBytes;
            Properties = new D3D12_HEAP_PROPERTIES(cpuPageProperty, memoryPoolPreference);
            Alignment = resAllocInfo->Alignment;
            Flags = flags;
        }

        public bool IsCPUAccessible
        {
            get
            {
                return Properties.IsCPUAccessible;
            }
        }

        public static bool operator ==(D3D12_HEAP_DESC l, D3D12_HEAP_DESC r)
        {
            return (l.SizeInBytes == r.SizeInBytes)
                && (l.Properties == r.Properties)
                && (l.Alignment == r.Alignment)
                && (l.Flags == r.Flags);
        }

        public static bool operator !=(D3D12_HEAP_DESC l, D3D12_HEAP_DESC r)
        {
            return !(l == r);
        }

        public override bool Equals(object? obj)
        {
            return (obj is D3D12_HEAP_DESC other) && (this == other);
        }

        public override int GetHashCode() => HashCode.Combine(
            SizeInBytes,
            Properties,
            Alignment,
            Flags
        );
    }
}
