// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BitmapBounds.xml' path='doc/member[@name="BitmapBounds"]/*' />
public partial struct BitmapBounds
{
    /// <include file='BitmapBounds.xml' path='doc/member[@name="BitmapBounds.X"]/*' />
    [NativeTypeName("UINT32")]
    public uint X;

    /// <include file='BitmapBounds.xml' path='doc/member[@name="BitmapBounds.Y"]/*' />
    [NativeTypeName("UINT32")]
    public uint Y;

    /// <include file='BitmapBounds.xml' path='doc/member[@name="BitmapBounds.Width"]/*' />
    [NativeTypeName("UINT32")]
    public uint Width;

    /// <include file='BitmapBounds.xml' path='doc/member[@name="BitmapBounds.Height"]/*' />
    [NativeTypeName("UINT32")]
    public uint Height;
}
