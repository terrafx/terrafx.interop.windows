// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("992388B4-3372-4F67-8B6F-C84C071F4751")]
    [NativeTypeName("struct IMFVideoSampleAllocatorCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFVideoSampleAllocatorCallback : IMFVideoSampleAllocatorCallback.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocatorCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoSampleAllocatorCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocatorCallback*, uint>)(lpVtbl[1]))((IMFVideoSampleAllocatorCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocatorCallback*, uint>)(lpVtbl[2]))((IMFVideoSampleAllocatorCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetCallback(IMFVideoSampleAllocatorNotify* pNotify)
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocatorCallback*, IMFVideoSampleAllocatorNotify*, int>)(lpVtbl[3]))((IMFVideoSampleAllocatorCallback*)Unsafe.AsPointer(ref this), pNotify);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetFreeSampleCount([NativeTypeName("LONG *")] int* plSamples)
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocatorCallback*, int*, int>)(lpVtbl[4]))((IMFVideoSampleAllocatorCallback*)Unsafe.AsPointer(ref this), plSamples);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetCallback(IMFVideoSampleAllocatorNotify* pNotify);

            [VtblIndex(4)]
            HRESULT GetFreeSampleCount([NativeTypeName("LONG *")] int* plSamples);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoSampleAllocatorCallback*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoSampleAllocatorCallback*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoSampleAllocatorCallback*, uint> Release;

            [NativeTypeName("HRESULT (IMFVideoSampleAllocatorNotify *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoSampleAllocatorCallback*, IMFVideoSampleAllocatorNotify*, int> SetCallback;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFVideoSampleAllocatorCallback*, int*, int> GetFreeSampleCount;
        }
    }
}
