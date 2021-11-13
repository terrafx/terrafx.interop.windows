// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum MIB_IPFORWARD_TYPE
    {
        MIB_IPROUTE_TYPE_OTHER = 1,
        MIB_IPROUTE_TYPE_INVALID = 2,
        MIB_IPROUTE_TYPE_DIRECT = 3,
        MIB_IPROUTE_TYPE_INDIRECT = 4,
    }
}
