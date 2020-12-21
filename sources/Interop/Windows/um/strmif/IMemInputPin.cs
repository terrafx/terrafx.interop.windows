// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A8689D-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IMemInputPin : IUnknown")]
    public unsafe partial struct IMemInputPin
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMemInputPin*, Guid*, void**, int>)(lpVtbl[0]))((IMemInputPin*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMemInputPin*, uint>)(lpVtbl[1]))((IMemInputPin*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMemInputPin*, uint>)(lpVtbl[2]))((IMemInputPin*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllocator([NativeTypeName("IMemAllocator **")] IMemAllocator** ppAllocator)
        {
            return ((delegate* unmanaged<IMemInputPin*, IMemAllocator**, int>)(lpVtbl[3]))((IMemInputPin*)Unsafe.AsPointer(ref this), ppAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyAllocator([NativeTypeName("IMemAllocator *")] IMemAllocator* pAllocator, [NativeTypeName("BOOL")] int bReadOnly)
        {
            return ((delegate* unmanaged<IMemInputPin*, IMemAllocator*, int, int>)(lpVtbl[4]))((IMemInputPin*)Unsafe.AsPointer(ref this), pAllocator, bReadOnly);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllocatorRequirements([NativeTypeName("ALLOCATOR_PROPERTIES *")] ALLOCATOR_PROPERTIES* pProps)
        {
            return ((delegate* unmanaged<IMemInputPin*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[5]))((IMemInputPin*)Unsafe.AsPointer(ref this), pProps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Receive([NativeTypeName("IMediaSample *")] IMediaSample* pSample)
        {
            return ((delegate* unmanaged<IMemInputPin*, IMediaSample*, int>)(lpVtbl[6]))((IMemInputPin*)Unsafe.AsPointer(ref this), pSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReceiveMultiple([NativeTypeName("IMediaSample **")] IMediaSample** pSamples, [NativeTypeName("long")] int nSamples, [NativeTypeName("long *")] int* nSamplesProcessed)
        {
            return ((delegate* unmanaged<IMemInputPin*, IMediaSample**, int, int*, int>)(lpVtbl[7]))((IMemInputPin*)Unsafe.AsPointer(ref this), pSamples, nSamples, nSamplesProcessed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReceiveCanBlock()
        {
            return ((delegate* unmanaged<IMemInputPin*, int>)(lpVtbl[8]))((IMemInputPin*)Unsafe.AsPointer(ref this));
        }
    }
}
