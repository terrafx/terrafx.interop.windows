// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct DWM_PRESENT_PARAMETERS
    {
        [NativeTypeName("UINT32")]
        public uint cbSize;

        [NativeTypeName("BOOL")]
        public int fQueue;

        [NativeTypeName("DWM_FRAME_COUNT")]
        public ulong cRefreshStart;

        [NativeTypeName("UINT")]
        public uint cBuffer;

        [NativeTypeName("BOOL")]
        public int fUseSourceRate;

        public UNSIGNED_RATIO rateSource;

        [NativeTypeName("UINT")]
        public uint cRefreshesPerFrame;

        public DWM_SOURCE_FRAME_SAMPLING eSampling;
    }
}
