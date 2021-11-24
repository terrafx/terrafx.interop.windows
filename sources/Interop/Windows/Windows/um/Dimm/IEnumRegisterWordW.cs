// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("4955DD31-B159-11D0-8FCF-00AA006BCC59")]
[NativeTypeName("struct IEnumRegisterWordW : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumRegisterWordW : IEnumRegisterWordW.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumRegisterWordW*, Guid*, void**, int>)(lpVtbl[0]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumRegisterWordW*, uint>)(lpVtbl[1]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumRegisterWordW*, uint>)(lpVtbl[2]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumRegisterWordW** ppEnum)
    {
        return ((delegate* unmanaged<IEnumRegisterWordW*, IEnumRegisterWordW**, int>)(lpVtbl[3]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this), ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, REGISTERWORDW* rgRegisterWord, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumRegisterWordW*, uint, REGISTERWORDW*, uint*, int>)(lpVtbl[4]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this), ulCount, rgRegisterWord, pcFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumRegisterWordW*, int>)(lpVtbl[5]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumRegisterWordW*, uint, int>)(lpVtbl[6]))((IEnumRegisterWordW*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumRegisterWordW** ppEnum);

        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, REGISTERWORDW* rgRegisterWord, [NativeTypeName("ULONG *")] uint* pcFetched);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("ULONG")] uint ulCount);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumRegisterWordW*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumRegisterWordW*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumRegisterWordW*, uint> Release;

        [NativeTypeName("HRESULT (IEnumRegisterWordW **) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumRegisterWordW*, IEnumRegisterWordW**, int> Clone;

        [NativeTypeName("HRESULT (ULONG, REGISTERWORDW *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumRegisterWordW*, uint, REGISTERWORDW*, uint*, int> Next;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumRegisterWordW*, int> Reset;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<IEnumRegisterWordW*, uint, int> Skip;
    }
}
