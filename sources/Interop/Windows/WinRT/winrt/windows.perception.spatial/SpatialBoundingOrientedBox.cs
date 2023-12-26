// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Numerics;

namespace TerraFX.Interop.WinRT;

/// <include file='SpatialBoundingOrientedBox.xml' path='doc/member[@name="SpatialBoundingOrientedBox"]/*' />
public partial struct SpatialBoundingOrientedBox
{
    /// <include file='SpatialBoundingOrientedBox.xml' path='doc/member[@name="SpatialBoundingOrientedBox.Center"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
    public Vector3 Center;

    /// <include file='SpatialBoundingOrientedBox.xml' path='doc/member[@name="SpatialBoundingOrientedBox.Extents"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
    public Vector3 Extents;

    /// <include file='SpatialBoundingOrientedBox.xml' path='doc/member[@name="SpatialBoundingOrientedBox.Orientation"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")]
    public Quaternion Orientation;
}
