// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRadialControllerConfiguration2.xml' path='doc/member[@name="IRadialControllerConfiguration2"]/*' />
[Guid("3D577EF7-3CEE-11E6-B535-001BDC06AB3B")]
[NativeTypeName("struct IRadialControllerConfiguration2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialControllerConfiguration2 : IRadialControllerConfiguration2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRadialControllerConfiguration2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfiguration2*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfiguration2*, uint>)(lpVtbl[1]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfiguration2*, uint>)(lpVtbl[2]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfiguration2*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfiguration2*, HSTRING*, int>)(lpVtbl[4]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfiguration2*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRadialControllerConfiguration2.xml' path='doc/member[@name="IRadialControllerConfiguration2.put_ActiveControllerWhenMenuIsSuppressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_ActiveControllerWhenMenuIsSuppressed([NativeTypeName("ABI::Windows::UI::Input::IRadialController *")] IRadialController* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfiguration2*, IRadialController*, int>)(lpVtbl[6]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerConfiguration2.xml' path='doc/member[@name="IRadialControllerConfiguration2.get_ActiveControllerWhenMenuIsSuppressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ActiveControllerWhenMenuIsSuppressed([NativeTypeName("ABI::Windows::UI::Input::IRadialController **")] IRadialController** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfiguration2*, IRadialController**, int>)(lpVtbl[7]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerConfiguration2.xml' path='doc/member[@name="IRadialControllerConfiguration2.put_IsMenuSuppressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_IsMenuSuppressed([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfiguration2*, byte, int>)(lpVtbl[8]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerConfiguration2.xml' path='doc/member[@name="IRadialControllerConfiguration2.get_IsMenuSuppressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsMenuSuppressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfiguration2*, byte*, int>)(lpVtbl[9]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_ActiveControllerWhenMenuIsSuppressed([NativeTypeName("ABI::Windows::UI::Input::IRadialController *")] IRadialController* value);

        [VtblIndex(7)]
        HRESULT get_ActiveControllerWhenMenuIsSuppressed([NativeTypeName("ABI::Windows::UI::Input::IRadialController **")] IRadialController** value);

        [VtblIndex(8)]
        HRESULT put_IsMenuSuppressed([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_IsMenuSuppressed([NativeTypeName("boolean *")] byte* value);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IRadialController *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRadialController*, int> put_ActiveControllerWhenMenuIsSuppressed;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IRadialController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRadialController**, int> get_ActiveControllerWhenMenuIsSuppressed;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsMenuSuppressed;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMenuSuppressed;
    }
}
