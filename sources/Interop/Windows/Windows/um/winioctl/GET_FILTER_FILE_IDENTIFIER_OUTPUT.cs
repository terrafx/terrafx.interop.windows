// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='GET_FILTER_FILE_IDENTIFIER_OUTPUT.xml' path='doc/member[@name="GET_FILTER_FILE_IDENTIFIER_OUTPUT"]/*' />
public partial struct GET_FILTER_FILE_IDENTIFIER_OUTPUT
{
    /// <include file='GET_FILTER_FILE_IDENTIFIER_OUTPUT.xml' path='doc/member[@name="GET_FILTER_FILE_IDENTIFIER_OUTPUT.FilterFileIdentifierLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort FilterFileIdentifierLength;

    /// <include file='GET_FILTER_FILE_IDENTIFIER_OUTPUT.xml' path='doc/member[@name="GET_FILTER_FILE_IDENTIFIER_OUTPUT.FilterFileIdentifier"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _FilterFileIdentifier_e__FixedBuffer FilterFileIdentifier;

    /// <include file='_FilterFileIdentifier_e__FixedBuffer.xml' path='doc/member[@name="_FilterFileIdentifier_e__FixedBuffer"]/*' />
    public partial struct _FilterFileIdentifier_e__FixedBuffer
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
