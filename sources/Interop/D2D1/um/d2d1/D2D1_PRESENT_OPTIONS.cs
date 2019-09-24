// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    /// <summary>Describes how present should behave.</summary>
    [Flags]
    public enum D2D1_PRESENT_OPTIONS : uint
    {
        D2D1_PRESENT_OPTIONS_NONE = 0x00000000,

        /// <summary>Keep the target contents intact through present.</summary>
        D2D1_PRESENT_OPTIONS_RETAIN_CONTENTS = 0x00000001,

        /// <summary>Do not wait for display refresh to commit changes to display.</summary>
        D2D1_PRESENT_OPTIONS_IMMEDIATELY = 0x00000002,

        D2D1_PRESENT_OPTIONS_FORCE_DWORD = 0xFFFFFFFF
    }
}
