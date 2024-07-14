// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='KCRM_TRANSACTION_BLOB.xml' path='doc/member[@name="KCRM_TRANSACTION_BLOB"]/*' />
public partial struct KCRM_TRANSACTION_BLOB
{
    /// <include file='KCRM_TRANSACTION_BLOB.xml' path='doc/member[@name="KCRM_TRANSACTION_BLOB.UOW"]/*' />
    [NativeTypeName("UOW")]
    public Guid UOW;

    /// <include file='KCRM_TRANSACTION_BLOB.xml' path='doc/member[@name="KCRM_TRANSACTION_BLOB.TmIdentity"]/*' />
    public Guid TmIdentity;

    /// <include file='KCRM_TRANSACTION_BLOB.xml' path='doc/member[@name="KCRM_TRANSACTION_BLOB.IsolationLevel"]/*' />
    [NativeTypeName("ULONG")]
    public uint IsolationLevel;

    /// <include file='KCRM_TRANSACTION_BLOB.xml' path='doc/member[@name="KCRM_TRANSACTION_BLOB.IsolationFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint IsolationFlags;

    /// <include file='KCRM_TRANSACTION_BLOB.xml' path='doc/member[@name="KCRM_TRANSACTION_BLOB.Timeout"]/*' />
    [NativeTypeName("ULONG")]
    public uint Timeout;

    /// <include file='KCRM_TRANSACTION_BLOB.xml' path='doc/member[@name="KCRM_TRANSACTION_BLOB.Description"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _Description_e__FixedBuffer Description;

    /// <include file='_Description_e__FixedBuffer.xml' path='doc/member[@name="_Description_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _Description_e__FixedBuffer
    {
        public char e0;
    }
}
