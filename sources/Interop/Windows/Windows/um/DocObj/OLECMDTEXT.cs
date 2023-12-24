// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='OLECMDTEXT.xml' path='doc/member[@name="OLECMDTEXT"]/*' />
public partial struct OLECMDTEXT
{
    /// <include file='OLECMDTEXT.xml' path='doc/member[@name="OLECMDTEXT.cmdtextf"]/*' />
    [NativeTypeName("DWORD")]
    public uint cmdtextf;

    /// <include file='OLECMDTEXT.xml' path='doc/member[@name="OLECMDTEXT.cwActual"]/*' />
    [NativeTypeName("ULONG")]
    public uint cwActual;

    /// <include file='OLECMDTEXT.xml' path='doc/member[@name="OLECMDTEXT.cwBuf"]/*' />
    [NativeTypeName("ULONG")]
    public uint cwBuf;

    /// <include file='OLECMDTEXT.xml' path='doc/member[@name="OLECMDTEXT.rgwz"]/*' />
    [NativeTypeName("wchar_t[1]")]
    public _rgwz_e__FixedBuffer rgwz;

    /// <include file='_rgwz_e__FixedBuffer.xml' path='doc/member[@name="_rgwz_e__FixedBuffer"]/*' />
    public partial struct _rgwz_e__FixedBuffer
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
