// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='RemSNB.xml' path='doc/member[@name="RemSNB"]/*' />
public partial struct RemSNB
{
    /// <include file='RemSNB.xml' path='doc/member[@name="RemSNB.ulCntStr"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulCntStr;

    /// <include file='RemSNB.xml' path='doc/member[@name="RemSNB.ulCntChar"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulCntChar;

    /// <include file='RemSNB.xml' path='doc/member[@name="RemSNB.rgString"]/*' />
    [NativeTypeName("OLECHAR[1]")]
    public _rgString_e__FixedBuffer rgString;

    /// <include file='_rgString_e__FixedBuffer.xml' path='doc/member[@name="_rgString_e__FixedBuffer"]/*' />
    public partial struct _rgString_e__FixedBuffer
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
