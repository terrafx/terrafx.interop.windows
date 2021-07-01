// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA
    {
        [NativeTypeName("DWORD")]
        public uint PrivateDataByteCount;

        [NativeTypeName("DWORD")]
        public uint MaxHWProtectionDataByteCount;

        [NativeTypeName("DWORD")]
        public uint HWProtectionDataByteCount;

        [NativeTypeName("HRESULT")]
        public int Status;

        [NativeTypeName("LONGLONG")]
        public long TransportTimeInHundredsOfNanoseconds;

        [NativeTypeName("LONGLONG")]
        public long ExecutionTimeInHundredsOfNanoseconds;

        [NativeTypeName("BYTE [4]")]
        public fixed byte OutputData[4];
    }
}
