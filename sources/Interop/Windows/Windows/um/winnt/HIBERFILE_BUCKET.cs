// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='HIBERFILE_BUCKET.xml' path='doc/member[@name="HIBERFILE_BUCKET"]/*' />
public partial struct HIBERFILE_BUCKET
{
    /// <include file='HIBERFILE_BUCKET.xml' path='doc/member[@name="HIBERFILE_BUCKET.MaxPhysicalMemory"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong MaxPhysicalMemory;

    /// <include file='HIBERFILE_BUCKET.xml' path='doc/member[@name="HIBERFILE_BUCKET.PhysicalMemoryPercent"]/*' />
    [NativeTypeName("DWORD[3]")]
    public _PhysicalMemoryPercent_e__FixedBuffer PhysicalMemoryPercent;

    /// <include file='_PhysicalMemoryPercent_e__FixedBuffer.xml' path='doc/member[@name="_PhysicalMemoryPercent_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _PhysicalMemoryPercent_e__FixedBuffer
    {
        public uint e0;
    }
}
