// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SHARE_ROLE
    {
        SHARE_ROLE_INVALID = -1,
        SHARE_ROLE_READER = 0,
        SHARE_ROLE_CONTRIBUTOR = 1,
        SHARE_ROLE_CO_OWNER = 2,
        SHARE_ROLE_OWNER = 3,
        SHARE_ROLE_CUSTOM = 4,
        SHARE_ROLE_MIXED = 5,
    }
}
