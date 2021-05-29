// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum AM_OVERLAY_NOTIFY_FLAGS
    {
        AM_OVERLAY_NOTIFY_VISIBLE_CHANGE = 0x1,
        AM_OVERLAY_NOTIFY_SOURCE_CHANGE = 0x2,
        AM_OVERLAY_NOTIFY_DEST_CHANGE = 0x4,
    }
}
