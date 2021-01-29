// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("01C2D285-D3C7-4B7B-B5B5-D97411D0C283")]
    [NativeTypeName("struct ITfLangBarItemBalloon : ITfLangBarItem")]
    public unsafe partial struct ITfLangBarItemBalloon
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, uint>)(lpVtbl[1]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, uint>)(lpVtbl[2]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInfo([NativeTypeName("TF_LANGBARITEMINFO *")] TF_LANGBARITEMINFO* pInfo)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, TF_LANGBARITEMINFO*, int>)(lpVtbl[3]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, uint*, int>)(lpVtbl[4]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("BOOL")] int fShow)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, int, int>)(lpVtbl[5]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTooltipString([NativeTypeName("BSTR *")] ushort** pbstrToolTip)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, ushort**, int>)(lpVtbl[6]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), pbstrToolTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnClick(TfLBIClick click, POINT pt, [NativeTypeName("const RECT *")] RECT* prcArea)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, TfLBIClick, POINT, RECT*, int>)(lpVtbl[7]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), click, pt, prcArea);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreferredSize([NativeTypeName("const SIZE *")] SIZE* pszDefault, [NativeTypeName("SIZE *")] SIZE* psz)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, SIZE*, SIZE*, int>)(lpVtbl[8]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), pszDefault, psz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBalloonInfo([NativeTypeName("TF_LBBALLOONINFO *")] TF_LBBALLOONINFO* pInfo)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, TF_LBBALLOONINFO*, int>)(lpVtbl[9]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), pInfo);
        }
    }
}
