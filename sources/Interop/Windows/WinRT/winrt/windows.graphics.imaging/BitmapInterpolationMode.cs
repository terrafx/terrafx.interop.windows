// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BitmapInterpolationMode.xml' path='doc/member[@name="BitmapInterpolationMode"]/*' />
public enum BitmapInterpolationMode
{
    /// <include file='BitmapInterpolationMode.xml' path='doc/member[@name="BitmapInterpolationMode.BitmapInterpolationMode_NearestNeighbor"]/*' />
    BitmapInterpolationMode_NearestNeighbor = 0,

    /// <include file='BitmapInterpolationMode.xml' path='doc/member[@name="BitmapInterpolationMode.BitmapInterpolationMode_Linear"]/*' />
    BitmapInterpolationMode_Linear = 1,

    /// <include file='BitmapInterpolationMode.xml' path='doc/member[@name="BitmapInterpolationMode.BitmapInterpolationMode_Cubic"]/*' />
    BitmapInterpolationMode_Cubic = 2,

    /// <include file='BitmapInterpolationMode.xml' path='doc/member[@name="BitmapInterpolationMode.BitmapInterpolationMode_Fant"]/*' />
    BitmapInterpolationMode_Fant = 3,
}
