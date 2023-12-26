// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='BackgroundAccessStatus.xml' path='doc/member[@name="BackgroundAccessStatus"]/*' />
public enum BackgroundAccessStatus
{
    /// <include file='BackgroundAccessStatus.xml' path='doc/member[@name="BackgroundAccessStatus.BackgroundAccessStatus_Unspecified"]/*' />
    BackgroundAccessStatus_Unspecified = 0,

    /// <include file='BackgroundAccessStatus.xml' path='doc/member[@name="BackgroundAccessStatus.BackgroundAccessStatus_AllowedWithAlwaysOnRealTimeConnectivity"]/*' />
    [Obsolete("Use AlwaysAllowed or AllowedSubjectToSystemPolicy instead of AllowedWithAlwaysOnRealTimeConnectivity. For more info, see MSDN.")]
    BackgroundAccessStatus_AllowedWithAlwaysOnRealTimeConnectivity = 1,

    /// <include file='BackgroundAccessStatus.xml' path='doc/member[@name="BackgroundAccessStatus.BackgroundAccessStatus_AllowedMayUseActiveRealTimeConnectivity"]/*' />
    [Obsolete("Use AlwaysAllowed or AllowedSubjectToSystemPolicy instead of AllowedMayUseActiveRealTimeConnectivity. For more info, see MSDN.")]
    BackgroundAccessStatus_AllowedMayUseActiveRealTimeConnectivity = 2,

    /// <include file='BackgroundAccessStatus.xml' path='doc/member[@name="BackgroundAccessStatus.BackgroundAccessStatus_Denied"]/*' />
    [Obsolete("Use DeniedByUser or DeniedBySystemPolicy instead of Denied. For more info, see MSDN.")]
    BackgroundAccessStatus_Denied = 3,

    /// <include file='BackgroundAccessStatus.xml' path='doc/member[@name="BackgroundAccessStatus.BackgroundAccessStatus_AlwaysAllowed"]/*' />
    BackgroundAccessStatus_AlwaysAllowed = 4,

    /// <include file='BackgroundAccessStatus.xml' path='doc/member[@name="BackgroundAccessStatus.BackgroundAccessStatus_AllowedSubjectToSystemPolicy"]/*' />
    BackgroundAccessStatus_AllowedSubjectToSystemPolicy = 5,

    /// <include file='BackgroundAccessStatus.xml' path='doc/member[@name="BackgroundAccessStatus.BackgroundAccessStatus_DeniedBySystemPolicy"]/*' />
    BackgroundAccessStatus_DeniedBySystemPolicy = 6,

    /// <include file='BackgroundAccessStatus.xml' path='doc/member[@name="BackgroundAccessStatus.BackgroundAccessStatus_DeniedByUser"]/*' />
    BackgroundAccessStatus_DeniedByUser = 7,
}
