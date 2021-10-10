// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6295DF2A-35EE-11D1-8707-00C04FD93327")]
    [NativeTypeName("struct ISyncMgrEnumItems : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrEnumItems
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrEnumItems*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrEnumItems*, uint>)(lpVtbl[1]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrEnumItems*, uint>)(lpVtbl[2]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, SYNCMGRITEM* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<ISyncMgrEnumItems*, uint, SYNCMGRITEM*, uint*, int>)(lpVtbl[3]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<ISyncMgrEnumItems*, uint, int>)(lpVtbl[4]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<ISyncMgrEnumItems*, int>)(lpVtbl[5]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(ISyncMgrEnumItems** ppenum)
        {
            return ((delegate* unmanaged<ISyncMgrEnumItems*, ISyncMgrEnumItems**, int>)(lpVtbl[6]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
