// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BitmapPlaneDescription.xml' path='doc/member[@name="BitmapPlaneDescription"]/*' />
public partial struct BitmapPlaneDescription
{
    /// <include file='BitmapPlaneDescription.xml' path='doc/member[@name="BitmapPlaneDescription.StartIndex"]/*' />
    [NativeTypeName("INT32")]
    public int StartIndex;

    /// <include file='BitmapPlaneDescription.xml' path='doc/member[@name="BitmapPlaneDescription.Width"]/*' />
    [NativeTypeName("INT32")]
    public int Width;

    /// <include file='BitmapPlaneDescription.xml' path='doc/member[@name="BitmapPlaneDescription.Height"]/*' />
    [NativeTypeName("INT32")]
    public int Height;

    /// <include file='BitmapPlaneDescription.xml' path='doc/member[@name="BitmapPlaneDescription.Stride"]/*' />
    [NativeTypeName("INT32")]
    public int Stride;
}
