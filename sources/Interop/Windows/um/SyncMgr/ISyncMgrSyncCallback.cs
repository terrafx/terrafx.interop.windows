// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("884CCD87-B139-4937-A4BA-4F8E19513FBE")]
    [NativeTypeName("struct ISyncMgrSyncCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrSyncCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrSyncCallback*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrSyncCallback*, uint>)(lpVtbl[1]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrSyncCallback*, uint>)(lpVtbl[2]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int ReportProgress([NativeTypeName("LPCWSTR")] ushort* pszItemID, [NativeTypeName("LPCWSTR")] ushort* pszProgressText, SYNCMGR_PROGRESS_STATUS nStatus, [NativeTypeName("ULONG")] uint uCurrentStep, [NativeTypeName("ULONG")] uint uMaxStep, SYNCMGR_CANCEL_REQUEST* pnCancelRequest)
        {
            return ((delegate* unmanaged<ISyncMgrSyncCallback*, ushort*, ushort*, SYNCMGR_PROGRESS_STATUS, uint, uint, SYNCMGR_CANCEL_REQUEST*, int>)(lpVtbl[3]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pszItemID, pszProgressText, nStatus, uCurrentStep, uMaxStep, pnCancelRequest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetHandlerProgressText([NativeTypeName("LPCWSTR")] ushort* pszProgressText, SYNCMGR_CANCEL_REQUEST* pnCancelRequest)
        {
            return ((delegate* unmanaged<ISyncMgrSyncCallback*, ushort*, SYNCMGR_CANCEL_REQUEST*, int>)(lpVtbl[4]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pszProgressText, pnCancelRequest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ReportEventW([NativeTypeName("LPCWSTR")] ushort* pszItemID, SYNCMGR_EVENT_LEVEL nLevel, SYNCMGR_EVENT_FLAGS nFlags, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("LPCWSTR")] ushort* pszDescription, [NativeTypeName("LPCWSTR")] ushort* pszLinkText, [NativeTypeName("LPCWSTR")] ushort* pszLinkReference, [NativeTypeName("LPCWSTR")] ushort* pszContext, [NativeTypeName("GUID *")] Guid* pguidEventID)
        {
            return ((delegate* unmanaged<ISyncMgrSyncCallback*, ushort*, SYNCMGR_EVENT_LEVEL, SYNCMGR_EVENT_FLAGS, ushort*, ushort*, ushort*, ushort*, ushort*, Guid*, int>)(lpVtbl[5]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pszItemID, nLevel, nFlags, pszName, pszDescription, pszLinkText, pszLinkReference, pszContext, pguidEventID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CanContinue([NativeTypeName("LPCWSTR")] ushort* pszItemID)
        {
            return ((delegate* unmanaged<ISyncMgrSyncCallback*, ushort*, int>)(lpVtbl[6]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pszItemID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int QueryForAdditionalItems(IEnumString** ppenumItemIDs, IEnumUnknown** ppenumPunks)
        {
            return ((delegate* unmanaged<ISyncMgrSyncCallback*, IEnumString**, IEnumUnknown**, int>)(lpVtbl[7]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), ppenumItemIDs, ppenumPunks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int AddItemToSession([NativeTypeName("LPCWSTR")] ushort* pszItemID)
        {
            return ((delegate* unmanaged<ISyncMgrSyncCallback*, ushort*, int>)(lpVtbl[8]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pszItemID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int AddIUnknownToSession(IUnknown* punk)
        {
            return ((delegate* unmanaged<ISyncMgrSyncCallback*, IUnknown*, int>)(lpVtbl[9]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int ProposeItem(ISyncMgrSyncItem* pNewItem)
        {
            return ((delegate* unmanaged<ISyncMgrSyncCallback*, ISyncMgrSyncItem*, int>)(lpVtbl[10]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pNewItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int CommitItem([NativeTypeName("LPCWSTR")] ushort* pszItemID)
        {
            return ((delegate* unmanaged<ISyncMgrSyncCallback*, ushort*, int>)(lpVtbl[11]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pszItemID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int ReportManualSync()
        {
            return ((delegate* unmanaged<ISyncMgrSyncCallback*, int>)(lpVtbl[12]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this));
        }
    }
}
