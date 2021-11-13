// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum WS_CHANNEL_STATE
    {
        WS_CHANNEL_STATE_CREATED = 0,
        WS_CHANNEL_STATE_OPENING = 1,
        WS_CHANNEL_STATE_ACCEPTING = 2,
        WS_CHANNEL_STATE_OPEN = 3,
        WS_CHANNEL_STATE_FAULTED = 4,
        WS_CHANNEL_STATE_CLOSING = 5,
        WS_CHANNEL_STATE_CLOSED = 6,
    }
}
