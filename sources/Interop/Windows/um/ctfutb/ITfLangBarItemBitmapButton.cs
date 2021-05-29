// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A26A0525-3FAE-4FA0-89EE-88A964F9F1B5")]
    [NativeTypeName("struct ITfLangBarItemBitmapButton : ITfLangBarItem")]
    public unsafe partial struct ITfLangBarItemBitmapButton
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, uint>)(lpVtbl[1]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, uint>)(lpVtbl[2]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInfo(TF_LANGBARITEMINFO* pInfo)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, TF_LANGBARITEMINFO*, int>)(lpVtbl[3]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, uint*, int>)(lpVtbl[4]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("BOOL")] int fShow)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, int, int>)(lpVtbl[5]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTooltipString([NativeTypeName("BSTR *")] ushort** pbstrToolTip)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, ushort**, int>)(lpVtbl[6]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), pbstrToolTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnClick(TfLBIClick click, POINT pt, [NativeTypeName("const RECT *")] RECT* prcArea)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, TfLBIClick, POINT, RECT*, int>)(lpVtbl[7]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), click, pt, prcArea);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitMenu(ITfMenu* pMenu)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, ITfMenu*, int>)(lpVtbl[8]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), pMenu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnMenuSelect([NativeTypeName("UINT")] uint wID)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, uint, int>)(lpVtbl[9]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), wID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreferredSize([NativeTypeName("const SIZE *")] SIZE* pszDefault, SIZE* psz)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, SIZE*, SIZE*, int>)(lpVtbl[10]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), pszDefault, psz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawBitmap([NativeTypeName("LONG")] int bmWidth, [NativeTypeName("LONG")] int bmHeight, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HBITMAP *")] IntPtr* phbmp, [NativeTypeName("HBITMAP *")] IntPtr* phbmpMask)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, int, int, uint, IntPtr*, IntPtr*, int>)(lpVtbl[11]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), bmWidth, bmHeight, dwFlags, phbmp, phbmpMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("BSTR *")] ushort** pbstrText)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmapButton*, ushort**, int>)(lpVtbl[12]))((ITfLangBarItemBitmapButton*)Unsafe.AsPointer(ref this), pbstrText);
        }
    }
}
