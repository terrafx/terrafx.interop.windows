// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_RESOURCE_DIR_STRING_U.xml' path='doc/member[@name="IMAGE_RESOURCE_DIR_STRING_U"]/*' />
public partial struct IMAGE_RESOURCE_DIR_STRING_U
{
    /// <include file='IMAGE_RESOURCE_DIR_STRING_U.xml' path='doc/member[@name="IMAGE_RESOURCE_DIR_STRING_U.Length"]/*' />
    [NativeTypeName("WORD")]
    public ushort Length;

    /// <include file='IMAGE_RESOURCE_DIR_STRING_U.xml' path='doc/member[@name="IMAGE_RESOURCE_DIR_STRING_U.NameString"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _NameString_e__FixedBuffer NameString;

    /// <include file='_NameString_e__FixedBuffer.xml' path='doc/member[@name="_NameString_e__FixedBuffer"]/*' />
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _NameString_e__FixedBuffer
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
