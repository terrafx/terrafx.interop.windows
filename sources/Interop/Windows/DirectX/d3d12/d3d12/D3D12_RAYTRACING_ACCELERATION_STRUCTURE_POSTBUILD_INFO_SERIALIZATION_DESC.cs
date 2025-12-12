// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION_DESC"]/*' />
public partial struct D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION_DESC
{
    /// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION_DESC.SerializedSizeInBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong SerializedSizeInBytes;

    /// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION_DESC.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12_L15466_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumBottomLevelAccelerationStructurePointers"]/*' />
    [UnscopedRef]
    public ref ulong NumBottomLevelAccelerationStructurePointers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.NumBottomLevelAccelerationStructurePointers;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumBottomLevelAccelerationStructureHeaderAndPointerListPairs"]/*' />
    [UnscopedRef]
    public ref ulong NumBottomLevelAccelerationStructureHeaderAndPointerListPairs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.NumBottomLevelAccelerationStructureHeaderAndPointerListPairs;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumBottomLevelAccelerationStructurePointers"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT64")]
        public ulong NumBottomLevelAccelerationStructurePointers;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumBottomLevelAccelerationStructureHeaderAndPointerListPairs"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT64")]
        public ulong NumBottomLevelAccelerationStructureHeaderAndPointerListPairs;
    }
}
