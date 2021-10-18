// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SOCKADDR_IN
    {
        [NativeTypeName("ADDRESS_FAMILY")]
        public ushort sin_family;

        [NativeTypeName("USHORT")]
        public ushort sin_port;

        public IN_ADDR sin_addr;

        [NativeTypeName("CHAR [8]")]
        public fixed sbyte sin_zero[8];
    }
}
