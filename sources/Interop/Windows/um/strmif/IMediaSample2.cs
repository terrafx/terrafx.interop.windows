// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36B73884-C2C8-11CF-8B46-00805F6CEF60")]
    [NativeTypeName("struct IMediaSample2 : IMediaSample")]
    [NativeInheritance("IMediaSample")]
    public unsafe partial struct IMediaSample2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMediaSample2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSample2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMediaSample2*, uint>)(lpVtbl[1]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMediaSample2*, uint>)(lpVtbl[2]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPointer(byte** ppBuffer)
        {
            return ((delegate* unmanaged<IMediaSample2*, byte**, int>)(lpVtbl[3]))((IMediaSample2*)Unsafe.AsPointer(ref this), ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("long")]
        public int GetSize()
        {
            return ((delegate* unmanaged<IMediaSample2*, int>)(lpVtbl[4]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd)
        {
            return ((delegate* unmanaged<IMediaSample2*, long*, long*, int>)(lpVtbl[5]))((IMediaSample2*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd)
        {
            return ((delegate* unmanaged<IMediaSample2*, long*, long*, int>)(lpVtbl[6]))((IMediaSample2*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT IsSyncPoint()
        {
            return ((delegate* unmanaged<IMediaSample2*, int>)(lpVtbl[7]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetSyncPoint(BOOL bIsSyncPoint)
        {
            return ((delegate* unmanaged<IMediaSample2*, BOOL, int>)(lpVtbl[8]))((IMediaSample2*)Unsafe.AsPointer(ref this), bIsSyncPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT IsPreroll()
        {
            return ((delegate* unmanaged<IMediaSample2*, int>)(lpVtbl[9]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetPreroll(BOOL bIsPreroll)
        {
            return ((delegate* unmanaged<IMediaSample2*, BOOL, int>)(lpVtbl[10]))((IMediaSample2*)Unsafe.AsPointer(ref this), bIsPreroll);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("long")]
        public int GetActualDataLength()
        {
            return ((delegate* unmanaged<IMediaSample2*, int>)(lpVtbl[11]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetActualDataLength([NativeTypeName("long")] int __MIDL__IMediaSample0000)
        {
            return ((delegate* unmanaged<IMediaSample2*, int, int>)(lpVtbl[12]))((IMediaSample2*)Unsafe.AsPointer(ref this), __MIDL__IMediaSample0000);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetMediaType(AM_MEDIA_TYPE** ppMediaType)
        {
            return ((delegate* unmanaged<IMediaSample2*, AM_MEDIA_TYPE**, int>)(lpVtbl[13]))((IMediaSample2*)Unsafe.AsPointer(ref this), ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetMediaType(AM_MEDIA_TYPE* pMediaType)
        {
            return ((delegate* unmanaged<IMediaSample2*, AM_MEDIA_TYPE*, int>)(lpVtbl[14]))((IMediaSample2*)Unsafe.AsPointer(ref this), pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT IsDiscontinuity()
        {
            return ((delegate* unmanaged<IMediaSample2*, int>)(lpVtbl[15]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetDiscontinuity(BOOL bDiscontinuity)
        {
            return ((delegate* unmanaged<IMediaSample2*, BOOL, int>)(lpVtbl[16]))((IMediaSample2*)Unsafe.AsPointer(ref this), bDiscontinuity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd)
        {
            return ((delegate* unmanaged<IMediaSample2*, long*, long*, int>)(lpVtbl[17]))((IMediaSample2*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd)
        {
            return ((delegate* unmanaged<IMediaSample2*, long*, long*, int>)(lpVtbl[18]))((IMediaSample2*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetProperties([NativeTypeName("DWORD")] uint cbProperties, byte* pbProperties)
        {
            return ((delegate* unmanaged<IMediaSample2*, uint, byte*, int>)(lpVtbl[19]))((IMediaSample2*)Unsafe.AsPointer(ref this), cbProperties, pbProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetProperties([NativeTypeName("DWORD")] uint cbProperties, [NativeTypeName("const BYTE *")] byte* pbProperties)
        {
            return ((delegate* unmanaged<IMediaSample2*, uint, byte*, int>)(lpVtbl[20]))((IMediaSample2*)Unsafe.AsPointer(ref this), cbProperties, pbProperties);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, uint> Release;

            [NativeTypeName("HRESULT (BYTE **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, byte**, int> GetPointer;

            [NativeTypeName("long () __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, int> GetSize;

            [NativeTypeName("HRESULT (REFERENCE_TIME *, REFERENCE_TIME *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, long*, long*, int> GetTime;

            [NativeTypeName("HRESULT (REFERENCE_TIME *, REFERENCE_TIME *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, long*, long*, int> SetTime;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, int> IsSyncPoint;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, BOOL, int> SetSyncPoint;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, int> IsPreroll;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, BOOL, int> SetPreroll;

            [NativeTypeName("long () __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, int> GetActualDataLength;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, int, int> SetActualDataLength;

            [NativeTypeName("HRESULT (AM_MEDIA_TYPE **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, AM_MEDIA_TYPE**, int> GetMediaType;

            [NativeTypeName("HRESULT (AM_MEDIA_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, AM_MEDIA_TYPE*, int> SetMediaType;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, int> IsDiscontinuity;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, BOOL, int> SetDiscontinuity;

            [NativeTypeName("HRESULT (LONGLONG *, LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, long*, long*, int> GetMediaTime;

            [NativeTypeName("HRESULT (LONGLONG *, LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, long*, long*, int> SetMediaTime;

            [NativeTypeName("HRESULT (DWORD, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, uint, byte*, int> GetProperties;

            [NativeTypeName("HRESULT (DWORD, const BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSample2*, uint, byte*, int> SetProperties;
        }
    }
}
