// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct XAUDIO2_DEBUG_CONFIGURATION
    {
        [NativeTypeName("UINT32")]
        public uint TraceMask;

        [NativeTypeName("UINT32")]
        public uint BreakMask;

        [NativeTypeName("BOOL")]
        public int LogThreadID;

        [NativeTypeName("BOOL")]
        public int LogFileline;

        [NativeTypeName("BOOL")]
        public int LogFunctionName;

        [NativeTypeName("BOOL")]
        public int LogTiming;
    }
}
