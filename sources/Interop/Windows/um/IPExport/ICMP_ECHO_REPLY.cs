// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct ICMP_ECHO_REPLY
    {
        [NativeTypeName("IPAddr")]
        public uint Address;

        [NativeTypeName("ULONG")]
        public uint Status;

        [NativeTypeName("ULONG")]
        public uint RoundTripTime;

        [NativeTypeName("USHORT")]
        public ushort DataSize;

        [NativeTypeName("USHORT")]
        public ushort Reserved;

        [NativeTypeName("PVOID")]
        public void* Data;

        [NativeTypeName("struct ip_option_information")]
        public IP_OPTION_INFORMATION Options;
    }
}
