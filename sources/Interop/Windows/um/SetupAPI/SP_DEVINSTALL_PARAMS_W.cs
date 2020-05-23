// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SP_DEVINSTALL_PARAMS_W
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint FlagsEx;

        [NativeTypeName("HWND")]
        public IntPtr hwndParent;

        [NativeTypeName("PSP_FILE_CALLBACK_A")]
        public IntPtr InstallMsgHandler;

        [NativeTypeName("PVOID")]
        public void* InstallMsgHandlerContext;

        [NativeTypeName("HSPFILEQ")]
        public void* FileQueue;

        [NativeTypeName("ULONG_PTR")]
        public nuint ClassInstallReserved;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort DriverPath[260];
    }
}
