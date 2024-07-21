// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemTrigger.xml' path='doc/member[@name="ISystemTrigger"]/*' />
[Guid("1D80C776-3748-4463-8D7E-276DC139AC1C")]
[NativeTypeName("struct ISystemTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemTrigger : ISystemTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemTrigger));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemTrigger*, Guid*, void**, int>)(lpVtbl[0]))((ISystemTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemTrigger*, uint>)(lpVtbl[1]))((ISystemTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemTrigger*, uint>)(lpVtbl[2]))((ISystemTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemTrigger*, HSTRING*, int>)(lpVtbl[4]))((ISystemTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemTrigger*, TrustLevel*, int>)(lpVtbl[5]))((ISystemTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemTrigger.xml' path='doc/member[@name="ISystemTrigger.get_OneShot"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OneShot([NativeTypeName("boolean *")] byte* oneShot)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemTrigger*, byte*, int>)(lpVtbl[6]))((ISystemTrigger*)Unsafe.AsPointer(ref this), oneShot);
    }

    /// <include file='ISystemTrigger.xml' path='doc/member[@name="ISystemTrigger.get_TriggerType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TriggerType([NativeTypeName("ABI::Windows::ApplicationModel::Background::SystemTriggerType *")] SystemTriggerType* triggerType)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemTrigger*, SystemTriggerType*, int>)(lpVtbl[7]))((ISystemTrigger*)Unsafe.AsPointer(ref this), triggerType);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OneShot([NativeTypeName("boolean *")] byte* oneShot);

        [VtblIndex(7)]
        HRESULT get_TriggerType([NativeTypeName("ABI::Windows::ApplicationModel::Background::SystemTriggerType *")] SystemTriggerType* triggerType);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_OneShot;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::SystemTriggerType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SystemTriggerType*, int> get_TriggerType;
    }
}
