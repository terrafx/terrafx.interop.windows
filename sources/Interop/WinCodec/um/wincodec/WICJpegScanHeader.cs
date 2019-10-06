// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct WICJpegScanHeader
    {
        [NativeTypeName("UINT")]
        public uint cComponents;

        [NativeTypeName("UINT")]
        public uint RestartInterval;

        [NativeTypeName("DWORD")]
        public uint ComponentSelectors;

        [NativeTypeName("DWORD")]
        public uint HuffmanTableIndices;

        [NativeTypeName("BYTE")]
        public byte StartSpectralSelection;

        [NativeTypeName("BYTE")]
        public byte EndSpectralSelection;

        [NativeTypeName("BYTE")]
        public byte SuccessiveApproximationHigh;

        [NativeTypeName("BYTE")]
        public byte SuccessiveApproximationLow;
    }
}
