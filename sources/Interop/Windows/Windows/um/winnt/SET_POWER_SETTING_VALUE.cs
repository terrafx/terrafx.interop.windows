// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SET_POWER_SETTING_VALUE.xml' path='doc/member[@name="SET_POWER_SETTING_VALUE"]/*' />
public partial struct SET_POWER_SETTING_VALUE
{
    /// <include file='SET_POWER_SETTING_VALUE.xml' path='doc/member[@name="SET_POWER_SETTING_VALUE.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SET_POWER_SETTING_VALUE.xml' path='doc/member[@name="SET_POWER_SETTING_VALUE.Guid"]/*' />
    public Guid Guid;

    /// <include file='SET_POWER_SETTING_VALUE.xml' path='doc/member[@name="SET_POWER_SETTING_VALUE.PowerCondition"]/*' />
    public SYSTEM_POWER_CONDITION PowerCondition;

    /// <include file='SET_POWER_SETTING_VALUE.xml' path='doc/member[@name="SET_POWER_SETTING_VALUE.DataLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataLength;

    /// <include file='SET_POWER_SETTING_VALUE.xml' path='doc/member[@name="SET_POWER_SETTING_VALUE.Data"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _Data_e__FixedBuffer Data;

    /// <include file='_Data_e__FixedBuffer.xml' path='doc/member[@name="_Data_e__FixedBuffer"]/*' />
    public partial struct _Data_e__FixedBuffer
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
