// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7B981CF0-560E-4116-9875-B099895F23D7")]
    [NativeTypeName("struct IMFSourceReaderEx : IMFSourceReader")]
    public unsafe partial struct IMFSourceReaderEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint>)(lpVtbl[1]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint>)(lpVtbl[2]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL *")] int* pfSelected)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint, int*, int>)(lpVtbl[3]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pfSelected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL")] int fSelected)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint, int, int>)(lpVtbl[4]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, fSelected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNativeMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwMediaTypeIndex, IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint, uint, IMFMediaType**, int>)(lpVtbl[5]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, dwMediaTypeIndex, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint, IMFMediaType**, int>)(lpVtbl[6]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, IMFMediaType* pMediaType)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint, uint*, IMFMediaType*, int>)(lpVtbl[7]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pdwReserved, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentPosition([NativeTypeName("const GUID &")] Guid* guidTimeFormat, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* varPosition)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, Guid*, PROPVARIANT*, int>)(lpVtbl[8]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), guidTimeFormat, varPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadSample([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwControlFlags, [NativeTypeName("DWORD *")] uint* pdwActualStreamIndex, [NativeTypeName("DWORD *")] uint* pdwStreamFlags, [NativeTypeName("LONGLONG *")] long* pllTimestamp, IMFSample** ppSample)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint, uint, uint*, uint*, long*, IMFSample**, int>)(lpVtbl[9]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, dwControlFlags, pdwActualStreamIndex, pdwStreamFlags, pllTimestamp, ppSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Flush([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint, int>)(lpVtbl[10]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetServiceForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint, Guid*, Guid*, void**, int>)(lpVtbl[11]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, guidService, riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPresentationAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidAttribute, PROPVARIANT* pvarAttribute)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[12]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, guidAttribute, pvarAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNativeMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType* pMediaType, [NativeTypeName("DWORD *")] uint* pdwStreamFlags)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint, IMFMediaType*, uint*, int>)(lpVtbl[13]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pMediaType, pdwStreamFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddTransformForStream([NativeTypeName("DWORD")] uint dwStreamIndex, IUnknown* pTransformOrActivate)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint, IUnknown*, int>)(lpVtbl[14]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pTransformOrActivate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllTransformsForStream([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint, int>)(lpVtbl[15]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTransformForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwTransformIndex, [NativeTypeName("GUID *")] Guid* pGuidCategory, IMFTransform** ppTransform)
        {
            return ((delegate* unmanaged<IMFSourceReaderEx*, uint, uint, Guid*, IMFTransform**, int>)(lpVtbl[16]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, dwTransformIndex, pGuidCategory, ppTransform);
        }
    }
}
