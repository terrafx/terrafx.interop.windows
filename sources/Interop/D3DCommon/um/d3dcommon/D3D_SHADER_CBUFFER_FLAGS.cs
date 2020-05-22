// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D_SHADER_CBUFFER_FLAGS
    {
        D3D_CBF_USERPACKED = 1,
        D3D10_CBF_USERPACKED = D3D_CBF_USERPACKED,
        D3D_CBF_FORCE_DWORD = 0x7fffffff,
    }
}
