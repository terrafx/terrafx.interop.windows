// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.casting.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CastingConnectionErrorStatus.xml' path='doc/member[@name="CastingConnectionErrorStatus"]/*' />
public enum CastingConnectionErrorStatus
{
    /// <include file='CastingConnectionErrorStatus.xml' path='doc/member[@name="CastingConnectionErrorStatus.CastingConnectionErrorStatus_Succeeded"]/*' />
    CastingConnectionErrorStatus_Succeeded = 0,

    /// <include file='CastingConnectionErrorStatus.xml' path='doc/member[@name="CastingConnectionErrorStatus.CastingConnectionErrorStatus_DeviceDidNotRespond"]/*' />
    CastingConnectionErrorStatus_DeviceDidNotRespond = 1,

    /// <include file='CastingConnectionErrorStatus.xml' path='doc/member[@name="CastingConnectionErrorStatus.CastingConnectionErrorStatus_DeviceError"]/*' />
    CastingConnectionErrorStatus_DeviceError = 2,

    /// <include file='CastingConnectionErrorStatus.xml' path='doc/member[@name="CastingConnectionErrorStatus.CastingConnectionErrorStatus_DeviceLocked"]/*' />
    CastingConnectionErrorStatus_DeviceLocked = 3,

    /// <include file='CastingConnectionErrorStatus.xml' path='doc/member[@name="CastingConnectionErrorStatus.CastingConnectionErrorStatus_ProtectedPlaybackFailed"]/*' />
    CastingConnectionErrorStatus_ProtectedPlaybackFailed = 4,

    /// <include file='CastingConnectionErrorStatus.xml' path='doc/member[@name="CastingConnectionErrorStatus.CastingConnectionErrorStatus_InvalidCastingSource"]/*' />
    CastingConnectionErrorStatus_InvalidCastingSource = 5,

    /// <include file='CastingConnectionErrorStatus.xml' path='doc/member[@name="CastingConnectionErrorStatus.CastingConnectionErrorStatus_Unknown"]/*' />
    CastingConnectionErrorStatus_Unknown = 6,
}
