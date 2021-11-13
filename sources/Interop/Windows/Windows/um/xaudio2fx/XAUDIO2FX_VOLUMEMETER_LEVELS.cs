// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct XAUDIO2FX_VOLUMEMETER_LEVELS
    {
        public float* pPeakLevels;

        public float* pRMSLevels;

        [NativeTypeName("UINT32")]
        public uint ChannelCount;
    }
}
