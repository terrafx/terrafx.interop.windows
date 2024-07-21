// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactCardOptions.xml' path='doc/member[@name="IContactCardOptions"]/*' />
[Guid("8C0A4F7E-6AB6-4F3F-BE72-817236EEEA5B")]
[NativeTypeName("struct IContactCardOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactCardOptions : IContactCardOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactCardOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactCardOptions*, Guid*, void**, int>)(lpVtbl[0]))((IContactCardOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactCardOptions*, uint>)(lpVtbl[1]))((IContactCardOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactCardOptions*, uint>)(lpVtbl[2]))((IContactCardOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactCardOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IContactCardOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactCardOptions*, HSTRING*, int>)(lpVtbl[4]))((IContactCardOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactCardOptions*, TrustLevel*, int>)(lpVtbl[5]))((IContactCardOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactCardOptions.xml' path='doc/member[@name="IContactCardOptions.get_HeaderKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_HeaderKind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardHeaderKind *")] ContactCardHeaderKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactCardOptions*, ContactCardHeaderKind*, int>)(lpVtbl[6]))((IContactCardOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactCardOptions.xml' path='doc/member[@name="IContactCardOptions.put_HeaderKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_HeaderKind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardHeaderKind")] ContactCardHeaderKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactCardOptions*, ContactCardHeaderKind, int>)(lpVtbl[7]))((IContactCardOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactCardOptions.xml' path='doc/member[@name="IContactCardOptions.get_InitialTabKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InitialTabKind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardTabKind *")] ContactCardTabKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactCardOptions*, ContactCardTabKind*, int>)(lpVtbl[8]))((IContactCardOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactCardOptions.xml' path='doc/member[@name="IContactCardOptions.put_InitialTabKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_InitialTabKind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardTabKind")] ContactCardTabKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactCardOptions*, ContactCardTabKind, int>)(lpVtbl[9]))((IContactCardOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_HeaderKind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardHeaderKind *")] ContactCardHeaderKind* value);

        [VtblIndex(7)]
        HRESULT put_HeaderKind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardHeaderKind")] ContactCardHeaderKind value);

        [VtblIndex(8)]
        HRESULT get_InitialTabKind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardTabKind *")] ContactCardTabKind* value);

        [VtblIndex(9)]
        HRESULT put_InitialTabKind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactCardTabKind")] ContactCardTabKind value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactCardHeaderKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactCardHeaderKind*, int> get_HeaderKind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactCardHeaderKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactCardHeaderKind, int> put_HeaderKind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactCardTabKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactCardTabKind*, int> get_InitialTabKind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactCardTabKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactCardTabKind, int> put_InitialTabKind;
    }
}
