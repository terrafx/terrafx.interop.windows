// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_OBJECTID_BUFFER.xml' path='doc/member[@name="FILE_OBJECTID_BUFFER"]/*' />
public partial struct FILE_OBJECTID_BUFFER
{
    /// <include file='FILE_OBJECTID_BUFFER.xml' path='doc/member[@name="FILE_OBJECTID_BUFFER.ObjectId"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _ObjectId_e__FixedBuffer ObjectId;

    /// <include file='FILE_OBJECTID_BUFFER.xml' path='doc/member[@name="FILE_OBJECTID_BUFFER.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winioctl_L12250_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BirthVolumeId"]/*' />
    [UnscopedRef]
    public Span<byte> BirthVolumeId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.BirthVolumeId;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BirthObjectId"]/*' />
    [UnscopedRef]
    public Span<byte> BirthObjectId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.BirthObjectId;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DomainId"]/*' />
    [UnscopedRef]
    public Span<byte> DomainId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.DomainId;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ExtendedInfo"]/*' />
    [UnscopedRef]
    public Span<byte> ExtendedInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.ExtendedInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L12251_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ExtendedInfo"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("BYTE[48]")]
        public _ExtendedInfo_e__FixedBuffer ExtendedInfo;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BirthVolumeId"]/*' />
            [NativeTypeName("BYTE[16]")]
            public _BirthVolumeId_e__FixedBuffer BirthVolumeId;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BirthObjectId"]/*' />
            [NativeTypeName("BYTE[16]")]
            public _BirthObjectId_e__FixedBuffer BirthObjectId;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DomainId"]/*' />
            [NativeTypeName("BYTE[16]")]
            public _DomainId_e__FixedBuffer DomainId;

            /// <include file='_BirthVolumeId_e__FixedBuffer.xml' path='doc/member[@name="_BirthVolumeId_e__FixedBuffer"]/*' />
            [InlineArray(16)]
            public partial struct _BirthVolumeId_e__FixedBuffer
            {
                public byte e0;
            }

            /// <include file='_BirthObjectId_e__FixedBuffer.xml' path='doc/member[@name="_BirthObjectId_e__FixedBuffer"]/*' />
            [InlineArray(16)]
            public partial struct _BirthObjectId_e__FixedBuffer
            {
                public byte e0;
            }

            /// <include file='_DomainId_e__FixedBuffer.xml' path='doc/member[@name="_DomainId_e__FixedBuffer"]/*' />
            [InlineArray(16)]
            public partial struct _DomainId_e__FixedBuffer
            {
                public byte e0;
            }
        }

        /// <include file='_ExtendedInfo_e__FixedBuffer.xml' path='doc/member[@name="_ExtendedInfo_e__FixedBuffer"]/*' />
        [InlineArray(48)]
        public partial struct _ExtendedInfo_e__FixedBuffer
        {
            public byte e0;
        }
    }

    /// <include file='_ObjectId_e__FixedBuffer.xml' path='doc/member[@name="_ObjectId_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _ObjectId_e__FixedBuffer
    {
        public byte e0;
    }
}
