// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpatialBoundingBox.xml' path='doc/member[@name="SpatialBoundingBox"]/*' />
public partial struct SpatialBoundingBox
{
    /// <include file='SpatialBoundingBox.xml' path='doc/member[@name="SpatialBoundingBox.Center"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
    public Vector3 Center;

    /// <include file='SpatialBoundingBox.xml' path='doc/member[@name="SpatialBoundingBox.Extents"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
    public Vector3 Extents;
}
