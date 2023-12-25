// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppServiceConnectionStatus.xml' path='doc/member[@name="AppServiceConnectionStatus"]/*' />
public enum AppServiceConnectionStatus
{
    /// <include file='AppServiceConnectionStatus.xml' path='doc/member[@name="AppServiceConnectionStatus.AppServiceConnectionStatus_Success"]/*' />
    AppServiceConnectionStatus_Success = 0,

    /// <include file='AppServiceConnectionStatus.xml' path='doc/member[@name="AppServiceConnectionStatus.AppServiceConnectionStatus_AppNotInstalled"]/*' />
    AppServiceConnectionStatus_AppNotInstalled = 1,

    /// <include file='AppServiceConnectionStatus.xml' path='doc/member[@name="AppServiceConnectionStatus.AppServiceConnectionStatus_AppUnavailable"]/*' />
    AppServiceConnectionStatus_AppUnavailable = 2,

    /// <include file='AppServiceConnectionStatus.xml' path='doc/member[@name="AppServiceConnectionStatus.AppServiceConnectionStatus_AppServiceUnavailable"]/*' />
    AppServiceConnectionStatus_AppServiceUnavailable = 3,

    /// <include file='AppServiceConnectionStatus.xml' path='doc/member[@name="AppServiceConnectionStatus.AppServiceConnectionStatus_Unknown"]/*' />
    AppServiceConnectionStatus_Unknown = 4,

    /// <include file='AppServiceConnectionStatus.xml' path='doc/member[@name="AppServiceConnectionStatus.AppServiceConnectionStatus_RemoteSystemUnavailable"]/*' />
    AppServiceConnectionStatus_RemoteSystemUnavailable = 5,

    /// <include file='AppServiceConnectionStatus.xml' path='doc/member[@name="AppServiceConnectionStatus.AppServiceConnectionStatus_RemoteSystemNotSupportedByApp"]/*' />
    AppServiceConnectionStatus_RemoteSystemNotSupportedByApp = 6,

    /// <include file='AppServiceConnectionStatus.xml' path='doc/member[@name="AppServiceConnectionStatus.AppServiceConnectionStatus_NotAuthorized"]/*' />
    AppServiceConnectionStatus_NotAuthorized = 7,

    /// <include file='AppServiceConnectionStatus.xml' path='doc/member[@name="AppServiceConnectionStatus.AppServiceConnectionStatus_AuthenticationError"]/*' />
    AppServiceConnectionStatus_AuthenticationError = 8,

    /// <include file='AppServiceConnectionStatus.xml' path='doc/member[@name="AppServiceConnectionStatus.AppServiceConnectionStatus_NetworkNotAvailable"]/*' />
    AppServiceConnectionStatus_NetworkNotAvailable = 9,

    /// <include file='AppServiceConnectionStatus.xml' path='doc/member[@name="AppServiceConnectionStatus.AppServiceConnectionStatus_DisabledByPolicy"]/*' />
    AppServiceConnectionStatus_DisabledByPolicy = 10,

    /// <include file='AppServiceConnectionStatus.xml' path='doc/member[@name="AppServiceConnectionStatus.AppServiceConnectionStatus_WebServiceUnavailable"]/*' />
    AppServiceConnectionStatus_WebServiceUnavailable = 11,
}
