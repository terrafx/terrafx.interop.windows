// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PUBLIC_OBJECT_BASIC_INFORMATION.xml' path='doc/member[@name="PUBLIC_OBJECT_BASIC_INFORMATION"]/*' />
public partial struct PUBLIC_OBJECT_BASIC_INFORMATION
{
    /// <include file='PUBLIC_OBJECT_BASIC_INFORMATION.xml' path='doc/member[@name="PUBLIC_OBJECT_BASIC_INFORMATION.Attributes"]/*' />
    [NativeTypeName("ULONG")]
    public uint Attributes;

    /// <include file='PUBLIC_OBJECT_BASIC_INFORMATION.xml' path='doc/member[@name="PUBLIC_OBJECT_BASIC_INFORMATION.GrantedAccess"]/*' />
    [NativeTypeName("ACCESS_MASK")]
    public uint GrantedAccess;

    /// <include file='PUBLIC_OBJECT_BASIC_INFORMATION.xml' path='doc/member[@name="PUBLIC_OBJECT_BASIC_INFORMATION.HandleCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint HandleCount;

    /// <include file='PUBLIC_OBJECT_BASIC_INFORMATION.xml' path='doc/member[@name="PUBLIC_OBJECT_BASIC_INFORMATION.PointerCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint PointerCount;

    /// <include file='PUBLIC_OBJECT_BASIC_INFORMATION.xml' path='doc/member[@name="PUBLIC_OBJECT_BASIC_INFORMATION.Reserved"]/*' />
    [NativeTypeName("ULONG[10]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(10)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }
}
