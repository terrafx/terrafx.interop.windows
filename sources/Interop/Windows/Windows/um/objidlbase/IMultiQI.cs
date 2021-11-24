// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("00000020-0000-0000-C000-000000000046")]
[NativeTypeName("struct IMultiQI : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMultiQI : IMultiQI.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMultiQI*, Guid*, void**, int>)(lpVtbl[0]))((IMultiQI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMultiQI*, uint>)(lpVtbl[1]))((IMultiQI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMultiQI*, uint>)(lpVtbl[2]))((IMultiQI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryMultipleInterfaces([NativeTypeName("ULONG")] uint cMQIs, MULTI_QI* pMQIs)
    {
        return ((delegate* unmanaged<IMultiQI*, uint, MULTI_QI*, int>)(lpVtbl[3]))((IMultiQI*)Unsafe.AsPointer(ref this), cMQIs, pMQIs);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryMultipleInterfaces([NativeTypeName("ULONG")] uint cMQIs, MULTI_QI* pMQIs);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMultiQI*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMultiQI*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMultiQI*, uint> Release;

        [NativeTypeName("HRESULT (ULONG, MULTI_QI *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMultiQI*, uint, MULTI_QI*, int> QueryMultipleInterfaces;
    }
}
