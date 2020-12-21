// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E0DB51C3-6F77-4BAE-B3D5-E47509B35838")]
    [NativeTypeName("struct ID2D1GdiInteropRenderTarget : IUnknown")]
    public unsafe partial struct ID2D1GdiInteropRenderTarget
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, uint>)(lpVtbl[1]))((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, uint>)(lpVtbl[2]))((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDC(D2D1_DC_INITIALIZE_MODE mode, [NativeTypeName("HDC *")] IntPtr* hdc)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, D2D1_DC_INITIALIZE_MODE, IntPtr*, int>)(lpVtbl[3]))((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this), mode, hdc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC([NativeTypeName("const RECT *")] RECT* update)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, RECT*, int>)(lpVtbl[4]))((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this), update);
        }
    }
}
