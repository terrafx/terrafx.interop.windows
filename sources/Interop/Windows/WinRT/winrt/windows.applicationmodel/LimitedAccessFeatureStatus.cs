// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='LimitedAccessFeatureStatus.xml' path='doc/member[@name="LimitedAccessFeatureStatus"]/*' />
public enum LimitedAccessFeatureStatus
{
    /// <include file='LimitedAccessFeatureStatus.xml' path='doc/member[@name="LimitedAccessFeatureStatus.LimitedAccessFeatureStatus_Unavailable"]/*' />
    LimitedAccessFeatureStatus_Unavailable = 0,

    /// <include file='LimitedAccessFeatureStatus.xml' path='doc/member[@name="LimitedAccessFeatureStatus.LimitedAccessFeatureStatus_Available"]/*' />
    LimitedAccessFeatureStatus_Available = 1,

    /// <include file='LimitedAccessFeatureStatus.xml' path='doc/member[@name="LimitedAccessFeatureStatus.LimitedAccessFeatureStatus_AvailableWithoutToken"]/*' />
    LimitedAccessFeatureStatus_AvailableWithoutToken = 2,

    /// <include file='LimitedAccessFeatureStatus.xml' path='doc/member[@name="LimitedAccessFeatureStatus.LimitedAccessFeatureStatus_Unknown"]/*' />
    LimitedAccessFeatureStatus_Unknown = 3,
}
