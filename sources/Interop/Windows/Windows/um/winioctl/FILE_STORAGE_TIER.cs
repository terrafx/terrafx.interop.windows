// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER"]/*' />
public partial struct FILE_STORAGE_TIER
{
    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.Id"]/*' />
    public Guid Id;

    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.Name"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _Name_e__FixedBuffer Name;

    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.Description"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _Description_e__FixedBuffer Description;

    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.Flags"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Flags;

    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.ProvisionedCapacity"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong ProvisionedCapacity;

    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.MediaType"]/*' />
    public FILE_STORAGE_TIER_MEDIA_TYPE MediaType;

    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.Class"]/*' />
    public FILE_STORAGE_TIER_CLASS Class;

    /// <include file='_Name_e__FixedBuffer.xml' path='doc/member[@name="_Name_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _Name_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_Description_e__FixedBuffer.xml' path='doc/member[@name="_Description_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _Description_e__FixedBuffer
    {
        public char e0;
    }
}
