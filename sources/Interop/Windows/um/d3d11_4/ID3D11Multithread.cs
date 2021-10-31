// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B7E4E00-342C-4106-A19F-4F2704F689F0")]
    [NativeTypeName("struct ID3D11Multithread : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11Multithread
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11Multithread*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Multithread*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11Multithread*, uint>)(lpVtbl[1]))((ID3D11Multithread*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11Multithread*, uint>)(lpVtbl[2]))((ID3D11Multithread*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void Enter()
        {
            ((delegate* unmanaged<ID3D11Multithread*, void>)(lpVtbl[3]))((ID3D11Multithread*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void Leave()
        {
            ((delegate* unmanaged<ID3D11Multithread*, void>)(lpVtbl[4]))((ID3D11Multithread*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public BOOL SetMultithreadProtected(BOOL bMTProtect)
        {
            return ((delegate* unmanaged<ID3D11Multithread*, BOOL, int>)(lpVtbl[5]))((ID3D11Multithread*)Unsafe.AsPointer(ref this), bMTProtect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public BOOL GetMultithreadProtected()
        {
            return ((delegate* unmanaged<ID3D11Multithread*, int>)(lpVtbl[6]))((ID3D11Multithread*)Unsafe.AsPointer(ref this));
        }
    }
}
