// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36B73880-C2C8-11CF-8B46-00805F6CEF60")]
    [NativeTypeName("struct IMediaSeeking : IUnknown")]
    public unsafe partial struct IMediaSeeking
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMediaSeeking*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSeeking*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMediaSeeking*, uint>)(lpVtbl[1]))((IMediaSeeking*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMediaSeeking*, uint>)(lpVtbl[2]))((IMediaSeeking*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCapabilities([NativeTypeName("DWORD *")] uint* pCapabilities)
        {
            return ((delegate* stdcall<IMediaSeeking*, uint*, int>)(lpVtbl[3]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pCapabilities);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckCapabilities([NativeTypeName("DWORD *")] uint* pCapabilities)
        {
            return ((delegate* stdcall<IMediaSeeking*, uint*, int>)(lpVtbl[4]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pCapabilities);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsFormatSupported([NativeTypeName("const GUID *")] Guid* pFormat)
        {
            return ((delegate* stdcall<IMediaSeeking*, Guid*, int>)(lpVtbl[5]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryPreferredFormat([NativeTypeName("GUID *")] Guid* pFormat)
        {
            return ((delegate* stdcall<IMediaSeeking*, Guid*, int>)(lpVtbl[6]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTimeFormat([NativeTypeName("GUID *")] Guid* pFormat)
        {
            return ((delegate* stdcall<IMediaSeeking*, Guid*, int>)(lpVtbl[7]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsUsingTimeFormat([NativeTypeName("const GUID *")] Guid* pFormat)
        {
            return ((delegate* stdcall<IMediaSeeking*, Guid*, int>)(lpVtbl[8]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTimeFormat([NativeTypeName("const GUID *")] Guid* pFormat)
        {
            return ((delegate* stdcall<IMediaSeeking*, Guid*, int>)(lpVtbl[9]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDuration([NativeTypeName("LONGLONG *")] long* pDuration)
        {
            return ((delegate* stdcall<IMediaSeeking*, long*, int>)(lpVtbl[10]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pDuration);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStopPosition([NativeTypeName("LONGLONG *")] long* pStop)
        {
            return ((delegate* stdcall<IMediaSeeking*, long*, int>)(lpVtbl[11]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pStop);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentPosition([NativeTypeName("LONGLONG *")] long* pCurrent)
        {
            return ((delegate* stdcall<IMediaSeeking*, long*, int>)(lpVtbl[12]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pCurrent);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConvertTimeFormat([NativeTypeName("LONGLONG *")] long* pTarget, [NativeTypeName("const GUID *")] Guid* pTargetFormat, [NativeTypeName("LONGLONG")] long Source, [NativeTypeName("const GUID *")] Guid* pSourceFormat)
        {
            return ((delegate* stdcall<IMediaSeeking*, long*, Guid*, long, Guid*, int>)(lpVtbl[13]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pTarget, pTargetFormat, Source, pSourceFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPositions([NativeTypeName("LONGLONG *")] long* pCurrent, [NativeTypeName("DWORD")] uint dwCurrentFlags, [NativeTypeName("LONGLONG *")] long* pStop, [NativeTypeName("DWORD")] uint dwStopFlags)
        {
            return ((delegate* stdcall<IMediaSeeking*, long*, uint, long*, uint, int>)(lpVtbl[14]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pCurrent, dwCurrentFlags, pStop, dwStopFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPositions([NativeTypeName("LONGLONG *")] long* pCurrent, [NativeTypeName("LONGLONG *")] long* pStop)
        {
            return ((delegate* stdcall<IMediaSeeking*, long*, long*, int>)(lpVtbl[15]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pCurrent, pStop);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAvailable([NativeTypeName("LONGLONG *")] long* pEarliest, [NativeTypeName("LONGLONG *")] long* pLatest)
        {
            return ((delegate* stdcall<IMediaSeeking*, long*, long*, int>)(lpVtbl[16]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pEarliest, pLatest);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRate(double dRate)
        {
            return ((delegate* stdcall<IMediaSeeking*, double, int>)(lpVtbl[17]))((IMediaSeeking*)Unsafe.AsPointer(ref this), dRate);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRate([NativeTypeName("double *")] double* pdRate)
        {
            return ((delegate* stdcall<IMediaSeeking*, double*, int>)(lpVtbl[18]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pdRate);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPreroll([NativeTypeName("LONGLONG *")] long* pllPreroll)
        {
            return ((delegate* stdcall<IMediaSeeking*, long*, int>)(lpVtbl[19]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pllPreroll);
        }
    }
}
