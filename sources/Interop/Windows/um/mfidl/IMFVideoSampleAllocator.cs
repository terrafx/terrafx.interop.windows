// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("86CBC910-E533-4751-8E3B-F19B5B806A03")]
    [NativeTypeName("struct IMFVideoSampleAllocator : IUnknown")]
    public unsafe partial struct IMFVideoSampleAllocator
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFVideoSampleAllocator*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFVideoSampleAllocator*, uint>)(lpVtbl[1]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFVideoSampleAllocator*, uint>)(lpVtbl[2]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDirectXManager([NativeTypeName("IUnknown *")] IUnknown* pManager)
        {
            return ((delegate* stdcall<IMFVideoSampleAllocator*, IUnknown*, int>)(lpVtbl[3]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this), pManager);
        }

        [return: NativeTypeName("HRESULT")]
        public int UninitializeSampleAllocator()
        {
            return ((delegate* stdcall<IMFVideoSampleAllocator*, int>)(lpVtbl[4]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeSampleAllocator([NativeTypeName("DWORD")] uint cRequestedFrames, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType)
        {
            return ((delegate* stdcall<IMFVideoSampleAllocator*, uint, IMFMediaType*, int>)(lpVtbl[5]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this), cRequestedFrames, pMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int AllocateSample([NativeTypeName("IMFSample **")] IMFSample** ppSample)
        {
            return ((delegate* stdcall<IMFVideoSampleAllocator*, IMFSample**, int>)(lpVtbl[6]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this), ppSample);
        }
    }
}
