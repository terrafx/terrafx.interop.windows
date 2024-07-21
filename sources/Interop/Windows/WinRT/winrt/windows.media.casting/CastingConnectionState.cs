// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.casting.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CastingConnectionState.xml' path='doc/member[@name="CastingConnectionState"]/*' />
public enum CastingConnectionState
{
    /// <include file='CastingConnectionState.xml' path='doc/member[@name="CastingConnectionState.CastingConnectionState_Disconnected"]/*' />
    CastingConnectionState_Disconnected = 0,

    /// <include file='CastingConnectionState.xml' path='doc/member[@name="CastingConnectionState.CastingConnectionState_Connected"]/*' />
    CastingConnectionState_Connected = 1,

    /// <include file='CastingConnectionState.xml' path='doc/member[@name="CastingConnectionState.CastingConnectionState_Rendering"]/*' />
    CastingConnectionState_Rendering = 2,

    /// <include file='CastingConnectionState.xml' path='doc/member[@name="CastingConnectionState.CastingConnectionState_Disconnecting"]/*' />
    CastingConnectionState_Disconnecting = 3,

    /// <include file='CastingConnectionState.xml' path='doc/member[@name="CastingConnectionState.CastingConnectionState_Connecting"]/*' />
    CastingConnectionState_Connecting = 4,
}
