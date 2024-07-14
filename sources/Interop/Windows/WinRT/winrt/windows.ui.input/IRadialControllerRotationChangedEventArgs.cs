// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRadialControllerRotationChangedEventArgs.xml' path='doc/member[@name="IRadialControllerRotationChangedEventArgs"]/*' />
[Guid("206AA435-E651-11E5-BF62-2C27D7404E85")]
[NativeTypeName("struct IRadialControllerRotationChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialControllerRotationChangedEventArgs : IRadialControllerRotationChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRadialControllerRotationChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerRotationChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerRotationChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerRotationChangedEventArgs*, uint>)(lpVtbl[1]))((IRadialControllerRotationChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerRotationChangedEventArgs*, uint>)(lpVtbl[2]))((IRadialControllerRotationChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerRotationChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerRotationChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerRotationChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IRadialControllerRotationChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerRotationChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerRotationChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRadialControllerRotationChangedEventArgs.xml' path='doc/member[@name="IRadialControllerRotationChangedEventArgs.get_RotationDeltaInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RotationDeltaInDegrees(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerRotationChangedEventArgs*, double*, int>)(lpVtbl[6]))((IRadialControllerRotationChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerRotationChangedEventArgs.xml' path='doc/member[@name="IRadialControllerRotationChangedEventArgs.get_Contact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Contact([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerScreenContact **")] IRadialControllerScreenContact** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerRotationChangedEventArgs*, IRadialControllerScreenContact**, int>)(lpVtbl[7]))((IRadialControllerRotationChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RotationDeltaInDegrees(double* value);

        [VtblIndex(7)]
        HRESULT get_Contact([NativeTypeName("ABI::Windows::UI::Input::IRadialControllerScreenContact **")] IRadialControllerScreenContact** value);
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

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_RotationDeltaInDegrees;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IRadialControllerScreenContact **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRadialControllerScreenContact**, int> get_Contact;
    }
}
