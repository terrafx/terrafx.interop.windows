// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BitmapAlphaMode.xml' path='doc/member[@name="BitmapAlphaMode"]/*' />
public enum BitmapAlphaMode
{
    /// <include file='BitmapAlphaMode.xml' path='doc/member[@name="BitmapAlphaMode.BitmapAlphaMode_Premultiplied"]/*' />
    BitmapAlphaMode_Premultiplied = 0,

    /// <include file='BitmapAlphaMode.xml' path='doc/member[@name="BitmapAlphaMode.BitmapAlphaMode_Straight"]/*' />
    BitmapAlphaMode_Straight = 1,

    /// <include file='BitmapAlphaMode.xml' path='doc/member[@name="BitmapAlphaMode.BitmapAlphaMode_Ignore"]/*' />
    BitmapAlphaMode_Ignore = 2,
}
