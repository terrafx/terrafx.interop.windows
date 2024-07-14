// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SE_TOKEN_USER.xml' path='doc/member[@name="SE_TOKEN_USER"]/*' />
public partial struct SE_TOKEN_USER
{
    /// <include file='SE_TOKEN_USER.xml' path='doc/member[@name="SE_TOKEN_USER.Anonymous1"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L12101_C5")]
    public _Anonymous1_e__Union Anonymous1;

    /// <include file='SE_TOKEN_USER.xml' path='doc/member[@name="SE_TOKEN_USER.Anonymous2"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L12106_C5")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.TokenUser"]/*' />
    [UnscopedRef]
    public ref TOKEN_USER TokenUser
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.TokenUser;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.User"]/*' />
    [UnscopedRef]
    public ref SID_AND_ATTRIBUTES User
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.User;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Sid"]/*' />
    [UnscopedRef]
    public ref SID Sid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Sid;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Buffer"]/*' />
    [UnscopedRef]
    public Span<byte> Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Buffer;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.TokenUser"]/*' />
        [FieldOffset(0)]
        public TOKEN_USER TokenUser;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.User"]/*' />
        [FieldOffset(0)]
        public SID_AND_ATTRIBUTES User;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Sid"]/*' />
        [FieldOffset(0)]
        public SID Sid;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Buffer"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("BYTE[68]")]
        public _Buffer_e__FixedBuffer Buffer;

        /// <include file='_Buffer_e__FixedBuffer.xml' path='doc/member[@name="_Buffer_e__FixedBuffer"]/*' />
        [InlineArray(68)]
        public partial struct _Buffer_e__FixedBuffer
        {
            public byte e0;
        }
    }
}
