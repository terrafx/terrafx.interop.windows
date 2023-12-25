// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BitmapPixelFormat.xml' path='doc/member[@name="BitmapPixelFormat"]/*' />
public enum BitmapPixelFormat
{
    /// <include file='BitmapPixelFormat.xml' path='doc/member[@name="BitmapPixelFormat.BitmapPixelFormat_Unknown"]/*' />
    BitmapPixelFormat_Unknown = 0,

    /// <include file='BitmapPixelFormat.xml' path='doc/member[@name="BitmapPixelFormat.BitmapPixelFormat_Rgba16"]/*' />
    BitmapPixelFormat_Rgba16 = 12,

    /// <include file='BitmapPixelFormat.xml' path='doc/member[@name="BitmapPixelFormat.BitmapPixelFormat_Rgba8"]/*' />
    BitmapPixelFormat_Rgba8 = 30,

    /// <include file='BitmapPixelFormat.xml' path='doc/member[@name="BitmapPixelFormat.BitmapPixelFormat_Gray16"]/*' />
    BitmapPixelFormat_Gray16 = 57,

    /// <include file='BitmapPixelFormat.xml' path='doc/member[@name="BitmapPixelFormat.BitmapPixelFormat_Gray8"]/*' />
    BitmapPixelFormat_Gray8 = 62,

    /// <include file='BitmapPixelFormat.xml' path='doc/member[@name="BitmapPixelFormat.BitmapPixelFormat_Bgra8"]/*' />
    BitmapPixelFormat_Bgra8 = 87,

    /// <include file='BitmapPixelFormat.xml' path='doc/member[@name="BitmapPixelFormat.BitmapPixelFormat_Nv12"]/*' />
    BitmapPixelFormat_Nv12 = 103,

    /// <include file='BitmapPixelFormat.xml' path='doc/member[@name="BitmapPixelFormat.BitmapPixelFormat_P010"]/*' />
    BitmapPixelFormat_P010 = 104,

    /// <include file='BitmapPixelFormat.xml' path='doc/member[@name="BitmapPixelFormat.BitmapPixelFormat_Yuy2"]/*' />
    BitmapPixelFormat_Yuy2 = 107,
}
