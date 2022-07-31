// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIB_TCPTABLE.xml' path='doc/member[@name="MIB_TCPTABLE"]/*' />
public partial struct MIB_TCPTABLE
{
    /// <include file='MIB_TCPTABLE.xml' path='doc/member[@name="MIB_TCPTABLE.dwNumEntries"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNumEntries;

    /// <include file='MIB_TCPTABLE.xml' path='doc/member[@name="MIB_TCPTABLE.table"]/*' />
    [NativeTypeName("MIB_TCPROW[1]")]
    public _table_e__FixedBuffer table;

    /// <include file='_table_e__FixedBuffer.xml' path='doc/member[@name="_table_e__FixedBuffer"]/*' />
    public partial struct _table_e__FixedBuffer
    {
        public MIB_TCPROW_LH e0;

        public ref MIB_TCPROW_LH this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<MIB_TCPROW_LH> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
