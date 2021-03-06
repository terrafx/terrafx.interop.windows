// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum CASTING_CONNECTION_STATE
    {
        CASTING_CONNECTION_STATE_DISCONNECTED = 0,
        CASTING_CONNECTION_STATE_CONNECTED = 1,
        CASTING_CONNECTION_STATE_RENDERING = 2,
        CASTING_CONNECTION_STATE_DISCONNECTING = 3,
        CASTING_CONNECTION_STATE_CONNECTING = 4,
    }
}
