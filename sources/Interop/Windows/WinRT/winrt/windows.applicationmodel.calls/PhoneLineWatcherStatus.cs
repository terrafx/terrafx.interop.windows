// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneLineWatcherStatus.xml' path='doc/member[@name="PhoneLineWatcherStatus"]/*' />
public enum PhoneLineWatcherStatus
{
    /// <include file='PhoneLineWatcherStatus.xml' path='doc/member[@name="PhoneLineWatcherStatus.PhoneLineWatcherStatus_Created"]/*' />
    PhoneLineWatcherStatus_Created = 0,

    /// <include file='PhoneLineWatcherStatus.xml' path='doc/member[@name="PhoneLineWatcherStatus.PhoneLineWatcherStatus_Started"]/*' />
    PhoneLineWatcherStatus_Started = 1,

    /// <include file='PhoneLineWatcherStatus.xml' path='doc/member[@name="PhoneLineWatcherStatus.PhoneLineWatcherStatus_EnumerationCompleted"]/*' />
    PhoneLineWatcherStatus_EnumerationCompleted = 2,

    /// <include file='PhoneLineWatcherStatus.xml' path='doc/member[@name="PhoneLineWatcherStatus.PhoneLineWatcherStatus_Stopped"]/*' />
    PhoneLineWatcherStatus_Stopped = 3,
}
