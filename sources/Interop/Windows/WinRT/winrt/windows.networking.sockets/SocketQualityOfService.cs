// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SocketQualityOfService.xml' path='doc/member[@name="SocketQualityOfService"]/*' />
public enum SocketQualityOfService
{
    /// <include file='SocketQualityOfService.xml' path='doc/member[@name="SocketQualityOfService.SocketQualityOfService_Normal"]/*' />
    SocketQualityOfService_Normal = 0,

    /// <include file='SocketQualityOfService.xml' path='doc/member[@name="SocketQualityOfService.SocketQualityOfService_LowLatency"]/*' />
    SocketQualityOfService_LowLatency = 1,
}
