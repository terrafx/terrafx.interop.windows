// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE"]/*' />
[Obsolete("struct EVENTSFORLOGFILE is deprecated and might not work on all platforms. For more info, see MSDN.")]
public partial struct EVENTSFORLOGFILE
{
    /// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE.ulSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulSize;

    /// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE.szLogicalLogFile"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _szLogicalLogFile_e__FixedBuffer szLogicalLogFile;

    /// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE.ulNumRecords"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulNumRecords;

    /// <include file='EVENTSFORLOGFILE.xml' path='doc/member[@name="EVENTSFORLOGFILE.pEventLogRecords"]/*' />
    [NativeTypeName("EVENTLOGRECORD[]")]
    public _pEventLogRecords_e__FixedBuffer pEventLogRecords;

    /// <include file='_szLogicalLogFile_e__FixedBuffer.xml' path='doc/member[@name="_szLogicalLogFile_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _szLogicalLogFile_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_pEventLogRecords_e__FixedBuffer.xml' path='doc/member[@name="_pEventLogRecords_e__FixedBuffer"]/*' />
    public partial struct _pEventLogRecords_e__FixedBuffer
    {
        public EVENTLOGRECORD e0;

        [UnscopedRef]
        public ref EVENTLOGRECORD this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<EVENTLOGRECORD> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
