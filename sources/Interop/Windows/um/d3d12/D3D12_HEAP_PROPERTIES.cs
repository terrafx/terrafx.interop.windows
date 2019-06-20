// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;
using static TerraFX.Interop.D3D12_CPU_PAGE_PROPERTY;
using static TerraFX.Interop.D3D12_HEAP_TYPE;
using static TerraFX.Interop.D3D12_MEMORY_POOL;
using static TerraFX.Utilities.HashUtilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_HEAP_PROPERTIES
    {
        #region Fields
        public D3D12_HEAP_TYPE Type;

        public D3D12_CPU_PAGE_PROPERTY CPUPageProperty;

        public D3D12_MEMORY_POOL MemoryPoolPreference;

        [NativeTypeName("UINT")]
        public uint CreationNodeMask;

        [NativeTypeName("UINT")]
        public uint VisibleNodeMask;
        #endregion

        #region Constructors
        public D3D12_HEAP_PROPERTIES(D3D12_CPU_PAGE_PROPERTY cpuPageProperty, D3D12_MEMORY_POOL memoryPoolPreference, uint creationNodeMask = 1, uint nodeMask = 1)
        {
            Type = D3D12_HEAP_TYPE_CUSTOM;
            CPUPageProperty = cpuPageProperty;
            MemoryPoolPreference = memoryPoolPreference;
            CreationNodeMask = creationNodeMask;
            VisibleNodeMask = nodeMask;
        }

        public D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE type, uint creationNodeMask = 1, uint nodeMask = 1)
        {
            Type = type;
            CPUPageProperty = D3D12_CPU_PAGE_PROPERTY_UNKNOWN;
            MemoryPoolPreference = D3D12_MEMORY_POOL_UNKNOWN;
            CreationNodeMask = creationNodeMask;
            VisibleNodeMask = nodeMask;
        }
        #endregion

        #region Properties
        public bool IsCPUAccessible
        {
            get
            {
                return (Type == D3D12_HEAP_TYPE_UPLOAD) || (Type == D3D12_HEAP_TYPE_READBACK) || ((Type == D3D12_HEAP_TYPE_CUSTOM) && ((CPUPageProperty == D3D12_CPU_PAGE_PROPERTY_WRITE_COMBINE) || (CPUPageProperty == D3D12_CPU_PAGE_PROPERTY_WRITE_BACK)));
            }
        }
        #endregion

        #region Operators
        public static bool operator ==(D3D12_HEAP_PROPERTIES l, D3D12_HEAP_PROPERTIES r)
        {
            return (l.Type == r.Type)
                && (l.CPUPageProperty == r.CPUPageProperty)
                && (l.MemoryPoolPreference == r.MemoryPoolPreference)
                && (l.CreationNodeMask == r.CreationNodeMask)
                && (l.VisibleNodeMask == r.VisibleNodeMask);
        }

        public static bool operator !=(D3D12_HEAP_PROPERTIES l, D3D12_HEAP_PROPERTIES r)
        {
            return !(l == r);
        }
        #endregion

        #region System.Object
        public override bool Equals(object obj)
        {
            return (obj is D3D12_HEAP_PROPERTIES other) && (this == other);
        }

        public override int GetHashCode()
        {
            var combinedValue = 0;
            {
                combinedValue = CombineValue(Type.GetHashCode(), combinedValue);
                combinedValue = CombineValue(CPUPageProperty.GetHashCode(), combinedValue);
                combinedValue = CombineValue(MemoryPoolPreference.GetHashCode(), combinedValue);
                combinedValue = CombineValue(CreationNodeMask.GetHashCode(), combinedValue);
                combinedValue = CombineValue(VisibleNodeMask.GetHashCode(), combinedValue);
            }
            return FinalizeValue(combinedValue, SizeOf<D3D12_HEAP_PROPERTIES>());
        }
        #endregion
    }
}
