// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SimpleOrientation.xml' path='doc/member[@name="SimpleOrientation"]/*' />
public enum SimpleOrientation
{
    /// <include file='SimpleOrientation.xml' path='doc/member[@name="SimpleOrientation.SimpleOrientation_NotRotated"]/*' />
    SimpleOrientation_NotRotated = 0,

    /// <include file='SimpleOrientation.xml' path='doc/member[@name="SimpleOrientation.SimpleOrientation_Rotated90DegreesCounterclockwise"]/*' />
    SimpleOrientation_Rotated90DegreesCounterclockwise = 1,

    /// <include file='SimpleOrientation.xml' path='doc/member[@name="SimpleOrientation.SimpleOrientation_Rotated180DegreesCounterclockwise"]/*' />
    SimpleOrientation_Rotated180DegreesCounterclockwise = 2,

    /// <include file='SimpleOrientation.xml' path='doc/member[@name="SimpleOrientation.SimpleOrientation_Rotated270DegreesCounterclockwise"]/*' />
    SimpleOrientation_Rotated270DegreesCounterclockwise = 3,

    /// <include file='SimpleOrientation.xml' path='doc/member[@name="SimpleOrientation.SimpleOrientation_Faceup"]/*' />
    SimpleOrientation_Faceup = 4,

    /// <include file='SimpleOrientation.xml' path='doc/member[@name="SimpleOrientation.SimpleOrientation_Facedown"]/*' />
    SimpleOrientation_Facedown = 5,
}
