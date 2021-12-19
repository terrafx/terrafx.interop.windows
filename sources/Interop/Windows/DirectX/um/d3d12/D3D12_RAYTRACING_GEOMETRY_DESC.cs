// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RAYTRACING_GEOMETRY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_DESC"]/*' />
public partial struct D3D12_RAYTRACING_GEOMETRY_DESC
{
    /// <include file='D3D12_RAYTRACING_GEOMETRY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_DESC.Type"]/*' />
    public D3D12_RAYTRACING_GEOMETRY_TYPE Type;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_DESC.Flags"]/*' />
    public D3D12_RAYTRACING_GEOMETRY_FLAGS Flags;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_DESC.Anonymous"]/*' />
    [NativeTypeName("D3D12_RAYTRACING_GEOMETRY_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/d3d12.h:13319:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Triangles"]/*' />
    public ref D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC Triangles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Triangles, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AABBs"]/*' />
    public ref D3D12_RAYTRACING_GEOMETRY_AABBS_DESC AABBs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.AABBs, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Triangles"]/*' />
        [FieldOffset(0)]
        public D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC Triangles;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AABBs"]/*' />
        [FieldOffset(0)]
        public D3D12_RAYTRACING_GEOMETRY_AABBS_DESC AABBs;
    }
}
