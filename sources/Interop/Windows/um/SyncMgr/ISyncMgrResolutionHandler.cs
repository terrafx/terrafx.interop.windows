// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("40A3D052-8BFF-4C4B-A338-D4A395700DE9")]
    [NativeTypeName("struct ISyncMgrResolutionHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrResolutionHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrResolutionHandler*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrResolutionHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrResolutionHandler*, uint>)(lpVtbl[1]))((ISyncMgrResolutionHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrResolutionHandler*, uint>)(lpVtbl[2]))((ISyncMgrResolutionHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT QueryAbilities([NativeTypeName("SYNCMGR_RESOLUTION_ABILITIES_FLAGS *")] uint* pdwAbilities)
        {
            return ((delegate* unmanaged<ISyncMgrResolutionHandler*, uint*, int>)(lpVtbl[3]))((ISyncMgrResolutionHandler*)Unsafe.AsPointer(ref this), pdwAbilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT KeepOther(IShellItem* psiOther, SYNCMGR_RESOLUTION_FEEDBACK* pFeedback)
        {
            return ((delegate* unmanaged<ISyncMgrResolutionHandler*, IShellItem*, SYNCMGR_RESOLUTION_FEEDBACK*, int>)(lpVtbl[4]))((ISyncMgrResolutionHandler*)Unsafe.AsPointer(ref this), psiOther, pFeedback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT KeepRecent(SYNCMGR_RESOLUTION_FEEDBACK* pFeedback)
        {
            return ((delegate* unmanaged<ISyncMgrResolutionHandler*, SYNCMGR_RESOLUTION_FEEDBACK*, int>)(lpVtbl[5]))((ISyncMgrResolutionHandler*)Unsafe.AsPointer(ref this), pFeedback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RemoveFromSyncSet(SYNCMGR_RESOLUTION_FEEDBACK* pFeedback)
        {
            return ((delegate* unmanaged<ISyncMgrResolutionHandler*, SYNCMGR_RESOLUTION_FEEDBACK*, int>)(lpVtbl[6]))((ISyncMgrResolutionHandler*)Unsafe.AsPointer(ref this), pFeedback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT KeepItems(ISyncMgrConflictResolutionItems* pArray, SYNCMGR_RESOLUTION_FEEDBACK* pFeedback)
        {
            return ((delegate* unmanaged<ISyncMgrResolutionHandler*, ISyncMgrConflictResolutionItems*, SYNCMGR_RESOLUTION_FEEDBACK*, int>)(lpVtbl[7]))((ISyncMgrResolutionHandler*)Unsafe.AsPointer(ref this), pArray, pFeedback);
        }
    }
}
