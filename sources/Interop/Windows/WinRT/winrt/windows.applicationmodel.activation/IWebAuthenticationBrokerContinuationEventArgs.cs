// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAuthenticationBrokerContinuationEventArgs.xml' path='doc/member[@name="IWebAuthenticationBrokerContinuationEventArgs"]/*' />
[Guid("75DDA3D4-7714-453D-B7FF-B95E3A1709DA")]
[NativeTypeName("struct IWebAuthenticationBrokerContinuationEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationBrokerContinuationEventArgs : IWebAuthenticationBrokerContinuationEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWebAuthenticationBrokerContinuationEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerContinuationEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationBrokerContinuationEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerContinuationEventArgs*, uint>)(lpVtbl[1]))((IWebAuthenticationBrokerContinuationEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerContinuationEventArgs*, uint>)(lpVtbl[2]))((IWebAuthenticationBrokerContinuationEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerContinuationEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationBrokerContinuationEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerContinuationEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationBrokerContinuationEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerContinuationEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationBrokerContinuationEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAuthenticationBrokerContinuationEventArgs.xml' path='doc/member[@name="IWebAuthenticationBrokerContinuationEventArgs.get_WebAuthenticationResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_WebAuthenticationResult([NativeTypeName("ABI::Windows::Security::Authentication::Web::IWebAuthenticationResult **")] IWebAuthenticationResult** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerContinuationEventArgs*, IWebAuthenticationResult**, int>)(lpVtbl[6]))((IWebAuthenticationBrokerContinuationEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_WebAuthenticationResult([NativeTypeName("ABI::Windows::Security::Authentication::Web::IWebAuthenticationResult **")] IWebAuthenticationResult** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::IWebAuthenticationResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAuthenticationResult**, int> get_WebAuthenticationResult;
    }
}
