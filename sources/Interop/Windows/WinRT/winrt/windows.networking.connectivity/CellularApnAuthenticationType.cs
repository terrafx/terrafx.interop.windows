// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CellularApnAuthenticationType.xml' path='doc/member[@name="CellularApnAuthenticationType"]/*' />
public enum CellularApnAuthenticationType
{
    /// <include file='CellularApnAuthenticationType.xml' path='doc/member[@name="CellularApnAuthenticationType.CellularApnAuthenticationType_None"]/*' />
    CellularApnAuthenticationType_None = 0,

    /// <include file='CellularApnAuthenticationType.xml' path='doc/member[@name="CellularApnAuthenticationType.CellularApnAuthenticationType_Pap"]/*' />
    CellularApnAuthenticationType_Pap = 1,

    /// <include file='CellularApnAuthenticationType.xml' path='doc/member[@name="CellularApnAuthenticationType.CellularApnAuthenticationType_Chap"]/*' />
    CellularApnAuthenticationType_Chap = 2,

    /// <include file='CellularApnAuthenticationType.xml' path='doc/member[@name="CellularApnAuthenticationType.CellularApnAuthenticationType_Mschapv2"]/*' />
    CellularApnAuthenticationType_Mschapv2 = 3,
}
