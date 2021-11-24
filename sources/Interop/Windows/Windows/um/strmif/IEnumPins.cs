// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("56A86892-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IEnumPins : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumPins : IEnumPins.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumPins*, Guid*, void**, int>)(lpVtbl[0]))((IEnumPins*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumPins*, uint>)(lpVtbl[1]))((IEnumPins*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumPins*, uint>)(lpVtbl[2]))((IEnumPins*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint cPins, IPin** ppPins, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumPins*, uint, IPin**, uint*, int>)(lpVtbl[3]))((IEnumPins*)Unsafe.AsPointer(ref this), cPins, ppPins, pcFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint cPins)
    {
        return ((delegate* unmanaged<IEnumPins*, uint, int>)(lpVtbl[4]))((IEnumPins*)Unsafe.AsPointer(ref this), cPins);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumPins*, int>)(lpVtbl[5]))((IEnumPins*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumPins** ppEnum)
    {
        return ((delegate* unmanaged<IEnumPins*, IEnumPins**, int>)(lpVtbl[6]))((IEnumPins*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint cPins, IPin** ppPins, [NativeTypeName("ULONG *")] uint* pcFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint cPins);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumPins** ppEnum);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumPins*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumPins*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumPins*, uint> Release;

        [NativeTypeName("HRESULT (ULONG, IPin **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumPins*, uint, IPin**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumPins*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumPins*, int> Reset;

        [NativeTypeName("HRESULT (IEnumPins **) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumPins*, IEnumPins**, int> Clone;
    }
}
