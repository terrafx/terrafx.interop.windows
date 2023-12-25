// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmsGeographicalScope.xml' path='doc/member[@name="SmsGeographicalScope"]/*' />
public enum SmsGeographicalScope
{
    /// <include file='SmsGeographicalScope.xml' path='doc/member[@name="SmsGeographicalScope.SmsGeographicalScope_None"]/*' />
    SmsGeographicalScope_None = 0,

    /// <include file='SmsGeographicalScope.xml' path='doc/member[@name="SmsGeographicalScope.SmsGeographicalScope_CellWithImmediateDisplay"]/*' />
    SmsGeographicalScope_CellWithImmediateDisplay = 1,

    /// <include file='SmsGeographicalScope.xml' path='doc/member[@name="SmsGeographicalScope.SmsGeographicalScope_LocationArea"]/*' />
    SmsGeographicalScope_LocationArea = 2,

    /// <include file='SmsGeographicalScope.xml' path='doc/member[@name="SmsGeographicalScope.SmsGeographicalScope_Plmn"]/*' />
    SmsGeographicalScope_Plmn = 3,

    /// <include file='SmsGeographicalScope.xml' path='doc/member[@name="SmsGeographicalScope.SmsGeographicalScope_Cell"]/*' />
    SmsGeographicalScope_Cell = 4,
}
