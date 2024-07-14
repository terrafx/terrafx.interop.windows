// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ConnectionStatus.xml' path='doc/member[@name="ConnectionStatus"]/*' />
public enum ConnectionStatus
{
    /// <include file='ConnectionStatus.xml' path='doc/member[@name="ConnectionStatus.ConnectionStatus_Online"]/*' />
    ConnectionStatus_Online = 0,

    /// <include file='ConnectionStatus.xml' path='doc/member[@name="ConnectionStatus.ConnectionStatus_Offline"]/*' />
    ConnectionStatus_Offline = 1,

    /// <include file='ConnectionStatus.xml' path='doc/member[@name="ConnectionStatus.ConnectionStatus_Sleeping"]/*' />
    ConnectionStatus_Sleeping = 2,
}
