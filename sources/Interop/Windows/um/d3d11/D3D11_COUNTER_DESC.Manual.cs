// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_COUNTER_DESC
    {
        public D3D11_COUNTER_DESC(D3D11_COUNTER counter, uint miscFlags = 0)
        {
            Counter = counter;
            MiscFlags = miscFlags;
        }
    }
}
