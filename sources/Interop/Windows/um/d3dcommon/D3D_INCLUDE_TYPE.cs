// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D_INCLUDE_TYPE
    {
        D3D_INCLUDE_LOCAL = 0,
        D3D_INCLUDE_SYSTEM = (D3D_INCLUDE_LOCAL + 1),
        D3D10_INCLUDE_LOCAL = D3D_INCLUDE_LOCAL,
        D3D10_INCLUDE_SYSTEM = D3D_INCLUDE_SYSTEM,
        D3D_INCLUDE_FORCE_DWORD = 0x7fffffff,
    }
}
