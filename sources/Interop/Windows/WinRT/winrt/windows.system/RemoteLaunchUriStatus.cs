// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteLaunchUriStatus.xml' path='doc/member[@name="RemoteLaunchUriStatus"]/*' />
public enum RemoteLaunchUriStatus
{
    /// <include file='RemoteLaunchUriStatus.xml' path='doc/member[@name="RemoteLaunchUriStatus.RemoteLaunchUriStatus_Unknown"]/*' />
    RemoteLaunchUriStatus_Unknown = 0,

    /// <include file='RemoteLaunchUriStatus.xml' path='doc/member[@name="RemoteLaunchUriStatus.RemoteLaunchUriStatus_Success"]/*' />
    RemoteLaunchUriStatus_Success = 1,

    /// <include file='RemoteLaunchUriStatus.xml' path='doc/member[@name="RemoteLaunchUriStatus.RemoteLaunchUriStatus_AppUnavailable"]/*' />
    RemoteLaunchUriStatus_AppUnavailable = 2,

    /// <include file='RemoteLaunchUriStatus.xml' path='doc/member[@name="RemoteLaunchUriStatus.RemoteLaunchUriStatus_ProtocolUnavailable"]/*' />
    RemoteLaunchUriStatus_ProtocolUnavailable = 3,

    /// <include file='RemoteLaunchUriStatus.xml' path='doc/member[@name="RemoteLaunchUriStatus.RemoteLaunchUriStatus_RemoteSystemUnavailable"]/*' />
    RemoteLaunchUriStatus_RemoteSystemUnavailable = 4,

    /// <include file='RemoteLaunchUriStatus.xml' path='doc/member[@name="RemoteLaunchUriStatus.RemoteLaunchUriStatus_ValueSetTooLarge"]/*' />
    RemoteLaunchUriStatus_ValueSetTooLarge = 5,

    /// <include file='RemoteLaunchUriStatus.xml' path='doc/member[@name="RemoteLaunchUriStatus.RemoteLaunchUriStatus_DeniedByLocalSystem"]/*' />
    RemoteLaunchUriStatus_DeniedByLocalSystem = 6,

    /// <include file='RemoteLaunchUriStatus.xml' path='doc/member[@name="RemoteLaunchUriStatus.RemoteLaunchUriStatus_DeniedByRemoteSystem"]/*' />
    RemoteLaunchUriStatus_DeniedByRemoteSystem = 7,
}
