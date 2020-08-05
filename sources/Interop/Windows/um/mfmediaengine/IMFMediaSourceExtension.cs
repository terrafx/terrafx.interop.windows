// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E467B94E-A713-4562-A802-816A42E9008A")]
    [NativeTypeName("struct IMFMediaSourceExtension : IUnknown")]
    public unsafe partial struct IMFMediaSourceExtension
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaSourceExtension*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaSourceExtension*, uint>)(lpVtbl[1]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaSourceExtension*, uint>)(lpVtbl[2]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("IMFSourceBufferList *")]
        public IMFSourceBufferList* GetSourceBuffers()
        {
            return ((delegate* stdcall<IMFMediaSourceExtension*, IMFSourceBufferList*>)(lpVtbl[3]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("IMFSourceBufferList *")]
        public IMFSourceBufferList* GetActiveSourceBuffers()
        {
            return ((delegate* stdcall<IMFMediaSourceExtension*, IMFSourceBufferList*>)(lpVtbl[4]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        public MF_MSE_READY GetReadyState()
        {
            return ((delegate* stdcall<IMFMediaSourceExtension*, MF_MSE_READY>)(lpVtbl[5]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        public double GetDuration()
        {
            return ((delegate* stdcall<IMFMediaSourceExtension*, double>)(lpVtbl[6]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDuration(double duration)
        {
            return ((delegate* stdcall<IMFMediaSourceExtension*, double, int>)(lpVtbl[7]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), duration);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSourceBuffer([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("IMFSourceBufferNotify *")] IMFSourceBufferNotify* pNotify, [NativeTypeName("IMFSourceBuffer **")] IMFSourceBuffer** ppSourceBuffer)
        {
            return ((delegate* stdcall<IMFMediaSourceExtension*, ushort*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)(lpVtbl[8]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), type, pNotify, ppSourceBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveSourceBuffer([NativeTypeName("IMFSourceBuffer *")] IMFSourceBuffer* pSourceBuffer)
        {
            return ((delegate* stdcall<IMFMediaSourceExtension*, IMFSourceBuffer*, int>)(lpVtbl[9]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), pSourceBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEndOfStream(MF_MSE_ERROR error)
        {
            return ((delegate* stdcall<IMFMediaSourceExtension*, MF_MSE_ERROR, int>)(lpVtbl[10]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), error);
        }

        [return: NativeTypeName("BOOL")]
        public int IsTypeSupported([NativeTypeName("BSTR")] ushort* type)
        {
            return ((delegate* stdcall<IMFMediaSourceExtension*, ushort*, int>)(lpVtbl[11]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), type);
        }

        [return: NativeTypeName("IMFSourceBuffer *")]
        public IMFSourceBuffer* GetSourceBuffer([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* stdcall<IMFMediaSourceExtension*, uint, IMFSourceBuffer*>)(lpVtbl[12]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }
    }
}
