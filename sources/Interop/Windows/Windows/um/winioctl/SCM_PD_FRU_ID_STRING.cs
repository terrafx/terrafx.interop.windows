// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCM_PD_FRU_ID_STRING.xml' path='doc/member[@name="SCM_PD_FRU_ID_STRING"]/*' />
public partial struct SCM_PD_FRU_ID_STRING
{
    /// <include file='SCM_PD_FRU_ID_STRING.xml' path='doc/member[@name="SCM_PD_FRU_ID_STRING.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_PD_FRU_ID_STRING.xml' path='doc/member[@name="SCM_PD_FRU_ID_STRING.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_PD_FRU_ID_STRING.xml' path='doc/member[@name="SCM_PD_FRU_ID_STRING.IdentifierSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint IdentifierSize;

    /// <include file='SCM_PD_FRU_ID_STRING.xml' path='doc/member[@name="SCM_PD_FRU_ID_STRING.Identifier"]/*' />
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
