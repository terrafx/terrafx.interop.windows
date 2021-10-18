// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum msidbIniFileAction
    {
        msidbIniFileActionAddLine = 0x00000000,
        msidbIniFileActionCreateLine = 0x00000001,
        msidbIniFileActionRemoveLine = 0x00000002,
        msidbIniFileActionAddTag = 0x00000003,
        msidbIniFileActionRemoveTag = 0x00000004,
    }
}
