// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FS_BPIO_RESULTS.xml' path='doc/member[@name="FS_BPIO_RESULTS"]/*' />
public partial struct FS_BPIO_RESULTS
{
    /// <include file='FS_BPIO_RESULTS.xml' path='doc/member[@name="FS_BPIO_RESULTS.OpStatus"]/*' />
    [NativeTypeName("DWORD")]
    public uint OpStatus;

    /// <include file='FS_BPIO_RESULTS.xml' path='doc/member[@name="FS_BPIO_RESULTS.FailingDriverNameLen"]/*' />
    [NativeTypeName("WORD")]
    public ushort FailingDriverNameLen;

    /// <include file='FS_BPIO_RESULTS.xml' path='doc/member[@name="FS_BPIO_RESULTS.FailingDriverName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _FailingDriverName_e__FixedBuffer FailingDriverName;

    /// <include file='FS_BPIO_RESULTS.xml' path='doc/member[@name="FS_BPIO_RESULTS.FailureReasonLen"]/*' />
    [NativeTypeName("WORD")]
    public ushort FailureReasonLen;

    /// <include file='FS_BPIO_RESULTS.xml' path='doc/member[@name="FS_BPIO_RESULTS.FailureReason"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _FailureReason_e__FixedBuffer FailureReason;

    /// <include file='_FailingDriverName_e__FixedBuffer.xml' path='doc/member[@name="_FailingDriverName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _FailingDriverName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_FailureReason_e__FixedBuffer.xml' path='doc/member[@name="_FailureReason_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _FailureReason_e__FixedBuffer
    {
        public char e0;
    }
}
