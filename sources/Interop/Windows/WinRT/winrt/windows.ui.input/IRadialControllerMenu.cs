// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRadialControllerMenu.xml' path='doc/member[@name="IRadialControllerMenu"]/*' />
[Guid("8506B35D-F640-4412-ABA0-BAD077E5EA8A")]
[NativeTypeName("struct IRadialControllerMenu : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialControllerMenu : IRadialControllerMenu.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRadialControllerMenu);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenu*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenu*, uint>)(lpVtbl[1]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenu*, uint>)(lpVtbl[2]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenu*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenu*, HSTRING*, int>)(lpVtbl[4]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenu*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRadialControllerMenu.xml' path='doc/member[@name="IRadialControllerMenu.get_Items"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Items([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CRadialControllerMenuItem_t **")] IVector<Pointer<IRadialControllerMenuItem>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenu*, IVector<Pointer<IRadialControllerMenuItem>>**, int>)(lpVtbl[6]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerMenu.xml' path='doc/member[@name="IRadialControllerMenu.get_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenu*, byte*, int>)(lpVtbl[7]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerMenu.xml' path='doc/member[@name="IRadialControllerMenu.put_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenu*, byte, int>)(lpVtbl[8]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerMenu.xml' path='doc/member[@name="IRadialControllerMenu.GetSelectedMenuItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSelectedMenuItem([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenu*, IRadialControllerMenuItem**, int>)(lpVtbl[9]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IRadialControllerMenu.xml' path='doc/member[@name="IRadialControllerMenu.SelectMenuItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SelectMenuItem([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem *")] IRadialControllerMenuItem* menuItem)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenu*, IRadialControllerMenuItem*, int>)(lpVtbl[10]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), menuItem);
    }

    /// <include file='IRadialControllerMenu.xml' path='doc/member[@name="IRadialControllerMenu.TrySelectPreviouslySelectedMenuItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TrySelectPreviouslySelectedMenuItem([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerMenu*, byte*, int>)(lpVtbl[11]))((IRadialControllerMenu*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Items([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CRadialControllerMenuItem_t **")] IVector<Pointer<IRadialControllerMenuItem>>** value);

        [VtblIndex(7)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT GetSelectedMenuItem([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result);

        [VtblIndex(10)]
        HRESULT SelectMenuItem([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem *")] IRadialControllerMenuItem* menuItem);

        [VtblIndex(11)]
        HRESULT TrySelectPreviouslySelectedMenuItem([NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CRadialControllerMenuItem_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IRadialControllerMenuItem>>**, int> get_Items;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IRadialControllerMenuItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRadialControllerMenuItem**, int> GetSelectedMenuItem;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IRadialControllerMenuItem *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRadialControllerMenuItem*, int> SelectMenuItem;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> TrySelectPreviouslySelectedMenuItem;
    }
}
