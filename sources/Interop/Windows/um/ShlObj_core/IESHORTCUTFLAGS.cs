// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum IESHORTCUTFLAGS
    {
        IESHORTCUT_NEWBROWSER = 0x01,
        IESHORTCUT_OPENNEWTAB = 0x02,
        IESHORTCUT_FORCENAVIGATE = 0x04,
        IESHORTCUT_BACKGROUNDTAB = 0x08,
    }
}
