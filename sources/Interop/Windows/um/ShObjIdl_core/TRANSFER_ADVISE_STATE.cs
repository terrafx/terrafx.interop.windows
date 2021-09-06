// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum TRANSFER_ADVISE_STATE
    {
        TS_NONE = 0,
        TS_PERFORMING = 0x1,
        TS_PREPARING = 0x2,
        TS_INDETERMINATE = 0x4,
    }
}
