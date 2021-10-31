// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MIB_IFSTATUS
    {
        [NativeTypeName("DWORD")]
        public uint dwIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwAdminStatus;

        [NativeTypeName("DWORD")]
        public uint dwOperationalStatus;

        public BOOL bMHbeatActive;

        public BOOL bMHbeatAlive;
    }
}
