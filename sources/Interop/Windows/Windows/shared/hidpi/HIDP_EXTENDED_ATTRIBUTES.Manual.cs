// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct HIDP_EXTENDED_ATTRIBUTES
{
    [NativeTypeName("UCHAR")]
    public byte NumGlobalUnknowns;

    [NativeTypeName("UCHAR [3]")]
    public fixed byte Reserved[3];

    [NativeTypeName("PHIDP_UNKNOWN_TOKEN")]
    public HIDP_UNKNOWN_TOKEN* GlobalUnknowns;

    [NativeTypeName("ULONG [1]")]
    public fixed uint Data[1];
}
