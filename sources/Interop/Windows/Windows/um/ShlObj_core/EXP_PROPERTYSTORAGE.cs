// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='EXP_PROPERTYSTORAGE.xml' path='doc/member[@name="EXP_PROPERTYSTORAGE"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct EXP_PROPERTYSTORAGE
{
    /// <include file='EXP_PROPERTYSTORAGE.xml' path='doc/member[@name="EXP_PROPERTYSTORAGE.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='EXP_PROPERTYSTORAGE.xml' path='doc/member[@name="EXP_PROPERTYSTORAGE.dwSignature"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSignature;

    /// <include file='EXP_PROPERTYSTORAGE.xml' path='doc/member[@name="EXP_PROPERTYSTORAGE.abPropertyStorage"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _abPropertyStorage_e__FixedBuffer abPropertyStorage;

    /// <include file='_abPropertyStorage_e__FixedBuffer.xml' path='doc/member[@name="_abPropertyStorage_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _abPropertyStorage_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
