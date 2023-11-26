// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDWritePaintReader.xml' path='doc/member[@name="IDWritePaintReader"]/*' />
[Guid("8128E912-3B97-42A5-AB6C-24AAD3A86E54")]
[NativeTypeName("struct IDWritePaintReader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWritePaintReader : IDWritePaintReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWritePaintReader));

    public void** lpVtbl;

    public HRESULT SetCurrentGlyph([NativeTypeName("UINT32")] uint glyphIndex, DWRITE_PAINT_ELEMENT* paintElement, D2D_RECT_F* clipBox, DWRITE_PAINT_ATTRIBUTES* glyphAttributes = null)
    {
        return SetCurrentGlyph(glyphIndex, paintElement, (uint)(sizeof(DWRITE_PAINT_ELEMENT)), clipBox, glyphAttributes);
    }

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWritePaintReader*, Guid*, void**, int>)(lpVtbl[0]))((IDWritePaintReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWritePaintReader*, uint>)(lpVtbl[1]))((IDWritePaintReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWritePaintReader*, uint>)(lpVtbl[2]))((IDWritePaintReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWritePaintReader.xml' path='doc/member[@name="IDWritePaintReader.SetCurrentGlyph"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetCurrentGlyph([NativeTypeName("UINT32")] uint glyphIndex, DWRITE_PAINT_ELEMENT* paintElement, [NativeTypeName("UINT32")] uint structSize, D2D_RECT_F* clipBox, DWRITE_PAINT_ATTRIBUTES* glyphAttributes = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWritePaintReader*, uint, DWRITE_PAINT_ELEMENT*, uint, D2D_RECT_F*, DWRITE_PAINT_ATTRIBUTES*, int>)(lpVtbl[3]))((IDWritePaintReader*)Unsafe.AsPointer(ref this), glyphIndex, paintElement, structSize, clipBox, glyphAttributes);
    }

    /// <include file='IDWritePaintReader.xml' path='doc/member[@name="IDWritePaintReader.SetTextColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTextColor([NativeTypeName("const DWRITE_COLOR_F &")] DXGI_RGBA* textColor)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWritePaintReader*, DXGI_RGBA*, int>)(lpVtbl[4]))((IDWritePaintReader*)Unsafe.AsPointer(ref this), textColor);
    }

    /// <include file='IDWritePaintReader.xml' path='doc/member[@name="IDWritePaintReader.SetColorPaletteIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetColorPaletteIndex([NativeTypeName("UINT32")] uint colorPaletteIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWritePaintReader*, uint, int>)(lpVtbl[5]))((IDWritePaintReader*)Unsafe.AsPointer(ref this), colorPaletteIndex);
    }

    /// <include file='IDWritePaintReader.xml' path='doc/member[@name="IDWritePaintReader.SetCustomColorPalette"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCustomColorPalette([NativeTypeName("const DWRITE_COLOR_F *")] DXGI_RGBA* paletteEntries, [NativeTypeName("UINT32")] uint paletteEntryCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWritePaintReader*, DXGI_RGBA*, uint, int>)(lpVtbl[6]))((IDWritePaintReader*)Unsafe.AsPointer(ref this), paletteEntries, paletteEntryCount);
    }

    /// <include file='IDWritePaintReader.xml' path='doc/member[@name="IDWritePaintReader.MoveToFirstChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT MoveToFirstChild(DWRITE_PAINT_ELEMENT* paintElement, [NativeTypeName("UINT32")] uint structSize = 36)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWritePaintReader*, DWRITE_PAINT_ELEMENT*, uint, int>)(lpVtbl[7]))((IDWritePaintReader*)Unsafe.AsPointer(ref this), paintElement, structSize);
    }

    /// <include file='IDWritePaintReader.xml' path='doc/member[@name="IDWritePaintReader.MoveToNextSibling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MoveToNextSibling(DWRITE_PAINT_ELEMENT* paintElement, [NativeTypeName("UINT32")] uint structSize = 36)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWritePaintReader*, DWRITE_PAINT_ELEMENT*, uint, int>)(lpVtbl[8]))((IDWritePaintReader*)Unsafe.AsPointer(ref this), paintElement, structSize);
    }

    /// <include file='IDWritePaintReader.xml' path='doc/member[@name="IDWritePaintReader.MoveToParent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT MoveToParent()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWritePaintReader*, int>)(lpVtbl[9]))((IDWritePaintReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWritePaintReader.xml' path='doc/member[@name="IDWritePaintReader.GetGradientStops"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetGradientStops([NativeTypeName("UINT32")] uint firstGradientStopIndex, [NativeTypeName("UINT32")] uint gradientStopCount, D2D1_GRADIENT_STOP* gradientStops)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWritePaintReader*, uint, uint, D2D1_GRADIENT_STOP*, int>)(lpVtbl[10]))((IDWritePaintReader*)Unsafe.AsPointer(ref this), firstGradientStopIndex, gradientStopCount, gradientStops);
    }

    /// <include file='IDWritePaintReader.xml' path='doc/member[@name="IDWritePaintReader.GetGradientStopColors"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGradientStopColors([NativeTypeName("UINT32")] uint firstGradientStopIndex, [NativeTypeName("UINT32")] uint gradientStopCount, DWRITE_PAINT_COLOR* gradientStopColors)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWritePaintReader*, uint, uint, DWRITE_PAINT_COLOR*, int>)(lpVtbl[11]))((IDWritePaintReader*)Unsafe.AsPointer(ref this), firstGradientStopIndex, gradientStopCount, gradientStopColors);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetCurrentGlyph([NativeTypeName("UINT32")] uint glyphIndex, DWRITE_PAINT_ELEMENT* paintElement, [NativeTypeName("UINT32")] uint structSize, D2D_RECT_F* clipBox, DWRITE_PAINT_ATTRIBUTES* glyphAttributes = null);

        [VtblIndex(4)]
        HRESULT SetTextColor([NativeTypeName("const DWRITE_COLOR_F &")] DXGI_RGBA* textColor);

        [VtblIndex(5)]
        HRESULT SetColorPaletteIndex([NativeTypeName("UINT32")] uint colorPaletteIndex);

        [VtblIndex(6)]
        HRESULT SetCustomColorPalette([NativeTypeName("const DWRITE_COLOR_F *")] DXGI_RGBA* paletteEntries, [NativeTypeName("UINT32")] uint paletteEntryCount);

        [VtblIndex(7)]
        HRESULT MoveToFirstChild(DWRITE_PAINT_ELEMENT* paintElement, [NativeTypeName("UINT32")] uint structSize = 36);

        [VtblIndex(8)]
        HRESULT MoveToNextSibling(DWRITE_PAINT_ELEMENT* paintElement, [NativeTypeName("UINT32")] uint structSize = 36);

        [VtblIndex(9)]
        HRESULT MoveToParent();

        [VtblIndex(10)]
        HRESULT GetGradientStops([NativeTypeName("UINT32")] uint firstGradientStopIndex, [NativeTypeName("UINT32")] uint gradientStopCount, D2D1_GRADIENT_STOP* gradientStops);

        [VtblIndex(11)]
        HRESULT GetGradientStopColors([NativeTypeName("UINT32")] uint firstGradientStopIndex, [NativeTypeName("UINT32")] uint gradientStopCount, DWRITE_PAINT_COLOR* gradientStopColors);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (UINT32, DWRITE_PAINT_ELEMENT *, UINT32, D2D_RECT_F *, DWRITE_PAINT_ATTRIBUTES *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, DWRITE_PAINT_ELEMENT*, uint, D2D_RECT_F*, DWRITE_PAINT_ATTRIBUTES*, int> SetCurrentGlyph1;

        [NativeTypeName("HRESULT (const DWRITE_COLOR_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXGI_RGBA*, int> SetTextColor;

        [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetColorPaletteIndex;

        [NativeTypeName("HRESULT (const DWRITE_COLOR_F *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXGI_RGBA*, uint, int> SetCustomColorPalette;

        [NativeTypeName("HRESULT (DWRITE_PAINT_ELEMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_PAINT_ELEMENT*, uint, int> MoveToFirstChild;

        [NativeTypeName("HRESULT (DWRITE_PAINT_ELEMENT *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_PAINT_ELEMENT*, uint, int> MoveToNextSibling;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> MoveToParent;

        [NativeTypeName("HRESULT (UINT32, UINT32, D2D1_GRADIENT_STOP *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, D2D1_GRADIENT_STOP*, int> GetGradientStops;

        [NativeTypeName("HRESULT (UINT32, UINT32, DWRITE_PAINT_COLOR *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, DWRITE_PAINT_COLOR*, int> GetGradientStopColors;
    }
}
