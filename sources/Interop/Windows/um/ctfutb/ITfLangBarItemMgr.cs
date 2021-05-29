// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BA468C55-9956-4FB1-A59D-52A7DD7CC6AA")]
    [NativeTypeName("struct ITfLangBarItemMgr : IUnknown")]
    public unsafe partial struct ITfLangBarItemMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint>)(lpVtbl[1]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint>)(lpVtbl[2]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumItems(IEnumTfLangBarItems** ppEnum)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, IEnumTfLangBarItems**, int>)(lpVtbl[3]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItem([NativeTypeName("const GUID &")] Guid* rguid, ITfLangBarItem** ppItem)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, Guid*, ITfLangBarItem**, int>)(lpVtbl[4]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), rguid, ppItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddItem(ITfLangBarItem* punk)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, ITfLangBarItem*, int>)(lpVtbl[5]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveItem(ITfLangBarItem* punk)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, ITfLangBarItem*, int>)(lpVtbl[6]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdviseItemSink(ITfLangBarItemSink* punk, [NativeTypeName("DWORD *")] uint* pdwCookie, [NativeTypeName("const GUID &")] Guid* rguidItem)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, ITfLangBarItemSink*, uint*, Guid*, int>)(lpVtbl[7]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), punk, pdwCookie, rguidItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnadviseItemSink([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint, int>)(lpVtbl[8]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemFloatingRect([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("const GUID &")] Guid* rguid, RECT* prc)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint, Guid*, RECT*, int>)(lpVtbl[9]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), dwThreadId, rguid, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemsStatus([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("const GUID *")] Guid* prgguid, [NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint, Guid*, uint*, int>)(lpVtbl[10]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), ulCount, prgguid, pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemNum([NativeTypeName("ULONG *")] uint* pulCount)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint*, int>)(lpVtbl[11]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), pulCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItems([NativeTypeName("ULONG")] uint ulCount, ITfLangBarItem** ppItem, TF_LANGBARITEMINFO* pInfo, [NativeTypeName("DWORD *")] uint* pdwStatus, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint, ITfLangBarItem**, TF_LANGBARITEMINFO*, uint*, uint*, int>)(lpVtbl[12]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), ulCount, ppItem, pInfo, pdwStatus, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdviseItemsSink([NativeTypeName("ULONG")] uint ulCount, ITfLangBarItemSink** ppunk, [NativeTypeName("const GUID *")] Guid* pguidItem, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint, ITfLangBarItemSink**, Guid*, uint*, int>)(lpVtbl[13]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), ulCount, ppunk, pguidItem, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnadviseItemsSink([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint, uint*, int>)(lpVtbl[14]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), ulCount, pdwCookie);
        }
    }
}
