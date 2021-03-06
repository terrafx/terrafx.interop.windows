// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct WS_SECURITY_CONTEXT_SECURITY_BINDING_POLICY_DESCRIPTION
    {
        public WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_POLICY_DESCRIPTION securityContextMessageSecurityBinding;

        public WS_SECURITY_PROPERTIES securityProperties;
    }
}
