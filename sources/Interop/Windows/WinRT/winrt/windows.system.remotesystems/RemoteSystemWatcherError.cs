// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteSystemWatcherError.xml' path='doc/member[@name="RemoteSystemWatcherError"]/*' />
public enum RemoteSystemWatcherError
{
    /// <include file='RemoteSystemWatcherError.xml' path='doc/member[@name="RemoteSystemWatcherError.RemoteSystemWatcherError_Unknown"]/*' />
    RemoteSystemWatcherError_Unknown = 0,

    /// <include file='RemoteSystemWatcherError.xml' path='doc/member[@name="RemoteSystemWatcherError.RemoteSystemWatcherError_InternetNotAvailable"]/*' />
    RemoteSystemWatcherError_InternetNotAvailable = 1,

    /// <include file='RemoteSystemWatcherError.xml' path='doc/member[@name="RemoteSystemWatcherError.RemoteSystemWatcherError_AuthenticationError"]/*' />
    RemoteSystemWatcherError_AuthenticationError = 2,
}
