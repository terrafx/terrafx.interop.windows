// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCM_PD_LOCATION_STRING.xml' path='doc/member[@name="SCM_PD_LOCATION_STRING"]/*' />
public partial struct SCM_PD_LOCATION_STRING
{
    /// <include file='SCM_PD_LOCATION_STRING.xml' path='doc/member[@name="SCM_PD_LOCATION_STRING.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_PD_LOCATION_STRING.xml' path='doc/member[@name="SCM_PD_LOCATION_STRING.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_PD_LOCATION_STRING.xml' path='doc/member[@name="SCM_PD_LOCATION_STRING.Location"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _Location_e__FixedBuffer Location;

    /// <include file='_Location_e__FixedBuffer.xml' path='doc/member[@name="_Location_e__FixedBuffer"]/*' />
    public partial struct _Location_e__FixedBuffer
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
