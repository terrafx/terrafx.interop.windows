// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_MLIR_PROGRAM_BINDING.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDING"]/*' />
public partial struct D3D12_MLIR_PROGRAM_BINDING
{
    /// <include file='D3D12_MLIR_PROGRAM_BINDING.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDING.BindPointIndex"]/*' />
    public uint BindPointIndex;

    /// <include file='D3D12_MLIR_PROGRAM_BINDING.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDING.Flags"]/*' />
    public D3D12_MLIR_PROGRAM_BINDING_FLAGS Flags;

    /// <include file='D3D12_MLIR_PROGRAM_BINDING.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDING.Type"]/*' />
    public D3D12_MLIR_PROGRAM_BINDING_TYPE Type;

    /// <include file='D3D12_MLIR_PROGRAM_BINDING.xml' path='doc/member[@name="D3D12_MLIR_PROGRAM_BINDING.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12_L22743_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.GpuVirtualAddressBinding"]/*' />
    [UnscopedRef]
    public ref D3D12_GPU_VIRTUAL_ADDRESS_RANGE GpuVirtualAddressBinding
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.GpuVirtualAddressBinding;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.GpuDescriptorBinding"]/*' />
    [UnscopedRef]
    public ref D3D12_GPU_DESCRIPTOR_HANDLE GpuDescriptorBinding
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.GpuDescriptorBinding;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CpuBinding"]/*' />
    [UnscopedRef]
    public ref D3D12_MLIR_PROGRAM_CPU_BINDING CpuBinding
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.CpuBinding;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.GpuVirtualAddressBinding"]/*' />
        [FieldOffset(0)]
        public D3D12_GPU_VIRTUAL_ADDRESS_RANGE GpuVirtualAddressBinding;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.GpuDescriptorBinding"]/*' />
        [FieldOffset(0)]
        public D3D12_GPU_DESCRIPTOR_HANDLE GpuDescriptorBinding;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CpuBinding"]/*' />
        [FieldOffset(0)]
        public D3D12_MLIR_PROGRAM_CPU_BINDING CpuBinding;
    }
}
