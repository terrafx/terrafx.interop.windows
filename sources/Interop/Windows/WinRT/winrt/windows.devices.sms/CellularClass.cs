// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CellularClass.xml' path='doc/member[@name="CellularClass"]/*' />
public enum CellularClass
{
    /// <include file='CellularClass.xml' path='doc/member[@name="CellularClass.CellularClass_None"]/*' />
    CellularClass_None = 0,

    /// <include file='CellularClass.xml' path='doc/member[@name="CellularClass.CellularClass_Gsm"]/*' />
    CellularClass_Gsm = 1,

    /// <include file='CellularClass.xml' path='doc/member[@name="CellularClass.CellularClass_Cdma"]/*' />
    CellularClass_Cdma = 2,
}
