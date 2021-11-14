// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SOCKADDR
    {
        [NativeTypeName("ADDRESS_FAMILY")]
        public ushort sa_family;

        [NativeTypeName("CHAR [14]")]
        public fixed sbyte sa_data[14];
    }
}
