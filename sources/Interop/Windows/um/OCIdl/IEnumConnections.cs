// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B287-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IEnumConnections : IUnknown")]
    public unsafe partial struct IEnumConnections
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumConnections*, Guid*, void**, int>)(lpVtbl[0]))((IEnumConnections*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumConnections*, uint>)(lpVtbl[1]))((IEnumConnections*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumConnections*, uint>)(lpVtbl[2]))((IEnumConnections*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cConnections, [NativeTypeName("LPCONNECTDATA")] CONNECTDATA* rgcd, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumConnections*, uint, CONNECTDATA*, uint*, int>)(lpVtbl[3]))((IEnumConnections*)Unsafe.AsPointer(ref this), cConnections, rgcd, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cConnections)
        {
            return ((delegate* unmanaged<IEnumConnections*, uint, int>)(lpVtbl[4]))((IEnumConnections*)Unsafe.AsPointer(ref this), cConnections);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumConnections*, int>)(lpVtbl[5]))((IEnumConnections*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumConnections** ppEnum)
        {
            return ((delegate* unmanaged<IEnumConnections*, IEnumConnections**, int>)(lpVtbl[6]))((IEnumConnections*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
