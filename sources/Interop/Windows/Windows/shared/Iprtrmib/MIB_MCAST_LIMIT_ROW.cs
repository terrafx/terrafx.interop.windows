// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct MIB_MCAST_LIMIT_ROW
    {
        [NativeTypeName("DWORD")]
        public uint dwTtl;

        [NativeTypeName("DWORD")]
        public uint dwRateLimit;
    }
}
