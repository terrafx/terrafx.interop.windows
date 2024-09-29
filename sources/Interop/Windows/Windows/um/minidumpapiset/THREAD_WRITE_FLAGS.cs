// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='THREAD_WRITE_FLAGS.xml' path='doc/member[@name="THREAD_WRITE_FLAGS"]/*' />
public enum THREAD_WRITE_FLAGS
{
    /// <include file='THREAD_WRITE_FLAGS.xml' path='doc/member[@name="THREAD_WRITE_FLAGS.ThreadWriteThread"]/*' />
    ThreadWriteThread = 0x0001,

    /// <include file='THREAD_WRITE_FLAGS.xml' path='doc/member[@name="THREAD_WRITE_FLAGS.ThreadWriteStack"]/*' />
    ThreadWriteStack = 0x0002,

    /// <include file='THREAD_WRITE_FLAGS.xml' path='doc/member[@name="THREAD_WRITE_FLAGS.ThreadWriteContext"]/*' />
    ThreadWriteContext = 0x0004,

    /// <include file='THREAD_WRITE_FLAGS.xml' path='doc/member[@name="THREAD_WRITE_FLAGS.ThreadWriteBackingStore"]/*' />
    ThreadWriteBackingStore = 0x0008,

    /// <include file='THREAD_WRITE_FLAGS.xml' path='doc/member[@name="THREAD_WRITE_FLAGS.ThreadWriteInstructionWindow"]/*' />
    ThreadWriteInstructionWindow = 0x0010,

    /// <include file='THREAD_WRITE_FLAGS.xml' path='doc/member[@name="THREAD_WRITE_FLAGS.ThreadWriteThreadData"]/*' />
    ThreadWriteThreadData = 0x0020,

    /// <include file='THREAD_WRITE_FLAGS.xml' path='doc/member[@name="THREAD_WRITE_FLAGS.ThreadWriteThreadInfo"]/*' />
    ThreadWriteThreadInfo = 0x0040,
}
