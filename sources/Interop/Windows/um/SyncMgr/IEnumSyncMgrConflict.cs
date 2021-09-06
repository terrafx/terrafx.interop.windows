// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("82705914-DDA3-4893-BA99-49DE6C8C8036")]
    [NativeTypeName("struct IEnumSyncMgrConflict : IUnknown")]
    public unsafe partial struct IEnumSyncMgrConflict
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumSyncMgrConflict*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumSyncMgrConflict*, uint>)(lpVtbl[1]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumSyncMgrConflict*, uint>)(lpVtbl[2]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, ISyncMgrConflict** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumSyncMgrConflict*, uint, ISyncMgrConflict**, uint*, int>)(lpVtbl[3]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumSyncMgrConflict*, uint, int>)(lpVtbl[4]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumSyncMgrConflict*, int>)(lpVtbl[5]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumSyncMgrConflict** ppenum)
        {
            return ((delegate* unmanaged<IEnumSyncMgrConflict*, IEnumSyncMgrConflict**, int>)(lpVtbl[6]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
