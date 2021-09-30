// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DEBUG_EVENT
    {
        [NativeTypeName("DWORD")]
        public uint dwDebugEventCode;

        [NativeTypeName("DWORD")]
        public uint dwProcessId;

        [NativeTypeName("DWORD")]
        public uint dwThreadId;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minwinbase.h:365:5)")]
        public _u_e__Union u;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _u_e__Union
        {
            [FieldOffset(0)]
            public EXCEPTION_DEBUG_INFO Exception;

            [FieldOffset(0)]
            public CREATE_THREAD_DEBUG_INFO CreateThread;

            [FieldOffset(0)]
            public CREATE_PROCESS_DEBUG_INFO CreateProcessInfo;

            [FieldOffset(0)]
            public EXIT_THREAD_DEBUG_INFO ExitThread;

            [FieldOffset(0)]
            public EXIT_PROCESS_DEBUG_INFO ExitProcess;

            [FieldOffset(0)]
            public LOAD_DLL_DEBUG_INFO LoadDll;

            [FieldOffset(0)]
            public UNLOAD_DLL_DEBUG_INFO UnloadDll;

            [FieldOffset(0)]
            public OUTPUT_DEBUG_STRING_INFO DebugString;

            [FieldOffset(0)]
            public RIP_INFO RipInfo;
        }
    }
}
