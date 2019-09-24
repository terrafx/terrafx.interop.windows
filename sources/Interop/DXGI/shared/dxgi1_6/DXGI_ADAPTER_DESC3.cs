// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_6.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct DXGI_ADAPTER_DESC3
    {
        [NativeTypeName("WCHAR[128]")]
        public fixed ushort Description[128];

        [NativeTypeName("UINT")]
        public uint VendorId;

        [NativeTypeName("UINT")]
        public uint DeviceId;

        [NativeTypeName("UINT")]
        public uint SubSysId;

        [NativeTypeName("UINT")]
        public uint Revision;

        [NativeTypeName("SIZE_T")]
        public UIntPtr DedicatedVideoMemory;

        [NativeTypeName("SIZE_T")]
        public UIntPtr DedicatedSystemMemory;

        [NativeTypeName("SIZE_T")]
        public UIntPtr SharedSystemMemory;

        public LUID AdapterLuid;

        public DXGI_ADAPTER_FLAG3 Flags;

        public DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;

        public DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;
    }
}
