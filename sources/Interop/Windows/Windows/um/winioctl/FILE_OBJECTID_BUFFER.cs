// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_OBJECTID_BUFFER.xml' path='doc/member[@name="FILE_OBJECTID_BUFFER"]/*' />
public unsafe partial struct FILE_OBJECTID_BUFFER
{
    /// <include file='FILE_OBJECTID_BUFFER.xml' path='doc/member[@name="FILE_OBJECTID_BUFFER.ObjectId"]/*' />
    [NativeTypeName("BYTE [16]")]
    public fixed byte ObjectId[16];

    /// <include file='FILE_OBJECTID_BUFFER.xml' path='doc/member[@name="FILE_OBJECTID_BUFFER.Anonymous"]/*' />
    [NativeTypeName("_FILE_OBJECTID_BUFFER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:12368:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BirthVolumeId"]/*' />
    public Span<byte> BirthVolumeId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.BirthVolumeId[0], 16);
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BirthObjectId"]/*' />
    public Span<byte> BirthObjectId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.BirthObjectId[0], 16);
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DomainId"]/*' />
    public Span<byte> DomainId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.DomainId[0], 16);
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ExtendedInfo"]/*' />
    public Span<byte> ExtendedInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.ExtendedInfo[0], 48);
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("_FILE_OBJECTID_BUFFER::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winioctl.h:12369:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ExtendedInfo"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("BYTE [48]")]
        public fixed byte ExtendedInfo[48];

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public unsafe partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BirthVolumeId"]/*' />
            [NativeTypeName("BYTE [16]")]
            public fixed byte BirthVolumeId[16];

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BirthObjectId"]/*' />
            [NativeTypeName("BYTE [16]")]
            public fixed byte BirthObjectId[16];

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DomainId"]/*' />
            [NativeTypeName("BYTE [16]")]
            public fixed byte DomainId[16];
        }
    }
}
