// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='PATHNAME_BUFFER.xml' path='doc/member[@name="PATHNAME_BUFFER"]/*' />
public partial struct PATHNAME_BUFFER
{
    /// <include file='PATHNAME_BUFFER.xml' path='doc/member[@name="PATHNAME_BUFFER.PathNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint PathNameLength;

    /// <include file='PATHNAME_BUFFER.xml' path='doc/member[@name="PATHNAME_BUFFER.Name"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _Name_e__FixedBuffer Name;

    /// <include file='_Name_e__FixedBuffer.xml' path='doc/member[@name="_Name_e__FixedBuffer"]/*' />
    public partial struct _Name_e__FixedBuffer
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
