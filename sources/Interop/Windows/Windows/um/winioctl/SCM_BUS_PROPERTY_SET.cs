// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCM_BUS_PROPERTY_SET.xml' path='doc/member[@name="SCM_BUS_PROPERTY_SET"]/*' />
public partial struct SCM_BUS_PROPERTY_SET
{
    /// <include file='SCM_BUS_PROPERTY_SET.xml' path='doc/member[@name="SCM_BUS_PROPERTY_SET.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_BUS_PROPERTY_SET.xml' path='doc/member[@name="SCM_BUS_PROPERTY_SET.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_BUS_PROPERTY_SET.xml' path='doc/member[@name="SCM_BUS_PROPERTY_SET.PropertyId"]/*' />
    public SCM_BUS_PROPERTY_ID PropertyId;

    /// <include file='SCM_BUS_PROPERTY_SET.xml' path='doc/member[@name="SCM_BUS_PROPERTY_SET.SetType"]/*' />
    public SCM_BUS_SET_TYPE SetType;

    /// <include file='SCM_BUS_PROPERTY_SET.xml' path='doc/member[@name="SCM_BUS_PROPERTY_SET.AdditionalParameters"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _AdditionalParameters_e__FixedBuffer AdditionalParameters;

    /// <include file='_AdditionalParameters_e__FixedBuffer.xml' path='doc/member[@name="_AdditionalParameters_e__FixedBuffer"]/*' />
    public partial struct _AdditionalParameters_e__FixedBuffer
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
