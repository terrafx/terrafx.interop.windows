// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='IppPrintDeviceInstallationStatus.xml' path='doc/member[@name="IppPrintDeviceInstallationStatus"]/*' />
public enum IppPrintDeviceInstallationStatus
{
    /// <include file='IppPrintDeviceInstallationStatus.xml' path='doc/member[@name="IppPrintDeviceInstallationStatus.IppPrintDeviceInstallationStatus_InstallationSucceeded"]/*' />
    IppPrintDeviceInstallationStatus_InstallationSucceeded = 0,

    /// <include file='IppPrintDeviceInstallationStatus.xml' path='doc/member[@name="IppPrintDeviceInstallationStatus.IppPrintDeviceInstallationStatus_PrinterAlreadyInstalled"]/*' />
    IppPrintDeviceInstallationStatus_PrinterAlreadyInstalled = 1,

    /// <include file='IppPrintDeviceInstallationStatus.xml' path='doc/member[@name="IppPrintDeviceInstallationStatus.IppPrintDeviceInstallationStatus_CommunicationError"]/*' />
    IppPrintDeviceInstallationStatus_CommunicationError = 2,

    /// <include file='IppPrintDeviceInstallationStatus.xml' path='doc/member[@name="IppPrintDeviceInstallationStatus.IppPrintDeviceInstallationStatus_OtherFailure"]/*' />
    IppPrintDeviceInstallationStatus_OtherFailure = 3,
}
