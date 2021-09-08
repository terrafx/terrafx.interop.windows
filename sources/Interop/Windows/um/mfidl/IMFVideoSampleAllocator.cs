// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("86CBC910-E533-4751-8E3B-F19B5B806A03")]
    [NativeTypeName("struct IMFVideoSampleAllocator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFVideoSampleAllocator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocator*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocator*, uint>)(lpVtbl[1]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocator*, uint>)(lpVtbl[2]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetDirectXManager(IUnknown* pManager)
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocator*, IUnknown*, int>)(lpVtbl[3]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this), pManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int UninitializeSampleAllocator()
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocator*, int>)(lpVtbl[4]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeSampleAllocator([NativeTypeName("DWORD")] uint cRequestedFrames, IMFMediaType* pMediaType)
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocator*, uint, IMFMediaType*, int>)(lpVtbl[5]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this), cRequestedFrames, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int AllocateSample(IMFSample** ppSample)
        {
            return ((delegate* unmanaged<IMFVideoSampleAllocator*, IMFSample**, int>)(lpVtbl[6]))((IMFVideoSampleAllocator*)Unsafe.AsPointer(ref this), ppSample);
        }
    }
}
