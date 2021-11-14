// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct MIB_IPMCAST_OIF_W2K
    {
        [NativeTypeName("DWORD")]
        public uint dwOutIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwNextHopAddr;

        [NativeTypeName("PVOID")]
        public void* pvReserved;

        [NativeTypeName("DWORD")]
        public uint dwReserved;
    }
}
