// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E467B94E-A713-4562-A802-816A42E9008A")]
    [NativeTypeName("struct IMFMediaSourceExtension : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaSourceExtension
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaSourceExtension*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaSourceExtension*, uint>)(lpVtbl[1]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaSourceExtension*, uint>)(lpVtbl[2]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public IMFSourceBufferList* GetSourceBuffers()
        {
            return ((delegate* unmanaged<IMFMediaSourceExtension*, IMFSourceBufferList*>)(lpVtbl[3]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public IMFSourceBufferList* GetActiveSourceBuffers()
        {
            return ((delegate* unmanaged<IMFMediaSourceExtension*, IMFSourceBufferList*>)(lpVtbl[4]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public MF_MSE_READY GetReadyState()
        {
            return ((delegate* unmanaged<IMFMediaSourceExtension*, MF_MSE_READY>)(lpVtbl[5]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public double GetDuration()
        {
            return ((delegate* unmanaged<IMFMediaSourceExtension*, double>)(lpVtbl[6]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetDuration(double duration)
        {
            return ((delegate* unmanaged<IMFMediaSourceExtension*, double, int>)(lpVtbl[7]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), duration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int AddSourceBuffer([NativeTypeName("BSTR")] ushort* type, IMFSourceBufferNotify* pNotify, IMFSourceBuffer** ppSourceBuffer)
        {
            return ((delegate* unmanaged<IMFMediaSourceExtension*, ushort*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)(lpVtbl[8]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), type, pNotify, ppSourceBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveSourceBuffer(IMFSourceBuffer* pSourceBuffer)
        {
            return ((delegate* unmanaged<IMFMediaSourceExtension*, IMFSourceBuffer*, int>)(lpVtbl[9]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), pSourceBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetEndOfStream(MF_MSE_ERROR error)
        {
            return ((delegate* unmanaged<IMFMediaSourceExtension*, MF_MSE_ERROR, int>)(lpVtbl[10]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), error);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("BOOL")]
        public int IsTypeSupported([NativeTypeName("BSTR")] ushort* type)
        {
            return ((delegate* unmanaged<IMFMediaSourceExtension*, ushort*, int>)(lpVtbl[11]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public IMFSourceBuffer* GetSourceBuffer([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* unmanaged<IMFMediaSourceExtension*, uint, IMFSourceBuffer*>)(lpVtbl[12]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }
    }
}
