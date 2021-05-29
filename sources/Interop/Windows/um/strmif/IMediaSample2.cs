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
    public unsafe partial struct IMediaSample2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMediaSample2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSample2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMediaSample2*, uint>)(lpVtbl[1]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMediaSample2*, uint>)(lpVtbl[2]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPointer([NativeTypeName("BYTE **")] byte** ppBuffer)
        {
            return ((delegate* unmanaged<IMediaSample2*, byte**, int>)(lpVtbl[3]))((IMediaSample2*)Unsafe.AsPointer(ref this), ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("long")]
        public int GetSize()
        {
            return ((delegate* unmanaged<IMediaSample2*, int>)(lpVtbl[4]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd)
        {
            return ((delegate* unmanaged<IMediaSample2*, long*, long*, int>)(lpVtbl[5]))((IMediaSample2*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd)
        {
            return ((delegate* unmanaged<IMediaSample2*, long*, long*, int>)(lpVtbl[6]))((IMediaSample2*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsSyncPoint()
        {
            return ((delegate* unmanaged<IMediaSample2*, int>)(lpVtbl[7]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSyncPoint([NativeTypeName("BOOL")] int bIsSyncPoint)
        {
            return ((delegate* unmanaged<IMediaSample2*, int, int>)(lpVtbl[8]))((IMediaSample2*)Unsafe.AsPointer(ref this), bIsSyncPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsPreroll()
        {
            return ((delegate* unmanaged<IMediaSample2*, int>)(lpVtbl[9]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPreroll([NativeTypeName("BOOL")] int bIsPreroll)
        {
            return ((delegate* unmanaged<IMediaSample2*, int, int>)(lpVtbl[10]))((IMediaSample2*)Unsafe.AsPointer(ref this), bIsPreroll);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("long")]
        public int GetActualDataLength()
        {
            return ((delegate* unmanaged<IMediaSample2*, int>)(lpVtbl[11]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetActualDataLength([NativeTypeName("long")] int __MIDL__IMediaSample0000)
        {
            return ((delegate* unmanaged<IMediaSample2*, int, int>)(lpVtbl[12]))((IMediaSample2*)Unsafe.AsPointer(ref this), __MIDL__IMediaSample0000);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMediaType(AM_MEDIA_TYPE** ppMediaType)
        {
            return ((delegate* unmanaged<IMediaSample2*, AM_MEDIA_TYPE**, int>)(lpVtbl[13]))((IMediaSample2*)Unsafe.AsPointer(ref this), ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMediaType(AM_MEDIA_TYPE* pMediaType)
        {
            return ((delegate* unmanaged<IMediaSample2*, AM_MEDIA_TYPE*, int>)(lpVtbl[14]))((IMediaSample2*)Unsafe.AsPointer(ref this), pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDiscontinuity()
        {
            return ((delegate* unmanaged<IMediaSample2*, int>)(lpVtbl[15]))((IMediaSample2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDiscontinuity([NativeTypeName("BOOL")] int bDiscontinuity)
        {
            return ((delegate* unmanaged<IMediaSample2*, int, int>)(lpVtbl[16]))((IMediaSample2*)Unsafe.AsPointer(ref this), bDiscontinuity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd)
        {
            return ((delegate* unmanaged<IMediaSample2*, long*, long*, int>)(lpVtbl[17]))((IMediaSample2*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd)
        {
            return ((delegate* unmanaged<IMediaSample2*, long*, long*, int>)(lpVtbl[18]))((IMediaSample2*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperties([NativeTypeName("DWORD")] uint cbProperties, [NativeTypeName("BYTE *")] byte* pbProperties)
        {
            return ((delegate* unmanaged<IMediaSample2*, uint, byte*, int>)(lpVtbl[19]))((IMediaSample2*)Unsafe.AsPointer(ref this), cbProperties, pbProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetProperties([NativeTypeName("DWORD")] uint cbProperties, [NativeTypeName("const BYTE *")] byte* pbProperties)
        {
            return ((delegate* unmanaged<IMediaSample2*, uint, byte*, int>)(lpVtbl[20]))((IMediaSample2*)Unsafe.AsPointer(ref this), cbProperties, pbProperties);
        }
    }
}
