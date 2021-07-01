// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum QUEUE_USER_APC_FLAGS
    {
        QUEUE_USER_APC_FLAGS_NONE = 0x0,
        QUEUE_USER_APC_FLAGS_SPECIAL_USER_APC = 0x1,
    }
}
