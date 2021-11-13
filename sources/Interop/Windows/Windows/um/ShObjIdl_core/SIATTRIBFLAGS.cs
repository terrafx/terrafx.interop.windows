// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum SIATTRIBFLAGS
    {
        SIATTRIBFLAGS_AND = 0x1,
        SIATTRIBFLAGS_OR = 0x2,
        SIATTRIBFLAGS_APPCOMPAT = 0x3,
        SIATTRIBFLAGS_MASK = 0x3,
        SIATTRIBFLAGS_ALLITEMS = 0x4000,
    }
}
