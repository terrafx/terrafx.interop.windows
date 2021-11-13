// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    public enum POINTER_INPUT_TYPE
    {
        PT_POINTER = 1,
        PT_TOUCH = 2,
        PT_PEN = 3,
        PT_MOUSE = 4,
        PT_TOUCHPAD = 5,
    }
}
