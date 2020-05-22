// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DXGI_ADAPTER_DESC2
    {
        [NativeTypeName("WCHAR [128]")]
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
        public nuint DedicatedVideoMemory;

        [NativeTypeName("SIZE_T")]
        public nuint DedicatedSystemMemory;

        [NativeTypeName("SIZE_T")]
        public nuint SharedSystemMemory;

        public LUID AdapterLuid;

        [NativeTypeName("UINT")]
        public uint Flags;

        public DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;

        public DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;
    }
}
