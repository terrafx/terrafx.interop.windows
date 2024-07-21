// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteSystemAccessStatus.xml' path='doc/member[@name="RemoteSystemAccessStatus"]/*' />
public enum RemoteSystemAccessStatus
{
    /// <include file='RemoteSystemAccessStatus.xml' path='doc/member[@name="RemoteSystemAccessStatus.RemoteSystemAccessStatus_Unspecified"]/*' />
    RemoteSystemAccessStatus_Unspecified = 0,

    /// <include file='RemoteSystemAccessStatus.xml' path='doc/member[@name="RemoteSystemAccessStatus.RemoteSystemAccessStatus_Allowed"]/*' />
    RemoteSystemAccessStatus_Allowed = 1,

    /// <include file='RemoteSystemAccessStatus.xml' path='doc/member[@name="RemoteSystemAccessStatus.RemoteSystemAccessStatus_DeniedByUser"]/*' />
    RemoteSystemAccessStatus_DeniedByUser = 2,

    /// <include file='RemoteSystemAccessStatus.xml' path='doc/member[@name="RemoteSystemAccessStatus.RemoteSystemAccessStatus_DeniedBySystem"]/*' />
    RemoteSystemAccessStatus_DeniedBySystem = 3,
}
