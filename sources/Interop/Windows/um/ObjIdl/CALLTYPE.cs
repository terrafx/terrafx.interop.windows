// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum CALLTYPE
    {
        CALLTYPE_TOPLEVEL = 1,
        CALLTYPE_NESTED = 2,
        CALLTYPE_ASYNC = 3,
        CALLTYPE_TOPLEVEL_CALLPENDING = 4,
        CALLTYPE_ASYNC_CALLPENDING = 5,
    }
}
