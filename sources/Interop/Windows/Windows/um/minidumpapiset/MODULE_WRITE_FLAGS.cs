// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='MODULE_WRITE_FLAGS.xml' path='doc/member[@name="MODULE_WRITE_FLAGS"]/*' />
[Flags]
public enum MODULE_WRITE_FLAGS
{
    /// <include file='MODULE_WRITE_FLAGS.xml' path='doc/member[@name="MODULE_WRITE_FLAGS.ModuleWriteModule"]/*' />
    ModuleWriteModule = 0x0001,

    /// <include file='MODULE_WRITE_FLAGS.xml' path='doc/member[@name="MODULE_WRITE_FLAGS.ModuleWriteDataSeg"]/*' />
    ModuleWriteDataSeg = 0x0002,

    /// <include file='MODULE_WRITE_FLAGS.xml' path='doc/member[@name="MODULE_WRITE_FLAGS.ModuleWriteMiscRecord"]/*' />
    ModuleWriteMiscRecord = 0x0004,

    /// <include file='MODULE_WRITE_FLAGS.xml' path='doc/member[@name="MODULE_WRITE_FLAGS.ModuleWriteCvRecord"]/*' />
    ModuleWriteCvRecord = 0x0008,

    /// <include file='MODULE_WRITE_FLAGS.xml' path='doc/member[@name="MODULE_WRITE_FLAGS.ModuleReferencedByMemory"]/*' />
    ModuleReferencedByMemory = 0x0010,

    /// <include file='MODULE_WRITE_FLAGS.xml' path='doc/member[@name="MODULE_WRITE_FLAGS.ModuleWriteTlsData"]/*' />
    ModuleWriteTlsData = 0x0020,

    /// <include file='MODULE_WRITE_FLAGS.xml' path='doc/member[@name="MODULE_WRITE_FLAGS.ModuleWriteCodeSegs"]/*' />
    ModuleWriteCodeSegs = 0x0040,
}
