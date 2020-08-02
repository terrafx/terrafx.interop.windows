// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A8689A-0AD4-11CE-B03A-0020AF0BA770")]
    public unsafe partial struct IMediaSample
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMediaSample*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSample*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMediaSample*, uint>)(lpVtbl[1]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMediaSample*, uint>)(lpVtbl[2]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPointer([NativeTypeName("BYTE **")] byte** ppBuffer)
        {
            return ((delegate* stdcall<IMediaSample*, byte**, int>)(lpVtbl[3]))((IMediaSample*)Unsafe.AsPointer(ref this), ppBuffer);
        }

        [return: NativeTypeName("long")]
        public int GetSize()
        {
            return ((delegate* stdcall<IMediaSample*, int>)(lpVtbl[4]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd)
        {
            return ((delegate* stdcall<IMediaSample*, long*, long*, int>)(lpVtbl[5]))((IMediaSample*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd)
        {
            return ((delegate* stdcall<IMediaSample*, long*, long*, int>)(lpVtbl[6]))((IMediaSample*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsSyncPoint()
        {
            return ((delegate* stdcall<IMediaSample*, int>)(lpVtbl[7]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSyncPoint([NativeTypeName("BOOL")] int bIsSyncPoint)
        {
            return ((delegate* stdcall<IMediaSample*, int, int>)(lpVtbl[8]))((IMediaSample*)Unsafe.AsPointer(ref this), bIsSyncPoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsPreroll()
        {
            return ((delegate* stdcall<IMediaSample*, int>)(lpVtbl[9]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPreroll([NativeTypeName("BOOL")] int bIsPreroll)
        {
            return ((delegate* stdcall<IMediaSample*, int, int>)(lpVtbl[10]))((IMediaSample*)Unsafe.AsPointer(ref this), bIsPreroll);
        }

        [return: NativeTypeName("long")]
        public int GetActualDataLength()
        {
            return ((delegate* stdcall<IMediaSample*, int>)(lpVtbl[11]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetActualDataLength([NativeTypeName("long")] int __MIDL__IMediaSample0000)
        {
            return ((delegate* stdcall<IMediaSample*, int, int>)(lpVtbl[12]))((IMediaSample*)Unsafe.AsPointer(ref this), __MIDL__IMediaSample0000);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMediaType([NativeTypeName("AM_MEDIA_TYPE **")] AM_MEDIA_TYPE** ppMediaType)
        {
            return ((delegate* stdcall<IMediaSample*, AM_MEDIA_TYPE**, int>)(lpVtbl[13]))((IMediaSample*)Unsafe.AsPointer(ref this), ppMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMediaType([NativeTypeName("AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pMediaType)
        {
            return ((delegate* stdcall<IMediaSample*, AM_MEDIA_TYPE*, int>)(lpVtbl[14]))((IMediaSample*)Unsafe.AsPointer(ref this), pMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDiscontinuity()
        {
            return ((delegate* stdcall<IMediaSample*, int>)(lpVtbl[15]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDiscontinuity([NativeTypeName("BOOL")] int bDiscontinuity)
        {
            return ((delegate* stdcall<IMediaSample*, int, int>)(lpVtbl[16]))((IMediaSample*)Unsafe.AsPointer(ref this), bDiscontinuity);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd)
        {
            return ((delegate* stdcall<IMediaSample*, long*, long*, int>)(lpVtbl[17]))((IMediaSample*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd)
        {
            return ((delegate* stdcall<IMediaSample*, long*, long*, int>)(lpVtbl[18]))((IMediaSample*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }
    }
}
