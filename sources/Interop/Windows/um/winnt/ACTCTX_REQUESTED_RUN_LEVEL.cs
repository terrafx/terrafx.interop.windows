// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum ACTCTX_REQUESTED_RUN_LEVEL
    {
        ACTCTX_RUN_LEVEL_UNSPECIFIED = 0,
        ACTCTX_RUN_LEVEL_AS_INVOKER,
        ACTCTX_RUN_LEVEL_HIGHEST_AVAILABLE,
        ACTCTX_RUN_LEVEL_REQUIRE_ADMIN,
        ACTCTX_RUN_LEVEL_NUMBERS,
    }
}
