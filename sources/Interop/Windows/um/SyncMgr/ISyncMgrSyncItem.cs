// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B20B24CE-2593-4F04-BD8B-7AD6C45051CD")]
    [NativeTypeName("struct ISyncMgrSyncItem : IUnknown")]
    public unsafe partial struct ISyncMgrSyncItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItem*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrSyncItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrSyncItem*, uint>)(lpVtbl[1]))((ISyncMgrSyncItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrSyncItem*, uint>)(lpVtbl[2]))((ISyncMgrSyncItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemID([NativeTypeName("LPWSTR *")] ushort** ppszItemID)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItem*, ushort**, int>)(lpVtbl[3]))((ISyncMgrSyncItem*)Unsafe.AsPointer(ref this), ppszItemID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItem*, ushort**, int>)(lpVtbl[4]))((ISyncMgrSyncItem*)Unsafe.AsPointer(ref this), ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemInfo(ISyncMgrSyncItemInfo** ppItemInfo)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItem*, ISyncMgrSyncItemInfo**, int>)(lpVtbl[5]))((ISyncMgrSyncItem*)Unsafe.AsPointer(ref this), ppItemInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjectW([NativeTypeName("const GUID &")] Guid* rguidObjectID, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItem*, Guid*, Guid*, void**, int>)(lpVtbl[6]))((ISyncMgrSyncItem*)Unsafe.AsPointer(ref this), rguidObjectID, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCapabilities(SYNCMGR_ITEM_CAPABILITIES* pmCapabilities)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItem*, SYNCMGR_ITEM_CAPABILITIES*, int>)(lpVtbl[7]))((ISyncMgrSyncItem*)Unsafe.AsPointer(ref this), pmCapabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPolicies(SYNCMGR_ITEM_POLICIES* pmPolicies)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItem*, SYNCMGR_ITEM_POLICIES*, int>)(lpVtbl[8]))((ISyncMgrSyncItem*)Unsafe.AsPointer(ref this), pmPolicies);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Enable([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItem*, int, int>)(lpVtbl[9]))((ISyncMgrSyncItem*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Delete()
        {
            return ((delegate* unmanaged<ISyncMgrSyncItem*, int>)(lpVtbl[10]))((ISyncMgrSyncItem*)Unsafe.AsPointer(ref this));
        }
    }
}
