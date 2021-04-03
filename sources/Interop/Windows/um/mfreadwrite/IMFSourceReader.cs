// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("70AE66F2-C809-4E4F-8915-BDCB406B7993")]
    [NativeTypeName("struct IMFSourceReader : IUnknown")]
    public unsafe partial struct IMFSourceReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceReader*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSourceReader*, uint>)(lpVtbl[1]))((IMFSourceReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSourceReader*, uint>)(lpVtbl[2]))((IMFSourceReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL *")] int* pfSelected)
        {
            return ((delegate* unmanaged<IMFSourceReader*, uint, int*, int>)(lpVtbl[3]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, pfSelected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL")] int fSelected)
        {
            return ((delegate* unmanaged<IMFSourceReader*, uint, int, int>)(lpVtbl[4]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, fSelected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNativeMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwMediaTypeIndex, IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged<IMFSourceReader*, uint, uint, IMFMediaType**, int>)(lpVtbl[5]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, dwMediaTypeIndex, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged<IMFSourceReader*, uint, IMFMediaType**, int>)(lpVtbl[6]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, IMFMediaType* pMediaType)
        {
            return ((delegate* unmanaged<IMFSourceReader*, uint, uint*, IMFMediaType*, int>)(lpVtbl[7]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, pdwReserved, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentPosition([NativeTypeName("const GUID &")] Guid* guidTimeFormat, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* varPosition)
        {
            return ((delegate* unmanaged<IMFSourceReader*, Guid*, PROPVARIANT*, int>)(lpVtbl[8]))((IMFSourceReader*)Unsafe.AsPointer(ref this), guidTimeFormat, varPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadSample([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwControlFlags, [NativeTypeName("DWORD *")] uint* pdwActualStreamIndex, [NativeTypeName("DWORD *")] uint* pdwStreamFlags, [NativeTypeName("LONGLONG *")] long* pllTimestamp, IMFSample** ppSample)
        {
            return ((delegate* unmanaged<IMFSourceReader*, uint, uint, uint*, uint*, long*, IMFSample**, int>)(lpVtbl[9]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, dwControlFlags, pdwActualStreamIndex, pdwStreamFlags, pllTimestamp, ppSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Flush([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* unmanaged<IMFSourceReader*, uint, int>)(lpVtbl[10]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetServiceForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceReader*, uint, Guid*, Guid*, void**, int>)(lpVtbl[11]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, guidService, riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPresentationAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidAttribute, PROPVARIANT* pvarAttribute)
        {
            return ((delegate* unmanaged<IMFSourceReader*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[12]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, guidAttribute, pvarAttribute);
        }
    }
}
