// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WIA_BARCODE_INFO.xml' path='doc/member[@name="WIA_BARCODE_INFO"]/*' />
public partial struct WIA_BARCODE_INFO
{
    /// <include file='WIA_BARCODE_INFO.xml' path='doc/member[@name="WIA_BARCODE_INFO.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='WIA_BARCODE_INFO.xml' path='doc/member[@name="WIA_BARCODE_INFO.Type"]/*' />
    [NativeTypeName("DWORD")]
    public uint Type;

    /// <include file='WIA_BARCODE_INFO.xml' path='doc/member[@name="WIA_BARCODE_INFO.Page"]/*' />
    [NativeTypeName("DWORD")]
    public uint Page;

    /// <include file='WIA_BARCODE_INFO.xml' path='doc/member[@name="WIA_BARCODE_INFO.Confidence"]/*' />
    [NativeTypeName("DWORD")]
    public uint Confidence;

    /// <include file='WIA_BARCODE_INFO.xml' path='doc/member[@name="WIA_BARCODE_INFO.XOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint XOffset;

    /// <include file='WIA_BARCODE_INFO.xml' path='doc/member[@name="WIA_BARCODE_INFO.YOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint YOffset;

    /// <include file='WIA_BARCODE_INFO.xml' path='doc/member[@name="WIA_BARCODE_INFO.Rotation"]/*' />
    [NativeTypeName("DWORD")]
    public uint Rotation;

    /// <include file='WIA_BARCODE_INFO.xml' path='doc/member[@name="WIA_BARCODE_INFO.Length"]/*' />
    [NativeTypeName("DWORD")]
    public uint Length;

    /// <include file='WIA_BARCODE_INFO.xml' path='doc/member[@name="WIA_BARCODE_INFO.Text"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _Text_e__FixedBuffer Text;

    /// <include file='_Text_e__FixedBuffer.xml' path='doc/member[@name="_Text_e__FixedBuffer"]/*' />
    public partial struct _Text_e__FixedBuffer
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
