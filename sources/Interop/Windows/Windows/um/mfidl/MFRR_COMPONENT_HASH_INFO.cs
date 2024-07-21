// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MFRR_COMPONENT_HASH_INFO.xml' path='doc/member[@name="MFRR_COMPONENT_HASH_INFO"]/*' />
public partial struct MFRR_COMPONENT_HASH_INFO
{
    /// <include file='MFRR_COMPONENT_HASH_INFO.xml' path='doc/member[@name="MFRR_COMPONENT_HASH_INFO.ulReason"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulReason;

    /// <include file='MFRR_COMPONENT_HASH_INFO.xml' path='doc/member[@name="MFRR_COMPONENT_HASH_INFO.rgHeaderHash"]/*' />
    [NativeTypeName("WCHAR[43]")]
    public _rgHeaderHash_e__FixedBuffer rgHeaderHash;

    /// <include file='MFRR_COMPONENT_HASH_INFO.xml' path='doc/member[@name="MFRR_COMPONENT_HASH_INFO.rgPublicKeyHash"]/*' />
    [NativeTypeName("WCHAR[43]")]
    public _rgPublicKeyHash_e__FixedBuffer rgPublicKeyHash;

    /// <include file='MFRR_COMPONENT_HASH_INFO.xml' path='doc/member[@name="MFRR_COMPONENT_HASH_INFO.wszName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _wszName_e__FixedBuffer wszName;

    /// <include file='_rgHeaderHash_e__FixedBuffer.xml' path='doc/member[@name="_rgHeaderHash_e__FixedBuffer"]/*' />
    [InlineArray(43)]
    public partial struct _rgHeaderHash_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_rgPublicKeyHash_e__FixedBuffer.xml' path='doc/member[@name="_rgPublicKeyHash_e__FixedBuffer"]/*' />
    [InlineArray(43)]
    public partial struct _rgPublicKeyHash_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_wszName_e__FixedBuffer.xml' path='doc/member[@name="_wszName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _wszName_e__FixedBuffer
    {
        public char e0;
    }
}
