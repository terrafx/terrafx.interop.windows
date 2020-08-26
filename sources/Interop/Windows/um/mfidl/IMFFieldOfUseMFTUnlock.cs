// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("508E71D3-EC66-4FC3-8775-B4B9ED6BA847")]
    [NativeTypeName("struct IMFFieldOfUseMFTUnlock : IUnknown")]
    public unsafe partial struct IMFFieldOfUseMFTUnlock
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFFieldOfUseMFTUnlock*, Guid*, void**, int>)(lpVtbl[0]))((IMFFieldOfUseMFTUnlock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFFieldOfUseMFTUnlock*, uint>)(lpVtbl[1]))((IMFFieldOfUseMFTUnlock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFFieldOfUseMFTUnlock*, uint>)(lpVtbl[2]))((IMFFieldOfUseMFTUnlock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unlock([NativeTypeName("IUnknown *")] IUnknown* pUnkMFT)
        {
            return ((delegate* stdcall<IMFFieldOfUseMFTUnlock*, IUnknown*, int>)(lpVtbl[3]))((IMFFieldOfUseMFTUnlock*)Unsafe.AsPointer(ref this), pUnkMFT);
        }
    }
}
