// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION"]/*' />
public partial struct TRANSACTION_PROPERTIES_INFORMATION
{
    /// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION.IsolationLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint IsolationLevel;

    /// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION.IsolationFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint IsolationFlags;

    /// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION.Timeout"]/*' />
    public LARGE_INTEGER Timeout;

    /// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION.Outcome"]/*' />
    [NativeTypeName("DWORD")]
    public uint Outcome;

    /// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION.DescriptionLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint DescriptionLength;

    /// <include file='TRANSACTION_PROPERTIES_INFORMATION.xml' path='doc/member[@name="TRANSACTION_PROPERTIES_INFORMATION.Description"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _Description_e__FixedBuffer Description;

    /// <include file='_Description_e__FixedBuffer.xml' path='doc/member[@name="_Description_e__FixedBuffer"]/*' />
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _Description_e__FixedBuffer
    {
        public char e0;

        [UnscopedRef]
        public ref char this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<char> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
