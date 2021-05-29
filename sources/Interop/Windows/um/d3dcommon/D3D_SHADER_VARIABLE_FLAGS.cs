// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D_SHADER_VARIABLE_FLAGS
    {
        D3D_SVF_USERPACKED = 1,
        D3D_SVF_USED = 2,
        D3D_SVF_INTERFACE_POINTER = 4,
        D3D_SVF_INTERFACE_PARAMETER = 8,
        D3D10_SVF_USERPACKED = D3D_SVF_USERPACKED,
        D3D10_SVF_USED = D3D_SVF_USED,
        D3D11_SVF_INTERFACE_POINTER = D3D_SVF_INTERFACE_POINTER,
        D3D11_SVF_INTERFACE_PARAMETER = D3D_SVF_INTERFACE_PARAMETER,
        D3D_SVF_FORCE_DWORD = 0x7fffffff,
    }
}
