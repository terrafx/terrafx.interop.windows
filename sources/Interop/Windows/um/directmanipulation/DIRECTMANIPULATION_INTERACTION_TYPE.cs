// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DIRECTMANIPULATION_INTERACTION_TYPE
    {
        DIRECTMANIPULATION_INTERACTION_BEGIN = 0,
        DIRECTMANIPULATION_INTERACTION_TYPE_MANIPULATION = 1,
        DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_TAP = 2,
        DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_HOLD = 3,
        DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_CROSS_SLIDE = 4,
        DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_PINCH_ZOOM = 5,
        DIRECTMANIPULATION_INTERACTION_END = 100,
    }
}
