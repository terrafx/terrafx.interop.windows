// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Numerics;

namespace TerraFX.Interop.WinRT;

/// <include file='SpatialBoundingFrustum.xml' path='doc/member[@name="SpatialBoundingFrustum"]/*' />
public partial struct SpatialBoundingFrustum
{
    /// <include file='SpatialBoundingFrustum.xml' path='doc/member[@name="SpatialBoundingFrustum.Near"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Plane")]
    public Plane Near;

    /// <include file='SpatialBoundingFrustum.xml' path='doc/member[@name="SpatialBoundingFrustum.Far"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Plane")]
    public Plane Far;

    /// <include file='SpatialBoundingFrustum.xml' path='doc/member[@name="SpatialBoundingFrustum.Right"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Plane")]
    public Plane Right;

    /// <include file='SpatialBoundingFrustum.xml' path='doc/member[@name="SpatialBoundingFrustum.Left"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Plane")]
    public Plane Left;

    /// <include file='SpatialBoundingFrustum.xml' path='doc/member[@name="SpatialBoundingFrustum.Top"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Plane")]
    public Plane Top;

    /// <include file='SpatialBoundingFrustum.xml' path='doc/member[@name="SpatialBoundingFrustum.Bottom"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Plane")]
    public Plane Bottom;
}
