// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum D3D10_TEXTURE_ADDRESS_MODE
    {
        D3D10_TEXTURE_ADDRESS_WRAP = 1,
        D3D10_TEXTURE_ADDRESS_MIRROR = 2,
        D3D10_TEXTURE_ADDRESS_CLAMP = 3,
        D3D10_TEXTURE_ADDRESS_BORDER = 4,
        D3D10_TEXTURE_ADDRESS_MIRROR_ONCE = 5,
    }
}
