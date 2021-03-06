// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DVD_CMD_FLAGS
    {
        DVD_CMD_FLAG_None = 0,
        DVD_CMD_FLAG_Flush = 0x1,
        DVD_CMD_FLAG_SendEvents = 0x2,
        DVD_CMD_FLAG_Block = 0x4,
        DVD_CMD_FLAG_StartWhenRendered = 0x8,
        DVD_CMD_FLAG_EndAfterRendered = 0x10,
    }
}
