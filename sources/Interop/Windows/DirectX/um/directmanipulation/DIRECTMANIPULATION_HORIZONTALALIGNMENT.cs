// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX
{
    [Flags]
    [SupportedOSPlatform("windows8.0")]
    public enum DIRECTMANIPULATION_HORIZONTALALIGNMENT
    {
        DIRECTMANIPULATION_HORIZONTALALIGNMENT_NONE = 0,
        DIRECTMANIPULATION_HORIZONTALALIGNMENT_LEFT = 0x1,
        DIRECTMANIPULATION_HORIZONTALALIGNMENT_CENTER = 0x2,
        DIRECTMANIPULATION_HORIZONTALALIGNMENT_RIGHT = 0x4,
        DIRECTMANIPULATION_HORIZONTALALIGNMENT_UNLOCKCENTER = 0x8,
    }
}
