// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SocketActivityConnectedStandbyAction.xml' path='doc/member[@name="SocketActivityConnectedStandbyAction"]/*' />
public enum SocketActivityConnectedStandbyAction
{
    /// <include file='SocketActivityConnectedStandbyAction.xml' path='doc/member[@name="SocketActivityConnectedStandbyAction.SocketActivityConnectedStandbyAction_DoNotWake"]/*' />
    SocketActivityConnectedStandbyAction_DoNotWake = 0,

    /// <include file='SocketActivityConnectedStandbyAction.xml' path='doc/member[@name="SocketActivityConnectedStandbyAction.SocketActivityConnectedStandbyAction_Wake"]/*' />
    SocketActivityConnectedStandbyAction_Wake = 1,
}
