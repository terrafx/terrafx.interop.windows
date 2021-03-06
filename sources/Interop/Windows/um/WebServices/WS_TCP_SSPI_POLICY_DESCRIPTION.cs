// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct WS_TCP_SSPI_POLICY_DESCRIPTION
    {
        public WS_CHANNEL_PROPERTIES channelProperties;

        public WS_SECURITY_PROPERTIES securityProperties;

        public WS_SSPI_TRANSPORT_SECURITY_BINDING_POLICY_DESCRIPTION sspiTransportSecurityBinding;
    }
}
