// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct WICJpegFrameHeader
    {
        #region Fields
        [NativeTypeName("UINT")]
        public uint Width;

        [NativeTypeName("UINT")]
        public uint Height;

        public WICJpegTransferMatrix TransferMatrix;

        public WICJpegScanType ScanType;

        [NativeTypeName("UINT")]
        public uint cComponents;

        [NativeTypeName("DWORD")]
        public uint ComponentIdentifiers;

        [NativeTypeName("DWORD")]
        public uint SampleFactors;

        [NativeTypeName("DWORD")]
        public uint QuantizationTableIndices;
        #endregion
    }
}
