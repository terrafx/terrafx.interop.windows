// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MINIDUMP_STREAM_TYPE
    {
        UnusedStream = 0,
        ReservedStream0 = 1,
        ReservedStream1 = 2,
        ThreadListStream = 3,
        ModuleListStream = 4,
        MemoryListStream = 5,
        ExceptionStream = 6,
        SystemInfoStream = 7,
        ThreadExListStream = 8,
        Memory64ListStream = 9,
        CommentStreamA = 10,
        CommentStreamW = 11,
        HandleDataStream = 12,
        FunctionTableStream = 13,
        UnloadedModuleListStream = 14,
        MiscInfoStream = 15,
        MemoryInfoListStream = 16,
        ThreadInfoListStream = 17,
        HandleOperationListStream = 18,
        TokenStream = 19,
        JavaScriptDataStream = 20,
        SystemMemoryInfoStream = 21,
        ProcessVmCountersStream = 22,
        IptTraceStream = 23,
        ThreadNamesStream = 24,
        ceStreamNull = 0x8000,
        ceStreamSystemInfo = 0x8001,
        ceStreamException = 0x8002,
        ceStreamModuleList = 0x8003,
        ceStreamProcessList = 0x8004,
        ceStreamThreadList = 0x8005,
        ceStreamThreadContextList = 0x8006,
        ceStreamThreadCallStackList = 0x8007,
        ceStreamMemoryVirtualList = 0x8008,
        ceStreamMemoryPhysicalList = 0x8009,
        ceStreamBucketParameters = 0x800A,
        ceStreamProcessModuleMap = 0x800B,
        ceStreamDiagnosisList = 0x800C,
        LastReservedStream = 0xffff,
    }
}
