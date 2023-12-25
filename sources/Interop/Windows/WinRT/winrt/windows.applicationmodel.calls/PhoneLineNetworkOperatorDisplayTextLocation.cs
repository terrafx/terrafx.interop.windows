// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneLineNetworkOperatorDisplayTextLocation.xml' path='doc/member[@name="PhoneLineNetworkOperatorDisplayTextLocation"]/*' />
public enum PhoneLineNetworkOperatorDisplayTextLocation
{
    /// <include file='PhoneLineNetworkOperatorDisplayTextLocation.xml' path='doc/member[@name="PhoneLineNetworkOperatorDisplayTextLocation.PhoneLineNetworkOperatorDisplayTextLocation_Default"]/*' />
    PhoneLineNetworkOperatorDisplayTextLocation_Default = 0,

    /// <include file='PhoneLineNetworkOperatorDisplayTextLocation.xml' path='doc/member[@name="PhoneLineNetworkOperatorDisplayTextLocation.PhoneLineNetworkOperatorDisplayTextLocation_Tile"]/*' />
    PhoneLineNetworkOperatorDisplayTextLocation_Tile = 1,

    /// <include file='PhoneLineNetworkOperatorDisplayTextLocation.xml' path='doc/member[@name="PhoneLineNetworkOperatorDisplayTextLocation.PhoneLineNetworkOperatorDisplayTextLocation_Dialer"]/*' />
    PhoneLineNetworkOperatorDisplayTextLocation_Dialer = 2,

    /// <include file='PhoneLineNetworkOperatorDisplayTextLocation.xml' path='doc/member[@name="PhoneLineNetworkOperatorDisplayTextLocation.PhoneLineNetworkOperatorDisplayTextLocation_InCallUI"]/*' />
    PhoneLineNetworkOperatorDisplayTextLocation_InCallUI = 3,
}
