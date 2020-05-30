// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct XAUDIO2FX_VOLUMEMETER_LEVELS
    {
        [NativeTypeName("float *")]
        public float* pPeakLevels;

        [NativeTypeName("float *")]
        public float* pRMSLevels;

        [NativeTypeName("UINT32")]
        public uint ChannelCount;
    }
}
