// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("28C7F1D0-DE25-11D2-AFDD-00105A2799B5")]
    [NativeTypeName("struct ITfLangBarItemButton : ITfLangBarItem")]
    public unsafe partial struct ITfLangBarItemButton
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, uint>)(lpVtbl[1]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, uint>)(lpVtbl[2]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInfo(TF_LANGBARITEMINFO* pInfo)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, TF_LANGBARITEMINFO*, int>)(lpVtbl[3]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, uint*, int>)(lpVtbl[4]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("BOOL")] int fShow)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, int, int>)(lpVtbl[5]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTooltipString([NativeTypeName("BSTR *")] ushort** pbstrToolTip)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, ushort**, int>)(lpVtbl[6]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), pbstrToolTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnClick(TfLBIClick click, POINT pt, [NativeTypeName("const RECT *")] RECT* prcArea)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, TfLBIClick, POINT, RECT*, int>)(lpVtbl[7]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), click, pt, prcArea);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitMenu(ITfMenu* pMenu)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, ITfMenu*, int>)(lpVtbl[8]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), pMenu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnMenuSelect([NativeTypeName("UINT")] uint wID)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, uint, int>)(lpVtbl[9]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), wID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIcon([NativeTypeName("HICON *")] IntPtr* phIcon)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, IntPtr*, int>)(lpVtbl[10]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), phIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("BSTR *")] ushort** pbstrText)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, ushort**, int>)(lpVtbl[11]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), pbstrText);
        }
    }
}
