// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Numerics;

namespace TerraFX.Interop.WinRT;

/// <include file='SpatialRay.xml' path='doc/member[@name="SpatialRay"]/*' />
public partial struct SpatialRay
{
    /// <include file='SpatialRay.xml' path='doc/member[@name="SpatialRay.Origin"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
    public Vector3 Origin;

    /// <include file='SpatialRay.xml' path='doc/member[@name="SpatialRay.Direction"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")]
    public Vector3 Direction;
}
