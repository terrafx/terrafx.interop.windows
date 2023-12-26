// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='SmsMessageFilter.xml' path='doc/member[@name="SmsMessageFilter"]/*' />
[Obsolete("SmsMessageFilter may be altered or unavailable for releases after Windows 10.")]
public enum SmsMessageFilter
{
    /// <include file='SmsMessageFilter.xml' path='doc/member[@name="SmsMessageFilter.SmsMessageFilter_All"]/*' />
    SmsMessageFilter_All = 0,

    /// <include file='SmsMessageFilter.xml' path='doc/member[@name="SmsMessageFilter.SmsMessageFilter_Unread"]/*' />
    SmsMessageFilter_Unread = 1,

    /// <include file='SmsMessageFilter.xml' path='doc/member[@name="SmsMessageFilter.SmsMessageFilter_Read"]/*' />
    SmsMessageFilter_Read = 2,

    /// <include file='SmsMessageFilter.xml' path='doc/member[@name="SmsMessageFilter.SmsMessageFilter_Sent"]/*' />
    SmsMessageFilter_Sent = 3,

    /// <include file='SmsMessageFilter.xml' path='doc/member[@name="SmsMessageFilter.SmsMessageFilter_Draft"]/*' />
    SmsMessageFilter_Draft = 4,
}
