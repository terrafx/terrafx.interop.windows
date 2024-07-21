// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HdcpProtection.xml' path='doc/member[@name="HdcpProtection"]/*' />
public enum HdcpProtection
{
    /// <include file='HdcpProtection.xml' path='doc/member[@name="HdcpProtection.HdcpProtection_Off"]/*' />
    HdcpProtection_Off = 0,

    /// <include file='HdcpProtection.xml' path='doc/member[@name="HdcpProtection.HdcpProtection_On"]/*' />
    HdcpProtection_On = 1,

    /// <include file='HdcpProtection.xml' path='doc/member[@name="HdcpProtection.HdcpProtection_OnWithTypeEnforcement"]/*' />
    HdcpProtection_OnWithTypeEnforcement = 2,
}
