// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6EF2A660-47C0-4666-B13D-CBB717F2FA2C")]
    [NativeTypeName("struct IMFMediaSink : IUnknown")]
    public unsafe partial struct IMFMediaSink
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaSink*, uint>)(lpVtbl[1]))((IMFMediaSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaSink*, uint>)(lpVtbl[2]))((IMFMediaSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
        {
            return ((delegate* stdcall<IMFMediaSink*, uint*, int>)(lpVtbl[3]))((IMFMediaSink*)Unsafe.AsPointer(ref this), pdwCharacteristics);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStreamSink([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType, [NativeTypeName("IMFStreamSink **")] IMFStreamSink** ppStreamSink)
        {
            return ((delegate* stdcall<IMFMediaSink*, uint, IMFMediaType*, IMFStreamSink**, int>)(lpVtbl[4]))((IMFMediaSink*)Unsafe.AsPointer(ref this), dwStreamSinkIdentifier, pMediaType, ppStreamSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveStreamSink([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier)
        {
            return ((delegate* stdcall<IMFMediaSink*, uint, int>)(lpVtbl[5]))((IMFMediaSink*)Unsafe.AsPointer(ref this), dwStreamSinkIdentifier);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamSinkCount([NativeTypeName("DWORD *")] uint* pcStreamSinkCount)
        {
            return ((delegate* stdcall<IMFMediaSink*, uint*, int>)(lpVtbl[6]))((IMFMediaSink*)Unsafe.AsPointer(ref this), pcStreamSinkCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamSinkByIndex([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("IMFStreamSink **")] IMFStreamSink** ppStreamSink)
        {
            return ((delegate* stdcall<IMFMediaSink*, uint, IMFStreamSink**, int>)(lpVtbl[7]))((IMFMediaSink*)Unsafe.AsPointer(ref this), dwIndex, ppStreamSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamSinkById([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier, [NativeTypeName("IMFStreamSink **")] IMFStreamSink** ppStreamSink)
        {
            return ((delegate* stdcall<IMFMediaSink*, uint, IMFStreamSink**, int>)(lpVtbl[8]))((IMFMediaSink*)Unsafe.AsPointer(ref this), dwStreamSinkIdentifier, ppStreamSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPresentationClock([NativeTypeName("IMFPresentationClock *")] IMFPresentationClock* pPresentationClock)
        {
            return ((delegate* stdcall<IMFMediaSink*, IMFPresentationClock*, int>)(lpVtbl[9]))((IMFMediaSink*)Unsafe.AsPointer(ref this), pPresentationClock);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPresentationClock([NativeTypeName("IMFPresentationClock **")] IMFPresentationClock** ppPresentationClock)
        {
            return ((delegate* stdcall<IMFMediaSink*, IMFPresentationClock**, int>)(lpVtbl[10]))((IMFMediaSink*)Unsafe.AsPointer(ref this), ppPresentationClock);
        }

        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* stdcall<IMFMediaSink*, int>)(lpVtbl[11]))((IMFMediaSink*)Unsafe.AsPointer(ref this));
        }
    }
}
