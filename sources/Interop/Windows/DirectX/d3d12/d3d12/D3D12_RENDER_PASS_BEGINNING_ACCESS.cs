// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS"]/*' />
public partial struct D3D12_RENDER_PASS_BEGINNING_ACCESS
{
    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS.Type"]/*' />
    public D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE Type;

    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS.Anonymous"]/*' />
    [NativeTypeName("D3D12_RENDER_PASS_BEGINNING_ACCESS::(anonymous union at ./d3d12.h:18845:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Clear"]/*' />
    public ref D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS Clear
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Clear, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Clear"]/*' />
        [FieldOffset(0)]
        public D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS Clear;
    }
}
