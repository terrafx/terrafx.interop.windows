// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("72D6135B-35E9-412C-B926-FD5265F2A885")]
    [NativeTypeName("struct IMFCaptureSink : IUnknown")]
    public unsafe partial struct IMFCaptureSink
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFCaptureSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFCaptureSink*, uint>)(lpVtbl[1]))((IMFCaptureSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFCaptureSink*, uint>)(lpVtbl[2]))((IMFCaptureSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputMediaType([NativeTypeName("DWORD")] uint dwSinkStreamIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* stdcall<IMFCaptureSink*, uint, IMFMediaType**, int>)(lpVtbl[3]))((IMFCaptureSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, ppMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("DWORD")] uint dwSinkStreamIndex, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown **")] IUnknown** ppUnknown)
        {
            return ((delegate* stdcall<IMFCaptureSink*, uint, Guid*, Guid*, IUnknown**, int>)(lpVtbl[4]))((IMFCaptureSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, rguidService, riid, ppUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStream([NativeTypeName("DWORD")] uint dwSourceStreamIndex, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("DWORD *")] uint* pdwSinkStreamIndex)
        {
            return ((delegate* stdcall<IMFCaptureSink*, uint, IMFMediaType*, IMFAttributes*, uint*, int>)(lpVtbl[5]))((IMFCaptureSink*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pMediaType, pAttributes, pdwSinkStreamIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int Prepare()
        {
            return ((delegate* stdcall<IMFCaptureSink*, int>)(lpVtbl[6]))((IMFCaptureSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAllStreams()
        {
            return ((delegate* stdcall<IMFCaptureSink*, int>)(lpVtbl[7]))((IMFCaptureSink*)Unsafe.AsPointer(ref this));
        }
    }
}
