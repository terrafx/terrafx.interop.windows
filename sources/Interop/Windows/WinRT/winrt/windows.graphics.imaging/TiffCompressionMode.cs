// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TiffCompressionMode.xml' path='doc/member[@name="TiffCompressionMode"]/*' />
public enum TiffCompressionMode
{
    /// <include file='TiffCompressionMode.xml' path='doc/member[@name="TiffCompressionMode.TiffCompressionMode_Automatic"]/*' />
    TiffCompressionMode_Automatic = 0,

    /// <include file='TiffCompressionMode.xml' path='doc/member[@name="TiffCompressionMode.TiffCompressionMode_None"]/*' />
    TiffCompressionMode_None = 1,

    /// <include file='TiffCompressionMode.xml' path='doc/member[@name="TiffCompressionMode.TiffCompressionMode_Ccitt3"]/*' />
    TiffCompressionMode_Ccitt3 = 2,

    /// <include file='TiffCompressionMode.xml' path='doc/member[@name="TiffCompressionMode.TiffCompressionMode_Ccitt4"]/*' />
    TiffCompressionMode_Ccitt4 = 3,

    /// <include file='TiffCompressionMode.xml' path='doc/member[@name="TiffCompressionMode.TiffCompressionMode_Lzw"]/*' />
    TiffCompressionMode_Lzw = 4,

    /// <include file='TiffCompressionMode.xml' path='doc/member[@name="TiffCompressionMode.TiffCompressionMode_Rle"]/*' />
    TiffCompressionMode_Rle = 5,

    /// <include file='TiffCompressionMode.xml' path='doc/member[@name="TiffCompressionMode.TiffCompressionMode_Zip"]/*' />
    TiffCompressionMode_Zip = 6,

    /// <include file='TiffCompressionMode.xml' path='doc/member[@name="TiffCompressionMode.TiffCompressionMode_LzwhDifferencing"]/*' />
    TiffCompressionMode_LzwhDifferencing = 7,
}
