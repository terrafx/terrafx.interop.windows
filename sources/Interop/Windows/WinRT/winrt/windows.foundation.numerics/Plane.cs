// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.numerics.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='Plane.xml' path='doc/member[@name="Plane"]/*' />
public partial struct Plane
{
    /// <include file='Plane.xml' path='doc/member[@name="Plane.Normal"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
    public Vector3 Normal;

    /// <include file='Plane.xml' path='doc/member[@name="Plane.D"]/*' />
    public float D;
}
