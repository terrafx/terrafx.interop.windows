// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WICPngItxtProperties : uint
    {
        WICPngItxtKeyword = 0x1,
        WICPngItxtCompressionFlag = 0x2,
        WICPngItxtLanguageTag = 0x3,
        WICPngItxtTranslatedKeyword = 0x4,
        WICPngItxtText = 0x5,
        WICPngItxtProperties_FORCE_DWORD = 0x7fffffff,
    }
}
