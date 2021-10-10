// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CF8FC579-C396-4774-85F1-D908A831156E")]
    [NativeTypeName("struct ISyncMgrConflictStore : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrConflictStore
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrConflictStore*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrConflictStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrConflictStore*, uint>)(lpVtbl[1]))((ISyncMgrConflictStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrConflictStore*, uint>)(lpVtbl[2]))((ISyncMgrConflictStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int EnumConflicts([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, IEnumSyncMgrConflict** ppEnum)
        {
            return ((delegate* unmanaged<ISyncMgrConflictStore*, ushort*, ushort*, IEnumSyncMgrConflict**, int>)(lpVtbl[3]))((ISyncMgrConflictStore*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int BindToConflict([NativeTypeName("const SYNCMGR_CONFLICT_ID_INFO *")] SYNCMGR_CONFLICT_ID_INFO* pConflictIdInfo, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ISyncMgrConflictStore*, SYNCMGR_CONFLICT_ID_INFO*, Guid*, void**, int>)(lpVtbl[4]))((ISyncMgrConflictStore*)Unsafe.AsPointer(ref this), pConflictIdInfo, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveConflicts([NativeTypeName("const SYNCMGR_CONFLICT_ID_INFO *")] SYNCMGR_CONFLICT_ID_INFO* rgConflictIdInfo, [NativeTypeName("DWORD")] uint cConflicts)
        {
            return ((delegate* unmanaged<ISyncMgrConflictStore*, SYNCMGR_CONFLICT_ID_INFO*, uint, int>)(lpVtbl[5]))((ISyncMgrConflictStore*)Unsafe.AsPointer(ref this), rgConflictIdInfo, cConflicts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, [NativeTypeName("DWORD *")] uint* pnConflicts)
        {
            return ((delegate* unmanaged<ISyncMgrConflictStore*, ushort*, ushort*, uint*, int>)(lpVtbl[6]))((ISyncMgrConflictStore*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, pnConflicts);
        }
    }
}
