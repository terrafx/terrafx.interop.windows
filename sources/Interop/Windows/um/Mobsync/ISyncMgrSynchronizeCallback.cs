// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6295DF41-35EE-11D1-8707-00C04FD93327")]
    [NativeTypeName("struct ISyncMgrSynchronizeCallback : IUnknown")]
    public unsafe partial struct ISyncMgrSynchronizeCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, uint>)(lpVtbl[1]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, uint>)(lpVtbl[2]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowPropertiesCompleted([NativeTypeName("HRESULT")] int hr)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, int, int>)(lpVtbl[3]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PrepareForSyncCompleted([NativeTypeName("HRESULT")] int hr)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, int, int>)(lpVtbl[4]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SynchronizeCompleted([NativeTypeName("HRESULT")] int hr)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, int, int>)(lpVtbl[5]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowErrorCompleted([NativeTypeName("HRESULT")] int hr, [NativeTypeName("ULONG")] uint cItems, [NativeTypeName("const GUID *")] Guid* pItemIDs)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, int, uint, Guid*, int>)(lpVtbl[6]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), hr, cItems, pItemIDs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableModeless([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, int, int>)(lpVtbl[7]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Progress([NativeTypeName("const GUID &")] Guid* ItemID, [NativeTypeName("const SYNCMGRPROGRESSITEM *")] SYNCMGRPROGRESSITEM* pSyncProgressItem)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, Guid*, SYNCMGRPROGRESSITEM*, int>)(lpVtbl[8]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), ItemID, pSyncProgressItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LogError([NativeTypeName("DWORD")] uint dwErrorLevel, [NativeTypeName("LPCWSTR")] ushort* pszErrorText, [NativeTypeName("const SYNCMGRLOGERRORINFO *")] SYNCMGRLOGERRORINFO* pSyncLogError)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, uint, ushort*, SYNCMGRLOGERRORINFO*, int>)(lpVtbl[9]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), dwErrorLevel, pszErrorText, pSyncLogError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteLogError([NativeTypeName("const GUID &")] Guid* ErrorID, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, Guid*, uint, int>)(lpVtbl[10]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), ErrorID, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EstablishConnection([NativeTypeName("LPCWSTR")] ushort* pwszConnection, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronizeCallback*, ushort*, uint, int>)(lpVtbl[11]))((ISyncMgrSynchronizeCallback*)Unsafe.AsPointer(ref this), pwszConnection, dwReserved);
        }
    }
}
