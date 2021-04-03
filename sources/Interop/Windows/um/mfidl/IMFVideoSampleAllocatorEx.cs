// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("545B3A48-3283-4F62-866F-A62D8F598F9F")]
    [NativeTypeName("struct IMFVideoSampleAllocatorEx : IMFVideoSampleAllocator")]
    public unsafe partial struct IMFVideoSampleAllocatorEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, uint>)(lpVtbl[1]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, uint>)(lpVtbl[2]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDirectXManager(IUnknown* pManager)
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, IUnknown*, int>)(lpVtbl[3]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), pManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UninitializeSampleAllocator()
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, int>)(lpVtbl[4]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeSampleAllocator([NativeTypeName("DWORD")] uint cRequestedFrames, IMFMediaType* pMediaType)
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, uint, IMFMediaType*, int>)(lpVtbl[5]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), cRequestedFrames, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AllocateSample(IMFSample** ppSample)
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, IMFSample**, int>)(lpVtbl[6]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), ppSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeSampleAllocatorEx([NativeTypeName("DWORD")] uint cInitialSamples, [NativeTypeName("DWORD")] uint cMaximumSamples, IMFAttributes* pAttributes, IMFMediaType* pMediaType)
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocatorEx*, uint, uint, IMFAttributes*, IMFMediaType*, int>)(lpVtbl[7]))((IMFVideoSampleAllocatorEx*)Unsafe.AsPointer(ref this), cInitialSamples, cMaximumSamples, pAttributes, pMediaType);
        }
    }
}
