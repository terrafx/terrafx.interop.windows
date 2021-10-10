// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E7FD9502-BE0C-4464-90A1-2B5277031232")]
    [NativeTypeName("struct ISyncMgrSyncItemInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrSyncItemInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, uint>)(lpVtbl[1]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, uint>)(lpVtbl[2]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeLabel([NativeTypeName("LPWSTR *")] ushort** ppszTypeLabel)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, ushort**, int>)(lpVtbl[3]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this), ppszTypeLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetComment([NativeTypeName("LPWSTR *")] ushort** ppszComment)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, ushort**, int>)(lpVtbl[4]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this), ppszComment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetLastSyncTime(FILETIME* pftLastSync)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, FILETIME*, int>)(lpVtbl[5]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this), pftLastSync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int IsEnabled()
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, int>)(lpVtbl[6]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int IsConnected()
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, int>)(lpVtbl[7]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this));
        }
    }
}
