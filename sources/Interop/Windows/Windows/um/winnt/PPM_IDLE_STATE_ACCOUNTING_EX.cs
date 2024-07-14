// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX"]/*' />
public partial struct PPM_IDLE_STATE_ACCOUNTING_EX
{
    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.TotalTime"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong TotalTime;

    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.IdleTransitions"]/*' />
    [NativeTypeName("DWORD")]
    public uint IdleTransitions;

    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.FailedTransitions"]/*' />
    [NativeTypeName("DWORD")]
    public uint FailedTransitions;

    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.InvalidBucketIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint InvalidBucketIndex;

    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.MinTimeUs"]/*' />
    [NativeTypeName("DWORD")]
    public uint MinTimeUs;

    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.MaxTimeUs"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxTimeUs;

    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.CancelledTransitions"]/*' />
    [NativeTypeName("DWORD")]
    public uint CancelledTransitions;

    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.IdleTimeBuckets"]/*' />
    [NativeTypeName("PPM_IDLE_STATE_BUCKET_EX[16]")]
    public _IdleTimeBuckets_e__FixedBuffer IdleTimeBuckets;

    /// <include file='_IdleTimeBuckets_e__FixedBuffer.xml' path='doc/member[@name="_IdleTimeBuckets_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _IdleTimeBuckets_e__FixedBuffer
    {
        public PPM_IDLE_STATE_BUCKET_EX e0;
    }
}
