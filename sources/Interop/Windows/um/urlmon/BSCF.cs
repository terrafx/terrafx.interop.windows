// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum BSCF
    {
        BSCF_FIRSTDATANOTIFICATION = 0x1,
        BSCF_INTERMEDIATEDATANOTIFICATION = 0x2,
        BSCF_LASTDATANOTIFICATION = 0x4,
        BSCF_DATAFULLYAVAILABLE = 0x8,
        BSCF_AVAILABLEDATASIZEUNKNOWN = 0x10,
        BSCF_SKIPDRAINDATAFORFILEURLS = 0x20,
        BSCF_64BITLENGTHDOWNLOAD = 0x40,
    }
}
