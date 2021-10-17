// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define TCPIP_OWNING_MODULE_SIZE 16")]
        public const int TCPIP_OWNING_MODULE_SIZE = 16;

        [NativeTypeName("#define MIB_TCP_MAXCONN_DYNAMIC ((ULONG)-1)")]
        public const uint MIB_TCP_MAXCONN_DYNAMIC = unchecked((uint)(-1));
    }
}
