// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D11_DSV_FLAG
    {
        D3D11_DSV_READ_ONLY_DEPTH = 0x1,
        D3D11_DSV_READ_ONLY_STENCIL = 0x2,
    }
}
