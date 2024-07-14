// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardReaderStatus.xml' path='doc/member[@name="SmartCardReaderStatus"]/*' />
public enum SmartCardReaderStatus
{
    /// <include file='SmartCardReaderStatus.xml' path='doc/member[@name="SmartCardReaderStatus.SmartCardReaderStatus_Disconnected"]/*' />
    SmartCardReaderStatus_Disconnected = 0,

    /// <include file='SmartCardReaderStatus.xml' path='doc/member[@name="SmartCardReaderStatus.SmartCardReaderStatus_Ready"]/*' />
    SmartCardReaderStatus_Ready = 1,

    /// <include file='SmartCardReaderStatus.xml' path='doc/member[@name="SmartCardReaderStatus.SmartCardReaderStatus_Exclusive"]/*' />
    SmartCardReaderStatus_Exclusive = 2,
}
