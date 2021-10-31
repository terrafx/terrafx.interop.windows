// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct ID3D10StateBlock : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D10StateBlock
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10StateBlock*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10StateBlock*, uint>)(lpVtbl[1]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10StateBlock*, uint>)(lpVtbl[2]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Capture()
        {
            return ((delegate* unmanaged<ID3D10StateBlock*, int>)(lpVtbl[3]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Apply()
        {
            return ((delegate* unmanaged<ID3D10StateBlock*, int>)(lpVtbl[4]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ReleaseAllDeviceObjects()
        {
            return ((delegate* unmanaged<ID3D10StateBlock*, int>)(lpVtbl[5]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetDevice(ID3D10Device** ppDevice)
        {
            return ((delegate* unmanaged<ID3D10StateBlock*, ID3D10Device**, int>)(lpVtbl[6]))((ID3D10StateBlock*)Unsafe.AsPointer(ref this), ppDevice);
        }
    }
}
