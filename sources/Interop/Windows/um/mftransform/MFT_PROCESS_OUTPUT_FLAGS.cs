// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFT_PROCESS_OUTPUT_FLAGS
    {
        MFT_PROCESS_OUTPUT_DISCARD_WHEN_NO_BUFFER = 0x1,
        MFT_PROCESS_OUTPUT_REGENERATE_LAST_OUTPUT = 0x2,
    }
}
