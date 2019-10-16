// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WICRawRenderMode
    {
        WICRawRenderModeDraft = 0x1,
        WICRawRenderModeNormal = 0x2,
        WICRawRenderModeBestQuality = 0x3,
        WICRAWRENDERMODE_FORCE_DWORD = 0x7FFFFFFF,
    }
}
