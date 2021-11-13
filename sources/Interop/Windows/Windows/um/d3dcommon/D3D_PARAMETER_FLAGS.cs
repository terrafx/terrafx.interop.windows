// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    [Flags]
    public enum D3D_PARAMETER_FLAGS
    {
        D3D_PF_NONE = 0,
        D3D_PF_IN = 0x1,
        D3D_PF_OUT = 0x2,
        D3D_PF_FORCE_DWORD = 0x7fffffff,
    }
}
