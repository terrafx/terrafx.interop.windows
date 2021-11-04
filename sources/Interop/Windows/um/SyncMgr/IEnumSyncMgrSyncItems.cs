// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54B3ABF3-F085-4181-B546-E29C403C726B")]
    [NativeTypeName("struct IEnumSyncMgrSyncItems : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumSyncMgrSyncItems
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, uint>)(lpVtbl[1]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, uint>)(lpVtbl[2]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, ISyncMgrSyncItem** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, uint, ISyncMgrSyncItem**, uint*, int>)(lpVtbl[3]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, uint, int>)(lpVtbl[4]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, int>)(lpVtbl[5]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Clone(IEnumSyncMgrSyncItems** ppenum)
        {
            return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, IEnumSyncMgrSyncItems**, int>)(lpVtbl[6]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this), ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSyncMgrSyncItems*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSyncMgrSyncItems*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSyncMgrSyncItems*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, ISyncMgrSyncItem **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSyncMgrSyncItems*, uint, ISyncMgrSyncItem**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSyncMgrSyncItems*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSyncMgrSyncItems*, int> Reset;

            [NativeTypeName("HRESULT (IEnumSyncMgrSyncItems **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSyncMgrSyncItems*, IEnumSyncMgrSyncItems**, int> Clone;
        }
    }
}
