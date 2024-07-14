// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='LaunchQuerySupportStatus.xml' path='doc/member[@name="LaunchQuerySupportStatus"]/*' />
public enum LaunchQuerySupportStatus
{
    /// <include file='LaunchQuerySupportStatus.xml' path='doc/member[@name="LaunchQuerySupportStatus.LaunchQuerySupportStatus_Available"]/*' />
    LaunchQuerySupportStatus_Available = 0,

    /// <include file='LaunchQuerySupportStatus.xml' path='doc/member[@name="LaunchQuerySupportStatus.LaunchQuerySupportStatus_AppNotInstalled"]/*' />
    LaunchQuerySupportStatus_AppNotInstalled = 1,

    /// <include file='LaunchQuerySupportStatus.xml' path='doc/member[@name="LaunchQuerySupportStatus.LaunchQuerySupportStatus_AppUnavailable"]/*' />
    LaunchQuerySupportStatus_AppUnavailable = 2,

    /// <include file='LaunchQuerySupportStatus.xml' path='doc/member[@name="LaunchQuerySupportStatus.LaunchQuerySupportStatus_NotSupported"]/*' />
    LaunchQuerySupportStatus_NotSupported = 3,

    /// <include file='LaunchQuerySupportStatus.xml' path='doc/member[@name="LaunchQuerySupportStatus.LaunchQuerySupportStatus_Unknown"]/*' />
    LaunchQuerySupportStatus_Unknown = 4,
}
