// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WICBitmapToneMappingMode.xml' path='doc/member[@name="WICBitmapToneMappingMode"]/*' />
public enum WICBitmapToneMappingMode
{
    /// <include file='WICBitmapToneMappingMode.xml' path='doc/member[@name="WICBitmapToneMappingMode.WICBitmapToneMappingMode_None"]/*' />
    WICBitmapToneMappingMode_None = 0,

    /// <include file='WICBitmapToneMappingMode.xml' path='doc/member[@name="WICBitmapToneMappingMode.WICBitmapToneMappingMode_Default"]/*' />
    WICBitmapToneMappingMode_Default = 0x1,

    /// <include file='WICBitmapToneMappingMode.xml' path='doc/member[@name="WICBitmapToneMappingMode.WICBitmapToneMappingMode_D2D"]/*' />
    WICBitmapToneMappingMode_D2D = 0x2,

    /// <include file='WICBitmapToneMappingMode.xml' path='doc/member[@name="WICBitmapToneMappingMode.WICBitmapToneMappingMode_GainMap"]/*' />
    WICBitmapToneMappingMode_GainMap = 0x3,

    /// <include file='WICBitmapToneMappingMode.xml' path='doc/member[@name="WICBitmapToneMappingMode.WICBITMAPTONEMAPPINGMODE_FORCE_DWORD"]/*' />
    WICBITMAPTONEMAPPINGMODE_FORCE_DWORD = 0x7fffffff,
}
