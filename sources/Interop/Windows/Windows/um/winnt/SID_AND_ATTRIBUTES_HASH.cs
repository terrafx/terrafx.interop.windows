// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SID_AND_ATTRIBUTES_HASH.xml' path='doc/member[@name="SID_AND_ATTRIBUTES_HASH"]/*' />
public unsafe partial struct SID_AND_ATTRIBUTES_HASH
{
    /// <include file='SID_AND_ATTRIBUTES_HASH.xml' path='doc/member[@name="SID_AND_ATTRIBUTES_HASH.SidCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint SidCount;

    /// <include file='SID_AND_ATTRIBUTES_HASH.xml' path='doc/member[@name="SID_AND_ATTRIBUTES_HASH.SidAttr"]/*' />
    [NativeTypeName("PSID_AND_ATTRIBUTES")]
    public SID_AND_ATTRIBUTES* SidAttr;

    /// <include file='SID_AND_ATTRIBUTES_HASH.xml' path='doc/member[@name="SID_AND_ATTRIBUTES_HASH.Hash"]/*' />
    [NativeTypeName("SID_HASH_ENTRY[32]")]
    public _Hash_e__FixedBuffer Hash;

    /// <include file='_Hash_e__FixedBuffer.xml' path='doc/member[@name="_Hash_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _Hash_e__FixedBuffer
    {
        public nuint e0;
    }
}
