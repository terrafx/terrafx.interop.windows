// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("9BFBBC02-EFF1-101A-84ED-00AA00341D07")]
[NativeTypeName("struct IPropertyNotifySink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyNotifySink : IPropertyNotifySink.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyNotifySink*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyNotifySink*, uint>)(lpVtbl[1]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyNotifySink*, uint>)(lpVtbl[2]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnChanged([NativeTypeName("DISPID")] int dispID)
    {
        return ((delegate* unmanaged<IPropertyNotifySink*, int, int>)(lpVtbl[3]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this), dispID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnRequestEdit([NativeTypeName("DISPID")] int dispID)
    {
        return ((delegate* unmanaged<IPropertyNotifySink*, int, int>)(lpVtbl[4]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this), dispID);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnChanged([NativeTypeName("DISPID")] int dispID);

        [VtblIndex(4)]
        HRESULT OnRequestEdit([NativeTypeName("DISPID")] int dispID);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IPropertyNotifySink*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IPropertyNotifySink*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IPropertyNotifySink*, uint> Release;

        [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
        public delegate* unmanaged<IPropertyNotifySink*, int, int> OnChanged;

        [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
        public delegate* unmanaged<IPropertyNotifySink*, int, int> OnRequestEdit;
    }
}
