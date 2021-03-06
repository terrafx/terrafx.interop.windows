// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct WS_XML_TOKEN_MESSAGE_SECURITY_BINDING
    {
        public WS_SECURITY_BINDING binding;

        public WS_MESSAGE_SECURITY_USAGE bindingUsage;

        [NativeTypeName("WS_SECURITY_TOKEN *")]
        public IntPtr xmlToken;
    }
}
