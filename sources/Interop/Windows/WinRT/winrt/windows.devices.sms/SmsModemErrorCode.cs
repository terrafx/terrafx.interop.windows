// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmsModemErrorCode.xml' path='doc/member[@name="SmsModemErrorCode"]/*' />
public enum SmsModemErrorCode
{
    /// <include file='SmsModemErrorCode.xml' path='doc/member[@name="SmsModemErrorCode.SmsModemErrorCode_Other"]/*' />
    SmsModemErrorCode_Other = 0,

    /// <include file='SmsModemErrorCode.xml' path='doc/member[@name="SmsModemErrorCode.SmsModemErrorCode_MessagingNetworkError"]/*' />
    SmsModemErrorCode_MessagingNetworkError = 1,

    /// <include file='SmsModemErrorCode.xml' path='doc/member[@name="SmsModemErrorCode.SmsModemErrorCode_SmsOperationNotSupportedByDevice"]/*' />
    SmsModemErrorCode_SmsOperationNotSupportedByDevice = 2,

    /// <include file='SmsModemErrorCode.xml' path='doc/member[@name="SmsModemErrorCode.SmsModemErrorCode_SmsServiceNotSupportedByNetwork"]/*' />
    SmsModemErrorCode_SmsServiceNotSupportedByNetwork = 3,

    /// <include file='SmsModemErrorCode.xml' path='doc/member[@name="SmsModemErrorCode.SmsModemErrorCode_DeviceFailure"]/*' />
    SmsModemErrorCode_DeviceFailure = 4,

    /// <include file='SmsModemErrorCode.xml' path='doc/member[@name="SmsModemErrorCode.SmsModemErrorCode_MessageNotEncodedProperly"]/*' />
    SmsModemErrorCode_MessageNotEncodedProperly = 5,

    /// <include file='SmsModemErrorCode.xml' path='doc/member[@name="SmsModemErrorCode.SmsModemErrorCode_MessageTooLarge"]/*' />
    SmsModemErrorCode_MessageTooLarge = 6,

    /// <include file='SmsModemErrorCode.xml' path='doc/member[@name="SmsModemErrorCode.SmsModemErrorCode_DeviceNotReady"]/*' />
    SmsModemErrorCode_DeviceNotReady = 7,

    /// <include file='SmsModemErrorCode.xml' path='doc/member[@name="SmsModemErrorCode.SmsModemErrorCode_NetworkNotReady"]/*' />
    SmsModemErrorCode_NetworkNotReady = 8,

    /// <include file='SmsModemErrorCode.xml' path='doc/member[@name="SmsModemErrorCode.SmsModemErrorCode_InvalidSmscAddress"]/*' />
    SmsModemErrorCode_InvalidSmscAddress = 9,

    /// <include file='SmsModemErrorCode.xml' path='doc/member[@name="SmsModemErrorCode.SmsModemErrorCode_NetworkFailure"]/*' />
    SmsModemErrorCode_NetworkFailure = 10,

    /// <include file='SmsModemErrorCode.xml' path='doc/member[@name="SmsModemErrorCode.SmsModemErrorCode_FixedDialingNumberRestricted"]/*' />
    SmsModemErrorCode_FixedDialingNumberRestricted = 11,
}
