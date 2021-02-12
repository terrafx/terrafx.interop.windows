// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum AM_PROPERTY_FRAMESTEP
    {
        AM_PROPERTY_FRAMESTEP_STEP = 0x01,
        AM_PROPERTY_FRAMESTEP_CANCEL = 0x02,
        AM_PROPERTY_FRAMESTEP_CANSTEP = 0x03,
        AM_PROPERTY_FRAMESTEP_CANSTEPMULTIPLE = 0x04,
    }
}
