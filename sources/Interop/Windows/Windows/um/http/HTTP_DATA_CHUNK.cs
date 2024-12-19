// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_DATA_CHUNK.xml' path='doc/member[@name="HTTP_DATA_CHUNK"]/*' />
public partial struct HTTP_DATA_CHUNK
{
    /// <include file='HTTP_DATA_CHUNK.xml' path='doc/member[@name="HTTP_DATA_CHUNK.DataChunkType"]/*' />
    public HTTP_DATA_CHUNK_TYPE DataChunkType;

    /// <include file='HTTP_DATA_CHUNK.xml' path='doc/member[@name="HTTP_DATA_CHUNK.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_http_L1292_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FromMemory"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._FromMemory_e__Struct FromMemory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.FromMemory;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FromFileHandle"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._FromFileHandle_e__Struct FromFileHandle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.FromFileHandle;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FromFragmentCache"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._FromFragmentCache_e__Struct FromFragmentCache
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.FromFragmentCache;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FromFragmentCacheEx"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._FromFragmentCacheEx_e__Struct FromFragmentCacheEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.FromFragmentCacheEx;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Trailers"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._Trailers_e__Struct Trailers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Trailers;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FromWinHttpFastForwarding"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._FromWinHttpFastForwarding_e__Struct FromWinHttpFastForwarding
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.FromWinHttpFastForwarding;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FromMemory"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_http_L1298_C9")]
        public _FromMemory_e__Struct FromMemory;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FromFileHandle"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_http_L1309_C9")]
        public _FromFileHandle_e__Struct FromFileHandle;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FromFragmentCache"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_http_L1320_C9")]
        public _FromFragmentCache_e__Struct FromFragmentCache;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FromFragmentCacheEx"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_http_L1331_C9")]
        public _FromFragmentCacheEx_e__Struct FromFragmentCacheEx;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Trailers"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_http_L1342_C9")]
        public _Trailers_e__Struct Trailers;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.FromWinHttpFastForwarding"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_http_L1349_C9")]
        public _FromWinHttpFastForwarding_e__Struct FromWinHttpFastForwarding;

        /// <include file='_FromMemory_e__Struct.xml' path='doc/member[@name="_FromMemory_e__Struct"]/*' />
        public unsafe partial struct _FromMemory_e__Struct
        {
            /// <include file='_FromMemory_e__Struct.xml' path='doc/member[@name="_FromMemory_e__Struct.pBuffer"]/*' />
            [NativeTypeName("PVOID")]
            public void* pBuffer;

            /// <include file='_FromMemory_e__Struct.xml' path='doc/member[@name="_FromMemory_e__Struct.BufferLength"]/*' />
            [NativeTypeName("ULONG")]
            public uint BufferLength;
        }

        /// <include file='_FromFileHandle_e__Struct.xml' path='doc/member[@name="_FromFileHandle_e__Struct"]/*' />
        public partial struct _FromFileHandle_e__Struct
        {
            /// <include file='_FromFileHandle_e__Struct.xml' path='doc/member[@name="_FromFileHandle_e__Struct.ByteRange"]/*' />
            public HTTP_BYTE_RANGE ByteRange;

            /// <include file='_FromFileHandle_e__Struct.xml' path='doc/member[@name="_FromFileHandle_e__Struct.FileHandle"]/*' />
            public HANDLE FileHandle;
        }

        /// <include file='_FromFragmentCache_e__Struct.xml' path='doc/member[@name="_FromFragmentCache_e__Struct"]/*' />
        public unsafe partial struct _FromFragmentCache_e__Struct
        {
            /// <include file='_FromFragmentCache_e__Struct.xml' path='doc/member[@name="_FromFragmentCache_e__Struct.FragmentNameLength"]/*' />
            public ushort FragmentNameLength;

            /// <include file='_FromFragmentCache_e__Struct.xml' path='doc/member[@name="_FromFragmentCache_e__Struct.pFragmentName"]/*' />
            [NativeTypeName("PCWSTR")]
            public char* pFragmentName;
        }

        /// <include file='_FromFragmentCacheEx_e__Struct.xml' path='doc/member[@name="_FromFragmentCacheEx_e__Struct"]/*' />
        public unsafe partial struct _FromFragmentCacheEx_e__Struct
        {
            /// <include file='_FromFragmentCacheEx_e__Struct.xml' path='doc/member[@name="_FromFragmentCacheEx_e__Struct.ByteRange"]/*' />
            public HTTP_BYTE_RANGE ByteRange;

            /// <include file='_FromFragmentCacheEx_e__Struct.xml' path='doc/member[@name="_FromFragmentCacheEx_e__Struct.pFragmentName"]/*' />
            [NativeTypeName("PCWSTR")]
            public char* pFragmentName;
        }

        /// <include file='_Trailers_e__Struct.xml' path='doc/member[@name="_Trailers_e__Struct"]/*' />
        public unsafe partial struct _Trailers_e__Struct
        {
            /// <include file='_Trailers_e__Struct.xml' path='doc/member[@name="_Trailers_e__Struct.TrailerCount"]/*' />
            public ushort TrailerCount;

            /// <include file='_Trailers_e__Struct.xml' path='doc/member[@name="_Trailers_e__Struct.pTrailers"]/*' />
            [NativeTypeName("PHTTP_UNKNOWN_HEADER")]
            public HTTP_UNKNOWN_HEADER* pTrailers;
        }

        /// <include file='_FromWinHttpFastForwarding_e__Struct.xml' path='doc/member[@name="_FromWinHttpFastForwarding_e__Struct"]/*' />
        public partial struct _FromWinHttpFastForwarding_e__Struct
        {
            /// <include file='_FromWinHttpFastForwarding_e__Struct.xml' path='doc/member[@name="_FromWinHttpFastForwarding_e__Struct.WhFastForwardingData"]/*' />
            public HTTP_WINHTTP_FAST_FORWARDING_DATA WhFastForwardingData;
        }
    }
}
