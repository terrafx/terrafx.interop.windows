// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastNotificationHistoryChangedTriggerFactory.xml' path='doc/member[@name="IToastNotificationHistoryChangedTriggerFactory"]/*' />
[Guid("81C6FAAD-8797-4785-81B4-B0CCCB73D1D9")]
[NativeTypeName("struct IToastNotificationHistoryChangedTriggerFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotificationHistoryChangedTriggerFactory : IToastNotificationHistoryChangedTriggerFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotificationHistoryChangedTriggerFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistoryChangedTriggerFactory*, Guid*, void**, int>)(lpVtbl[0]))((IToastNotificationHistoryChangedTriggerFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistoryChangedTriggerFactory*, uint>)(lpVtbl[1]))((IToastNotificationHistoryChangedTriggerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistoryChangedTriggerFactory*, uint>)(lpVtbl[2]))((IToastNotificationHistoryChangedTriggerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistoryChangedTriggerFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IToastNotificationHistoryChangedTriggerFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistoryChangedTriggerFactory*, HSTRING*, int>)(lpVtbl[4]))((IToastNotificationHistoryChangedTriggerFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistoryChangedTriggerFactory*, TrustLevel*, int>)(lpVtbl[5]))((IToastNotificationHistoryChangedTriggerFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastNotificationHistoryChangedTriggerFactory.xml' path='doc/member[@name="IToastNotificationHistoryChangedTriggerFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(HSTRING applicationId, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")] IBackgroundTrigger** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistoryChangedTriggerFactory*, HSTRING, IBackgroundTrigger**, int>)(lpVtbl[6]))((IToastNotificationHistoryChangedTriggerFactory*)Unsafe.AsPointer(ref this), applicationId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(HSTRING applicationId, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")] IBackgroundTrigger** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IBackgroundTrigger**, int> Create;
    }
}
