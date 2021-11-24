// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct MFFOLDDOWN_MATRIX
{
    [NativeTypeName("UINT32")]
    public uint cbSize;

    [NativeTypeName("UINT32")]
    public uint cSrcChannels;

    [NativeTypeName("UINT32")]
    public uint cDstChannels;

    [NativeTypeName("UINT32")]
    public uint dwChannelMask;

    [NativeTypeName("LONG [64]")]
    public fixed int Coeff[64];
}
