// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SP_DEVINSTALL_PARAMS32_A
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint FlagsEx;

    public HWND hwndParent;

    [NativeTypeName("PSP_FILE_CALLBACK_W")]
    public delegate* unmanaged<void*, uint, nuint, nuint, uint> InstallMsgHandler;

    [NativeTypeName("PVOID")]
    public void* InstallMsgHandlerContext;

    public HSPFILEQ FileQueue;

    [NativeTypeName("ULONG_PTR")]
    public nuint ClassInstallReserved;

    [NativeTypeName("DWORD")]
    public uint Reserved;

    [NativeTypeName("CHAR [260]")]
    public fixed sbyte DriverPath[260];
}
