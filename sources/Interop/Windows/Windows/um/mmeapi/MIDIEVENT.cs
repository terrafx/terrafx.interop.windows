// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIDIEVENT
{
    [NativeTypeName("DWORD")]
    public uint dwDeltaTime;

    [NativeTypeName("DWORD")]
    public uint dwStreamID;

    [NativeTypeName("DWORD")]
    public uint dwEvent;

    [NativeTypeName("DWORD [1]")]
    public fixed uint dwParms[1];
}
