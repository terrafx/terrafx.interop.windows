// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneCallOperationStatus.xml' path='doc/member[@name="PhoneCallOperationStatus"]/*' />
public enum PhoneCallOperationStatus
{
    /// <include file='PhoneCallOperationStatus.xml' path='doc/member[@name="PhoneCallOperationStatus.PhoneCallOperationStatus_Succeeded"]/*' />
    PhoneCallOperationStatus_Succeeded = 0,

    /// <include file='PhoneCallOperationStatus.xml' path='doc/member[@name="PhoneCallOperationStatus.PhoneCallOperationStatus_OtherFailure"]/*' />
    PhoneCallOperationStatus_OtherFailure = 1,

    /// <include file='PhoneCallOperationStatus.xml' path='doc/member[@name="PhoneCallOperationStatus.PhoneCallOperationStatus_TimedOut"]/*' />
    PhoneCallOperationStatus_TimedOut = 2,

    /// <include file='PhoneCallOperationStatus.xml' path='doc/member[@name="PhoneCallOperationStatus.PhoneCallOperationStatus_ConnectionLost"]/*' />
    PhoneCallOperationStatus_ConnectionLost = 3,

    /// <include file='PhoneCallOperationStatus.xml' path='doc/member[@name="PhoneCallOperationStatus.PhoneCallOperationStatus_InvalidCallState"]/*' />
    PhoneCallOperationStatus_InvalidCallState = 4,
}
