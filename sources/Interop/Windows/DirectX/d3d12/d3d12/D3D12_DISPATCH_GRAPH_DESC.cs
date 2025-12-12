// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DISPATCH_GRAPH_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_GRAPH_DESC"]/*' />
public partial struct D3D12_DISPATCH_GRAPH_DESC
{
    /// <include file='D3D12_DISPATCH_GRAPH_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_GRAPH_DESC.Mode"]/*' />
    public D3D12_DISPATCH_MODE Mode;

    /// <include file='D3D12_DISPATCH_GRAPH_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_GRAPH_DESC.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12_L21997_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NodeCPUInput"]/*' />
    [UnscopedRef]
    public ref D3D12_NODE_CPU_INPUT NodeCPUInput
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.NodeCPUInput;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NodeGPUInput"]/*' />
    [UnscopedRef]
    public ref ulong NodeGPUInput
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.NodeGPUInput;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.MultiNodeCPUInput"]/*' />
    [UnscopedRef]
    public ref D3D12_MULTI_NODE_CPU_INPUT MultiNodeCPUInput
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.MultiNodeCPUInput;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.MultiNodeGPUInput"]/*' />
    [UnscopedRef]
    public ref ulong MultiNodeGPUInput
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.MultiNodeGPUInput;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NodeCPUInput"]/*' />
        [FieldOffset(0)]
        public D3D12_NODE_CPU_INPUT NodeCPUInput;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NodeGPUInput"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
        public ulong NodeGPUInput;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.MultiNodeCPUInput"]/*' />
        [FieldOffset(0)]
        public D3D12_MULTI_NODE_CPU_INPUT MultiNodeCPUInput;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.MultiNodeGPUInput"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
        public ulong MultiNodeGPUInput;
    }
}
