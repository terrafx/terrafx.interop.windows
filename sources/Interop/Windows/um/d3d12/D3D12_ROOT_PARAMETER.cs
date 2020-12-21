// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D12_ROOT_PARAMETER
    {
        public D3D12_ROOT_PARAMETER_TYPE ParameterType;

        [NativeTypeName("D3D12_ROOT_PARAMETER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d12.h:3451:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref D3D12_ROOT_DESCRIPTOR_TABLE DescriptorTable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.DescriptorTable, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->DescriptorTable;
#endif
            }
        }

        public unsafe ref D3D12_ROOT_CONSTANTS Constants
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Constants, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Constants;
#endif
            }
        }

        public unsafe ref D3D12_ROOT_DESCRIPTOR Descriptor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Descriptor, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Descriptor;
#endif
            }
        }

        public D3D12_SHADER_VISIBILITY ShaderVisibility;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D12_ROOT_DESCRIPTOR_TABLE DescriptorTable;

            [FieldOffset(0)]
            public D3D12_ROOT_CONSTANTS Constants;

            [FieldOffset(0)]
            public D3D12_ROOT_DESCRIPTOR Descriptor;
        }
    }
}
