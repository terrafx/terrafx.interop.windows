// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("091162A4-BC96-411F-AAE8-C5122CD03363")]
    [NativeTypeName("struct ISharedBitmap : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISharedBitmap
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISharedBitmap*, Guid*, void**, int>)(lpVtbl[0]))((ISharedBitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISharedBitmap*, uint>)(lpVtbl[1]))((ISharedBitmap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISharedBitmap*, uint>)(lpVtbl[2]))((ISharedBitmap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetSharedBitmap([NativeTypeName("HBITMAP *")] IntPtr* phbm)
        {
            return ((delegate* unmanaged<ISharedBitmap*, IntPtr*, int>)(lpVtbl[3]))((ISharedBitmap*)Unsafe.AsPointer(ref this), phbm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSize(SIZE* pSize)
        {
            return ((delegate* unmanaged<ISharedBitmap*, SIZE*, int>)(lpVtbl[4]))((ISharedBitmap*)Unsafe.AsPointer(ref this), pSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetFormat(WTS_ALPHATYPE* pat)
        {
            return ((delegate* unmanaged<ISharedBitmap*, WTS_ALPHATYPE*, int>)(lpVtbl[5]))((ISharedBitmap*)Unsafe.AsPointer(ref this), pat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT InitializeBitmap([NativeTypeName("HBITMAP")] IntPtr hbm, WTS_ALPHATYPE wtsAT)
        {
            return ((delegate* unmanaged<ISharedBitmap*, IntPtr, WTS_ALPHATYPE, int>)(lpVtbl[6]))((ISharedBitmap*)Unsafe.AsPointer(ref this), hbm, wtsAT);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Detach([NativeTypeName("HBITMAP *")] IntPtr* phbm)
        {
            return ((delegate* unmanaged<ISharedBitmap*, IntPtr*, int>)(lpVtbl[7]))((ISharedBitmap*)Unsafe.AsPointer(ref this), phbm);
        }
    }
}
