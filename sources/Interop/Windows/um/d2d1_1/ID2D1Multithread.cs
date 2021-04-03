// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("31E6E7BC-E0FF-4D46-8C64-A0A8C41C15D3")]
    [NativeTypeName("struct ID2D1Multithread : IUnknown")]
    public unsafe partial struct ID2D1Multithread
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1Multithread*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Multithread*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1Multithread*, uint>)(lpVtbl[1]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1Multithread*, uint>)(lpVtbl[2]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetMultithreadProtected()
        {
            return ((delegate* unmanaged<ID2D1Multithread*, int>)(lpVtbl[3]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Enter()
        {
            ((delegate* unmanaged<ID2D1Multithread*, void>)(lpVtbl[4]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Leave()
        {
            ((delegate* unmanaged<ID2D1Multithread*, void>)(lpVtbl[5]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }
    }
}
