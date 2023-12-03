// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE"]/*' />
public partial struct DVTARGETDEVICE
{
    /// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE.tdSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint tdSize;

    /// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE.tdDriverNameOffset"]/*' />
    [NativeTypeName("WORD")]
    public ushort tdDriverNameOffset;

    /// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE.tdDeviceNameOffset"]/*' />
    [NativeTypeName("WORD")]
    public ushort tdDeviceNameOffset;

    /// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE.tdPortNameOffset"]/*' />
    [NativeTypeName("WORD")]
    public ushort tdPortNameOffset;

    /// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE.tdExtDevmodeOffset"]/*' />
    [NativeTypeName("WORD")]
    public ushort tdExtDevmodeOffset;

    /// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE.tdData"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _tdData_e__FixedBuffer tdData;

    /// <include file='_tdData_e__FixedBuffer.xml' path='doc/member[@name="_tdData_e__FixedBuffer"]/*' />
    public partial struct _tdData_e__FixedBuffer
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
