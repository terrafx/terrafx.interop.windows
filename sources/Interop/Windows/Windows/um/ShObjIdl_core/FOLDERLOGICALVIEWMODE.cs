// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum FOLDERLOGICALVIEWMODE
{
    FLVM_UNSPECIFIED = -1,
    FLVM_FIRST = 1,
    FLVM_DETAILS = 1,
    FLVM_TILES = 2,
    FLVM_ICONS = 3,
    FLVM_LIST = 4,
    FLVM_CONTENT = 5,
    FLVM_LAST = 5,
}
