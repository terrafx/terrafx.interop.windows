// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct WINHTTP_CONNECTION_INFO32
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    public SOCKADDR_STORAGE LocalAddress;

    public SOCKADDR_STORAGE RemoteAddress;
}
