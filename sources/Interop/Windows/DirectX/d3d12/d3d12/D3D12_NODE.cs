// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_NODE.xml' path='doc/member[@name="D3D12_NODE"]/*' />
public partial struct D3D12_NODE
{
    /// <include file='D3D12_NODE.xml' path='doc/member[@name="D3D12_NODE.NodeType"]/*' />
    public D3D12_NODE_TYPE NodeType;

    /// <include file='D3D12_NODE.xml' path='doc/member[@name="D3D12_NODE.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12_L15213_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Shader"]/*' />
    [UnscopedRef]
    public ref D3D12_SHADER_NODE Shader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Shader;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Shader"]/*' />
        [FieldOffset(0)]
        public D3D12_SHADER_NODE Shader;
    }
}
