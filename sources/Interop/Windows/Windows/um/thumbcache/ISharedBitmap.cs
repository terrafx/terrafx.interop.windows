// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("091162A4-BC96-411F-AAE8-C5122CD03363")]
[NativeTypeName("struct ISharedBitmap : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISharedBitmap : ISharedBitmap.Interface
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
    public HRESULT GetSharedBitmap(HBITMAP* phbm)
    {
        return ((delegate* unmanaged<ISharedBitmap*, HBITMAP*, int>)(lpVtbl[3]))((ISharedBitmap*)Unsafe.AsPointer(ref this), phbm);
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
    public HRESULT InitializeBitmap(HBITMAP hbm, WTS_ALPHATYPE wtsAT)
    {
        return ((delegate* unmanaged<ISharedBitmap*, HBITMAP, WTS_ALPHATYPE, int>)(lpVtbl[6]))((ISharedBitmap*)Unsafe.AsPointer(ref this), hbm, wtsAT);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Detach(HBITMAP* phbm)
    {
        return ((delegate* unmanaged<ISharedBitmap*, HBITMAP*, int>)(lpVtbl[7]))((ISharedBitmap*)Unsafe.AsPointer(ref this), phbm);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSharedBitmap(HBITMAP* phbm);

        [VtblIndex(4)]
        HRESULT GetSize(SIZE* pSize);

        [VtblIndex(5)]
        HRESULT GetFormat(WTS_ALPHATYPE* pat);

        [VtblIndex(6)]
        HRESULT InitializeBitmap(HBITMAP hbm, WTS_ALPHATYPE wtsAT);

        [VtblIndex(7)]
        HRESULT Detach(HBITMAP* phbm);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (HBITMAP *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HBITMAP*, int> GetSharedBitmap;

        [NativeTypeName("HRESULT (SIZE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, int> GetSize;

        [NativeTypeName("HRESULT (WTS_ALPHATYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WTS_ALPHATYPE*, int> GetFormat;

        [NativeTypeName("HRESULT (HBITMAP, WTS_ALPHATYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HBITMAP, WTS_ALPHATYPE, int> InitializeBitmap;

        [NativeTypeName("HRESULT (HBITMAP *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HBITMAP*, int> Detach;
    }
}
