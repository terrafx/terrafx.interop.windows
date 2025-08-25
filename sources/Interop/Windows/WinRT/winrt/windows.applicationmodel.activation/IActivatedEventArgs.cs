// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IActivatedEventArgs.xml' path='doc/member[@name="IActivatedEventArgs"]/*' />
[Guid("CF651713-CD08-4FD8-B697-A281B6544E2E")]
[NativeTypeName("struct IActivatedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IActivatedEventArgs : IActivatedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IActivatedEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivatedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IActivatedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IActivatedEventArgs*, uint>)(lpVtbl[1]))((IActivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IActivatedEventArgs*, uint>)(lpVtbl[2]))((IActivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivatedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IActivatedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivatedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IActivatedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivatedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IActivatedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IActivatedEventArgs.xml' path='doc/member[@name="IActivatedEventArgs.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Activation::ActivationKind *")] ActivationKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivatedEventArgs*, ActivationKind*, int>)(lpVtbl[6]))((IActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActivatedEventArgs.xml' path='doc/member[@name="IActivatedEventArgs.get_PreviousExecutionState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PreviousExecutionState([NativeTypeName("ABI::Windows::ApplicationModel::Activation::ApplicationExecutionState *")] ApplicationExecutionState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivatedEventArgs*, ApplicationExecutionState*, int>)(lpVtbl[7]))((IActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IActivatedEventArgs.xml' path='doc/member[@name="IActivatedEventArgs.get_SplashScreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SplashScreen([NativeTypeName("ABI::Windows::ApplicationModel::Activation::ISplashScreen **")] ISplashScreen** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivatedEventArgs*, ISplashScreen**, int>)(lpVtbl[8]))((IActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Activation::ActivationKind *")] ActivationKind* value);

        [VtblIndex(7)]
        HRESULT get_PreviousExecutionState([NativeTypeName("ABI::Windows::ApplicationModel::Activation::ApplicationExecutionState *")] ApplicationExecutionState* value);

        [VtblIndex(8)]
        HRESULT get_SplashScreen([NativeTypeName("ABI::Windows::ApplicationModel::Activation::ISplashScreen **")] ISplashScreen** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Activation::ActivationKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ActivationKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Activation::ApplicationExecutionState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ApplicationExecutionState*, int> get_PreviousExecutionState;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Activation::ISplashScreen **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISplashScreen**, int> get_SplashScreen;
    }
}
