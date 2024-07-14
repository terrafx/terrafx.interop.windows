// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneTriggerFactory.xml' path='doc/member[@name="IPhoneTriggerFactory"]/*' />
[Guid("A0D93CDA-5FC1-48FB-A546-32262040157B")]
[NativeTypeName("struct IPhoneTriggerFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneTriggerFactory : IPhoneTriggerFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneTriggerFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTriggerFactory*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneTriggerFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTriggerFactory*, uint>)(lpVtbl[1]))((IPhoneTriggerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTriggerFactory*, uint>)(lpVtbl[2]))((IPhoneTriggerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTriggerFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneTriggerFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTriggerFactory*, HSTRING*, int>)(lpVtbl[4]))((IPhoneTriggerFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTriggerFactory*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneTriggerFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneTriggerFactory.xml' path='doc/member[@name="IPhoneTriggerFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::ApplicationModel::Calls::Background::PhoneTriggerType")] PhoneTriggerType type, [NativeTypeName("boolean")] byte oneShot, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IPhoneTrigger **")] IPhoneTrigger** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneTriggerFactory*, PhoneTriggerType, byte, IPhoneTrigger**, int>)(lpVtbl[6]))((IPhoneTriggerFactory*)Unsafe.AsPointer(ref this), type, oneShot, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::ApplicationModel::Calls::Background::PhoneTriggerType")] PhoneTriggerType type, [NativeTypeName("boolean")] byte oneShot, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IPhoneTrigger **")] IPhoneTrigger** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::Background::PhoneTriggerType, boolean, ABI::Windows::ApplicationModel::Background::IPhoneTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneTriggerType, byte, IPhoneTrigger**, int> Create;
    }
}
