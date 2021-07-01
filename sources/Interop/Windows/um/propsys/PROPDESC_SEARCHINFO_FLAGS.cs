// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum PROPDESC_SEARCHINFO_FLAGS
    {
        PDSIF_DEFAULT = 0,
        PDSIF_ININVERTEDINDEX = 0x1,
        PDSIF_ISCOLUMN = 0x2,
        PDSIF_ISCOLUMNSPARSE = 0x4,
        PDSIF_ALWAYSINCLUDE = 0x8,
        PDSIF_USEFORTYPEAHEAD = 0x10,
    }
}
