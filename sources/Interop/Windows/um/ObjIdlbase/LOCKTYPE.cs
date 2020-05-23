// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum LOCKTYPE
    {
        LOCK_WRITE = 1,
        LOCK_EXCLUSIVE = 2,
        LOCK_ONLYONCE = 4,
    }
}
