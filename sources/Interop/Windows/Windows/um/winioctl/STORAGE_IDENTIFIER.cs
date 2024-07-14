// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER"]/*' />
public partial struct STORAGE_IDENTIFIER
{
    /// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER.CodeSet"]/*' />
    public STORAGE_IDENTIFIER_CODE_SET CodeSet;

    /// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER.Type"]/*' />
    public STORAGE_IDENTIFIER_TYPE Type;

    /// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER.IdentifierSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort IdentifierSize;

    /// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER.NextOffset"]/*' />
    [NativeTypeName("WORD")]
    public ushort NextOffset;

    /// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER.Association"]/*' />
    public STORAGE_ASSOCIATION_TYPE Association;

    /// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER.Identifier"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _Identifier_e__FixedBuffer Identifier;

    /// <include file='_Identifier_e__FixedBuffer.xml' path='doc/member[@name="_Identifier_e__FixedBuffer"]/*' />
    public partial struct _Identifier_e__FixedBuffer
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
