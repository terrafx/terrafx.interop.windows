// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum XFORMCOORDS
    {
        XFORMCOORDS_POSITION = 0x1,
        XFORMCOORDS_SIZE = 0x2,
        XFORMCOORDS_HIMETRICTOCONTAINER = 0x4,
        XFORMCOORDS_CONTAINERTOHIMETRIC = 0x8,
        XFORMCOORDS_EVENTCOMPAT = 0x10,
    }
}
