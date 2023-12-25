// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VoipPhoneCallRejectReason.xml' path='doc/member[@name="VoipPhoneCallRejectReason"]/*' />
public enum VoipPhoneCallRejectReason
{
    /// <include file='VoipPhoneCallRejectReason.xml' path='doc/member[@name="VoipPhoneCallRejectReason.VoipPhoneCallRejectReason_UserIgnored"]/*' />
    VoipPhoneCallRejectReason_UserIgnored = 0,

    /// <include file='VoipPhoneCallRejectReason.xml' path='doc/member[@name="VoipPhoneCallRejectReason.VoipPhoneCallRejectReason_TimedOut"]/*' />
    VoipPhoneCallRejectReason_TimedOut = 1,

    /// <include file='VoipPhoneCallRejectReason.xml' path='doc/member[@name="VoipPhoneCallRejectReason.VoipPhoneCallRejectReason_OtherIncomingCall"]/*' />
    VoipPhoneCallRejectReason_OtherIncomingCall = 2,

    /// <include file='VoipPhoneCallRejectReason.xml' path='doc/member[@name="VoipPhoneCallRejectReason.VoipPhoneCallRejectReason_EmergencyCallExists"]/*' />
    VoipPhoneCallRejectReason_EmergencyCallExists = 3,

    /// <include file='VoipPhoneCallRejectReason.xml' path='doc/member[@name="VoipPhoneCallRejectReason.VoipPhoneCallRejectReason_InvalidCallState"]/*' />
    VoipPhoneCallRejectReason_InvalidCallState = 4,
}
