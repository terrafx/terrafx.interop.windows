// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VoipPhoneCallState.xml' path='doc/member[@name="VoipPhoneCallState"]/*' />
public enum VoipPhoneCallState
{
    /// <include file='VoipPhoneCallState.xml' path='doc/member[@name="VoipPhoneCallState.VoipPhoneCallState_Ended"]/*' />
    VoipPhoneCallState_Ended = 0,

    /// <include file='VoipPhoneCallState.xml' path='doc/member[@name="VoipPhoneCallState.VoipPhoneCallState_Held"]/*' />
    VoipPhoneCallState_Held = 1,

    /// <include file='VoipPhoneCallState.xml' path='doc/member[@name="VoipPhoneCallState.VoipPhoneCallState_Active"]/*' />
    VoipPhoneCallState_Active = 2,

    /// <include file='VoipPhoneCallState.xml' path='doc/member[@name="VoipPhoneCallState.VoipPhoneCallState_Incoming"]/*' />
    VoipPhoneCallState_Incoming = 3,

    /// <include file='VoipPhoneCallState.xml' path='doc/member[@name="VoipPhoneCallState.VoipPhoneCallState_Outgoing"]/*' />
    VoipPhoneCallState_Outgoing = 4,
}
