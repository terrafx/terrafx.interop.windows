// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BitmapSize.xml' path='doc/member[@name="BitmapSize"]/*' />
public partial struct BitmapSize
{
    /// <include file='BitmapSize.xml' path='doc/member[@name="BitmapSize.Width"]/*' />
    [NativeTypeName("UINT32")]
    public uint Width;

    /// <include file='BitmapSize.xml' path='doc/member[@name="BitmapSize.Height"]/*' />
    [NativeTypeName("UINT32")]
    public uint Height;
}
