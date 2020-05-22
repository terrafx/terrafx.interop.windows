// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum APTTYPEQUALIFIER
    {
        APTTYPEQUALIFIER_NONE = 0,
        APTTYPEQUALIFIER_IMPLICIT_MTA = 1,
        APTTYPEQUALIFIER_NA_ON_MTA = 2,
        APTTYPEQUALIFIER_NA_ON_STA = 3,
        APTTYPEQUALIFIER_NA_ON_IMPLICIT_MTA = 4,
        APTTYPEQUALIFIER_NA_ON_MAINSTA = 5,
        APTTYPEQUALIFIER_APPLICATION_STA = 6,
        APTTYPEQUALIFIER_RESERVED_1 = 7,
    }
}
