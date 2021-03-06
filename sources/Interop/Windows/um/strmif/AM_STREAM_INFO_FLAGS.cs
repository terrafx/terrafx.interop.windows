// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum AM_STREAM_INFO_FLAGS
    {
        AM_STREAM_INFO_START_DEFINED = 0x1,
        AM_STREAM_INFO_STOP_DEFINED = 0x2,
        AM_STREAM_INFO_DISCARDING = 0x4,
        AM_STREAM_INFO_STOP_SEND_EXTRA = 0x10,
    }
}
