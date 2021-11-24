// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SP_DEVINSTALL_PARAMS64_W
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

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort DriverPath[260];
}
