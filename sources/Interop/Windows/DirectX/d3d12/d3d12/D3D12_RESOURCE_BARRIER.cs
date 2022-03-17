// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RESOURCE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER"]/*' />
public partial struct D3D12_RESOURCE_BARRIER
{
    /// <include file='D3D12_RESOURCE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER.Type"]/*' />
    public D3D12_RESOURCE_BARRIER_TYPE Type;

    /// <include file='D3D12_RESOURCE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER.Flags"]/*' />
    public D3D12_RESOURCE_BARRIER_FLAGS Flags;

    /// <include file='D3D12_RESOURCE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER.Anonymous"]/*' />
    [NativeTypeName("D3D12_RESOURCE_BARRIER::(anonymous union at ./d3d12.h:2907:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Transition"]/*' />
    public ref D3D12_RESOURCE_TRANSITION_BARRIER Transition
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Transition, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Aliasing"]/*' />
    public ref D3D12_RESOURCE_ALIASING_BARRIER Aliasing
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Aliasing, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UAV"]/*' />
    public ref D3D12_RESOURCE_UAV_BARRIER UAV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.UAV, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Transition"]/*' />
        [FieldOffset(0)]
        public D3D12_RESOURCE_TRANSITION_BARRIER Transition;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Aliasing"]/*' />
        [FieldOffset(0)]
        public D3D12_RESOURCE_ALIASING_BARRIER Aliasing;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UAV"]/*' />
        [FieldOffset(0)]
        public D3D12_RESOURCE_UAV_BARRIER UAV;
    }
}
