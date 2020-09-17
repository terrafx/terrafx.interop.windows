// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WS_SERVICE_HOST_STATE
    {
        WS_SERVICE_HOST_STATE_CREATED = 0,
        WS_SERVICE_HOST_STATE_OPENING = 1,
        WS_SERVICE_HOST_STATE_OPEN = 2,
        WS_SERVICE_HOST_STATE_CLOSING = 3,
        WS_SERVICE_HOST_STATE_CLOSED = 4,
        WS_SERVICE_HOST_STATE_FAULTED = 5,
    }
}
