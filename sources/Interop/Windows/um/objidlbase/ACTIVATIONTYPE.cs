// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum ACTIVATIONTYPE
    {
        ACTIVATIONTYPE_UNCATEGORIZED = 0,
        ACTIVATIONTYPE_FROM_MONIKER = 0x1,
        ACTIVATIONTYPE_FROM_DATA = 0x2,
        ACTIVATIONTYPE_FROM_STORAGE = 0x4,
        ACTIVATIONTYPE_FROM_STREAM = 0x8,
        ACTIVATIONTYPE_FROM_FILE = 0x10,
    }
}
