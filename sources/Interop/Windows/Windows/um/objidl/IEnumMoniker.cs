// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("00000102-0000-0000-C000-000000000046")]
[NativeTypeName("struct IEnumMoniker : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumMoniker : IEnumMoniker.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumMoniker*, Guid*, void**, int>)(lpVtbl[0]))((IEnumMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumMoniker*, uint>)(lpVtbl[1]))((IEnumMoniker*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumMoniker*, uint>)(lpVtbl[2]))((IEnumMoniker*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, IMoniker** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IEnumMoniker*, uint, IMoniker**, uint*, int>)(lpVtbl[3]))((IEnumMoniker*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IEnumMoniker*, uint, int>)(lpVtbl[4]))((IEnumMoniker*)Unsafe.AsPointer(ref this), celt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumMoniker*, int>)(lpVtbl[5]))((IEnumMoniker*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumMoniker** ppenum)
    {
        return ((delegate* unmanaged<IEnumMoniker*, IEnumMoniker**, int>)(lpVtbl[6]))((IEnumMoniker*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, IMoniker** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumMoniker** ppenum);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumMoniker*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumMoniker*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumMoniker*, uint> Release;

        [NativeTypeName("HRESULT (ULONG, IMoniker **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumMoniker*, uint, IMoniker**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumMoniker*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumMoniker*, int> Reset;

        [NativeTypeName("HRESULT (IEnumMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumMoniker*, IEnumMoniker**, int> Clone;
    }
}
