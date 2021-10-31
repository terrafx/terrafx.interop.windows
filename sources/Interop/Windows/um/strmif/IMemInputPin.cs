// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A8689D-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IMemInputPin : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMemInputPin
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMemInputPin*, Guid*, void**, int>)(lpVtbl[0]))((IMemInputPin*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMemInputPin*, uint>)(lpVtbl[1]))((IMemInputPin*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMemInputPin*, uint>)(lpVtbl[2]))((IMemInputPin*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetAllocator(IMemAllocator** ppAllocator)
        {
            return ((delegate* unmanaged<IMemInputPin*, IMemAllocator**, int>)(lpVtbl[3]))((IMemInputPin*)Unsafe.AsPointer(ref this), ppAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT NotifyAllocator(IMemAllocator* pAllocator, BOOL bReadOnly)
        {
            return ((delegate* unmanaged<IMemInputPin*, IMemAllocator*, BOOL, int>)(lpVtbl[4]))((IMemInputPin*)Unsafe.AsPointer(ref this), pAllocator, bReadOnly);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetAllocatorRequirements(ALLOCATOR_PROPERTIES* pProps)
        {
            return ((delegate* unmanaged<IMemInputPin*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[5]))((IMemInputPin*)Unsafe.AsPointer(ref this), pProps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Receive(IMediaSample* pSample)
        {
            return ((delegate* unmanaged<IMemInputPin*, IMediaSample*, int>)(lpVtbl[6]))((IMemInputPin*)Unsafe.AsPointer(ref this), pSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ReceiveMultiple(IMediaSample** pSamples, [NativeTypeName("long")] int nSamples, [NativeTypeName("long *")] int* nSamplesProcessed)
        {
            return ((delegate* unmanaged<IMemInputPin*, IMediaSample**, int, int*, int>)(lpVtbl[7]))((IMemInputPin*)Unsafe.AsPointer(ref this), pSamples, nSamples, nSamplesProcessed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ReceiveCanBlock()
        {
            return ((delegate* unmanaged<IMemInputPin*, int>)(lpVtbl[8]))((IMemInputPin*)Unsafe.AsPointer(ref this));
        }
    }
}
