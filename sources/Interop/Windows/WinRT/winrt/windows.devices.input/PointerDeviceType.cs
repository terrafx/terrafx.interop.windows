// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PointerDeviceType.xml' path='doc/member[@name="PointerDeviceType"]/*' />
public enum PointerDeviceType
{
    /// <include file='PointerDeviceType.xml' path='doc/member[@name="PointerDeviceType.PointerDeviceType_Touch"]/*' />
    PointerDeviceType_Touch = 0,

    /// <include file='PointerDeviceType.xml' path='doc/member[@name="PointerDeviceType.PointerDeviceType_Pen"]/*' />
    PointerDeviceType_Pen = 1,

    /// <include file='PointerDeviceType.xml' path='doc/member[@name="PointerDeviceType.PointerDeviceType_Mouse"]/*' />
    PointerDeviceType_Mouse = 2,
}
