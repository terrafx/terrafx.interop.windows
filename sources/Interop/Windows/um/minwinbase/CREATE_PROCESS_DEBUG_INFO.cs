// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

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
        public delegate* unmanaged<void*, uint> lpStartAddress;

        [NativeTypeName("LPVOID")]
        public void* lpImageName;

        [NativeTypeName("WORD")]
        public ushort fUnicode;
    }
}
