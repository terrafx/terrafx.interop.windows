// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEAAF403-C1D8-450D-AA05-E0CCEE7502A8")]
    [NativeTypeName("struct ISpatialAudioObjectRenderStreamBase : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpatialAudioObjectRenderStreamBase
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, uint>)(lpVtbl[1]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, uint>)(lpVtbl[2]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetAvailableDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetService([NativeTypeName("const IID &")] Guid* riid, void** service)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, Guid*, void**, int>)(lpVtbl[4]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this), riid, service);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Start()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, int>)(lpVtbl[5]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Stop()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, int>)(lpVtbl[6]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, int>)(lpVtbl[7]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT BeginUpdatingAudioObjects([NativeTypeName("UINT32 *")] uint* availableDynamicObjectCount, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, uint*, uint*, int>)(lpVtbl[8]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this), availableDynamicObjectCount, frameCountPerBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT EndUpdatingAudioObjects()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, int>)(lpVtbl[9]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, uint> Release;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, uint*, int> GetAvailableDynamicObjectCount;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, Guid*, void**, int> GetService;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, int> Start;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, int> Stop;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, int> Reset;

            [NativeTypeName("HRESULT (UINT32 *, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, uint*, uint*, int> BeginUpdatingAudioObjects;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, int> EndUpdatingAudioObjects;
        }
    }
}
