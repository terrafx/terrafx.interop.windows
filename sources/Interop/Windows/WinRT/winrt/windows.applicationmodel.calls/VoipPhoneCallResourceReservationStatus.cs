// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VoipPhoneCallResourceReservationStatus.xml' path='doc/member[@name="VoipPhoneCallResourceReservationStatus"]/*' />
public enum VoipPhoneCallResourceReservationStatus
{
    /// <include file='VoipPhoneCallResourceReservationStatus.xml' path='doc/member[@name="VoipPhoneCallResourceReservationStatus.VoipPhoneCallResourceReservationStatus_Success"]/*' />
    VoipPhoneCallResourceReservationStatus_Success = 0,

    /// <include file='VoipPhoneCallResourceReservationStatus.xml' path='doc/member[@name="VoipPhoneCallResourceReservationStatus.VoipPhoneCallResourceReservationStatus_ResourcesNotAvailable"]/*' />
    VoipPhoneCallResourceReservationStatus_ResourcesNotAvailable = 1,
}
