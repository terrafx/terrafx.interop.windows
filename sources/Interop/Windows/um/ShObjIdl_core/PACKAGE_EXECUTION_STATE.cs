// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum PACKAGE_EXECUTION_STATE
    {
        PES_UNKNOWN = 0,
        PES_RUNNING = 1,
        PES_SUSPENDING = 2,
        PES_SUSPENDED = 3,
        PES_TERMINATED = 4,
    }
}
