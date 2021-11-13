// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum MSIINSTALLCONTEXT
    {
        MSIINSTALLCONTEXT_FIRSTVISIBLE = 0,
        MSIINSTALLCONTEXT_NONE = 0,
        MSIINSTALLCONTEXT_USERMANAGED = 1,
        MSIINSTALLCONTEXT_USERUNMANAGED = 2,
        MSIINSTALLCONTEXT_MACHINE = 4,
        MSIINSTALLCONTEXT_ALL = (MSIINSTALLCONTEXT_USERMANAGED | MSIINSTALLCONTEXT_USERUNMANAGED | MSIINSTALLCONTEXT_MACHINE),
        MSIINSTALLCONTEXT_ALLUSERMANAGED = 8,
    }
}
