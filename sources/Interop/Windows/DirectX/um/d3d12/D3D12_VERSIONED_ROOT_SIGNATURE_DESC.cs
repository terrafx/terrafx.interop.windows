// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VERSIONED_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_VERSIONED_ROOT_SIGNATURE_DESC"]/*' />
public partial struct D3D12_VERSIONED_ROOT_SIGNATURE_DESC
{
    /// <include file='D3D12_VERSIONED_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_VERSIONED_ROOT_SIGNATURE_DESC.Version"]/*' />
    public D3D_ROOT_SIGNATURE_VERSION Version;

    /// <include file='D3D12_VERSIONED_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_VERSIONED_ROOT_SIGNATURE_DESC.Anonymous"]/*' />
    [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/d3d12.h:3711:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Desc_1_0"]/*' />
    [UnscopedRef]
    public ref D3D12_ROOT_SIGNATURE_DESC Desc_1_0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Desc_1_0;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Desc_1_1"]/*' />
    [UnscopedRef]
    public ref D3D12_ROOT_SIGNATURE_DESC1 Desc_1_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Desc_1_1;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Desc_1_0"]/*' />
        [FieldOffset(0)]
        public D3D12_ROOT_SIGNATURE_DESC Desc_1_0;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Desc_1_1"]/*' />
        [FieldOffset(0)]
        public D3D12_ROOT_SIGNATURE_DESC1 Desc_1_1;
    }
}
