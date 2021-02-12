// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WICSectionAccessLevel : uint
    {
        WICSectionAccessLevelRead = 0x1,
        WICSectionAccessLevelReadWrite = 0x3,
        WICSectionAccessLevel_FORCE_DWORD = 0x7fffffff,
    }
}
