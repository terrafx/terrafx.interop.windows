// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX
{
    [SupportedOSPlatform("windows8.1")]
    public enum DCOMPOSITION_BACKFACE_VISIBILITY
    {
        DCOMPOSITION_BACKFACE_VISIBILITY_VISIBLE = 0,
        DCOMPOSITION_BACKFACE_VISIBILITY_HIDDEN = 1,
        DCOMPOSITION_BACKFACE_VISIBILITY_INHERIT = unchecked((int)(0xffffffff)),
    }
}
