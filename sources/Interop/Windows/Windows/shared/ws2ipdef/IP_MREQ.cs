// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct IP_MREQ
    {
        public IN_ADDR imr_multiaddr;

        public IN_ADDR imr_interface;
    }
}
