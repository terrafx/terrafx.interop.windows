// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneLineOperationStatus.xml' path='doc/member[@name="PhoneLineOperationStatus"]/*' />
public enum PhoneLineOperationStatus
{
    /// <include file='PhoneLineOperationStatus.xml' path='doc/member[@name="PhoneLineOperationStatus.PhoneLineOperationStatus_Succeeded"]/*' />
    PhoneLineOperationStatus_Succeeded = 0,

    /// <include file='PhoneLineOperationStatus.xml' path='doc/member[@name="PhoneLineOperationStatus.PhoneLineOperationStatus_OtherFailure"]/*' />
    PhoneLineOperationStatus_OtherFailure = 1,

    /// <include file='PhoneLineOperationStatus.xml' path='doc/member[@name="PhoneLineOperationStatus.PhoneLineOperationStatus_TimedOut"]/*' />
    PhoneLineOperationStatus_TimedOut = 2,

    /// <include file='PhoneLineOperationStatus.xml' path='doc/member[@name="PhoneLineOperationStatus.PhoneLineOperationStatus_ConnectionLost"]/*' />
    PhoneLineOperationStatus_ConnectionLost = 3,

    /// <include file='PhoneLineOperationStatus.xml' path='doc/member[@name="PhoneLineOperationStatus.PhoneLineOperationStatus_InvalidCallState"]/*' />
    PhoneLineOperationStatus_InvalidCallState = 4,
}
