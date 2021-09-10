// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C81A1D4E-8CF7-4683-80E0-BCAE88D677B6")]
    [NativeTypeName("struct IEnumSyncMgrEvents : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumSyncMgrEvents
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumSyncMgrEvents*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumSyncMgrEvents*, uint>)(lpVtbl[1]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumSyncMgrEvents*, uint>)(lpVtbl[2]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, ISyncMgrEvent** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumSyncMgrEvents*, uint, ISyncMgrEvent**, uint*, int>)(lpVtbl[3]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumSyncMgrEvents*, uint, int>)(lpVtbl[4]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumSyncMgrEvents*, int>)(lpVtbl[5]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumSyncMgrEvents** ppenum)
        {
            return ((delegate* unmanaged<IEnumSyncMgrEvents*, IEnumSyncMgrEvents**, int>)(lpVtbl[6]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
