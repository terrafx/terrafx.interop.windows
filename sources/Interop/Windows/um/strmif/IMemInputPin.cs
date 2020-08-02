// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A8689D-0AD4-11CE-B03A-0020AF0BA770")]
    public unsafe partial struct IMemInputPin
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMemInputPin*, Guid*, void**, int>)(lpVtbl[0]))((IMemInputPin*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMemInputPin*, uint>)(lpVtbl[1]))((IMemInputPin*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMemInputPin*, uint>)(lpVtbl[2]))((IMemInputPin*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllocator([NativeTypeName("IMemAllocator **")] IMemAllocator** ppAllocator)
        {
            return ((delegate* stdcall<IMemInputPin*, IMemAllocator**, int>)(lpVtbl[3]))((IMemInputPin*)Unsafe.AsPointer(ref this), ppAllocator);
        }

        [return: NativeTypeName("HRESULT")]
        public int NotifyAllocator([NativeTypeName("IMemAllocator *")] IMemAllocator* pAllocator, [NativeTypeName("BOOL")] int bReadOnly)
        {
            return ((delegate* stdcall<IMemInputPin*, IMemAllocator*, int, int>)(lpVtbl[4]))((IMemInputPin*)Unsafe.AsPointer(ref this), pAllocator, bReadOnly);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllocatorRequirements([NativeTypeName("ALLOCATOR_PROPERTIES *")] ALLOCATOR_PROPERTIES* pProps)
        {
            return ((delegate* stdcall<IMemInputPin*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[5]))((IMemInputPin*)Unsafe.AsPointer(ref this), pProps);
        }

        [return: NativeTypeName("HRESULT")]
        public int Receive([NativeTypeName("IMediaSample *")] IMediaSample* pSample)
        {
            return ((delegate* stdcall<IMemInputPin*, IMediaSample*, int>)(lpVtbl[6]))((IMemInputPin*)Unsafe.AsPointer(ref this), pSample);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReceiveMultiple([NativeTypeName("IMediaSample **")] IMediaSample** pSamples, [NativeTypeName("long")] int nSamples, [NativeTypeName("long *")] int* nSamplesProcessed)
        {
            return ((delegate* stdcall<IMemInputPin*, IMediaSample**, int, int*, int>)(lpVtbl[7]))((IMemInputPin*)Unsafe.AsPointer(ref this), pSamples, nSamples, nSamplesProcessed);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReceiveCanBlock()
        {
            return ((delegate* stdcall<IMemInputPin*, int>)(lpVtbl[8]))((IMemInputPin*)Unsafe.AsPointer(ref this));
        }
    }
}
