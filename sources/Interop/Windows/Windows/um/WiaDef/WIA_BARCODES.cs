// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WIA_BARCODES.xml' path='doc/member[@name="WIA_BARCODES"]/*' />
public partial struct WIA_BARCODES
{
    /// <include file='WIA_BARCODES.xml' path='doc/member[@name="WIA_BARCODES.Tag"]/*' />
    [NativeTypeName("DWORD")]
    public uint Tag;

    /// <include file='WIA_BARCODES.xml' path='doc/member[@name="WIA_BARCODES.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='WIA_BARCODES.xml' path='doc/member[@name="WIA_BARCODES.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='WIA_BARCODES.xml' path='doc/member[@name="WIA_BARCODES.Count"]/*' />
    [NativeTypeName("DWORD")]
    public uint Count;

    /// <include file='WIA_BARCODES.xml' path='doc/member[@name="WIA_BARCODES.Barcodes"]/*' />
    [NativeTypeName("WIA_BARCODE_INFO[1]")]
    public _Barcodes_e__FixedBuffer Barcodes;

    /// <include file='_Barcodes_e__FixedBuffer.xml' path='doc/member[@name="_Barcodes_e__FixedBuffer"]/*' />
    public partial struct _Barcodes_e__FixedBuffer
    {
        public WIA_BARCODE_INFO e0;

        [UnscopedRef]
        public ref WIA_BARCODE_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<WIA_BARCODE_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
