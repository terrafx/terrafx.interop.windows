// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("439A42A8-0D2C-4505-BE83-F79B2A05D5C4")]
    [NativeTypeName("struct IMFCaptureSource : IUnknown")]
    public unsafe partial struct IMFCaptureSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFCaptureSource*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFCaptureSource*, uint>)(lpVtbl[1]))((IMFCaptureSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFCaptureSource*, uint>)(lpVtbl[2]))((IMFCaptureSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCaptureDeviceSource(MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, [NativeTypeName("IMFMediaSource **")] IMFMediaSource** ppMediaSource)
        {
            return ((delegate* stdcall<IMFCaptureSource*, MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFMediaSource**, int>)(lpVtbl[3]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), mfCaptureEngineDeviceType, ppMediaSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCaptureDeviceActivate(MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, [NativeTypeName("IMFActivate **")] IMFActivate** ppActivate)
        {
            return ((delegate* stdcall<IMFCaptureSource*, MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFActivate**, int>)(lpVtbl[4]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), mfCaptureEngineDeviceType, ppActivate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("const IID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown **")] IUnknown** ppUnknown)
        {
            return ((delegate* stdcall<IMFCaptureSource*, Guid*, Guid*, IUnknown**, int>)(lpVtbl[5]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), rguidService, riid, ppUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddEffect([NativeTypeName("DWORD")] uint dwSourceStreamIndex, [NativeTypeName("IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IMFCaptureSource*, uint, IUnknown*, int>)(lpVtbl[6]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveEffect([NativeTypeName("DWORD")] uint dwSourceStreamIndex, [NativeTypeName("IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IMFCaptureSource*, uint, IUnknown*, int>)(lpVtbl[7]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllEffects([NativeTypeName("DWORD")] uint dwSourceStreamIndex)
        {
            return ((delegate* stdcall<IMFCaptureSource*, uint, int>)(lpVtbl[8]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAvailableDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, [NativeTypeName("DWORD")] uint dwMediaTypeIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* stdcall<IMFCaptureSource*, uint, uint, IMFMediaType**, int>)(lpVtbl[9]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, dwMediaTypeIndex, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType)
        {
            return ((delegate* stdcall<IMFCaptureSource*, uint, IMFMediaType*, int>)(lpVtbl[10]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* stdcall<IMFCaptureSource*, uint, IMFMediaType**, int>)(lpVtbl[11]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceStreamCount([NativeTypeName("DWORD *")] uint* pdwStreamCount)
        {
            return ((delegate* stdcall<IMFCaptureSource*, uint*, int>)(lpVtbl[12]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), pdwStreamCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceStreamCategory([NativeTypeName("DWORD")] uint dwSourceStreamIndex, [NativeTypeName("MF_CAPTURE_ENGINE_STREAM_CATEGORY *")] MF_CAPTURE_ENGINE_STREAM_CATEGORY* pStreamCategory)
        {
            return ((delegate* stdcall<IMFCaptureSource*, uint, MF_CAPTURE_ENGINE_STREAM_CATEGORY*, int>)(lpVtbl[13]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pStreamCategory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMirrorState([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL *")] int* pfMirrorState)
        {
            return ((delegate* stdcall<IMFCaptureSource*, uint, int*, int>)(lpVtbl[14]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwStreamIndex, pfMirrorState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMirrorState([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL")] int fMirrorState)
        {
            return ((delegate* stdcall<IMFCaptureSource*, uint, int, int>)(lpVtbl[15]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwStreamIndex, fMirrorState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamIndexFromFriendlyName([NativeTypeName("UINT32")] uint uifriendlyName, [NativeTypeName("DWORD *")] uint* pdwActualStreamIndex)
        {
            return ((delegate* stdcall<IMFCaptureSource*, uint, uint*, int>)(lpVtbl[16]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), uifriendlyName, pdwActualStreamIndex);
        }
    }
}
