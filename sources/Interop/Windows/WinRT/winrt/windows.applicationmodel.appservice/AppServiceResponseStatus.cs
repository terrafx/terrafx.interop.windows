// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppServiceResponseStatus.xml' path='doc/member[@name="AppServiceResponseStatus"]/*' />
public enum AppServiceResponseStatus
{
    /// <include file='AppServiceResponseStatus.xml' path='doc/member[@name="AppServiceResponseStatus.AppServiceResponseStatus_Success"]/*' />
    AppServiceResponseStatus_Success = 0,

    /// <include file='AppServiceResponseStatus.xml' path='doc/member[@name="AppServiceResponseStatus.AppServiceResponseStatus_Failure"]/*' />
    AppServiceResponseStatus_Failure = 1,

    /// <include file='AppServiceResponseStatus.xml' path='doc/member[@name="AppServiceResponseStatus.AppServiceResponseStatus_ResourceLimitsExceeded"]/*' />
    AppServiceResponseStatus_ResourceLimitsExceeded = 2,

    /// <include file='AppServiceResponseStatus.xml' path='doc/member[@name="AppServiceResponseStatus.AppServiceResponseStatus_Unknown"]/*' />
    AppServiceResponseStatus_Unknown = 3,

    /// <include file='AppServiceResponseStatus.xml' path='doc/member[@name="AppServiceResponseStatus.AppServiceResponseStatus_RemoteSystemUnavailable"]/*' />
    AppServiceResponseStatus_RemoteSystemUnavailable = 4,

    /// <include file='AppServiceResponseStatus.xml' path='doc/member[@name="AppServiceResponseStatus.AppServiceResponseStatus_MessageSizeTooLarge"]/*' />
    AppServiceResponseStatus_MessageSizeTooLarge = 5,

    /// <include file='AppServiceResponseStatus.xml' path='doc/member[@name="AppServiceResponseStatus.AppServiceResponseStatus_AppUnavailable"]/*' />
    AppServiceResponseStatus_AppUnavailable = 6,

    /// <include file='AppServiceResponseStatus.xml' path='doc/member[@name="AppServiceResponseStatus.AppServiceResponseStatus_AuthenticationError"]/*' />
    AppServiceResponseStatus_AuthenticationError = 7,

    /// <include file='AppServiceResponseStatus.xml' path='doc/member[@name="AppServiceResponseStatus.AppServiceResponseStatus_NetworkNotAvailable"]/*' />
    AppServiceResponseStatus_NetworkNotAvailable = 8,

    /// <include file='AppServiceResponseStatus.xml' path='doc/member[@name="AppServiceResponseStatus.AppServiceResponseStatus_DisabledByPolicy"]/*' />
    AppServiceResponseStatus_DisabledByPolicy = 9,

    /// <include file='AppServiceResponseStatus.xml' path='doc/member[@name="AppServiceResponseStatus.AppServiceResponseStatus_WebServiceUnavailable"]/*' />
    AppServiceResponseStatus_WebServiceUnavailable = 10,
}
