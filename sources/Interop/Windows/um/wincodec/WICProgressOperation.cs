// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WICProgressOperation
    {
        WICProgressOperationCopyPixels = 0x1,

        WICProgressOperationWritePixels = 0x2,

        WICProgressOperationAll = 0xFFFF,

        WICPROGRESSOPERATION_FORCE_DWORD = 0x7FFFFFFF
    }
}
