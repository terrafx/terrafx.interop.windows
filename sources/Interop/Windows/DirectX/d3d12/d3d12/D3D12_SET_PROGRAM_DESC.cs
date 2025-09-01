// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SET_PROGRAM_DESC.xml' path='doc/member[@name="D3D12_SET_PROGRAM_DESC"]/*' />
public partial struct D3D12_SET_PROGRAM_DESC
{
    /// <include file='D3D12_SET_PROGRAM_DESC.xml' path='doc/member[@name="D3D12_SET_PROGRAM_DESC.Type"]/*' />
    public D3D12_PROGRAM_TYPE Type;

    /// <include file='D3D12_SET_PROGRAM_DESC.xml' path='doc/member[@name="D3D12_SET_PROGRAM_DESC.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12_L20978_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.GenericPipeline"]/*' />
    [UnscopedRef]
    public ref D3D12_SET_GENERIC_PIPELINE_DESC GenericPipeline
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.GenericPipeline;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RaytracingPipeline"]/*' />
    [UnscopedRef]
    public ref D3D12_SET_RAYTRACING_PIPELINE_DESC RaytracingPipeline
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.RaytracingPipeline;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.WorkGraph"]/*' />
    [UnscopedRef]
    public ref D3D12_SET_WORK_GRAPH_DESC WorkGraph
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.WorkGraph;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.GenericPipeline"]/*' />
        [FieldOffset(0)]
        public D3D12_SET_GENERIC_PIPELINE_DESC GenericPipeline;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RaytracingPipeline"]/*' />
        [FieldOffset(0)]
        public D3D12_SET_RAYTRACING_PIPELINE_DESC RaytracingPipeline;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.WorkGraph"]/*' />
        [FieldOffset(0)]
        public D3D12_SET_WORK_GRAPH_DESC WorkGraph;
    }
}
