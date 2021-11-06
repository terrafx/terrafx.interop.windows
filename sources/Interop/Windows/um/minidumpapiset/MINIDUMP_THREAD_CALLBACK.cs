// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MINIDUMP_THREAD_CALLBACK
    {
        [NativeTypeName("ULONG")]
        public uint ThreadId;

        public HANDLE ThreadHandle;

        public CONTEXT Context;

        [NativeTypeName("ULONG")]
        public uint SizeOfContext;

        [NativeTypeName("ULONG64")]
        public ulong StackBase;

        [NativeTypeName("ULONG64")]
        public ulong StackEnd;
    }
}
