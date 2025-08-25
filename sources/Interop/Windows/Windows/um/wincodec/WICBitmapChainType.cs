// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WICBitmapChainType.xml' path='doc/member[@name="WICBitmapChainType"]/*' />
public enum WICBitmapChainType
{
    /// <include file='WICBitmapChainType.xml' path='doc/member[@name="WICBitmapChainType.WICBitmapChainType_Alternate"]/*' />
    WICBitmapChainType_Alternate = 0x1,

    /// <include file='WICBitmapChainType.xml' path='doc/member[@name="WICBitmapChainType.WICBitmapChainType_Layer"]/*' />
    WICBitmapChainType_Layer = 0x2,

    /// <include file='WICBitmapChainType.xml' path='doc/member[@name="WICBitmapChainType.WICBitmapChainType_Preview"]/*' />
    WICBitmapChainType_Preview = 0x3,

    /// <include file='WICBitmapChainType.xml' path='doc/member[@name="WICBitmapChainType.WICBitmapChainType_Thumbnail"]/*' />
    WICBitmapChainType_Thumbnail = 0x4,

    /// <include file='WICBitmapChainType.xml' path='doc/member[@name="WICBitmapChainType.WICBitmapChainType_AlphaMap"]/*' />
    WICBitmapChainType_AlphaMap = 0x5,

    /// <include file='WICBitmapChainType.xml' path='doc/member[@name="WICBitmapChainType.WICBitmapChainType_DepthMap"]/*' />
    WICBitmapChainType_DepthMap = 0x6,

    /// <include file='WICBitmapChainType.xml' path='doc/member[@name="WICBitmapChainType.WICBitmapChainType_GainMap"]/*' />
    WICBitmapChainType_GainMap = 0x7,

    /// <include file='WICBitmapChainType.xml' path='doc/member[@name="WICBitmapChainType.WICBITMAPCHAINTYPE_FORCE_DWORD"]/*' />
    WICBITMAPCHAINTYPE_FORCE_DWORD = 0x7fffffff,
}
