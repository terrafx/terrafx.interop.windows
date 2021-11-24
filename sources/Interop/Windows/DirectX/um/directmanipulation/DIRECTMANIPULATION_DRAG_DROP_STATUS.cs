// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

[SupportedOSPlatform("windows8.1")]
public enum DIRECTMANIPULATION_DRAG_DROP_STATUS
{
    DIRECTMANIPULATION_DRAG_DROP_READY = 0,
    DIRECTMANIPULATION_DRAG_DROP_PRESELECT = 1,
    DIRECTMANIPULATION_DRAG_DROP_SELECTING = 2,
    DIRECTMANIPULATION_DRAG_DROP_DRAGGING = 3,
    DIRECTMANIPULATION_DRAG_DROP_CANCELLED = 4,
    DIRECTMANIPULATION_DRAG_DROP_COMMITTED = 5,
}
