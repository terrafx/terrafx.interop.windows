// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WICGifLogicalScreenDescriptorProperties
    {
        WICGifLogicalScreenSignature = 0x1,
        WICGifLogicalScreenDescriptorWidth = 0x2,
        WICGifLogicalScreenDescriptorHeight = 0x3,
        WICGifLogicalScreenDescriptorGlobalColorTableFlag = 0x4,
        WICGifLogicalScreenDescriptorColorResolution = 0x5,
        WICGifLogicalScreenDescriptorSortFlag = 0x6,
        WICGifLogicalScreenDescriptorGlobalColorTableSize = 0x7,
        WICGifLogicalScreenDescriptorBackgroundColorIndex = 0x8,
        WICGifLogicalScreenDescriptorPixelAspectRatio = 0x9,
        WICGifLogicalScreenDescriptorProperties_FORCE_DWORD = 0x7fffffff,
    }
}
