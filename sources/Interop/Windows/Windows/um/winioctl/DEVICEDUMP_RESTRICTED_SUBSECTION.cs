// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DEVICEDUMP_RESTRICTED_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_RESTRICTED_SUBSECTION"]/*' />
public partial struct DEVICEDUMP_RESTRICTED_SUBSECTION
{
    /// <include file='DEVICEDUMP_RESTRICTED_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_RESTRICTED_SUBSECTION.bData"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _bData_e__FixedBuffer bData;

    /// <include file='_bData_e__FixedBuffer.xml' path='doc/member[@name="_bData_e__FixedBuffer"]/*' />
    public partial struct _bData_e__FixedBuffer
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
