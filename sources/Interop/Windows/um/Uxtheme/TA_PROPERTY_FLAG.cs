// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum TA_PROPERTY_FLAG
    {
        TAPF_NONE = 0x0,
        TAPF_HASSTAGGER = 0x1,
        TAPF_ISRTLAWARE = 0x2,
        TAPF_ALLOWCOLLECTION = 0x4,
        TAPF_HASBACKGROUND = 0x8,
        TAPF_HASPERSPECTIVE = 0x10,
    }
}
