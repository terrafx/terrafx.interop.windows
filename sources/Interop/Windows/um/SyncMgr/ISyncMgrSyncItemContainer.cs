// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("90701133-BE32-4129-A65C-99E616CAFFF4")]
    [NativeTypeName("struct ISyncMgrSyncItemContainer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrSyncItemContainer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemContainer*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrSyncItemContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemContainer*, uint>)(lpVtbl[1]))((ISyncMgrSyncItemContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemContainer*, uint>)(lpVtbl[2]))((ISyncMgrSyncItemContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetSyncItem([NativeTypeName("LPCWSTR")] ushort* pszItemID, ISyncMgrSyncItem** ppItem)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemContainer*, ushort*, ISyncMgrSyncItem**, int>)(lpVtbl[3]))((ISyncMgrSyncItemContainer*)Unsafe.AsPointer(ref this), pszItemID, ppItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetSyncItemEnumerator(IEnumSyncMgrSyncItems** ppenum)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemContainer*, IEnumSyncMgrSyncItems**, int>)(lpVtbl[4]))((ISyncMgrSyncItemContainer*)Unsafe.AsPointer(ref this), ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetSyncItemCount([NativeTypeName("ULONG *")] uint* pcItems)
        {
            return ((delegate* unmanaged<ISyncMgrSyncItemContainer*, uint*, int>)(lpVtbl[5]))((ISyncMgrSyncItemContainer*)Unsafe.AsPointer(ref this), pcItems);
        }
    }
}
