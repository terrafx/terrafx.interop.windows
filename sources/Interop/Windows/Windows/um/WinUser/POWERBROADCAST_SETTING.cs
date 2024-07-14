// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='POWERBROADCAST_SETTING.xml' path='doc/member[@name="POWERBROADCAST_SETTING"]/*' />
public partial struct POWERBROADCAST_SETTING
{
    /// <include file='POWERBROADCAST_SETTING.xml' path='doc/member[@name="POWERBROADCAST_SETTING.PowerSetting"]/*' />
    public Guid PowerSetting;

    /// <include file='POWERBROADCAST_SETTING.xml' path='doc/member[@name="POWERBROADCAST_SETTING.DataLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataLength;

    /// <include file='POWERBROADCAST_SETTING.xml' path='doc/member[@name="POWERBROADCAST_SETTING.Data"]/*' />
    [NativeTypeName("UCHAR[1]")]
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
