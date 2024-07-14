// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass"]/*' />
[NativeTypeName("unsigned int")]
public enum WwanDataClass : uint
{
    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_None"]/*' />
    WwanDataClass_None = 0,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_Gprs"]/*' />
    WwanDataClass_Gprs = 0x1,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_Edge"]/*' />
    WwanDataClass_Edge = 0x2,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_Umts"]/*' />
    WwanDataClass_Umts = 0x4,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_Hsdpa"]/*' />
    WwanDataClass_Hsdpa = 0x8,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_Hsupa"]/*' />
    WwanDataClass_Hsupa = 0x10,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_LteAdvanced"]/*' />
    WwanDataClass_LteAdvanced = 0x20,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_Cdma1xRtt"]/*' />
    WwanDataClass_Cdma1xRtt = 0x10000,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_Cdma1xEvdo"]/*' />
    WwanDataClass_Cdma1xEvdo = 0x20000,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_Cdma1xEvdoRevA"]/*' />
    WwanDataClass_Cdma1xEvdoRevA = 0x40000,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_Cdma1xEvdv"]/*' />
    WwanDataClass_Cdma1xEvdv = 0x80000,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_Cdma3xRtt"]/*' />
    WwanDataClass_Cdma3xRtt = 0x100000,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_Cdma1xEvdoRevB"]/*' />
    WwanDataClass_Cdma1xEvdoRevB = 0x200000,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_CdmaUmb"]/*' />
    WwanDataClass_CdmaUmb = 0x400000,

    /// <include file='WwanDataClass.xml' path='doc/member[@name="WwanDataClass.WwanDataClass_Custom"]/*' />
    WwanDataClass_Custom = 0x80000000,
}
