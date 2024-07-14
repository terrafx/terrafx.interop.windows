// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MULTIKEYHELPW.xml' path='doc/member[@name="MULTIKEYHELPW"]/*' />
public partial struct MULTIKEYHELPW
{
    /// <include file='MULTIKEYHELPW.xml' path='doc/member[@name="MULTIKEYHELPW.mkSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint mkSize;

    /// <include file='MULTIKEYHELPW.xml' path='doc/member[@name="MULTIKEYHELPW.mkKeylist"]/*' />
    [NativeTypeName("WCHAR")]
    public char mkKeylist;

    /// <include file='MULTIKEYHELPW.xml' path='doc/member[@name="MULTIKEYHELPW.szKeyphrase"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _szKeyphrase_e__FixedBuffer szKeyphrase;

    /// <include file='_szKeyphrase_e__FixedBuffer.xml' path='doc/member[@name="_szKeyphrase_e__FixedBuffer"]/*' />
    public partial struct _szKeyphrase_e__FixedBuffer
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
