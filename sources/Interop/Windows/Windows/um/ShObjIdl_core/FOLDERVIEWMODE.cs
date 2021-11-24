// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum FOLDERVIEWMODE
{
    FVM_AUTO = -1,
    FVM_FIRST = 1,
    FVM_ICON = 1,
    FVM_SMALLICON = 2,
    FVM_LIST = 3,
    FVM_DETAILS = 4,
    FVM_THUMBNAIL = 5,
    FVM_TILE = 6,
    FVM_THUMBSTRIP = 7,
    FVM_CONTENT = 8,
    FVM_LAST = 8,
}
