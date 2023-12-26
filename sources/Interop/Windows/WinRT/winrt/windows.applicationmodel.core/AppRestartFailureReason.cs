// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppRestartFailureReason.xml' path='doc/member[@name="AppRestartFailureReason"]/*' />
public enum AppRestartFailureReason
{
    /// <include file='AppRestartFailureReason.xml' path='doc/member[@name="AppRestartFailureReason.AppRestartFailureReason_RestartPending"]/*' />
    AppRestartFailureReason_RestartPending = 0,

    /// <include file='AppRestartFailureReason.xml' path='doc/member[@name="AppRestartFailureReason.AppRestartFailureReason_NotInForeground"]/*' />
    AppRestartFailureReason_NotInForeground = 1,

    /// <include file='AppRestartFailureReason.xml' path='doc/member[@name="AppRestartFailureReason.AppRestartFailureReason_InvalidUser"]/*' />
    AppRestartFailureReason_InvalidUser = 2,

    /// <include file='AppRestartFailureReason.xml' path='doc/member[@name="AppRestartFailureReason.AppRestartFailureReason_Other"]/*' />
    AppRestartFailureReason_Other = 3,
}
