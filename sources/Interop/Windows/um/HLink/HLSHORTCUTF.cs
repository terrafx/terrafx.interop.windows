// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum HLSHORTCUTF
    {
        HLSHORTCUTF_DEFAULT = 0,
        HLSHORTCUTF_DONTACTUALLYCREATE = 0x1,
        HLSHORTCUTF_USEFILENAMEFROMFRIENDLYNAME = 0x2,
        HLSHORTCUTF_USEUNIQUEFILENAME = 0x4,
        HLSHORTCUTF_MAYUSEEXISTINGSHORTCUT = 0x8,
    }
}
