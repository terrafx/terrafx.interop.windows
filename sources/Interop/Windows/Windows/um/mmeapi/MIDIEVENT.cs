// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIDIEVENT.xml' path='doc/member[@name="MIDIEVENT"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIDIEVENT
{
    /// <include file='MIDIEVENT.xml' path='doc/member[@name="MIDIEVENT.dwDeltaTime"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDeltaTime;

    /// <include file='MIDIEVENT.xml' path='doc/member[@name="MIDIEVENT.dwStreamID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStreamID;

    /// <include file='MIDIEVENT.xml' path='doc/member[@name="MIDIEVENT.dwEvent"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwEvent;

    /// <include file='MIDIEVENT.xml' path='doc/member[@name="MIDIEVENT.dwParms"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _dwParms_e__FixedBuffer dwParms;

    /// <include file='_dwParms_e__FixedBuffer.xml' path='doc/member[@name="_dwParms_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _dwParms_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
