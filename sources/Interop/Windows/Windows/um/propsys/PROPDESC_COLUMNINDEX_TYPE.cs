// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum PROPDESC_COLUMNINDEX_TYPE
{
    PDCIT_NONE = 0,
    PDCIT_ONDISK = 1,
    PDCIT_INMEMORY = 2,
    PDCIT_ONDEMAND = 3,
    PDCIT_ONDISKALL = 4,
    PDCIT_ONDISKVECTOR = 5,
}
