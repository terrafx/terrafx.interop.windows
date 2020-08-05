// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C9B2EB9-86D5-4514-A394-F56664F9F0D8")]
    [NativeTypeName("struct IMFMediaSourceEx : IMFMediaSource")]
    public unsafe partial struct IMFMediaSourceEx
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, uint>)(lpVtbl[1]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, uint>)(lpVtbl[2]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEvent([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IMFMediaEvent **")] IMFMediaEvent** ppEvent)
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginGetEvent([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndGetEvent([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("IMFMediaEvent **")] IMFMediaEvent** ppEvent)
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pResult, ppEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, [NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, uint, Guid*, int, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, uint*, int>)(lpVtbl[7]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pdwCharacteristics);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePresentationDescriptor([NativeTypeName("IMFPresentationDescriptor **")] IMFPresentationDescriptor** ppPresentationDescriptor)
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, IMFPresentationDescriptor**, int>)(lpVtbl[8]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), ppPresentationDescriptor);
        }

        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("IMFPresentationDescriptor *")] IMFPresentationDescriptor* pPresentationDescriptor, [NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition)
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, IMFPresentationDescriptor*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pPresentationDescriptor, pguidTimeFormat, pvarStartPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, int>)(lpVtbl[10]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, int>)(lpVtbl[11]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, int>)(lpVtbl[12]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceAttributes([NativeTypeName("IMFAttributes **")] IMFAttributes** ppAttributes)
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, IMFAttributes**, int>)(lpVtbl[13]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), ppAttributes);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamAttributes([NativeTypeName("DWORD")] uint dwStreamIdentifier, [NativeTypeName("IMFAttributes **")] IMFAttributes** ppAttributes)
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, uint, IMFAttributes**, int>)(lpVtbl[14]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), dwStreamIdentifier, ppAttributes);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetD3DManager([NativeTypeName("IUnknown *")] IUnknown* pManager)
        {
            return ((delegate* stdcall<IMFMediaSourceEx*, IUnknown*, int>)(lpVtbl[15]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pManager);
        }
    }
}
