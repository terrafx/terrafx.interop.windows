// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct WICJpegScanHeader
{
    public uint cComponents;

    public uint RestartInterval;

    [NativeTypeName("DWORD")]
    public uint ComponentSelectors;

    [NativeTypeName("DWORD")]
    public uint HuffmanTableIndices;

    public byte StartSpectralSelection;

    public byte EndSpectralSelection;

    public byte SuccessiveApproximationHigh;

    public byte SuccessiveApproximationLow;
}
