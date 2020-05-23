// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum REGCLS
    {
        REGCLS_SINGLEUSE = 0,
        REGCLS_MULTIPLEUSE = 1,
        REGCLS_MULTI_SEPARATE = 2,
        REGCLS_SUSPENDED = 4,
        REGCLS_SURROGATE = 8,
        REGCLS_AGILE = 0x10,
    }
}
