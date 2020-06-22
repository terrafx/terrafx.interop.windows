// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("70AE66F2-C809-4E4F-8915-BDCB406B7993")]
    public unsafe partial struct IMFSourceReader
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSourceReader*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSourceReader*, uint>)(lpVtbl[1]))((IMFSourceReader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSourceReader*, uint>)(lpVtbl[2]))((IMFSourceReader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL *")] int* pfSelected)
        {
            return ((delegate* stdcall<IMFSourceReader*, uint, int*, int>)(lpVtbl[3]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, pfSelected);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL")] int fSelected)
        {
            return ((delegate* stdcall<IMFSourceReader*, uint, int, int>)(lpVtbl[4]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, fSelected);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNativeMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwMediaTypeIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* stdcall<IMFSourceReader*, uint, uint, IMFMediaType**, int>)(lpVtbl[5]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, dwMediaTypeIndex, ppMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* stdcall<IMFSourceReader*, uint, IMFMediaType**, int>)(lpVtbl[6]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, ppMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType)
        {
            return ((delegate* stdcall<IMFSourceReader*, uint, uint*, IMFMediaType*, int>)(lpVtbl[7]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, pdwReserved, pMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentPosition([NativeTypeName("const GUID &")] Guid* guidTimeFormat, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* varPosition)
        {
            return ((delegate* stdcall<IMFSourceReader*, Guid*, PROPVARIANT*, int>)(lpVtbl[8]))((IMFSourceReader*)Unsafe.AsPointer(ref this), guidTimeFormat, varPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadSample([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwControlFlags, [NativeTypeName("DWORD *")] uint* pdwActualStreamIndex, [NativeTypeName("DWORD *")] uint* pdwStreamFlags, [NativeTypeName("LONGLONG *")] long* pllTimestamp, [NativeTypeName("IMFSample **")] IMFSample** ppSample)
        {
            return ((delegate* stdcall<IMFSourceReader*, uint, uint, uint*, uint*, long*, IMFSample**, int>)(lpVtbl[9]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, dwControlFlags, pdwActualStreamIndex, pdwStreamFlags, pllTimestamp, ppSample);
        }

        [return: NativeTypeName("HRESULT")]
        public int Flush([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* stdcall<IMFSourceReader*, uint, int>)(lpVtbl[10]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetServiceForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSourceReader*, uint, Guid*, Guid*, void**, int>)(lpVtbl[11]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, guidService, riid, ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPresentationAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidAttribute, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarAttribute)
        {
            return ((delegate* stdcall<IMFSourceReader*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[12]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, guidAttribute, pvarAttribute);
        }
    }
}
