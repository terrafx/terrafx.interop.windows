// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFRATE_DIRECTION
    {
        MFRATE_FORWARD = 0,
        MFRATE_REVERSE = (MFRATE_FORWARD + 1),
    }
}
