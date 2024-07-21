// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidclass.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION"]/*' />
public partial struct HID_COLLECTION_INFORMATION
{
    /// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION.DescriptorSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint DescriptorSize;

    /// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION.Polled"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Polled;

    /// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION.Reserved1"]/*' />
    [NativeTypeName("UCHAR[1]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    /// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION.VendorID"]/*' />
    public ushort VendorID;

    /// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION.ProductID"]/*' />
    public ushort ProductID;

    /// <include file='HID_COLLECTION_INFORMATION.xml' path='doc/member[@name="HID_COLLECTION_INFORMATION.VersionNumber"]/*' />
    public ushort VersionNumber;

    /// <include file='_Reserved1_e__FixedBuffer.xml' path='doc/member[@name="_Reserved1_e__FixedBuffer"]/*' />
    public partial struct _Reserved1_e__FixedBuffer
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
