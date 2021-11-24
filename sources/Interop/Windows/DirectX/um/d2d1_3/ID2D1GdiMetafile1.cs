// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("2E69F9E8-DD3F-4BF9-95BA-C04F49D788DF")]
[NativeTypeName("struct ID2D1GdiMetafile1 : ID2D1GdiMetafile")]
[NativeInheritance("ID2D1GdiMetafile")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct ID2D1GdiMetafile1 : ID2D1GdiMetafile1.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafile1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1GdiMetafile1*, uint>)(lpVtbl[1]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1GdiMetafile1*, uint>)(lpVtbl[2]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1GdiMetafile1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), factory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Stream(ID2D1GdiMetafileSink* sink)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafile1*, ID2D1GdiMetafileSink*, int>)(lpVtbl[4]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), sink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBounds([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafile1*, D2D_RECT_F*, int>)(lpVtbl[5]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), bounds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDpi(float* dpiX, float* dpiY)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafile1*, float*, float*, int>)(lpVtbl[6]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), dpiX, dpiY);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSourceBounds([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafile1*, D2D_RECT_F*, int>)(lpVtbl[7]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), bounds);
    }

    public interface Interface : ID2D1GdiMetafile.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDpi(float* dpiX, float* dpiY);

        [VtblIndex(7)]
        HRESULT GetSourceBounds([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1GdiMetafile1*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1GdiMetafile1*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1GdiMetafile1*, uint> Release;

        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1GdiMetafile1*, ID2D1Factory**, void> GetFactory;

        [NativeTypeName("HRESULT (ID2D1GdiMetafileSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1GdiMetafile1*, ID2D1GdiMetafileSink*, int> Stream;

        [NativeTypeName("HRESULT (D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1GdiMetafile1*, D2D_RECT_F*, int> GetBounds;

        [NativeTypeName("HRESULT (FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1GdiMetafile1*, float*, float*, int> GetDpi;

        [NativeTypeName("HRESULT (D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1GdiMetafile1*, D2D_RECT_F*, int> GetSourceBounds;
    }
}
