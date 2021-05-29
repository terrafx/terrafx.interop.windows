// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DML_BINDING_TABLE_DESC
    {
        public IDMLDispatchable* Dispatchable;

        public D3D12_CPU_DESCRIPTOR_HANDLE CPUDescriptorHandle;

        public D3D12_GPU_DESCRIPTOR_HANDLE GPUDescriptorHandle;

        [NativeTypeName("UINT")]
        public uint SizeInDescriptors;
    }
}
