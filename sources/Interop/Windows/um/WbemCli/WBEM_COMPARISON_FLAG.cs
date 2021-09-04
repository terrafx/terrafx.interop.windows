// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WBEM_COMPARISON_FLAG
    {
        WBEM_COMPARISON_INCLUDE_ALL = 0,
        WBEM_FLAG_IGNORE_QUALIFIERS = 0x1,
        WBEM_FLAG_IGNORE_OBJECT_SOURCE = 0x2,
        WBEM_FLAG_IGNORE_DEFAULT_VALUES = 0x4,
        WBEM_FLAG_IGNORE_CLASS = 0x8,
        WBEM_FLAG_IGNORE_CASE = 0x10,
        WBEM_FLAG_IGNORE_FLAVOR = 0x20,
    }
}
