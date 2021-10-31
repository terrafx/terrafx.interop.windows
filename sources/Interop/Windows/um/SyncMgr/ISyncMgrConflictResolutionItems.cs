// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("458725B9-129D-4135-A998-9CEAFEC27007")]
    [NativeTypeName("struct ISyncMgrConflictResolutionItems : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrConflictResolutionItems
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolutionItems*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrConflictResolutionItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolutionItems*, uint>)(lpVtbl[1]))((ISyncMgrConflictResolutionItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolutionItems*, uint>)(lpVtbl[2]))((ISyncMgrConflictResolutionItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolutionItems*, uint*, int>)(lpVtbl[3]))((ISyncMgrConflictResolutionItems*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetItem([NativeTypeName("UINT")] uint iIndex, CONFIRM_CONFLICT_RESULT_INFO* pItemInfo)
        {
            return ((delegate* unmanaged<ISyncMgrConflictResolutionItems*, uint, CONFIRM_CONFLICT_RESULT_INFO*, int>)(lpVtbl[4]))((ISyncMgrConflictResolutionItems*)Unsafe.AsPointer(ref this), iIndex, pItemInfo);
        }
    }
}
