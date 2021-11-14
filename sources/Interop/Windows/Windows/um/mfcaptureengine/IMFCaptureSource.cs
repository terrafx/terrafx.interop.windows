// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("439A42A8-0D2C-4505-BE83-F79B2A05D5C4")]
    [NativeTypeName("struct IMFCaptureSource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFCaptureSource : IMFCaptureSource.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFCaptureSource*, uint>)(lpVtbl[1]))((IMFCaptureSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFCaptureSource*, uint>)(lpVtbl[2]))((IMFCaptureSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCaptureDeviceSource(MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, IMFMediaSource** ppMediaSource)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFMediaSource**, int>)(lpVtbl[3]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), mfCaptureEngineDeviceType, ppMediaSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCaptureDeviceActivate(MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, IMFActivate** ppActivate)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFActivate**, int>)(lpVtbl[4]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), mfCaptureEngineDeviceType, ppActivate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetService([NativeTypeName("const IID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppUnknown)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, Guid*, Guid*, IUnknown**, int>)(lpVtbl[5]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), rguidService, riid, ppUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT AddEffect([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, uint, IUnknown*, int>)(lpVtbl[6]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT RemoveEffect([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, uint, IUnknown*, int>)(lpVtbl[7]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RemoveAllEffects([NativeTypeName("DWORD")] uint dwSourceStreamIndex)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, uint, int>)(lpVtbl[8]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetAvailableDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, [NativeTypeName("DWORD")] uint dwMediaTypeIndex, IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, uint, uint, IMFMediaType**, int>)(lpVtbl[9]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, dwMediaTypeIndex, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetCurrentDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType* pMediaType)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, uint, IMFMediaType*, int>)(lpVtbl[10]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetCurrentDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, uint, IMFMediaType**, int>)(lpVtbl[11]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetDeviceStreamCount([NativeTypeName("DWORD *")] uint* pdwStreamCount)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, uint*, int>)(lpVtbl[12]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), pdwStreamCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetDeviceStreamCategory([NativeTypeName("DWORD")] uint dwSourceStreamIndex, MF_CAPTURE_ENGINE_STREAM_CATEGORY* pStreamCategory)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, uint, MF_CAPTURE_ENGINE_STREAM_CATEGORY*, int>)(lpVtbl[13]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pStreamCategory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetMirrorState([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pfMirrorState)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, uint, BOOL*, int>)(lpVtbl[14]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwStreamIndex, pfMirrorState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetMirrorState([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fMirrorState)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, uint, BOOL, int>)(lpVtbl[15]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), dwStreamIndex, fMirrorState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetStreamIndexFromFriendlyName([NativeTypeName("UINT32")] uint uifriendlyName, [NativeTypeName("DWORD *")] uint* pdwActualStreamIndex)
        {
            return ((delegate* unmanaged<IMFCaptureSource*, uint, uint*, int>)(lpVtbl[16]))((IMFCaptureSource*)Unsafe.AsPointer(ref this), uifriendlyName, pdwActualStreamIndex);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetCaptureDeviceSource(MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, IMFMediaSource** ppMediaSource);

            [VtblIndex(4)]
            HRESULT GetCaptureDeviceActivate(MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, IMFActivate** ppActivate);

            [VtblIndex(5)]
            HRESULT GetService([NativeTypeName("const IID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppUnknown);

            [VtblIndex(6)]
            HRESULT AddEffect([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IUnknown* pUnknown);

            [VtblIndex(7)]
            HRESULT RemoveEffect([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IUnknown* pUnknown);

            [VtblIndex(8)]
            HRESULT RemoveAllEffects([NativeTypeName("DWORD")] uint dwSourceStreamIndex);

            [VtblIndex(9)]
            HRESULT GetAvailableDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, [NativeTypeName("DWORD")] uint dwMediaTypeIndex, IMFMediaType** ppMediaType);

            [VtblIndex(10)]
            HRESULT SetCurrentDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType* pMediaType);

            [VtblIndex(11)]
            HRESULT GetCurrentDeviceMediaType([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType** ppMediaType);

            [VtblIndex(12)]
            HRESULT GetDeviceStreamCount([NativeTypeName("DWORD *")] uint* pdwStreamCount);

            [VtblIndex(13)]
            HRESULT GetDeviceStreamCategory([NativeTypeName("DWORD")] uint dwSourceStreamIndex, MF_CAPTURE_ENGINE_STREAM_CATEGORY* pStreamCategory);

            [VtblIndex(14)]
            HRESULT GetMirrorState([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pfMirrorState);

            [VtblIndex(15)]
            HRESULT SetMirrorState([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fMirrorState);

            [VtblIndex(16)]
            HRESULT GetStreamIndexFromFriendlyName([NativeTypeName("UINT32")] uint uifriendlyName, [NativeTypeName("DWORD *")] uint* pdwActualStreamIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, uint> Release;

            [NativeTypeName("HRESULT (MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFMediaSource **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFMediaSource**, int> GetCaptureDeviceSource;

            [NativeTypeName("HRESULT (MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFActivate **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, MF_CAPTURE_ENGINE_DEVICE_TYPE, IMFActivate**, int> GetCaptureDeviceActivate;

            [NativeTypeName("HRESULT (const IID &, const IID &, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, Guid*, Guid*, IUnknown**, int> GetService;

            [NativeTypeName("HRESULT (DWORD, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, uint, IUnknown*, int> AddEffect;

            [NativeTypeName("HRESULT (DWORD, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, uint, IUnknown*, int> RemoveEffect;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, uint, int> RemoveAllEffects;

            [NativeTypeName("HRESULT (DWORD, DWORD, IMFMediaType **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, uint, uint, IMFMediaType**, int> GetAvailableDeviceMediaType;

            [NativeTypeName("HRESULT (DWORD, IMFMediaType *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, uint, IMFMediaType*, int> SetCurrentDeviceMediaType;

            [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, uint, IMFMediaType**, int> GetCurrentDeviceMediaType;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, uint*, int> GetDeviceStreamCount;

            [NativeTypeName("HRESULT (DWORD, MF_CAPTURE_ENGINE_STREAM_CATEGORY *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, uint, MF_CAPTURE_ENGINE_STREAM_CATEGORY*, int> GetDeviceStreamCategory;

            [NativeTypeName("HRESULT (DWORD, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, uint, BOOL*, int> GetMirrorState;

            [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, uint, BOOL, int> SetMirrorState;

            [NativeTypeName("HRESULT (UINT32, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSource*, uint, uint*, int> GetStreamIndexFromFriendlyName;
        }
    }
}
