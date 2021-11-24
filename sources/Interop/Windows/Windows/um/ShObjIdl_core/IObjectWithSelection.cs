// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("1C9CD5BB-98E9-4491-A60F-31AACC72B83C")]
[NativeTypeName("struct IObjectWithSelection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IObjectWithSelection : IObjectWithSelection.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IObjectWithSelection*, Guid*, void**, int>)(lpVtbl[0]))((IObjectWithSelection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IObjectWithSelection*, uint>)(lpVtbl[1]))((IObjectWithSelection*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IObjectWithSelection*, uint>)(lpVtbl[2]))((IObjectWithSelection*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSelection(IShellItemArray* psia)
    {
        return ((delegate* unmanaged<IObjectWithSelection*, IShellItemArray*, int>)(lpVtbl[3]))((IObjectWithSelection*)Unsafe.AsPointer(ref this), psia);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSelection([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IObjectWithSelection*, Guid*, void**, int>)(lpVtbl[4]))((IObjectWithSelection*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSelection(IShellItemArray* psia);

        [VtblIndex(4)]
        HRESULT GetSelection([NativeTypeName("const IID &")] Guid* riid, void** ppv);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IObjectWithSelection*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IObjectWithSelection*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IObjectWithSelection*, uint> Release;

        [NativeTypeName("HRESULT (IShellItemArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<IObjectWithSelection*, IShellItemArray*, int> SetSelection;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IObjectWithSelection*, Guid*, void**, int> GetSelection;
    }
}
