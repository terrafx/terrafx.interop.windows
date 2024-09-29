// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE"]/*' />
public enum MINIDUMP_STREAM_TYPE
{
    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.UnusedStream"]/*' />
    UnusedStream = 0,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ReservedStream0"]/*' />
    ReservedStream0 = 1,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ReservedStream1"]/*' />
    ReservedStream1 = 2,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ThreadListStream"]/*' />
    ThreadListStream = 3,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ModuleListStream"]/*' />
    ModuleListStream = 4,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.MemoryListStream"]/*' />
    MemoryListStream = 5,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ExceptionStream"]/*' />
    ExceptionStream = 6,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.SystemInfoStream"]/*' />
    SystemInfoStream = 7,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ThreadExListStream"]/*' />
    ThreadExListStream = 8,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.Memory64ListStream"]/*' />
    Memory64ListStream = 9,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.CommentStreamA"]/*' />
    CommentStreamA = 10,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.CommentStreamW"]/*' />
    CommentStreamW = 11,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.HandleDataStream"]/*' />
    HandleDataStream = 12,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.FunctionTableStream"]/*' />
    FunctionTableStream = 13,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.UnloadedModuleListStream"]/*' />
    UnloadedModuleListStream = 14,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.MiscInfoStream"]/*' />
    MiscInfoStream = 15,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.MemoryInfoListStream"]/*' />
    MemoryInfoListStream = 16,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ThreadInfoListStream"]/*' />
    ThreadInfoListStream = 17,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.HandleOperationListStream"]/*' />
    HandleOperationListStream = 18,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.TokenStream"]/*' />
    TokenStream = 19,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.JavaScriptDataStream"]/*' />
    JavaScriptDataStream = 20,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.SystemMemoryInfoStream"]/*' />
    SystemMemoryInfoStream = 21,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ProcessVmCountersStream"]/*' />
    ProcessVmCountersStream = 22,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.IptTraceStream"]/*' />
    IptTraceStream = 23,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ThreadNamesStream"]/*' />
    ThreadNamesStream = 24,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ceStreamNull"]/*' />
    ceStreamNull = 0x8000,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ceStreamSystemInfo"]/*' />
    ceStreamSystemInfo = 0x8001,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ceStreamException"]/*' />
    ceStreamException = 0x8002,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ceStreamModuleList"]/*' />
    ceStreamModuleList = 0x8003,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ceStreamProcessList"]/*' />
    ceStreamProcessList = 0x8004,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ceStreamThreadList"]/*' />
    ceStreamThreadList = 0x8005,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ceStreamThreadContextList"]/*' />
    ceStreamThreadContextList = 0x8006,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ceStreamThreadCallStackList"]/*' />
    ceStreamThreadCallStackList = 0x8007,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ceStreamMemoryVirtualList"]/*' />
    ceStreamMemoryVirtualList = 0x8008,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ceStreamMemoryPhysicalList"]/*' />
    ceStreamMemoryPhysicalList = 0x8009,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ceStreamBucketParameters"]/*' />
    ceStreamBucketParameters = 0x800A,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ceStreamProcessModuleMap"]/*' />
    ceStreamProcessModuleMap = 0x800B,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.ceStreamDiagnosisList"]/*' />
    ceStreamDiagnosisList = 0x800C,

    /// <include file='MINIDUMP_STREAM_TYPE.xml' path='doc/member[@name="MINIDUMP_STREAM_TYPE.LastReservedStream"]/*' />
    LastReservedStream = 0xffff,
}
