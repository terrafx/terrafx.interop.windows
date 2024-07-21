// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhotoOrientation.xml' path='doc/member[@name="PhotoOrientation"]/*' />
public enum PhotoOrientation
{
    /// <include file='PhotoOrientation.xml' path='doc/member[@name="PhotoOrientation.PhotoOrientation_Unspecified"]/*' />
    PhotoOrientation_Unspecified = 0,

    /// <include file='PhotoOrientation.xml' path='doc/member[@name="PhotoOrientation.PhotoOrientation_Normal"]/*' />
    PhotoOrientation_Normal = 1,

    /// <include file='PhotoOrientation.xml' path='doc/member[@name="PhotoOrientation.PhotoOrientation_FlipHorizontal"]/*' />
    PhotoOrientation_FlipHorizontal = 2,

    /// <include file='PhotoOrientation.xml' path='doc/member[@name="PhotoOrientation.PhotoOrientation_Rotate180"]/*' />
    PhotoOrientation_Rotate180 = 3,

    /// <include file='PhotoOrientation.xml' path='doc/member[@name="PhotoOrientation.PhotoOrientation_FlipVertical"]/*' />
    PhotoOrientation_FlipVertical = 4,

    /// <include file='PhotoOrientation.xml' path='doc/member[@name="PhotoOrientation.PhotoOrientation_Transpose"]/*' />
    PhotoOrientation_Transpose = 5,

    /// <include file='PhotoOrientation.xml' path='doc/member[@name="PhotoOrientation.PhotoOrientation_Rotate270"]/*' />
    PhotoOrientation_Rotate270 = 6,

    /// <include file='PhotoOrientation.xml' path='doc/member[@name="PhotoOrientation.PhotoOrientation_Transverse"]/*' />
    PhotoOrientation_Transverse = 7,

    /// <include file='PhotoOrientation.xml' path='doc/member[@name="PhotoOrientation.PhotoOrientation_Rotate90"]/*' />
    PhotoOrientation_Rotate90 = 8,
}
