// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum STGC
    {
        STGC_DEFAULT = 0,
        STGC_OVERWRITE = 1,
        STGC_ONLYIFCURRENT = 2,
        STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE = 4,
        STGC_CONSOLIDATE = 8,
    }
}
