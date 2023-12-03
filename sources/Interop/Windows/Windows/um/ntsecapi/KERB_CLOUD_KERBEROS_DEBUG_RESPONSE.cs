// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_RESPONSE"]/*' />
public partial struct KERB_CLOUD_KERBEROS_DEBUG_RESPONSE
{
    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.MessageType"]/*' />
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.Version"]/*' />
    [NativeTypeName("ULONG")]
    public uint Version;

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.Length"]/*' />
    [NativeTypeName("ULONG")]
    public uint Length;

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_RESPONSE.Data"]/*' />
    [NativeTypeName("ULONG[1]")]
    public _Data_e__FixedBuffer Data;

    /// <include file='_Data_e__FixedBuffer.xml' path='doc/member[@name="_Data_e__FixedBuffer"]/*' />
    public partial struct _Data_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
