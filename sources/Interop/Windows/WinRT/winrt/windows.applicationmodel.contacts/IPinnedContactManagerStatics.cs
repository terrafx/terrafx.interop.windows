// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPinnedContactManagerStatics.xml' path='doc/member[@name="IPinnedContactManagerStatics"]/*' />
[Guid("F65CCC7E-FDF9-486A-ACE9-BC311D0AE7F0")]
[NativeTypeName("struct IPinnedContactManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPinnedContactManagerStatics : IPinnedContactManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPinnedContactManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPinnedContactManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManagerStatics*, uint>)(lpVtbl[1]))((IPinnedContactManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManagerStatics*, uint>)(lpVtbl[2]))((IPinnedContactManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPinnedContactManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IPinnedContactManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPinnedContactManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPinnedContactManagerStatics.xml' path='doc/member[@name="IPinnedContactManagerStatics.GetDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefault([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IPinnedContactManager **")] IPinnedContactManager** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManagerStatics*, IPinnedContactManager**, int>)(lpVtbl[6]))((IPinnedContactManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPinnedContactManagerStatics.xml' path='doc/member[@name="IPinnedContactManagerStatics.GetForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IPinnedContactManager **")] IPinnedContactManager** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManagerStatics*, IUser*, IPinnedContactManager**, int>)(lpVtbl[7]))((IPinnedContactManagerStatics*)Unsafe.AsPointer(ref this), user, result);
    }

    /// <include file='IPinnedContactManagerStatics.xml' path='doc/member[@name="IPinnedContactManagerStatics.IsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsSupported([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPinnedContactManagerStatics*, byte*, int>)(lpVtbl[8]))((IPinnedContactManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefault([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IPinnedContactManager **")] IPinnedContactManager** result);

        [VtblIndex(7)]
        HRESULT GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IPinnedContactManager **")] IPinnedContactManager** result);

        [VtblIndex(8)]
        HRESULT IsSupported([NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IPinnedContactManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPinnedContactManager**, int> GetDefault;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::ApplicationModel::Contacts::IPinnedContactManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IPinnedContactManager**, int> GetForUser;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> IsSupported;
    }
}
