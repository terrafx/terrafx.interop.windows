// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRadialControllerConfigurationStatics2.xml' path='doc/member[@name="IRadialControllerConfigurationStatics2"]/*' />
[Guid("53E08B17-E205-48D3-9CAF-80FF47C4D7C7")]
[NativeTypeName("struct IRadialControllerConfigurationStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialControllerConfigurationStatics2 : IRadialControllerConfigurationStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRadialControllerConfigurationStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfigurationStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfigurationStatics2*, uint>)(lpVtbl[1]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfigurationStatics2*, uint>)(lpVtbl[2]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfigurationStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfigurationStatics2*, HSTRING*, int>)(lpVtbl[4]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfigurationStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRadialControllerConfigurationStatics2.xml' path='doc/member[@name="IRadialControllerConfigurationStatics2.put_AppController"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_AppController([NativeTypeName("ABI::Windows::UI::Input::IRadialController *")] IRadialController* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfigurationStatics2*, IRadialController*, int>)(lpVtbl[6]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerConfigurationStatics2.xml' path='doc/member[@name="IRadialControllerConfigurationStatics2.get_AppController"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AppController([NativeTypeName("ABI::Windows::UI::Input::IRadialController **")] IRadialController** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfigurationStatics2*, IRadialController**, int>)(lpVtbl[7]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerConfigurationStatics2.xml' path='doc/member[@name="IRadialControllerConfigurationStatics2.put_IsAppControllerEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_IsAppControllerEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfigurationStatics2*, byte, int>)(lpVtbl[8]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerConfigurationStatics2.xml' path='doc/member[@name="IRadialControllerConfigurationStatics2.get_IsAppControllerEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsAppControllerEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerConfigurationStatics2*, byte*, int>)(lpVtbl[9]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_AppController([NativeTypeName("ABI::Windows::UI::Input::IRadialController *")] IRadialController* value);

        [VtblIndex(7)]
        HRESULT get_AppController([NativeTypeName("ABI::Windows::UI::Input::IRadialController **")] IRadialController** value);

        [VtblIndex(8)]
        HRESULT put_IsAppControllerEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_IsAppControllerEnabled([NativeTypeName("boolean *")] byte* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IRadialController*, int> put_AppController;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IRadialController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRadialController**, int> get_AppController;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsAppControllerEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAppControllerEnabled;
    }
}
