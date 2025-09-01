// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RENDER_PASS_ENDING_ACCESS.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS"]/*' />
public partial struct D3D12_RENDER_PASS_ENDING_ACCESS
{
    /// <include file='D3D12_RENDER_PASS_ENDING_ACCESS.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS.Type"]/*' />
    public D3D12_RENDER_PASS_ENDING_ACCESS_TYPE Type;

    /// <include file='D3D12_RENDER_PASS_ENDING_ACCESS.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12_L20954_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Resolve"]/*' />
    [UnscopedRef]
    public ref D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS Resolve
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Resolve;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.PreserveLocal"]/*' />
    [UnscopedRef]
    public ref D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS PreserveLocal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.PreserveLocal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Resolve"]/*' />
        [FieldOffset(0)]
        public D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS Resolve;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.PreserveLocal"]/*' />
        [FieldOffset(0)]
        public D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS PreserveLocal;
    }
}
