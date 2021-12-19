// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgicommon.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_RATIONAL.xml' path='doc/member[@name="DXGI_RATIONAL"]/*' />
public partial struct DXGI_RATIONAL
{
    /// <include file='DXGI_RATIONAL.xml' path='doc/member[@name="DXGI_RATIONAL.Numerator"]/*' />
    public uint Numerator;

    /// <include file='DXGI_RATIONAL.xml' path='doc/member[@name="DXGI_RATIONAL.Denominator"]/*' />
    public uint Denominator;
}
