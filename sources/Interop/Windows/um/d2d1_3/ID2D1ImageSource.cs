// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C9B664E5-74A1-4378-9AC2-EEFC37A3F4D8")]
    [NativeTypeName("struct ID2D1ImageSource : ID2D1Image")]
    public unsafe partial struct ID2D1ImageSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1ImageSource*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1ImageSource*, uint>)(lpVtbl[1]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1ImageSource*, uint>)(lpVtbl[2]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1ImageSource*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OfferResources()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1ImageSource*, int>)(lpVtbl[4]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TryReclaimResources([NativeTypeName("BOOL *")] int* resourcesDiscarded)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1ImageSource*, int*, int>)(lpVtbl[5]))((ID2D1ImageSource*)Unsafe.AsPointer(ref this), resourcesDiscarded);
        }
    }
}
