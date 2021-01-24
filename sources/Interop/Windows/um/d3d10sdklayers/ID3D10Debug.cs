// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B7E4E01-342C-4106-A19F-4F2704F689F0")]
    [NativeTypeName("struct ID3D10Debug : IUnknown")]
    public unsafe partial struct ID3D10Debug
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10Debug*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10Debug*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10Debug*, uint>)(lpVtbl[1]))((ID3D10Debug*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10Debug*, uint>)(lpVtbl[2]))((ID3D10Debug*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFeatureMask([NativeTypeName("UINT")] uint Mask)
        {
            return ((delegate* unmanaged<ID3D10Debug*, uint, int>)(lpVtbl[3]))((ID3D10Debug*)Unsafe.AsPointer(ref this), Mask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetFeatureMask()
        {
            return ((delegate* unmanaged<ID3D10Debug*, uint>)(lpVtbl[4]))((ID3D10Debug*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPresentPerRenderOpDelay([NativeTypeName("UINT")] uint Milliseconds)
        {
            return ((delegate* unmanaged<ID3D10Debug*, uint, int>)(lpVtbl[5]))((ID3D10Debug*)Unsafe.AsPointer(ref this), Milliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetPresentPerRenderOpDelay()
        {
            return ((delegate* unmanaged<ID3D10Debug*, uint>)(lpVtbl[6]))((ID3D10Debug*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSwapChain([NativeTypeName("IDXGISwapChain *")] IDXGISwapChain* pSwapChain)
        {
            return ((delegate* unmanaged<ID3D10Debug*, IDXGISwapChain*, int>)(lpVtbl[7]))((ID3D10Debug*)Unsafe.AsPointer(ref this), pSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSwapChain([NativeTypeName("IDXGISwapChain **")] IDXGISwapChain** ppSwapChain)
        {
            return ((delegate* unmanaged<ID3D10Debug*, IDXGISwapChain**, int>)(lpVtbl[8]))((ID3D10Debug*)Unsafe.AsPointer(ref this), ppSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Validate()
        {
            return ((delegate* unmanaged<ID3D10Debug*, int>)(lpVtbl[9]))((ID3D10Debug*)Unsafe.AsPointer(ref this));
        }
    }
}
