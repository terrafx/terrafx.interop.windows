// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEXTURE_COPY_DESC.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_DESC"]/*' />
public unsafe partial struct D3D12_TEXTURE_COPY_DESC
{
    /// <include file='D3D12_TEXTURE_COPY_DESC.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_DESC.Type"]/*' />
    public D3D12_TEXTURE_COPY_DESC_TYPE Type;

    /// <include file='D3D12_TEXTURE_COPY_DESC.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_DESC.NumRegions"]/*' />
    public uint NumRegions;

    /// <include file='D3D12_TEXTURE_COPY_DESC.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_DESC.pCopyRegions"]/*' />
    [NativeTypeName("const D3D12_TEXTURE_COPY_REGION *")]
    public D3D12_TEXTURE_COPY_REGION* pCopyRegions;

    /// <include file='D3D12_TEXTURE_COPY_DESC.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_DESC.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12_L42861_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TextureTextureCopy"]/*' />
    [UnscopedRef]
    public ref D3D12_TEXTURE_TEXTURE_COPY_DESC TextureTextureCopy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.TextureTextureCopy;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BufferTextureCopy"]/*' />
    [UnscopedRef]
    public ref D3D12_BUFFER_TEXTURE_COPY_DESC BufferTextureCopy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.BufferTextureCopy;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.TextureTextureCopy"]/*' />
        [FieldOffset(0)]
        public D3D12_TEXTURE_TEXTURE_COPY_DESC TextureTextureCopy;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BufferTextureCopy"]/*' />
        [FieldOffset(0)]
        public D3D12_BUFFER_TEXTURE_COPY_DESC BufferTextureCopy;
    }
}
