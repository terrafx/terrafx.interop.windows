// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_OFFLOAD_TOKEN.xml' path='doc/member[@name="STORAGE_OFFLOAD_TOKEN"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct STORAGE_OFFLOAD_TOKEN
{
    /// <include file='STORAGE_OFFLOAD_TOKEN.xml' path='doc/member[@name="STORAGE_OFFLOAD_TOKEN.TokenType"]/*' />
    [NativeTypeName("BYTE[4]")]
    public _TokenType_e__FixedBuffer TokenType;

    /// <include file='STORAGE_OFFLOAD_TOKEN.xml' path='doc/member[@name="STORAGE_OFFLOAD_TOKEN.Reserved"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='STORAGE_OFFLOAD_TOKEN.xml' path='doc/member[@name="STORAGE_OFFLOAD_TOKEN.TokenIdLength"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _TokenIdLength_e__FixedBuffer TokenIdLength;

    /// <include file='STORAGE_OFFLOAD_TOKEN.xml' path='doc/member[@name="STORAGE_OFFLOAD_TOKEN.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winioctl_L3359_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.StorageOffloadZeroDataToken"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._StorageOffloadZeroDataToken_e__Struct StorageOffloadZeroDataToken
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.StorageOffloadZeroDataToken;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Token"]/*' />
    [UnscopedRef]
    public Span<byte> Token
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Token;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.StorageOffloadZeroDataToken"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L3360_C9")]
        public _StorageOffloadZeroDataToken_e__Struct StorageOffloadZeroDataToken;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Token"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("BYTE[504]")]
        public _Token_e__FixedBuffer Token;

        /// <include file='_StorageOffloadZeroDataToken_e__Struct.xml' path='doc/member[@name="_StorageOffloadZeroDataToken_e__Struct"]/*' />
        public partial struct _StorageOffloadZeroDataToken_e__Struct
        {
            /// <include file='_StorageOffloadZeroDataToken_e__Struct.xml' path='doc/member[@name="_StorageOffloadZeroDataToken_e__Struct.Reserved2"]/*' />
            [NativeTypeName("BYTE[504]")]
            public _Reserved2_e__FixedBuffer Reserved2;

            /// <include file='_Reserved2_e__FixedBuffer.xml' path='doc/member[@name="_Reserved2_e__FixedBuffer"]/*' />
            [InlineArray(504)]
            public partial struct _Reserved2_e__FixedBuffer
            {
                public byte e0;
            }
        }

        /// <include file='_Token_e__FixedBuffer.xml' path='doc/member[@name="_Token_e__FixedBuffer"]/*' />
        [InlineArray(504)]
        public partial struct _Token_e__FixedBuffer
        {
            public byte e0;
        }
    }

    /// <include file='_TokenType_e__FixedBuffer.xml' path='doc/member[@name="_TokenType_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _TokenType_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_TokenIdLength_e__FixedBuffer.xml' path='doc/member[@name="_TokenIdLength_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _TokenIdLength_e__FixedBuffer
    {
        public byte e0;
    }
}
