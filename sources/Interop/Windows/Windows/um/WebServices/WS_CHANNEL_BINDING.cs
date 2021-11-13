// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum WS_CHANNEL_BINDING
    {
        WS_HTTP_CHANNEL_BINDING = 0,
        WS_TCP_CHANNEL_BINDING = 1,
        WS_UDP_CHANNEL_BINDING = 2,
        WS_CUSTOM_CHANNEL_BINDING = 3,
        WS_NAMEDPIPE_CHANNEL_BINDING = 4,
    }
}
