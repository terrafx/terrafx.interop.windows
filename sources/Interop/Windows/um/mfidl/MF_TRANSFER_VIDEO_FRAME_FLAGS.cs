// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_TRANSFER_VIDEO_FRAME_FLAGS
    {
        MF_TRANSFER_VIDEO_FRAME_DEFAULT = 0,
        MF_TRANSFER_VIDEO_FRAME_STRETCH = 1,
        MF_TRANSFER_VIDEO_FRAME_IGNORE_PAR = 2,
    }
}
