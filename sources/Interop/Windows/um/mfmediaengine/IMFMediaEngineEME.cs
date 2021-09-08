// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("50DC93E4-BA4F-4275-AE66-83E836E57469")]
    [NativeTypeName("struct IMFMediaEngineEME : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaEngineEME
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineEME*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineEME*, uint>)(lpVtbl[1]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineEME*, uint>)(lpVtbl[2]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get_Keys(IMFMediaKeys** keys)
        {
            return ((delegate* unmanaged<IMFMediaEngineEME*, IMFMediaKeys**, int>)(lpVtbl[3]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this), keys);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetMediaKeys(IMFMediaKeys* keys)
        {
            return ((delegate* unmanaged<IMFMediaEngineEME*, IMFMediaKeys*, int>)(lpVtbl[4]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this), keys);
        }
    }
}
