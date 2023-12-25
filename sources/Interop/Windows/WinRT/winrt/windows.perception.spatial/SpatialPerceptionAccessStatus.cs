// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpatialPerceptionAccessStatus.xml' path='doc/member[@name="SpatialPerceptionAccessStatus"]/*' />
public enum SpatialPerceptionAccessStatus
{
    /// <include file='SpatialPerceptionAccessStatus.xml' path='doc/member[@name="SpatialPerceptionAccessStatus.SpatialPerceptionAccessStatus_Unspecified"]/*' />
    SpatialPerceptionAccessStatus_Unspecified = 0,

    /// <include file='SpatialPerceptionAccessStatus.xml' path='doc/member[@name="SpatialPerceptionAccessStatus.SpatialPerceptionAccessStatus_Allowed"]/*' />
    SpatialPerceptionAccessStatus_Allowed = 1,

    /// <include file='SpatialPerceptionAccessStatus.xml' path='doc/member[@name="SpatialPerceptionAccessStatus.SpatialPerceptionAccessStatus_DeniedByUser"]/*' />
    SpatialPerceptionAccessStatus_DeniedByUser = 2,

    /// <include file='SpatialPerceptionAccessStatus.xml' path='doc/member[@name="SpatialPerceptionAccessStatus.SpatialPerceptionAccessStatus_DeniedBySystem"]/*' />
    SpatialPerceptionAccessStatus_DeniedBySystem = 3,
}
