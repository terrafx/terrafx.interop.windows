// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GpioOpenStatus.xml' path='doc/member[@name="GpioOpenStatus"]/*' />
public enum GpioOpenStatus
{
    /// <include file='GpioOpenStatus.xml' path='doc/member[@name="GpioOpenStatus.GpioOpenStatus_PinOpened"]/*' />
    GpioOpenStatus_PinOpened = 0,

    /// <include file='GpioOpenStatus.xml' path='doc/member[@name="GpioOpenStatus.GpioOpenStatus_PinUnavailable"]/*' />
    GpioOpenStatus_PinUnavailable = 1,

    /// <include file='GpioOpenStatus.xml' path='doc/member[@name="GpioOpenStatus.GpioOpenStatus_SharingViolation"]/*' />
    GpioOpenStatus_SharingViolation = 2,

    /// <include file='GpioOpenStatus.xml' path='doc/member[@name="GpioOpenStatus.GpioOpenStatus_MuxingConflict"]/*' />
    GpioOpenStatus_MuxingConflict = 3,

    /// <include file='GpioOpenStatus.xml' path='doc/member[@name="GpioOpenStatus.GpioOpenStatus_UnknownError"]/*' />
    GpioOpenStatus_UnknownError = 4,
}
