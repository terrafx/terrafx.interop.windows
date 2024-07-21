// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus"]/*' />
public enum SocketErrorStatus
{
    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_Unknown"]/*' />
    SocketErrorStatus_Unknown = 0,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_OperationAborted"]/*' />
    SocketErrorStatus_OperationAborted = 1,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_HttpInvalidServerResponse"]/*' />
    SocketErrorStatus_HttpInvalidServerResponse = 2,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_ConnectionTimedOut"]/*' />
    SocketErrorStatus_ConnectionTimedOut = 3,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_AddressFamilyNotSupported"]/*' />
    SocketErrorStatus_AddressFamilyNotSupported = 4,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_SocketTypeNotSupported"]/*' />
    SocketErrorStatus_SocketTypeNotSupported = 5,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_HostNotFound"]/*' />
    SocketErrorStatus_HostNotFound = 6,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_NoDataRecordOfRequestedType"]/*' />
    SocketErrorStatus_NoDataRecordOfRequestedType = 7,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_NonAuthoritativeHostNotFound"]/*' />
    SocketErrorStatus_NonAuthoritativeHostNotFound = 8,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_ClassTypeNotFound"]/*' />
    SocketErrorStatus_ClassTypeNotFound = 9,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_AddressAlreadyInUse"]/*' />
    SocketErrorStatus_AddressAlreadyInUse = 10,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_CannotAssignRequestedAddress"]/*' />
    SocketErrorStatus_CannotAssignRequestedAddress = 11,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_ConnectionRefused"]/*' />
    SocketErrorStatus_ConnectionRefused = 12,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_NetworkIsUnreachable"]/*' />
    SocketErrorStatus_NetworkIsUnreachable = 13,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_UnreachableHost"]/*' />
    SocketErrorStatus_UnreachableHost = 14,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_NetworkIsDown"]/*' />
    SocketErrorStatus_NetworkIsDown = 15,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_NetworkDroppedConnectionOnReset"]/*' />
    SocketErrorStatus_NetworkDroppedConnectionOnReset = 16,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_SoftwareCausedConnectionAbort"]/*' />
    SocketErrorStatus_SoftwareCausedConnectionAbort = 17,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_ConnectionResetByPeer"]/*' />
    SocketErrorStatus_ConnectionResetByPeer = 18,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_HostIsDown"]/*' />
    SocketErrorStatus_HostIsDown = 19,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_NoAddressesFound"]/*' />
    SocketErrorStatus_NoAddressesFound = 20,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_TooManyOpenFiles"]/*' />
    SocketErrorStatus_TooManyOpenFiles = 21,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_MessageTooLong"]/*' />
    SocketErrorStatus_MessageTooLong = 22,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_CertificateExpired"]/*' />
    SocketErrorStatus_CertificateExpired = 23,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_CertificateUntrustedRoot"]/*' />
    SocketErrorStatus_CertificateUntrustedRoot = 24,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_CertificateCommonNameIsIncorrect"]/*' />
    SocketErrorStatus_CertificateCommonNameIsIncorrect = 25,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_CertificateWrongUsage"]/*' />
    SocketErrorStatus_CertificateWrongUsage = 26,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_CertificateRevoked"]/*' />
    SocketErrorStatus_CertificateRevoked = 27,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_CertificateNoRevocationCheck"]/*' />
    SocketErrorStatus_CertificateNoRevocationCheck = 28,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_CertificateRevocationServerOffline"]/*' />
    SocketErrorStatus_CertificateRevocationServerOffline = 29,

    /// <include file='SocketErrorStatus.xml' path='doc/member[@name="SocketErrorStatus.SocketErrorStatus_CertificateIsInvalid"]/*' />
    SocketErrorStatus_CertificateIsInvalid = 30,
}
