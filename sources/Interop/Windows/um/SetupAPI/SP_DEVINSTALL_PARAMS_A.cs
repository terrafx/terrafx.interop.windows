// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct SP_DEVINSTALL_PARAMS_A
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint FlagsEx;

        [NativeTypeName("HWND")]
        public IntPtr hwndParent;

        [NativeTypeName("PSP_FILE_CALLBACK_W")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, uint, nuint, nuint, uint> InstallMsgHandler;
#else
        public void* _InstallMsgHandler;

        public delegate* unmanaged[Stdcall]<void*, uint, nuint, nuint, uint> InstallMsgHandler
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, uint, nuint, nuint, uint>)_InstallMsgHandler;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _InstallMsgHandler = value;
            }
        }
#endif

        [NativeTypeName("PVOID")]
        public void* InstallMsgHandlerContext;

        [NativeTypeName("HSPFILEQ")]
        public void* FileQueue;

        [NativeTypeName("ULONG_PTR")]
        public nuint ClassInstallReserved;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("CHAR [260]")]
        public fixed sbyte DriverPath[260];
    }
}
