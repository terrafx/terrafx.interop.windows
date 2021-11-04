// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("508E71D3-EC66-4FC3-8775-B4B9ED6BA847")]
    [NativeTypeName("struct IMFFieldOfUseMFTUnlock : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFFieldOfUseMFTUnlock : IMFFieldOfUseMFTUnlock.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFFieldOfUseMFTUnlock*, Guid*, void**, int>)(lpVtbl[0]))((IMFFieldOfUseMFTUnlock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFFieldOfUseMFTUnlock*, uint>)(lpVtbl[1]))((IMFFieldOfUseMFTUnlock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFFieldOfUseMFTUnlock*, uint>)(lpVtbl[2]))((IMFFieldOfUseMFTUnlock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Unlock(IUnknown* pUnkMFT)
        {
            return ((delegate* unmanaged<IMFFieldOfUseMFTUnlock*, IUnknown*, int>)(lpVtbl[3]))((IMFFieldOfUseMFTUnlock*)Unsafe.AsPointer(ref this), pUnkMFT);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Unlock(IUnknown* pUnkMFT);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFFieldOfUseMFTUnlock*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFFieldOfUseMFTUnlock*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFFieldOfUseMFTUnlock*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFFieldOfUseMFTUnlock*, IUnknown*, int> Unlock;
        }
    }
}
