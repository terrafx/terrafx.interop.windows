// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CREATE_PROCESS_DEBUG_INFO
    {
        [NativeTypeName("HANDLE")]
        public IntPtr hFile;

        [NativeTypeName("HANDLE")]
        public IntPtr hProcess;

        [NativeTypeName("HANDLE")]
        public IntPtr hThread;

        [NativeTypeName("LPVOID")]
        public void* lpBaseOfImage;

        [NativeTypeName("DWORD")]
        public uint dwDebugInfoFileOffset;

        [NativeTypeName("DWORD")]
        public uint nDebugInfoSize;

        [NativeTypeName("LPVOID")]
        public void* lpThreadLocalBase;

        [NativeTypeName("LPTHREAD_START_ROUTINE")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, uint> lpStartAddress;
#else
        public void* _lpStartAddress;

        public delegate* unmanaged[Stdcall]<void*, uint> lpStartAddress
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, uint>)_lpStartAddress;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _lpStartAddress = value;
            }
        }
#endif

        [NativeTypeName("LPVOID")]
        public void* lpImageName;

        [NativeTypeName("WORD")]
        public ushort fUnicode;
    }
}
