// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA
    {
        [NativeTypeName("UINT")]
        public uint PrivateDataSize;

        [NativeTypeName("UINT")]
        public uint MaxHWProtectionDataSize;

        [NativeTypeName("UINT")]
        public uint HWProtectionDataSize;

        [NativeTypeName("UINT64")]
        public ulong TransportTime;

        [NativeTypeName("UINT64")]
        public ulong ExecutionTime;

        [NativeTypeName("BYTE [4]")]
        public fixed byte pbOutput[4];
    }
}
