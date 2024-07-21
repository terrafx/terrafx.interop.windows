// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmsEncoding.xml' path='doc/member[@name="SmsEncoding"]/*' />
public enum SmsEncoding
{
    /// <include file='SmsEncoding.xml' path='doc/member[@name="SmsEncoding.SmsEncoding_Unknown"]/*' />
    SmsEncoding_Unknown = 0,

    /// <include file='SmsEncoding.xml' path='doc/member[@name="SmsEncoding.SmsEncoding_Optimal"]/*' />
    SmsEncoding_Optimal = 1,

    /// <include file='SmsEncoding.xml' path='doc/member[@name="SmsEncoding.SmsEncoding_SevenBitAscii"]/*' />
    SmsEncoding_SevenBitAscii = 2,

    /// <include file='SmsEncoding.xml' path='doc/member[@name="SmsEncoding.SmsEncoding_Unicode"]/*' />
    SmsEncoding_Unicode = 3,

    /// <include file='SmsEncoding.xml' path='doc/member[@name="SmsEncoding.SmsEncoding_GsmSevenBit"]/*' />
    SmsEncoding_GsmSevenBit = 4,

    /// <include file='SmsEncoding.xml' path='doc/member[@name="SmsEncoding.SmsEncoding_EightBit"]/*' />
    SmsEncoding_EightBit = 5,

    /// <include file='SmsEncoding.xml' path='doc/member[@name="SmsEncoding.SmsEncoding_Latin"]/*' />
    SmsEncoding_Latin = 6,

    /// <include file='SmsEncoding.xml' path='doc/member[@name="SmsEncoding.SmsEncoding_Korean"]/*' />
    SmsEncoding_Korean = 7,

    /// <include file='SmsEncoding.xml' path='doc/member[@name="SmsEncoding.SmsEncoding_IA5"]/*' />
    SmsEncoding_IA5 = 8,

    /// <include file='SmsEncoding.xml' path='doc/member[@name="SmsEncoding.SmsEncoding_ShiftJis"]/*' />
    SmsEncoding_ShiftJis = 9,

    /// <include file='SmsEncoding.xml' path='doc/member[@name="SmsEncoding.SmsEncoding_LatinHebrew"]/*' />
    SmsEncoding_LatinHebrew = 10,
}
