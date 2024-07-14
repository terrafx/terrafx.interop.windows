// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppDiagnosticInfoWatcherStatus.xml' path='doc/member[@name="AppDiagnosticInfoWatcherStatus"]/*' />
public enum AppDiagnosticInfoWatcherStatus
{
    /// <include file='AppDiagnosticInfoWatcherStatus.xml' path='doc/member[@name="AppDiagnosticInfoWatcherStatus.AppDiagnosticInfoWatcherStatus_Created"]/*' />
    AppDiagnosticInfoWatcherStatus_Created = 0,

    /// <include file='AppDiagnosticInfoWatcherStatus.xml' path='doc/member[@name="AppDiagnosticInfoWatcherStatus.AppDiagnosticInfoWatcherStatus_Started"]/*' />
    AppDiagnosticInfoWatcherStatus_Started = 1,

    /// <include file='AppDiagnosticInfoWatcherStatus.xml' path='doc/member[@name="AppDiagnosticInfoWatcherStatus.AppDiagnosticInfoWatcherStatus_EnumerationCompleted"]/*' />
    AppDiagnosticInfoWatcherStatus_EnumerationCompleted = 2,

    /// <include file='AppDiagnosticInfoWatcherStatus.xml' path='doc/member[@name="AppDiagnosticInfoWatcherStatus.AppDiagnosticInfoWatcherStatus_Stopping"]/*' />
    AppDiagnosticInfoWatcherStatus_Stopping = 3,

    /// <include file='AppDiagnosticInfoWatcherStatus.xml' path='doc/member[@name="AppDiagnosticInfoWatcherStatus.AppDiagnosticInfoWatcherStatus_Stopped"]/*' />
    AppDiagnosticInfoWatcherStatus_Stopped = 4,

    /// <include file='AppDiagnosticInfoWatcherStatus.xml' path='doc/member[@name="AppDiagnosticInfoWatcherStatus.AppDiagnosticInfoWatcherStatus_Aborted"]/*' />
    AppDiagnosticInfoWatcherStatus_Aborted = 5,
}
