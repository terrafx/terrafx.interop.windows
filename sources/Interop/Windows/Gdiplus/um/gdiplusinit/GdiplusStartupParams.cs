// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

/// <include file='GdiplusStartupParams.xml' path='doc/member[@name="GdiplusStartupParams"]/*' />
public enum GdiplusStartupParams
{
    /// <include file='GdiplusStartupParams.xml' path='doc/member[@name="GdiplusStartupParams.GdiplusStartupDefault"]/*' />
    GdiplusStartupDefault = 0x00000000,

    /// <include file='GdiplusStartupParams.xml' path='doc/member[@name="GdiplusStartupParams.GdiplusStartupNoSetRound"]/*' />
    GdiplusStartupNoSetRound = 0x00000001,

    /// <include file='GdiplusStartupParams.xml' path='doc/member[@name="GdiplusStartupParams.GdiplusStartupSetPSValue"]/*' />
    GdiplusStartupSetPSValue = 0x00000002,

    /// <include file='GdiplusStartupParams.xml' path='doc/member[@name="GdiplusStartupParams.GdiplusStartupReserved0"]/*' />
    GdiplusStartupReserved0 = 0x00000004,

    /// <include file='GdiplusStartupParams.xml' path='doc/member[@name="GdiplusStartupParams.GdiplusStartupReserved1"]/*' />
    GdiplusStartupReserved1 = 0x00000008,

    /// <include file='GdiplusStartupParams.xml' path='doc/member[@name="GdiplusStartupParams.GdiplusStartupReserved2"]/*' />
    GdiplusStartupReserved2 = 0x00000010,

    /// <include file='GdiplusStartupParams.xml' path='doc/member[@name="GdiplusStartupParams.GdiplusStartupTransparencyMask"]/*' />
    GdiplusStartupTransparencyMask = unchecked((int)(0xFF000000)),
}
