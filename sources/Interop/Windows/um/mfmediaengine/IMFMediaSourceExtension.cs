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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, uint>)(lpVtbl[1]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, uint>)(lpVtbl[2]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("IMFSourceBufferList *")]
        public IMFSourceBufferList* GetSourceBuffers()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, IMFSourceBufferList*>)(lpVtbl[3]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("IMFSourceBufferList *")]
        public IMFSourceBufferList* GetActiveSourceBuffers()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, IMFSourceBufferList*>)(lpVtbl[4]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public MF_MSE_READY GetReadyState()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, MF_MSE_READY>)(lpVtbl[5]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double GetDuration()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, double>)(lpVtbl[6]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDuration(double duration)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, double, int>)(lpVtbl[7]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), duration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddSourceBuffer([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("IMFSourceBufferNotify *")] IMFSourceBufferNotify* pNotify, [NativeTypeName("IMFSourceBuffer **")] IMFSourceBuffer** ppSourceBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, ushort*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)(lpVtbl[8]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), type, pNotify, ppSourceBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveSourceBuffer([NativeTypeName("IMFSourceBuffer *")] IMFSourceBuffer* pSourceBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, IMFSourceBuffer*, int>)(lpVtbl[9]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), pSourceBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEndOfStream(MF_MSE_ERROR error)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, MF_MSE_ERROR, int>)(lpVtbl[10]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), error);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsTypeSupported([NativeTypeName("BSTR")] ushort* type)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, ushort*, int>)(lpVtbl[11]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("IMFSourceBuffer *")]
        public IMFSourceBuffer* GetSourceBuffer([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, uint, IMFSourceBuffer*>)(lpVtbl[12]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }
    }
}
