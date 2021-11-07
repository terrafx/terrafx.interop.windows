// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public enum DCOMPOSITION_BITMAP_INTERPOLATION_MODE
    {
        DCOMPOSITION_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR = 0,
        DCOMPOSITION_BITMAP_INTERPOLATION_MODE_LINEAR = 1,
        DCOMPOSITION_BITMAP_INTERPOLATION_MODE_INHERIT = unchecked((int)(0xffffffff)),
    }
}
