// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct KDHELP64
    {
        [NativeTypeName("DWORD64")]
        public ulong Thread;

        [NativeTypeName("DWORD")]
        public uint ThCallbackStack;

        [NativeTypeName("DWORD")]
        public uint ThCallbackBStore;

        [NativeTypeName("DWORD")]
        public uint NextCallback;

        [NativeTypeName("DWORD")]
        public uint FramePointer;

        [NativeTypeName("DWORD64")]
        public ulong KiCallUserMode;

        [NativeTypeName("DWORD64")]
        public ulong KeUserCallbackDispatcher;

        [NativeTypeName("DWORD64")]
        public ulong SystemRangeStart;

        [NativeTypeName("DWORD64")]
        public ulong KiUserExceptionDispatcher;

        [NativeTypeName("DWORD64")]
        public ulong StackBase;

        [NativeTypeName("DWORD64")]
        public ulong StackLimit;

        [NativeTypeName("DWORD")]
        public uint BuildVersion;

        [NativeTypeName("DWORD")]
        public uint RetpolineStubFunctionTableSize;

        [NativeTypeName("DWORD64")]
        public ulong RetpolineStubFunctionTable;

        [NativeTypeName("DWORD")]
        public uint RetpolineStubOffset;

        [NativeTypeName("DWORD")]
        public uint RetpolineStubSize;

        [NativeTypeName("DWORD64 [2]")]
        public fixed ulong Reserved0[2];
    }
}
