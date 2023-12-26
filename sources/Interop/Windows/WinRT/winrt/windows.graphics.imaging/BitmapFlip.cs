// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BitmapFlip.xml' path='doc/member[@name="BitmapFlip"]/*' />
public enum BitmapFlip
{
    /// <include file='BitmapFlip.xml' path='doc/member[@name="BitmapFlip.BitmapFlip_None"]/*' />
    BitmapFlip_None = 0,

    /// <include file='BitmapFlip.xml' path='doc/member[@name="BitmapFlip.BitmapFlip_Horizontal"]/*' />
    BitmapFlip_Horizontal = 1,

    /// <include file='BitmapFlip.xml' path='doc/member[@name="BitmapFlip.BitmapFlip_Vertical"]/*' />
    BitmapFlip_Vertical = 2,
}
