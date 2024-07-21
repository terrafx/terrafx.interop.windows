// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BitmapRotation.xml' path='doc/member[@name="BitmapRotation"]/*' />
public enum BitmapRotation
{
    /// <include file='BitmapRotation.xml' path='doc/member[@name="BitmapRotation.BitmapRotation_None"]/*' />
    BitmapRotation_None = 0,

    /// <include file='BitmapRotation.xml' path='doc/member[@name="BitmapRotation.BitmapRotation_Clockwise90Degrees"]/*' />
    BitmapRotation_Clockwise90Degrees = 1,

    /// <include file='BitmapRotation.xml' path='doc/member[@name="BitmapRotation.BitmapRotation_Clockwise180Degrees"]/*' />
    BitmapRotation_Clockwise180Degrees = 2,

    /// <include file='BitmapRotation.xml' path='doc/member[@name="BitmapRotation.BitmapRotation_Clockwise270Degrees"]/*' />
    BitmapRotation_Clockwise270Degrees = 3,
}
