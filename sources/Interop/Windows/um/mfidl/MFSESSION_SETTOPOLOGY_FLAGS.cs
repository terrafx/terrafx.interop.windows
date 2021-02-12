// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFSESSION_SETTOPOLOGY_FLAGS
    {
        MFSESSION_SETTOPOLOGY_IMMEDIATE = 0x1,
        MFSESSION_SETTOPOLOGY_NORESOLUTION = 0x2,
        MFSESSION_SETTOPOLOGY_CLEAR_CURRENT = 0x4,
    }
}
