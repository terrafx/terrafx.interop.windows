// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum SYNCMGRREGISTERFLAGS
{
    SYNCMGRREGISTERFLAG_CONNECT = 0x1,
    SYNCMGRREGISTERFLAG_PENDINGDISCONNECT = 0x2,
    SYNCMGRREGISTERFLAG_IDLE = 0x4,
}
