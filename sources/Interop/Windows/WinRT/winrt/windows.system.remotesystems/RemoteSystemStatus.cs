// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteSystemStatus.xml' path='doc/member[@name="RemoteSystemStatus"]/*' />
public enum RemoteSystemStatus
{
    /// <include file='RemoteSystemStatus.xml' path='doc/member[@name="RemoteSystemStatus.RemoteSystemStatus_Unavailable"]/*' />
    RemoteSystemStatus_Unavailable = 0,

    /// <include file='RemoteSystemStatus.xml' path='doc/member[@name="RemoteSystemStatus.RemoteSystemStatus_DiscoveringAvailability"]/*' />
    RemoteSystemStatus_DiscoveringAvailability = 1,

    /// <include file='RemoteSystemStatus.xml' path='doc/member[@name="RemoteSystemStatus.RemoteSystemStatus_Available"]/*' />
    RemoteSystemStatus_Available = 2,

    /// <include file='RemoteSystemStatus.xml' path='doc/member[@name="RemoteSystemStatus.RemoteSystemStatus_Unknown"]/*' />
    RemoteSystemStatus_Unknown = 3,
}
