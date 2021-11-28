// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("A26A0525-3FAE-4FA0-89EE-88A964F9F1B5")]
[NativeTypeName("struct ITfLangBarItemBitmapButton : ITfLangBarItem")]
[NativeInheritance("ITfLangBarItem")]
public unsafe partial struct ITfLangBarItemBitmapButton : ITfLangBarItemBitmapButton.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, uint>)(lpVtbl[1]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, uint>)(lpVtbl[2]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetInfo(TF_LANGBARITEMINFO* pInfo)
    {
        return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, TF_LANGBARITEMINFO*, int>)(lpVtbl[3]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
    {
        return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, uint*, int>)(lpVtbl[4]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), pdwStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Show(BOOL fShow)
    {
        return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, BOOL, int>)(lpVtbl[5]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), fShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetTooltipString([NativeTypeName("BSTR *")] ushort** pbstrToolTip)
    {
        return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, ushort**, int>)(lpVtbl[6]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), pbstrToolTip);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnClick(TfLBIClick click, POINT pt, [NativeTypeName("const RECT *")] RECT* prcArea)
    {
        return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, TfLBIClick, POINT, RECT*, int>)(lpVtbl[7]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), click, pt, prcArea);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InitMenu(ITfMenu* pMenu)
    {
        return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, ITfMenu*, int>)(lpVtbl[8]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), pMenu);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnMenuSelect(uint wID)
    {
        return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, uint, int>)(lpVtbl[9]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), wID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPreferredSize([NativeTypeName("const SIZE *")] SIZE* pszDefault, SIZE* psz)
    {
        return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, SIZE*, SIZE*, int>)(lpVtbl[10]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), pszDefault, psz);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DrawBitmap([NativeTypeName("LONG")] int bmWidth, [NativeTypeName("LONG")] int bmHeight, [NativeTypeName("DWORD")] uint dwFlags, HBITMAP* phbmp, HBITMAP* phbmpMask)
    {
        return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, int, int, uint, HBITMAP*, HBITMAP*, int>)(lpVtbl[11]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), bmWidth, bmHeight, dwFlags, phbmp, phbmpMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetText([NativeTypeName("BSTR *")] ushort** pbstrText)
    {
        return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, ushort**, int>)(lpVtbl[12]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), pbstrText);
    }

    public interface Interface : ITfLangBarItem.Interface
    {
        [VtblIndex(7)]
        HRESULT OnClick(TfLBIClick click, POINT pt, [NativeTypeName("const RECT *")] RECT* prcArea);

        [VtblIndex(8)]
        HRESULT InitMenu(ITfMenu* pMenu);

        [VtblIndex(9)]
        HRESULT OnMenuSelect(uint wID);

        [VtblIndex(10)]
        HRESULT GetPreferredSize([NativeTypeName("const SIZE *")] SIZE* pszDefault, SIZE* psz);

        [VtblIndex(11)]
        HRESULT DrawBitmap([NativeTypeName("LONG")] int bmWidth, [NativeTypeName("LONG")] int bmHeight, [NativeTypeName("DWORD")] uint dwFlags, HBITMAP* phbmp, HBITMAP* phbmpMask);

        [VtblIndex(12)]
        HRESULT GetText([NativeTypeName("BSTR *")] ushort** pbstrText);
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

        [NativeTypeName("HRESULT (TF_LANGBARITEMINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TF_LANGBARITEMINFO*, int> GetInfo;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetStatus;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Show;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetTooltipString;

        [NativeTypeName("HRESULT (TfLBIClick, POINT, const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TfLBIClick, POINT, RECT*, int> OnClick;

        [NativeTypeName("HRESULT (ITfMenu *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfMenu*, int> InitMenu;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnMenuSelect;

        [NativeTypeName("HRESULT (const SIZE *, SIZE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, SIZE*, int> GetPreferredSize;

        [NativeTypeName("HRESULT (LONG, LONG, DWORD, HBITMAP *, HBITMAP *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, uint, HBITMAP*, HBITMAP*, int> DrawBitmap;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetText;
    }
}
