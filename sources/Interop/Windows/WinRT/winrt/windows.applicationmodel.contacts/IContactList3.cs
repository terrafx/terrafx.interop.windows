// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactList3.xml' path='doc/member[@name="IContactList3"]/*' />
[Guid("1578EE57-26FC-41E8-A850-5AA32514ACA9")]
[NativeTypeName("struct IContactList3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactList3 : IContactList3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactList3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList3*, Guid*, void**, int>)(lpVtbl[0]))((IContactList3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList3*, uint>)(lpVtbl[1]))((IContactList3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList3*, uint>)(lpVtbl[2]))((IContactList3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList3*, uint*, Guid**, int>)(lpVtbl[3]))((IContactList3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList3*, HSTRING*, int>)(lpVtbl[4]))((IContactList3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList3*, TrustLevel*, int>)(lpVtbl[5]))((IContactList3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactList3.xml' path='doc/member[@name="IContactList3.get_LimitedWriteOperations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LimitedWriteOperations([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactListLimitedWriteOperations **")] IContactListLimitedWriteOperations** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList3*, IContactListLimitedWriteOperations**, int>)(lpVtbl[6]))((IContactList3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList3.xml' path='doc/member[@name="IContactList3.GetChangeTracker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetChangeTracker(HSTRING identity, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **")] IContactChangeTracker** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList3*, HSTRING, IContactChangeTracker**, int>)(lpVtbl[7]))((IContactList3*)Unsafe.AsPointer(ref this), identity, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LimitedWriteOperations([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactListLimitedWriteOperations **")] IContactListLimitedWriteOperations** value);

        [VtblIndex(7)]
        HRESULT GetChangeTracker(HSTRING identity, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **")] IContactChangeTracker** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactListLimitedWriteOperations **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactListLimitedWriteOperations**, int> get_LimitedWriteOperations;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IContactChangeTracker**, int> GetChangeTracker;
    }
}
