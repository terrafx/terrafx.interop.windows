// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SHADER_CACHE_SESSION_DESC1.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DESC1"]/*' />
public partial struct D3D12_SHADER_CACHE_SESSION_DESC1
{
    /// <include file='D3D12_SHADER_CACHE_SESSION_DESC1.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DESC1.Mode"]/*' />
    public D3D12_SHADER_CACHE_MODE Mode;

    /// <include file='D3D12_SHADER_CACHE_SESSION_DESC1.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SESSION_DESC1.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12_L31570_C36")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Memory"]/*' />
    [UnscopedRef]
    public ref D3D12_SHADER_CACHE_SESSION_MEMORY_DESC Memory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Memory;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Disk"]/*' />
    [UnscopedRef]
    public ref D3D12_SHADER_CACHE_SESSION_DISK_DESC Disk
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Disk;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Registered"]/*' />
    [UnscopedRef]
    public ref D3D12_SHADER_CACHE_SESSION_REGISTERED_DESC Registered
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Registered;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.File"]/*' />
    [UnscopedRef]
    public ref D3D12_SHADER_CACHE_SESSION_FILE_DESC File
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.File;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Memory"]/*' />
        [FieldOffset(0)]
        public D3D12_SHADER_CACHE_SESSION_MEMORY_DESC Memory;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Disk"]/*' />
        [FieldOffset(0)]
        public D3D12_SHADER_CACHE_SESSION_DISK_DESC Disk;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Registered"]/*' />
        [FieldOffset(0)]
        public D3D12_SHADER_CACHE_SESSION_REGISTERED_DESC Registered;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.File"]/*' />
        [FieldOffset(0)]
        public D3D12_SHADER_CACHE_SESSION_FILE_DESC File;
    }
}
