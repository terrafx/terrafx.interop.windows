// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct IP_PER_ADAPTER_INFO_W2KSP1
    {
        [NativeTypeName("UINT")]
        public uint AutoconfigEnabled;

        [NativeTypeName("UINT")]
        public uint AutoconfigActive;

        [NativeTypeName("PIP_ADDR_STRING")]
        public IP_ADDR_STRING* CurrentDnsServer;

        public IP_ADDR_STRING DnsServerList;
    }
}
