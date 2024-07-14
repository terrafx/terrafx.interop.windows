// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneCallStatus.xml' path='doc/member[@name="PhoneCallStatus"]/*' />
public enum PhoneCallStatus
{
    /// <include file='PhoneCallStatus.xml' path='doc/member[@name="PhoneCallStatus.PhoneCallStatus_Lost"]/*' />
    PhoneCallStatus_Lost = 0,

    /// <include file='PhoneCallStatus.xml' path='doc/member[@name="PhoneCallStatus.PhoneCallStatus_Incoming"]/*' />
    PhoneCallStatus_Incoming = 1,

    /// <include file='PhoneCallStatus.xml' path='doc/member[@name="PhoneCallStatus.PhoneCallStatus_Dialing"]/*' />
    PhoneCallStatus_Dialing = 2,

    /// <include file='PhoneCallStatus.xml' path='doc/member[@name="PhoneCallStatus.PhoneCallStatus_Talking"]/*' />
    PhoneCallStatus_Talking = 3,

    /// <include file='PhoneCallStatus.xml' path='doc/member[@name="PhoneCallStatus.PhoneCallStatus_Held"]/*' />
    PhoneCallStatus_Held = 4,

    /// <include file='PhoneCallStatus.xml' path='doc/member[@name="PhoneCallStatus.PhoneCallStatus_Ended"]/*' />
    PhoneCallStatus_Ended = 5,
}
