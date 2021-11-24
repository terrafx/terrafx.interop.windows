// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DRMWAVEFORMAT
{
    public WAVEFORMATEX wfx;

    [NativeTypeName("WORD")]
    public ushort wReserved;

    [NativeTypeName("ULONG")]
    public uint ulContentId;

    public WAVEFORMATEX wfxSecure;
}
