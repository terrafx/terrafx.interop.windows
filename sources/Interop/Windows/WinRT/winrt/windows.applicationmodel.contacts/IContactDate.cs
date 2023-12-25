// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactDate.xml' path='doc/member[@name="IContactDate"]/*' />
[Guid("FE98AE66-B205-4934-9174-0FF2B0565707")]
[NativeTypeName("struct IContactDate : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactDate : IContactDate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactDate));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, Guid*, void**, int>)(lpVtbl[0]))((IContactDate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, uint>)(lpVtbl[1]))((IContactDate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, uint>)(lpVtbl[2]))((IContactDate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, uint*, Guid**, int>)(lpVtbl[3]))((IContactDate*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, HSTRING*, int>)(lpVtbl[4]))((IContactDate*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, TrustLevel*, int>)(lpVtbl[5]))((IContactDate*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactDate.xml' path='doc/member[@name="IContactDate.get_Day"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Day([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, IReference<uint>**, int>)(lpVtbl[6]))((IContactDate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactDate.xml' path='doc/member[@name="IContactDate.put_Day"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Day([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, IReference<uint>*, int>)(lpVtbl[7]))((IContactDate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactDate.xml' path='doc/member[@name="IContactDate.get_Month"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Month([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, IReference<uint>**, int>)(lpVtbl[8]))((IContactDate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactDate.xml' path='doc/member[@name="IContactDate.put_Month"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Month([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, IReference<uint>*, int>)(lpVtbl[9]))((IContactDate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactDate.xml' path='doc/member[@name="IContactDate.get_Year"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Year([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, IReference<int>**, int>)(lpVtbl[10]))((IContactDate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactDate.xml' path='doc/member[@name="IContactDate.put_Year"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Year([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, IReference<int>*, int>)(lpVtbl[11]))((IContactDate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactDate.xml' path='doc/member[@name="IContactDate.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactDateKind *")] ContactDateKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, ContactDateKind*, int>)(lpVtbl[12]))((IContactDate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactDate.xml' path='doc/member[@name="IContactDate.put_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactDateKind")] ContactDateKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, ContactDateKind, int>)(lpVtbl[13]))((IContactDate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactDate.xml' path='doc/member[@name="IContactDate.get_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, HSTRING*, int>)(lpVtbl[14]))((IContactDate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactDate.xml' path='doc/member[@name="IContactDate.put_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Description(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactDate*, HSTRING, int>)(lpVtbl[15]))((IContactDate*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Day([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(7)]
        HRESULT put_Day([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);

        [VtblIndex(8)]
        HRESULT get_Month([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(9)]
        HRESULT put_Month([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);

        [VtblIndex(10)]
        HRESULT get_Year([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(11)]
        HRESULT put_Year([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(12)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactDateKind *")] ContactDateKind* value);

        [VtblIndex(13)]
        HRESULT put_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactDateKind")] ContactDateKind value);

        [VtblIndex(14)]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(15)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_Day;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_Day;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_Month;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_Month;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_Year;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_Year;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactDateKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactDateKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactDateKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactDateKind, int> put_Kind;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Description;
    }
}
