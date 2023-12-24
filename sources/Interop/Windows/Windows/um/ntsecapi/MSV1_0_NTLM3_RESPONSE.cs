// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE"]/*' />
public partial struct MSV1_0_NTLM3_RESPONSE
{
    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.Response"]/*' />
    [NativeTypeName("UCHAR[16]")]
    public _Response_e__FixedBuffer Response;

    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.RespType"]/*' />
    [NativeTypeName("UCHAR")]
    public byte RespType;

    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.HiRespType"]/*' />
    [NativeTypeName("UCHAR")]
    public byte HiRespType;

    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.Flags"]/*' />
    public ushort Flags;

    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.MsgWord"]/*' />
    [NativeTypeName("ULONG")]
    public uint MsgWord;

    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.TimeStamp"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong TimeStamp;

    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.ChallengeFromClient"]/*' />
    [NativeTypeName("UCHAR[8]")]
    public _ChallengeFromClient_e__FixedBuffer ChallengeFromClient;

    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.AvPairsOff"]/*' />
    [NativeTypeName("ULONG")]
    public uint AvPairsOff;

    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.Buffer"]/*' />
    [NativeTypeName("UCHAR[1]")]
    public _Buffer_e__FixedBuffer Buffer;

    /// <include file='_Response_e__FixedBuffer.xml' path='doc/member[@name="_Response_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _Response_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_ChallengeFromClient_e__FixedBuffer.xml' path='doc/member[@name="_ChallengeFromClient_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _ChallengeFromClient_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Buffer_e__FixedBuffer.xml' path='doc/member[@name="_Buffer_e__FixedBuffer"]/*' />
    public partial struct _Buffer_e__FixedBuffer
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
