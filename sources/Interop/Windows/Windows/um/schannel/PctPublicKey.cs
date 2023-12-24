// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='PctPublicKey.xml' path='doc/member[@name="PctPublicKey"]/*' />
public partial struct PctPublicKey
{
    /// <include file='PctPublicKey.xml' path='doc/member[@name="PctPublicKey.Type"]/*' />
    [NativeTypeName("DWORD")]
    public uint Type;

    /// <include file='PctPublicKey.xml' path='doc/member[@name="PctPublicKey.cbKey"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbKey;

    /// <include file='PctPublicKey.xml' path='doc/member[@name="PctPublicKey.pKey"]/*' />
    [NativeTypeName("UCHAR[1]")]
    public _pKey_e__FixedBuffer pKey;

    /// <include file='_pKey_e__FixedBuffer.xml' path='doc/member[@name="_pKey_e__FixedBuffer"]/*' />
    public partial struct _pKey_e__FixedBuffer
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
