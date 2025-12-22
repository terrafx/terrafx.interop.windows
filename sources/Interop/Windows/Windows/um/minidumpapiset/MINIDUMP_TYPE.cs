// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE"]/*' />
public enum MINIDUMP_TYPE
{
    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpNormal"]/*' />
    MiniDumpNormal = 0x00000000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithDataSegs"]/*' />
    MiniDumpWithDataSegs = 0x00000001,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithFullMemory"]/*' />
    MiniDumpWithFullMemory = 0x00000002,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithHandleData"]/*' />
    MiniDumpWithHandleData = 0x00000004,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpFilterMemory"]/*' />
    MiniDumpFilterMemory = 0x00000008,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpScanMemory"]/*' />
    MiniDumpScanMemory = 0x00000010,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithUnloadedModules"]/*' />
    MiniDumpWithUnloadedModules = 0x00000020,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithIndirectlyReferencedMemory"]/*' />
    MiniDumpWithIndirectlyReferencedMemory = 0x00000040,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpFilterModulePaths"]/*' />
    MiniDumpFilterModulePaths = 0x00000080,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithProcessThreadData"]/*' />
    MiniDumpWithProcessThreadData = 0x00000100,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithPrivateReadWriteMemory"]/*' />
    MiniDumpWithPrivateReadWriteMemory = 0x00000200,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithoutOptionalData"]/*' />
    MiniDumpWithoutOptionalData = 0x00000400,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithFullMemoryInfo"]/*' />
    MiniDumpWithFullMemoryInfo = 0x00000800,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithThreadInfo"]/*' />
    MiniDumpWithThreadInfo = 0x00001000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithCodeSegs"]/*' />
    MiniDumpWithCodeSegs = 0x00002000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithoutAuxiliaryState"]/*' />
    MiniDumpWithoutAuxiliaryState = 0x00004000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithFullAuxiliaryState"]/*' />
    MiniDumpWithFullAuxiliaryState = 0x00008000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithPrivateWriteCopyMemory"]/*' />
    MiniDumpWithPrivateWriteCopyMemory = 0x00010000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpIgnoreInaccessibleMemory"]/*' />
    MiniDumpIgnoreInaccessibleMemory = 0x00020000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithTokenInformation"]/*' />
    MiniDumpWithTokenInformation = 0x00040000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithModuleHeaders"]/*' />
    MiniDumpWithModuleHeaders = 0x00080000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpFilterTriage"]/*' />
    MiniDumpFilterTriage = 0x00100000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithAvxXStateContext"]/*' />
    MiniDumpWithAvxXStateContext = 0x00200000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpWithIptTrace"]/*' />
    MiniDumpWithIptTrace = 0x00400000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpScanInaccessiblePartialPages"]/*' />
    MiniDumpScanInaccessiblePartialPages = 0x00800000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpFilterWriteCombinedMemory"]/*' />
    MiniDumpFilterWriteCombinedMemory = 0x01000000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpValidTypeFlags"]/*' />
    MiniDumpValidTypeFlags = 0x01ffffff,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpNoIgnoreInaccessibleMemory"]/*' />
    MiniDumpNoIgnoreInaccessibleMemory = 0x02000000,

    /// <include file='MINIDUMP_TYPE.xml' path='doc/member[@name="MINIDUMP_TYPE.MiniDumpValidTypeFlagsEx"]/*' />
    MiniDumpValidTypeFlagsEx = 0x03ffffff,
}
