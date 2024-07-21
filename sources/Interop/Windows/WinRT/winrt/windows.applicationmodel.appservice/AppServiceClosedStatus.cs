// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppServiceClosedStatus.xml' path='doc/member[@name="AppServiceClosedStatus"]/*' />
public enum AppServiceClosedStatus
{
    /// <include file='AppServiceClosedStatus.xml' path='doc/member[@name="AppServiceClosedStatus.AppServiceClosedStatus_Completed"]/*' />
    AppServiceClosedStatus_Completed = 0,

    /// <include file='AppServiceClosedStatus.xml' path='doc/member[@name="AppServiceClosedStatus.AppServiceClosedStatus_Canceled"]/*' />
    AppServiceClosedStatus_Canceled = 1,

    /// <include file='AppServiceClosedStatus.xml' path='doc/member[@name="AppServiceClosedStatus.AppServiceClosedStatus_ResourceLimitsExceeded"]/*' />
    AppServiceClosedStatus_ResourceLimitsExceeded = 2,

    /// <include file='AppServiceClosedStatus.xml' path='doc/member[@name="AppServiceClosedStatus.AppServiceClosedStatus_Unknown"]/*' />
    AppServiceClosedStatus_Unknown = 3,
}
