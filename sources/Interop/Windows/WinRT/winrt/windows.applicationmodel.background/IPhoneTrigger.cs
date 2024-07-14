// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneTrigger.xml' path='doc/member[@name="IPhoneTrigger"]/*' />
[Guid("8DCFE99B-D4C5-49F1-B7D3-82E87A0E9DDE")]
[NativeTypeName("struct IPhoneTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneTrigger : IPhoneTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneTrigger));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTrigger*, uint>)(lpVtbl[1]))((IPhoneTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTrigger*, uint>)(lpVtbl[2]))((IPhoneTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTrigger*, HSTRING*, int>)(lpVtbl[4]))((IPhoneTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneTrigger.xml' path='doc/member[@name="IPhoneTrigger.get_OneShot"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OneShot([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTrigger*, byte*, int>)(lpVtbl[6]))((IPhoneTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneTrigger.xml' path='doc/member[@name="IPhoneTrigger.get_TriggerType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TriggerType([NativeTypeName("ABI::Windows::ApplicationModel::Calls::Background::PhoneTriggerType *")] PhoneTriggerType* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTrigger*, PhoneTriggerType*, int>)(lpVtbl[7]))((IPhoneTrigger*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OneShot([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_TriggerType([NativeTypeName("ABI::Windows::ApplicationModel::Calls::Background::PhoneTriggerType *")] PhoneTriggerType* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::Background::PhoneTriggerType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneTriggerType*, int> get_TriggerType;
    }
}
