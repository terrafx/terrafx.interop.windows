// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

[Flags]
[SupportedOSPlatform("windows8.0")]
public enum DIRECTMANIPULATION_GESTURE_CONFIGURATION
{
    DIRECTMANIPULATION_GESTURE_NONE = 0,
    DIRECTMANIPULATION_GESTURE_DEFAULT = 0,
    DIRECTMANIPULATION_GESTURE_CROSS_SLIDE_VERTICAL = 0x8,
    DIRECTMANIPULATION_GESTURE_CROSS_SLIDE_HORIZONTAL = 0x10,
    DIRECTMANIPULATION_GESTURE_PINCH_ZOOM = 0x20,
}
