// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("73830352-D722-4179-ADA5-F045C98DF355")]
    [NativeTypeName("struct ITfLangBarItemBitmap : ITfLangBarItem")]
    public unsafe partial struct ITfLangBarItemBitmap
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmap*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarItemBitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmap*, uint>)(lpVtbl[1]))((ITfLangBarItemBitmap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmap*, uint>)(lpVtbl[2]))((ITfLangBarItemBitmap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInfo([NativeTypeName("TF_LANGBARITEMINFO *")] TF_LANGBARITEMINFO* pInfo)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmap*, TF_LANGBARITEMINFO*, int>)(lpVtbl[3]))((ITfLangBarItemBitmap*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmap*, uint*, int>)(lpVtbl[4]))((ITfLangBarItemBitmap*)Unsafe.AsPointer(ref this), pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("BOOL")] int fShow)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmap*, int, int>)(lpVtbl[5]))((ITfLangBarItemBitmap*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTooltipString([NativeTypeName("BSTR *")] ushort** pbstrToolTip)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmap*, ushort**, int>)(lpVtbl[6]))((ITfLangBarItemBitmap*)Unsafe.AsPointer(ref this), pbstrToolTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnClick(TfLBIClick click, POINT pt, [NativeTypeName("const RECT *")] RECT* prcArea)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmap*, TfLBIClick, POINT, RECT*, int>)(lpVtbl[7]))((ITfLangBarItemBitmap*)Unsafe.AsPointer(ref this), click, pt, prcArea);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreferredSize([NativeTypeName("const SIZE *")] SIZE* pszDefault, [NativeTypeName("SIZE *")] SIZE* psz)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmap*, SIZE*, SIZE*, int>)(lpVtbl[8]))((ITfLangBarItemBitmap*)Unsafe.AsPointer(ref this), pszDefault, psz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DrawBitmap([NativeTypeName("LONG")] int bmWidth, [NativeTypeName("LONG")] int bmHeight, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HBITMAP *")] IntPtr* phbmp, [NativeTypeName("HBITMAP *")] IntPtr* phbmpMask)
        {
            return ((delegate* unmanaged<ITfLangBarItemBitmap*, int, int, uint, IntPtr*, IntPtr*, int>)(lpVtbl[9]))((ITfLangBarItemBitmap*)Unsafe.AsPointer(ref this), bmWidth, bmHeight, dwFlags, phbmp, phbmpMask);
        }
    }
}
