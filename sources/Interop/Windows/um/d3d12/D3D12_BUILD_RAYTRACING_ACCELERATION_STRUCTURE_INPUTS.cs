// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS
    {
        public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE Type;

        public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS Flags;

        [NativeTypeName("UINT")]
        public uint NumDescs;

        public D3D12_ELEMENTS_LAYOUT DescsLayout;

        [NativeTypeName("D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/d3d12.h:13332:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref ulong InstanceDescs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.InstanceDescs, 1));
            }
        }

        public ref D3D12_RAYTRACING_GEOMETRY_DESC* pGeometryDescs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pGeometryDescs;
                }
            }
        }

        public ref D3D12_RAYTRACING_GEOMETRY_DESC** ppGeometryDescs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->ppGeometryDescs;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
            public ulong InstanceDescs;

            [FieldOffset(0)]
            [NativeTypeName("const D3D12_RAYTRACING_GEOMETRY_DESC *")]
            public D3D12_RAYTRACING_GEOMETRY_DESC* pGeometryDescs;

            [FieldOffset(0)]
            [NativeTypeName("const D3D12_RAYTRACING_GEOMETRY_DESC *const *")]
            public D3D12_RAYTRACING_GEOMETRY_DESC** ppGeometryDescs;
        }
    }
}
