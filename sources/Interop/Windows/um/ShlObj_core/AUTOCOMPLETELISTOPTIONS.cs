// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum AUTOCOMPLETELISTOPTIONS
    {
        ACLO_NONE = 0,
        ACLO_CURRENTDIR = 1,
        ACLO_MYCOMPUTER = 2,
        ACLO_DESKTOP = 4,
        ACLO_FAVORITES = 8,
        ACLO_FILESYSONLY = 16,
        ACLO_FILESYSDIRS = 32,
        ACLO_VIRTUALNAMESPACE = 64,
    }
}
