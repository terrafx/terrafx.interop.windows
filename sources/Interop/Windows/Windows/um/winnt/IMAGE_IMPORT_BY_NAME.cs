// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_IMPORT_BY_NAME.xml' path='doc/member[@name="IMAGE_IMPORT_BY_NAME"]/*' />
public partial struct IMAGE_IMPORT_BY_NAME
{
    /// <include file='IMAGE_IMPORT_BY_NAME.xml' path='doc/member[@name="IMAGE_IMPORT_BY_NAME.Hint"]/*' />
    [NativeTypeName("WORD")]
    public ushort Hint;

    /// <include file='IMAGE_IMPORT_BY_NAME.xml' path='doc/member[@name="IMAGE_IMPORT_BY_NAME.Name"]/*' />
    [NativeTypeName("CHAR[1]")]
    public _Name_e__FixedBuffer Name;

    /// <include file='_Name_e__FixedBuffer.xml' path='doc/member[@name="_Name_e__FixedBuffer"]/*' />
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _Name_e__FixedBuffer
    {
        public sbyte e0;

        [UnscopedRef]
        public ref sbyte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<sbyte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
