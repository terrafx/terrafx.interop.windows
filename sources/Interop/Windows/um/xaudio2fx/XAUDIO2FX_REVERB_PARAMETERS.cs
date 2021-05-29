// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct XAUDIO2FX_REVERB_PARAMETERS
    {
        public float WetDryMix;

        [NativeTypeName("UINT32")]
        public uint ReflectionsDelay;

        [NativeTypeName("BYTE")]
        public byte ReverbDelay;

        [NativeTypeName("BYTE")]
        public byte RearDelay;

        [NativeTypeName("BYTE")]
        public byte SideDelay;

        [NativeTypeName("BYTE")]
        public byte PositionLeft;

        [NativeTypeName("BYTE")]
        public byte PositionRight;

        [NativeTypeName("BYTE")]
        public byte PositionMatrixLeft;

        [NativeTypeName("BYTE")]
        public byte PositionMatrixRight;

        [NativeTypeName("BYTE")]
        public byte EarlyDiffusion;

        [NativeTypeName("BYTE")]
        public byte LateDiffusion;

        [NativeTypeName("BYTE")]
        public byte LowEQGain;

        [NativeTypeName("BYTE")]
        public byte LowEQCutoff;

        [NativeTypeName("BYTE")]
        public byte HighEQGain;

        [NativeTypeName("BYTE")]
        public byte HighEQCutoff;

        public float RoomFilterFreq;

        public float RoomFilterMain;

        public float RoomFilterHF;

        public float ReflectionsGain;

        public float ReverbGain;

        public float DecayTime;

        public float Density;

        public float RoomSize;

        [NativeTypeName("BOOL")]
        public int DisableLateField;
    }
}
