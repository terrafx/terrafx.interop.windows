// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GattCommunicationStatus.xml' path='doc/member[@name="GattCommunicationStatus"]/*' />
public enum GattCommunicationStatus
{
    /// <include file='GattCommunicationStatus.xml' path='doc/member[@name="GattCommunicationStatus.GattCommunicationStatus_Success"]/*' />
    GattCommunicationStatus_Success = 0,

    /// <include file='GattCommunicationStatus.xml' path='doc/member[@name="GattCommunicationStatus.GattCommunicationStatus_Unreachable"]/*' />
    GattCommunicationStatus_Unreachable = 1,

    /// <include file='GattCommunicationStatus.xml' path='doc/member[@name="GattCommunicationStatus.GattCommunicationStatus_ProtocolError"]/*' />
    GattCommunicationStatus_ProtocolError = 2,

    /// <include file='GattCommunicationStatus.xml' path='doc/member[@name="GattCommunicationStatus.GattCommunicationStatus_AccessDenied"]/*' />
    GattCommunicationStatus_AccessDenied = 3,
}
