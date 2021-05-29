// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("245BF8E9-0755-40F7-88A5-AE0F18D55E17")]
    [NativeTypeName("struct IMFTrackedSample : IUnknown")]
    public unsafe partial struct IMFTrackedSample
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTrackedSample*, Guid*, void**, int>)(lpVtbl[0]))((IMFTrackedSample*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTrackedSample*, uint>)(lpVtbl[1]))((IMFTrackedSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTrackedSample*, uint>)(lpVtbl[2]))((IMFTrackedSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAllocator(IMFAsyncCallback* pSampleAllocator, IUnknown* pUnkState)
        {
            return ((delegate* unmanaged<IMFTrackedSample*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFTrackedSample*)Unsafe.AsPointer(ref this), pSampleAllocator, pUnkState);
        }
    }
}
