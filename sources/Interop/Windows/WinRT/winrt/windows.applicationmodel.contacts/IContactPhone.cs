// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactPhone.xml' path='doc/member[@name="IContactPhone"]/*' />
[Guid("467DAB65-2712-4F52-B783-9EA8111C63CD")]
[NativeTypeName("struct IContactPhone : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactPhone : IContactPhone.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactPhone));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPhone*, Guid*, void**, int>)(lpVtbl[0]))((IContactPhone*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPhone*, uint>)(lpVtbl[1]))((IContactPhone*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPhone*, uint>)(lpVtbl[2]))((IContactPhone*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPhone*, uint*, Guid**, int>)(lpVtbl[3]))((IContactPhone*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPhone*, HSTRING*, int>)(lpVtbl[4]))((IContactPhone*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPhone*, TrustLevel*, int>)(lpVtbl[5]))((IContactPhone*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactPhone.xml' path='doc/member[@name="IContactPhone.get_Number"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Number(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPhone*, HSTRING*, int>)(lpVtbl[6]))((IContactPhone*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPhone.xml' path='doc/member[@name="IContactPhone.put_Number"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Number(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPhone*, HSTRING, int>)(lpVtbl[7]))((IContactPhone*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPhone.xml' path='doc/member[@name="IContactPhone.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactPhoneKind *")] ContactPhoneKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPhone*, ContactPhoneKind*, int>)(lpVtbl[8]))((IContactPhone*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPhone.xml' path='doc/member[@name="IContactPhone.put_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactPhoneKind")] ContactPhoneKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPhone*, ContactPhoneKind, int>)(lpVtbl[9]))((IContactPhone*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPhone.xml' path='doc/member[@name="IContactPhone.get_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPhone*, HSTRING*, int>)(lpVtbl[10]))((IContactPhone*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPhone.xml' path='doc/member[@name="IContactPhone.put_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Description(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPhone*, HSTRING, int>)(lpVtbl[11]))((IContactPhone*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Number(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Number(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactPhoneKind *")] ContactPhoneKind* value);

        [VtblIndex(9)]
        HRESULT put_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactPhoneKind")] ContactPhoneKind value);

        [VtblIndex(10)]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_Description(HSTRING value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Number;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Number;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactPhoneKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactPhoneKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactPhoneKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactPhoneKind, int> put_Kind;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Description;
    }
}
