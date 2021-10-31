// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B63616C-36B2-46BC-959F-C1593952D19B")]
    [NativeTypeName("struct ISyncMgrControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrControl*, uint>)(lpVtbl[1]))((ISyncMgrControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrControl*, uint>)(lpVtbl[2]))((ISyncMgrControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int StartHandlerSync([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("HWND")] IntPtr hwndOwner, IUnknown* punk, SYNCMGR_SYNC_CONTROL_FLAGS nSyncControlFlags, ISyncMgrSyncResult* pResult)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, IntPtr, IUnknown*, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult*, int>)(lpVtbl[3]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, hwndOwner, punk, nSyncControlFlags, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int StartItemSync([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR *")] ushort** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems, [NativeTypeName("HWND")] IntPtr hwndOwner, IUnknown* punk, SYNCMGR_SYNC_CONTROL_FLAGS nSyncControlFlags, ISyncMgrSyncResult* pResult)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, ushort**, uint, IntPtr, IUnknown*, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult*, int>)(lpVtbl[4]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, ppszItemIDs, cItems, hwndOwner, punk, nSyncControlFlags, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int StartSyncAll([NativeTypeName("HWND")] IntPtr hwndOwner)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, IntPtr, int>)(lpVtbl[5]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), hwndOwner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int StopHandlerSync([NativeTypeName("LPCWSTR")] ushort* pszHandlerID)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, int>)(lpVtbl[6]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int StopItemSync([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR *")] ushort** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, ushort**, uint, int>)(lpVtbl[7]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, ppszItemIDs, cItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int StopSyncAll()
        {
            return ((delegate* unmanaged<ISyncMgrControl*, int>)(lpVtbl[8]))((ISyncMgrControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateHandlerCollection([NativeTypeName("const IID &")] Guid* rclsidCollectionID, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, Guid*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[9]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), rclsidCollectionID, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateHandler([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[10]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateItem([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, ushort*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[11]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateEvents([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, ushort*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[12]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateConflict([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, ISyncMgrConflict* pConflict, SYNCMGR_UPDATE_REASON nReason)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, ushort*, ISyncMgrConflict*, SYNCMGR_UPDATE_REASON, int>)(lpVtbl[13]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, pConflict, nReason);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateConflicts([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, ushort*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[14]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateHandler(BOOL fActivate, [NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("HWND")] IntPtr hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, BOOL, ushort*, IntPtr, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[15]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), fActivate, pszHandlerID, hwndOwner, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int EnableHandler(BOOL fEnable, [NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("HWND")] IntPtr hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, BOOL, ushort*, IntPtr, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[16]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), fEnable, pszHandlerID, hwndOwner, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int EnableItem(BOOL fEnable, [NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, [NativeTypeName("HWND")] IntPtr hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, BOOL, ushort*, ushort*, IntPtr, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[17]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), fEnable, pszHandlerID, pszItemID, hwndOwner, nControlFlags);
        }
    }
}
