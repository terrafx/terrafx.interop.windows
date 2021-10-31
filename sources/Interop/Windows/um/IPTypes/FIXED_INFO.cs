// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct FIXED_INFO
    {
        [NativeTypeName("char [132]")]
        public fixed sbyte HostName[132];

        [NativeTypeName("char [132]")]
        public fixed sbyte DomainName[132];

        [NativeTypeName("PIP_ADDR_STRING")]
        public IP_ADDR_STRING* CurrentDnsServer;

        public IP_ADDR_STRING DnsServerList;

        public uint NodeType;

        [NativeTypeName("char [260]")]
        public fixed sbyte ScopeId[260];

        public uint EnableRouting;

        public uint EnableProxy;

        public uint EnableDns;
    }
}
