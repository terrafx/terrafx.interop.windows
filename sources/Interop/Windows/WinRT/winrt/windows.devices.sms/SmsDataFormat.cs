// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmsDataFormat.xml' path='doc/member[@name="SmsDataFormat"]/*' />
public enum SmsDataFormat
{
    /// <include file='SmsDataFormat.xml' path='doc/member[@name="SmsDataFormat.SmsDataFormat_Unknown"]/*' />
    SmsDataFormat_Unknown = 0,

    /// <include file='SmsDataFormat.xml' path='doc/member[@name="SmsDataFormat.SmsDataFormat_CdmaSubmit"]/*' />
    SmsDataFormat_CdmaSubmit = 1,

    /// <include file='SmsDataFormat.xml' path='doc/member[@name="SmsDataFormat.SmsDataFormat_GsmSubmit"]/*' />
    SmsDataFormat_GsmSubmit = 2,

    /// <include file='SmsDataFormat.xml' path='doc/member[@name="SmsDataFormat.SmsDataFormat_CdmaDeliver"]/*' />
    SmsDataFormat_CdmaDeliver = 3,

    /// <include file='SmsDataFormat.xml' path='doc/member[@name="SmsDataFormat.SmsDataFormat_GsmDeliver"]/*' />
    SmsDataFormat_GsmDeliver = 4,
}
