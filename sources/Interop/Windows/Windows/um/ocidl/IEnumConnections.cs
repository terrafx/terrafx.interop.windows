// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("B196B287-BAB4-101A-B69C-00AA00341D07")]
[NativeTypeName("struct IEnumConnections : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumConnections : IEnumConnections.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumConnections*, Guid*, void**, int>)(lpVtbl[0]))((IEnumConnections*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumConnections*, uint>)(lpVtbl[1]))((IEnumConnections*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumConnections*, uint>)(lpVtbl[2]))((IEnumConnections*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint cConnections, [NativeTypeName("LPCONNECTDATA")] CONNECTDATA* rgcd, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumConnections*, uint, CONNECTDATA*, uint*, int>)(lpVtbl[3]))((IEnumConnections*)Unsafe.AsPointer(ref this), cConnections, rgcd, pcFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint cConnections)
    {
        return ((delegate* unmanaged<IEnumConnections*, uint, int>)(lpVtbl[4]))((IEnumConnections*)Unsafe.AsPointer(ref this), cConnections);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumConnections*, int>)(lpVtbl[5]))((IEnumConnections*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumConnections** ppEnum)
    {
        return ((delegate* unmanaged<IEnumConnections*, IEnumConnections**, int>)(lpVtbl[6]))((IEnumConnections*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint cConnections, [NativeTypeName("LPCONNECTDATA")] CONNECTDATA* rgcd, [NativeTypeName("ULONG *")] uint* pcFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint cConnections);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumConnections** ppEnum);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumConnections*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumConnections*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumConnections*, uint> Release;

        [NativeTypeName("HRESULT (ULONG, LPCONNECTDATA, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumConnections*, uint, CONNECTDATA*, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumConnections*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumConnections*, int> Reset;

        [NativeTypeName("HRESULT (IEnumConnections **) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumConnections*, IEnumConnections**, int> Clone;
    }
}
