// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus"]/*' />
public enum StatelessAppServiceResponseStatus
{
    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_Success"]/*' />
    StatelessAppServiceResponseStatus_Success = 0,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_AppNotInstalled"]/*' />
    StatelessAppServiceResponseStatus_AppNotInstalled = 1,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_AppUnavailable"]/*' />
    StatelessAppServiceResponseStatus_AppUnavailable = 2,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_AppServiceUnavailable"]/*' />
    StatelessAppServiceResponseStatus_AppServiceUnavailable = 3,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_RemoteSystemUnavailable"]/*' />
    StatelessAppServiceResponseStatus_RemoteSystemUnavailable = 4,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_RemoteSystemNotSupportedByApp"]/*' />
    StatelessAppServiceResponseStatus_RemoteSystemNotSupportedByApp = 5,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_NotAuthorized"]/*' />
    StatelessAppServiceResponseStatus_NotAuthorized = 6,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_ResourceLimitsExceeded"]/*' />
    StatelessAppServiceResponseStatus_ResourceLimitsExceeded = 7,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_MessageSizeTooLarge"]/*' />
    StatelessAppServiceResponseStatus_MessageSizeTooLarge = 8,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_Failure"]/*' />
    StatelessAppServiceResponseStatus_Failure = 9,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_Unknown"]/*' />
    StatelessAppServiceResponseStatus_Unknown = 10,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_AuthenticationError"]/*' />
    StatelessAppServiceResponseStatus_AuthenticationError = 11,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_NetworkNotAvailable"]/*' />
    StatelessAppServiceResponseStatus_NetworkNotAvailable = 12,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_DisabledByPolicy"]/*' />
    StatelessAppServiceResponseStatus_DisabledByPolicy = 13,

    /// <include file='StatelessAppServiceResponseStatus.xml' path='doc/member[@name="StatelessAppServiceResponseStatus.StatelessAppServiceResponseStatus_WebServiceUnavailable"]/*' />
    StatelessAppServiceResponseStatus_WebServiceUnavailable = 14,
}
