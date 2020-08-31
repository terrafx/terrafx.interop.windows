// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B284-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IConnectionPointContainer : IUnknown")]
    public unsafe partial struct IConnectionPointContainer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IConnectionPointContainer*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IConnectionPointContainer*, uint>)(lpVtbl[1]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IConnectionPointContainer*, uint>)(lpVtbl[2]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumConnectionPoints([NativeTypeName("IEnumConnectionPoints **")] IEnumConnectionPoints** ppEnum)
        {
            return ((delegate* stdcall<IConnectionPointContainer*, IEnumConnectionPoints**, int>)(lpVtbl[3]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindConnectionPoint([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IConnectionPoint **")] IConnectionPoint** ppCP)
        {
            return ((delegate* stdcall<IConnectionPointContainer*, Guid*, IConnectionPoint**, int>)(lpVtbl[4]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this), riid, ppCP);
        }
    }
}
