// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1"]/*' />
public partial struct D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1
{
    /// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1.DriverMatchingIdentifier"]/*' />
    public D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER DriverMatchingIdentifier;

    /// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1.SerializedSizeInBytesIncludingHeader"]/*' />
    [NativeTypeName("UINT64")]
    public ulong SerializedSizeInBytesIncludingHeader;

    /// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1.DeserializedSizeInBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong DeserializedSizeInBytes;

    /// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12_L15517_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1.HeaderPostambleType"]/*' />
    public D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER_POSTAMBLE_TYPE HeaderPostambleType;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumBottomLevelAccelerationStructurePointersAfterHeader"]/*' />
    [UnscopedRef]
    public ref uint NumBottomLevelAccelerationStructurePointersAfterHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.NumBottomLevelAccelerationStructurePointersAfterHeader;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumBlocks"]/*' />
    [UnscopedRef]
    public ref uint NumBlocks
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.NumBlocks;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumBottomLevelAccelerationStructurePointersAfterHeader"]/*' />
        [FieldOffset(0)]
        public uint NumBottomLevelAccelerationStructurePointersAfterHeader;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumBlocks"]/*' />
        [FieldOffset(0)]
        public uint NumBlocks;
    }
}
