// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxgicommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

public partial struct DXGI_RATIONAL
{
    public DXGI_RATIONAL(uint numerator, uint denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }
}
