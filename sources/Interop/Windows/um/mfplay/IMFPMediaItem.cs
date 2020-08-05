// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("90EB3E6B-ECBF-45CC-B1DA-C6FE3EA70D57")]
    [NativeTypeName("struct IMFPMediaItem : IUnknown")]
    public unsafe partial struct IMFPMediaItem
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFPMediaItem*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFPMediaItem*, uint>)(lpVtbl[1]))((IMFPMediaItem*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFPMediaItem*, uint>)(lpVtbl[2]))((IMFPMediaItem*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMediaPlayer([NativeTypeName("IMFPMediaPlayer **")] IMFPMediaPlayer** ppMediaPlayer)
        {
            return ((delegate* stdcall<IMFPMediaItem*, IMFPMediaPlayer**, int>)(lpVtbl[3]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), ppMediaPlayer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetURL([NativeTypeName("LPWSTR *")] ushort** ppwszURL)
        {
            return ((delegate* stdcall<IMFPMediaItem*, ushort**, int>)(lpVtbl[4]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), ppwszURL);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObject([NativeTypeName("IUnknown **")] IUnknown** ppIUnknown)
        {
            return ((delegate* stdcall<IMFPMediaItem*, IUnknown**, int>)(lpVtbl[5]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), ppIUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserData([NativeTypeName("DWORD_PTR *")] nuint* pdwUserData)
        {
            return ((delegate* stdcall<IMFPMediaItem*, nuint*, int>)(lpVtbl[6]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pdwUserData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUserData([NativeTypeName("DWORD_PTR")] nuint dwUserData)
        {
            return ((delegate* stdcall<IMFPMediaItem*, nuint, int>)(lpVtbl[7]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), dwUserData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStartStopPosition([NativeTypeName("GUID *")] Guid* pguidStartPositionType, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvStartValue, [NativeTypeName("GUID *")] Guid* pguidStopPositionType, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvStopValue)
        {
            return ((delegate* stdcall<IMFPMediaItem*, Guid*, PROPVARIANT*, Guid*, PROPVARIANT*, int>)(lpVtbl[8]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pguidStartPositionType, pvStartValue, pguidStopPositionType, pvStopValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStartStopPosition([NativeTypeName("const GUID *")] Guid* pguidStartPositionType, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvStartValue, [NativeTypeName("const GUID *")] Guid* pguidStopPositionType, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvStopValue)
        {
            return ((delegate* stdcall<IMFPMediaItem*, Guid*, PROPVARIANT*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pguidStartPositionType, pvStartValue, pguidStopPositionType, pvStopValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int HasVideo([NativeTypeName("BOOL *")] int* pfHasVideo, [NativeTypeName("BOOL *")] int* pfSelected)
        {
            return ((delegate* stdcall<IMFPMediaItem*, int*, int*, int>)(lpVtbl[10]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pfHasVideo, pfSelected);
        }

        [return: NativeTypeName("HRESULT")]
        public int HasAudio([NativeTypeName("BOOL *")] int* pfHasAudio, [NativeTypeName("BOOL *")] int* pfSelected)
        {
            return ((delegate* stdcall<IMFPMediaItem*, int*, int*, int>)(lpVtbl[11]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pfHasAudio, pfSelected);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsProtected([NativeTypeName("BOOL *")] int* pfProtected)
        {
            return ((delegate* stdcall<IMFPMediaItem*, int*, int>)(lpVtbl[12]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pfProtected);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDuration([NativeTypeName("const GUID &")] Guid* guidPositionType, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvDurationValue)
        {
            return ((delegate* stdcall<IMFPMediaItem*, Guid*, PROPVARIANT*, int>)(lpVtbl[13]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), guidPositionType, pvDurationValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNumberOfStreams([NativeTypeName("DWORD *")] uint* pdwStreamCount)
        {
            return ((delegate* stdcall<IMFPMediaItem*, uint*, int>)(lpVtbl[14]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pdwStreamCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL *")] int* pfEnabled)
        {
            return ((delegate* stdcall<IMFPMediaItem*, uint, int*, int>)(lpVtbl[15]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), dwStreamIndex, pfEnabled);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL")] int fEnabled)
        {
            return ((delegate* stdcall<IMFPMediaItem*, uint, int, int>)(lpVtbl[16]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), dwStreamIndex, fEnabled);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidMFAttribute, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* stdcall<IMFPMediaItem*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[17]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), dwStreamIndex, guidMFAttribute, pvValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPresentationAttribute([NativeTypeName("const GUID &")] Guid* guidMFAttribute, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* stdcall<IMFPMediaItem*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), guidMFAttribute, pvValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCharacteristics([NativeTypeName("MFP_MEDIAITEM_CHARACTERISTICS *")] uint* pCharacteristics)
        {
            return ((delegate* stdcall<IMFPMediaItem*, uint*, int>)(lpVtbl[19]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), pCharacteristics);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStreamSink([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("IUnknown *")] IUnknown* pMediaSink)
        {
            return ((delegate* stdcall<IMFPMediaItem*, uint, IUnknown*, int>)(lpVtbl[20]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), dwStreamIndex, pMediaSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadata([NativeTypeName("IPropertyStore **")] IPropertyStore** ppMetadataStore)
        {
            return ((delegate* stdcall<IMFPMediaItem*, IPropertyStore**, int>)(lpVtbl[21]))((IMFPMediaItem*)Unsafe.AsPointer(ref this), ppMetadataStore);
        }
    }
}
