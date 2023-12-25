// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DeviceInformationKind.xml' path='doc/member[@name="DeviceInformationKind"]/*' />
public enum DeviceInformationKind
{
    /// <include file='DeviceInformationKind.xml' path='doc/member[@name="DeviceInformationKind.DeviceInformationKind_Unknown"]/*' />
    DeviceInformationKind_Unknown = 0,

    /// <include file='DeviceInformationKind.xml' path='doc/member[@name="DeviceInformationKind.DeviceInformationKind_DeviceInterface"]/*' />
    DeviceInformationKind_DeviceInterface = 1,

    /// <include file='DeviceInformationKind.xml' path='doc/member[@name="DeviceInformationKind.DeviceInformationKind_DeviceContainer"]/*' />
    DeviceInformationKind_DeviceContainer = 2,

    /// <include file='DeviceInformationKind.xml' path='doc/member[@name="DeviceInformationKind.DeviceInformationKind_Device"]/*' />
    DeviceInformationKind_Device = 3,

    /// <include file='DeviceInformationKind.xml' path='doc/member[@name="DeviceInformationKind.DeviceInformationKind_DeviceInterfaceClass"]/*' />
    DeviceInformationKind_DeviceInterfaceClass = 4,

    /// <include file='DeviceInformationKind.xml' path='doc/member[@name="DeviceInformationKind.DeviceInformationKind_AssociationEndpoint"]/*' />
    DeviceInformationKind_AssociationEndpoint = 5,

    /// <include file='DeviceInformationKind.xml' path='doc/member[@name="DeviceInformationKind.DeviceInformationKind_AssociationEndpointContainer"]/*' />
    DeviceInformationKind_AssociationEndpointContainer = 6,

    /// <include file='DeviceInformationKind.xml' path='doc/member[@name="DeviceInformationKind.DeviceInformationKind_AssociationEndpointService"]/*' />
    DeviceInformationKind_AssociationEndpointService = 7,

    /// <include file='DeviceInformationKind.xml' path='doc/member[@name="DeviceInformationKind.DeviceInformationKind_DevicePanel"]/*' />
    DeviceInformationKind_DevicePanel = 8,
}
