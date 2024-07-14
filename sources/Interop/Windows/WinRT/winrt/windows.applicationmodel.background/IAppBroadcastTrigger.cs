// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastTrigger.xml' path='doc/member[@name="IAppBroadcastTrigger"]/*' />
[Guid("74D4F496-8D37-44EC-9481-2A0B9854EB48")]
[NativeTypeName("struct IAppBroadcastTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastTrigger : IAppBroadcastTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastTrigger));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTrigger*, uint>)(lpVtbl[1]))((IAppBroadcastTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTrigger*, uint>)(lpVtbl[2]))((IAppBroadcastTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTrigger*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastTrigger.xml' path='doc/member[@name="IAppBroadcastTrigger.put_ProviderInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_ProviderInfo([NativeTypeName("ABI::Windows::ApplicationModel::Background::IAppBroadcastTriggerProviderInfo *")] IAppBroadcastTriggerProviderInfo* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTrigger*, IAppBroadcastTriggerProviderInfo*, int>)(lpVtbl[6]))((IAppBroadcastTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastTrigger.xml' path='doc/member[@name="IAppBroadcastTrigger.get_ProviderInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ProviderInfo([NativeTypeName("ABI::Windows::ApplicationModel::Background::IAppBroadcastTriggerProviderInfo **")] IAppBroadcastTriggerProviderInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTrigger*, IAppBroadcastTriggerProviderInfo**, int>)(lpVtbl[7]))((IAppBroadcastTrigger*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_ProviderInfo([NativeTypeName("ABI::Windows::ApplicationModel::Background::IAppBroadcastTriggerProviderInfo *")] IAppBroadcastTriggerProviderInfo* value);

        [VtblIndex(7)]
        HRESULT get_ProviderInfo([NativeTypeName("ABI::Windows::ApplicationModel::Background::IAppBroadcastTriggerProviderInfo **")] IAppBroadcastTriggerProviderInfo** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IAppBroadcastTriggerProviderInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastTriggerProviderInfo*, int> put_ProviderInfo;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IAppBroadcastTriggerProviderInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastTriggerProviderInfo**, int> get_ProviderInfo;
    }
}
