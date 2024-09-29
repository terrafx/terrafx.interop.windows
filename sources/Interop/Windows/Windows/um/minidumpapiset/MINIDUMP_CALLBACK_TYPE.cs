// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE"]/*' />
public enum MINIDUMP_CALLBACK_TYPE
{
    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.ModuleCallback"]/*' />
    ModuleCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.ThreadCallback"]/*' />
    ThreadCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.ThreadExCallback"]/*' />
    ThreadExCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.IncludeThreadCallback"]/*' />
    IncludeThreadCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.IncludeModuleCallback"]/*' />
    IncludeModuleCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.MemoryCallback"]/*' />
    MemoryCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.CancelCallback"]/*' />
    CancelCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.WriteKernelMinidumpCallback"]/*' />
    WriteKernelMinidumpCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.KernelMinidumpStatusCallback"]/*' />
    KernelMinidumpStatusCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.RemoveMemoryCallback"]/*' />
    RemoveMemoryCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.IncludeVmRegionCallback"]/*' />
    IncludeVmRegionCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.IoStartCallback"]/*' />
    IoStartCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.IoWriteAllCallback"]/*' />
    IoWriteAllCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.IoFinishCallback"]/*' />
    IoFinishCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.ReadMemoryFailureCallback"]/*' />
    ReadMemoryFailureCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.SecondaryFlagsCallback"]/*' />
    SecondaryFlagsCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.IsProcessSnapshotCallback"]/*' />
    IsProcessSnapshotCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.VmStartCallback"]/*' />
    VmStartCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.VmQueryCallback"]/*' />
    VmQueryCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.VmPreReadCallback"]/*' />
    VmPreReadCallback,

    /// <include file='MINIDUMP_CALLBACK_TYPE.xml' path='doc/member[@name="MINIDUMP_CALLBACK_TYPE.VmPostReadCallback"]/*' />
    VmPostReadCallback,
}
