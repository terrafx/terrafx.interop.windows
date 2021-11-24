// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("B3E7C340-EF97-11CE-9BC9-00AA00608E01")]
[NativeTypeName("struct IEnumOleUndoUnits : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumOleUndoUnits : IEnumOleUndoUnits.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumOleUndoUnits*, Guid*, void**, int>)(lpVtbl[0]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumOleUndoUnits*, uint>)(lpVtbl[1]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumOleUndoUnits*, uint>)(lpVtbl[2]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint cElt, IOleUndoUnit** rgElt, [NativeTypeName("ULONG *")] uint* pcEltFetched)
    {
        return ((delegate* unmanaged<IEnumOleUndoUnits*, uint, IOleUndoUnit**, uint*, int>)(lpVtbl[3]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this), cElt, rgElt, pcEltFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint cElt)
    {
        return ((delegate* unmanaged<IEnumOleUndoUnits*, uint, int>)(lpVtbl[4]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this), cElt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumOleUndoUnits*, int>)(lpVtbl[5]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumOleUndoUnits** ppEnum)
    {
        return ((delegate* unmanaged<IEnumOleUndoUnits*, IEnumOleUndoUnits**, int>)(lpVtbl[6]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint cElt, IOleUndoUnit** rgElt, [NativeTypeName("ULONG *")] uint* pcEltFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint cElt);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumOleUndoUnits** ppEnum);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumOleUndoUnits*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumOleUndoUnits*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumOleUndoUnits*, uint> Release;

        [NativeTypeName("HRESULT (ULONG, IOleUndoUnit **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumOleUndoUnits*, uint, IOleUndoUnit**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumOleUndoUnits*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumOleUndoUnits*, int> Reset;

        [NativeTypeName("HRESULT (IEnumOleUndoUnits **) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumOleUndoUnits*, IEnumOleUndoUnits**, int> Clone;
    }
}
