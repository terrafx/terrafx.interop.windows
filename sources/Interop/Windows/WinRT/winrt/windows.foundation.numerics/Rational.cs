// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.numerics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='Rational.xml' path='doc/member[@name="Rational"]/*' />
public partial struct Rational
{
    /// <include file='Rational.xml' path='doc/member[@name="Rational.Numerator"]/*' />
    [NativeTypeName("UINT32")]
    public uint Numerator;

    /// <include file='Rational.xml' path='doc/member[@name="Rational.Denominator"]/*' />
    [NativeTypeName("UINT32")]
    public uint Denominator;
}
