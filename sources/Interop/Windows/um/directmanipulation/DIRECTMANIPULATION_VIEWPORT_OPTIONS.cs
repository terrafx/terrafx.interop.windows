// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum DIRECTMANIPULATION_VIEWPORT_OPTIONS
    {
        DIRECTMANIPULATION_VIEWPORT_OPTIONS_DEFAULT = 0,
        DIRECTMANIPULATION_VIEWPORT_OPTIONS_AUTODISABLE = 0x1,
        DIRECTMANIPULATION_VIEWPORT_OPTIONS_MANUALUPDATE = 0x2,
        DIRECTMANIPULATION_VIEWPORT_OPTIONS_INPUT = 0x4,
        DIRECTMANIPULATION_VIEWPORT_OPTIONS_EXPLICITHITTEST = 0x8,
        DIRECTMANIPULATION_VIEWPORT_OPTIONS_DISABLEPIXELSNAPPING = 0x10,
    }
}
