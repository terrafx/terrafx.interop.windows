// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WINHTTP_WEB_SOCKET_OPERATION
    {
        WINHTTP_WEB_SOCKET_SEND_OPERATION = 0,
        WINHTTP_WEB_SOCKET_RECEIVE_OPERATION = 1,
        WINHTTP_WEB_SOCKET_CLOSE_OPERATION = 2,
        WINHTTP_WEB_SOCKET_SHUTDOWN_OPERATION = 3,
    }
}
