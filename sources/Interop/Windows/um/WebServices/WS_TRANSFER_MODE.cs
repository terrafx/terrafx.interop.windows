// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WS_TRANSFER_MODE
    {
        WS_STREAMED_INPUT_TRANSFER_MODE = 0x1,
        WS_STREAMED_OUTPUT_TRANSFER_MODE = 0x2,
        WS_BUFFERED_TRANSFER_MODE = 0x0,
        WS_STREAMED_TRANSFER_MODE = (WS_STREAMED_INPUT_TRANSFER_MODE | WS_STREAMED_OUTPUT_TRANSFER_MODE),
    }
}
