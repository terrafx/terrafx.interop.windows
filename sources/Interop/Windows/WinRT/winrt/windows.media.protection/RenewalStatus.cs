// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RenewalStatus.xml' path='doc/member[@name="RenewalStatus"]/*' />
public enum RenewalStatus
{
    /// <include file='RenewalStatus.xml' path='doc/member[@name="RenewalStatus.RenewalStatus_NotStarted"]/*' />
    RenewalStatus_NotStarted = 0,

    /// <include file='RenewalStatus.xml' path='doc/member[@name="RenewalStatus.RenewalStatus_UpdatesInProgress"]/*' />
    RenewalStatus_UpdatesInProgress = 1,

    /// <include file='RenewalStatus.xml' path='doc/member[@name="RenewalStatus.RenewalStatus_UserCancelled"]/*' />
    RenewalStatus_UserCancelled = 2,

    /// <include file='RenewalStatus.xml' path='doc/member[@name="RenewalStatus.RenewalStatus_AppComponentsMayNeedUpdating"]/*' />
    RenewalStatus_AppComponentsMayNeedUpdating = 3,

    /// <include file='RenewalStatus.xml' path='doc/member[@name="RenewalStatus.RenewalStatus_NoComponentsFound"]/*' />
    RenewalStatus_NoComponentsFound = 4,
}
