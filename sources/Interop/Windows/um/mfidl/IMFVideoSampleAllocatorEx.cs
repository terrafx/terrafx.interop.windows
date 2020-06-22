// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("545B3A48-3283-4F62-866F-A62D8F598F9F")]
    public unsafe partial struct IMFVideoSampleAllocatorEx
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorEx*, uint>)(lpVtbl[1]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorEx*, uint>)(lpVtbl[2]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDirectXManager([NativeTypeName("IUnknown *")] IUnknown* pManager)
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorEx*, IUnknown*, int>)(lpVtbl[3]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), pManager);
        }

        [return: NativeTypeName("HRESULT")]
        public int UninitializeSampleAllocator()
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorEx*, int>)(lpVtbl[4]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeSampleAllocator([NativeTypeName("DWORD")] uint cRequestedFrames, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType)
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorEx*, uint, IMFMediaType*, int>)(lpVtbl[5]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), cRequestedFrames, pMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int AllocateSample([NativeTypeName("IMFSample **")] IMFSample** ppSample)
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorEx*, IMFSample**, int>)(lpVtbl[6]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), ppSample);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeSampleAllocatorEx([NativeTypeName("DWORD")] uint cInitialSamples, [NativeTypeName("DWORD")] uint cMaximumSamples, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType)
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorEx*, uint, uint, IMFAttributes*, IMFMediaType*, int>)(lpVtbl[7]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), cInitialSamples, cMaximumSamples, pAttributes, pMediaType);
        }
    }
}
