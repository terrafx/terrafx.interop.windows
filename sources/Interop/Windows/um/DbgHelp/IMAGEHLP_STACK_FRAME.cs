// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct IMAGEHLP_STACK_FRAME
    {
        [NativeTypeName("ULONG64")]
        public ulong InstructionOffset;

        [NativeTypeName("ULONG64")]
        public ulong ReturnOffset;

        [NativeTypeName("ULONG64")]
        public ulong FrameOffset;

        [NativeTypeName("ULONG64")]
        public ulong StackOffset;

        [NativeTypeName("ULONG64")]
        public ulong BackingStoreOffset;

        [NativeTypeName("ULONG64")]
        public ulong FuncTableEntry;

        [NativeTypeName("ULONG64 [4]")]
        public fixed ulong Params[4];

        [NativeTypeName("ULONG64 [5]")]
        public fixed ulong Reserved[5];

        public BOOL Virtual;

        [NativeTypeName("ULONG")]
        public uint Reserved2;
    }
}
