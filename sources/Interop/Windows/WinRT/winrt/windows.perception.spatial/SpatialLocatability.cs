// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpatialLocatability.xml' path='doc/member[@name="SpatialLocatability"]/*' />
public enum SpatialLocatability
{
    /// <include file='SpatialLocatability.xml' path='doc/member[@name="SpatialLocatability.SpatialLocatability_Unavailable"]/*' />
    SpatialLocatability_Unavailable = 0,

    /// <include file='SpatialLocatability.xml' path='doc/member[@name="SpatialLocatability.SpatialLocatability_OrientationOnly"]/*' />
    SpatialLocatability_OrientationOnly = 1,

    /// <include file='SpatialLocatability.xml' path='doc/member[@name="SpatialLocatability.SpatialLocatability_PositionalTrackingActivating"]/*' />
    SpatialLocatability_PositionalTrackingActivating = 2,

    /// <include file='SpatialLocatability.xml' path='doc/member[@name="SpatialLocatability.SpatialLocatability_PositionalTrackingActive"]/*' />
    SpatialLocatability_PositionalTrackingActive = 3,

    /// <include file='SpatialLocatability.xml' path='doc/member[@name="SpatialLocatability.SpatialLocatability_PositionalTrackingInhibited"]/*' />
    SpatialLocatability_PositionalTrackingInhibited = 4,
}
