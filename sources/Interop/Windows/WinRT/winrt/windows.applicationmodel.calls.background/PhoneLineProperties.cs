// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneLineProperties.xml' path='doc/member[@name="PhoneLineProperties"]/*' />
[NativeTypeName("unsigned int")]
public enum PhoneLineProperties : uint
{
    /// <include file='PhoneLineProperties.xml' path='doc/member[@name="PhoneLineProperties.PhoneLineProperties_None"]/*' />
    PhoneLineProperties_None = 0,

    /// <include file='PhoneLineProperties.xml' path='doc/member[@name="PhoneLineProperties.PhoneLineProperties_BrandingOptions"]/*' />
    PhoneLineProperties_BrandingOptions = 0x1,

    /// <include file='PhoneLineProperties.xml' path='doc/member[@name="PhoneLineProperties.PhoneLineProperties_CanDial"]/*' />
    PhoneLineProperties_CanDial = 0x2,

    /// <include file='PhoneLineProperties.xml' path='doc/member[@name="PhoneLineProperties.PhoneLineProperties_CellularDetails"]/*' />
    PhoneLineProperties_CellularDetails = 0x4,

    /// <include file='PhoneLineProperties.xml' path='doc/member[@name="PhoneLineProperties.PhoneLineProperties_DisplayColor"]/*' />
    PhoneLineProperties_DisplayColor = 0x8,

    /// <include file='PhoneLineProperties.xml' path='doc/member[@name="PhoneLineProperties.PhoneLineProperties_DisplayName"]/*' />
    PhoneLineProperties_DisplayName = 0x10,

    /// <include file='PhoneLineProperties.xml' path='doc/member[@name="PhoneLineProperties.PhoneLineProperties_NetworkName"]/*' />
    PhoneLineProperties_NetworkName = 0x20,

    /// <include file='PhoneLineProperties.xml' path='doc/member[@name="PhoneLineProperties.PhoneLineProperties_NetworkState"]/*' />
    PhoneLineProperties_NetworkState = 0x40,

    /// <include file='PhoneLineProperties.xml' path='doc/member[@name="PhoneLineProperties.PhoneLineProperties_Transport"]/*' />
    PhoneLineProperties_Transport = 0x80,

    /// <include file='PhoneLineProperties.xml' path='doc/member[@name="PhoneLineProperties.PhoneLineProperties_Voicemail"]/*' />
    PhoneLineProperties_Voicemail = 0x100,
}
