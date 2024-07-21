// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PositionAccuracy.xml' path='doc/member[@name="PositionAccuracy"]/*' />
public enum PositionAccuracy
{
    /// <include file='PositionAccuracy.xml' path='doc/member[@name="PositionAccuracy.PositionAccuracy_Default"]/*' />
    PositionAccuracy_Default = 0,

    /// <include file='PositionAccuracy.xml' path='doc/member[@name="PositionAccuracy.PositionAccuracy_High"]/*' />
    PositionAccuracy_High = 1,
}
