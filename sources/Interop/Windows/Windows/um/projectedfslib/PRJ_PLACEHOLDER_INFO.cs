// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO"]/*' />
[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct PRJ_PLACEHOLDER_INFO
{
    /// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO.FileBasicInfo"]/*' />
    public PRJ_FILE_BASIC_INFO FileBasicInfo;

    /// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO.EaInformation"]/*' />
    [NativeTypeName("__AnonymousRecord_projectedfslib_L212_C5")]
    public _EaInformation_e__Struct EaInformation;

    /// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO.SecurityInformation"]/*' />
    [NativeTypeName("__AnonymousRecord_projectedfslib_L218_C5")]
    public _SecurityInformation_e__Struct SecurityInformation;

    /// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO.StreamsInformation"]/*' />
    [NativeTypeName("__AnonymousRecord_projectedfslib_L224_C5")]
    public _StreamsInformation_e__Struct StreamsInformation;

    /// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO.VersionInfo"]/*' />
    public PRJ_PLACEHOLDER_VERSION_INFO VersionInfo;

    /// <include file='PRJ_PLACEHOLDER_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_INFO.VariableData"]/*' />
    [NativeTypeName("UINT8[1]")]
    public _VariableData_e__FixedBuffer VariableData;

    /// <include file='_EaInformation_e__Struct.xml' path='doc/member[@name="_EaInformation_e__Struct"]/*' />
    public partial struct _EaInformation_e__Struct
    {
        /// <include file='_EaInformation_e__Struct.xml' path='doc/member[@name="_EaInformation_e__Struct.EaBufferSize"]/*' />
        [NativeTypeName("UINT32")]
        public uint EaBufferSize;

        /// <include file='_EaInformation_e__Struct.xml' path='doc/member[@name="_EaInformation_e__Struct.OffsetToFirstEa"]/*' />
        [NativeTypeName("UINT32")]
        public uint OffsetToFirstEa;
    }

    /// <include file='_SecurityInformation_e__Struct.xml' path='doc/member[@name="_SecurityInformation_e__Struct"]/*' />
    public partial struct _SecurityInformation_e__Struct
    {
        /// <include file='_SecurityInformation_e__Struct.xml' path='doc/member[@name="_SecurityInformation_e__Struct.SecurityBufferSize"]/*' />
        [NativeTypeName("UINT32")]
        public uint SecurityBufferSize;

        /// <include file='_SecurityInformation_e__Struct.xml' path='doc/member[@name="_SecurityInformation_e__Struct.OffsetToSecurityDescriptor"]/*' />
        [NativeTypeName("UINT32")]
        public uint OffsetToSecurityDescriptor;
    }

    /// <include file='_StreamsInformation_e__Struct.xml' path='doc/member[@name="_StreamsInformation_e__Struct"]/*' />
    public partial struct _StreamsInformation_e__Struct
    {
        /// <include file='_StreamsInformation_e__Struct.xml' path='doc/member[@name="_StreamsInformation_e__Struct.StreamsInfoBufferSize"]/*' />
        [NativeTypeName("UINT32")]
        public uint StreamsInfoBufferSize;

        /// <include file='_StreamsInformation_e__Struct.xml' path='doc/member[@name="_StreamsInformation_e__Struct.OffsetToFirstStreamInfo"]/*' />
        [NativeTypeName("UINT32")]
        public uint OffsetToFirstStreamInfo;
    }

    /// <include file='_VariableData_e__FixedBuffer.xml' path='doc/member[@name="_VariableData_e__FixedBuffer"]/*' />
    public partial struct _VariableData_e__FixedBuffer
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
