// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_CLEAR_VALUE.xml' path='doc/member[@name="D3D12_CLEAR_VALUE"]/*' />
public unsafe partial struct D3D12_CLEAR_VALUE
{
    /// <include file='D3D12_CLEAR_VALUE.xml' path='doc/member[@name="D3D12_CLEAR_VALUE.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_CLEAR_VALUE.xml' path='doc/member[@name="D3D12_CLEAR_VALUE.Anonymous"]/*' />
    [NativeTypeName("D3D12_CLEAR_VALUE::(anonymous union at ./d3d12.h:2734:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Color"]/*' />
    public Span<float> Color
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.Color[0], 4);
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DepthStencil"]/*' />
    public ref D3D12_DEPTH_STENCIL_VALUE DepthStencil
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.DepthStencil, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Color"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("FLOAT[4]")]
        public fixed float Color[4];

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DepthStencil"]/*' />
        [FieldOffset(0)]
        public D3D12_DEPTH_STENCIL_VALUE DepthStencil;
    }
}
