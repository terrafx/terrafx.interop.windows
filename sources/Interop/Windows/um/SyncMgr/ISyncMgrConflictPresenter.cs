// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0B4F5353-FD2B-42CD-8763-4779F2D508A3")]
    [NativeTypeName("struct ISyncMgrConflictPresenter : IUnknown")]
    public unsafe partial struct ISyncMgrConflictPresenter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrConflictPresenter*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrConflictPresenter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrConflictPresenter*, uint>)(lpVtbl[1]))((ISyncMgrConflictPresenter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrConflictPresenter*, uint>)(lpVtbl[2]))((ISyncMgrConflictPresenter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PresentConflict(ISyncMgrConflict* pConflict, ISyncMgrConflictResolveInfo* pResolveInfo)
        {
            return ((delegate* unmanaged<ISyncMgrConflictPresenter*, ISyncMgrConflict*, ISyncMgrConflictResolveInfo*, int>)(lpVtbl[3]))((ISyncMgrConflictPresenter*)Unsafe.AsPointer(ref this), pConflict, pResolveInfo);
        }
    }
}
