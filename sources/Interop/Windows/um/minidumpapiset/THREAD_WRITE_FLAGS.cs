// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum THREAD_WRITE_FLAGS
    {
        ThreadWriteThread = 0x0001,
        ThreadWriteStack = 0x0002,
        ThreadWriteContext = 0x0004,
        ThreadWriteBackingStore = 0x0008,
        ThreadWriteInstructionWindow = 0x0010,
        ThreadWriteThreadData = 0x0020,
        ThreadWriteThreadInfo = 0x0040,
    }
}
