// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum HITRESULT
    {
        HITRESULT_OUTSIDE = 0,
        HITRESULT_TRANSPARENT = 1,
        HITRESULT_CLOSE = 2,
        HITRESULT_HIT = 3,
    }
}
