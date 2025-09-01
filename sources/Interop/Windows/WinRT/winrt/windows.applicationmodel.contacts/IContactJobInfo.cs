// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo"]/*' />
[Guid("6D117B4C-CE50-4B43-9E69-B18258EA5315")]
[NativeTypeName("struct IContactJobInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactJobInfo : IContactJobInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IContactJobInfo);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, Guid*, void**, int>)(lpVtbl[0]))((IContactJobInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, uint>)(lpVtbl[1]))((IContactJobInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, uint>)(lpVtbl[2]))((IContactJobInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IContactJobInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING*, int>)(lpVtbl[4]))((IContactJobInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, TrustLevel*, int>)(lpVtbl[5]))((IContactJobInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.get_CompanyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CompanyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING*, int>)(lpVtbl[6]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.put_CompanyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CompanyName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING, int>)(lpVtbl[7]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.get_CompanyYomiName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CompanyYomiName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING*, int>)(lpVtbl[8]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.put_CompanyYomiName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CompanyYomiName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING, int>)(lpVtbl[9]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.get_Department"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Department(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING*, int>)(lpVtbl[10]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.put_Department"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Department(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING, int>)(lpVtbl[11]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING*, int>)(lpVtbl[12]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING, int>)(lpVtbl[13]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.get_Manager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Manager(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING*, int>)(lpVtbl[14]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.put_Manager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Manager(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING, int>)(lpVtbl[15]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.get_Office"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Office(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING*, int>)(lpVtbl[16]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.put_Office"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Office(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING, int>)(lpVtbl[17]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.get_CompanyAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_CompanyAddress(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING*, int>)(lpVtbl[18]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.put_CompanyAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_CompanyAddress(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING, int>)(lpVtbl[19]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.get_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING*, int>)(lpVtbl[20]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactJobInfo.xml' path='doc/member[@name="IContactJobInfo.put_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_Description(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactJobInfo*, HSTRING, int>)(lpVtbl[21]))((IContactJobInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CompanyName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_CompanyName(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_CompanyYomiName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_CompanyYomiName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Department(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_Department(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_Manager(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_Manager(HSTRING value);

        [VtblIndex(16)]
        HRESULT get_Office(HSTRING* value);

        [VtblIndex(17)]
        HRESULT put_Office(HSTRING value);

        [VtblIndex(18)]
        HRESULT get_CompanyAddress(HSTRING* value);

        [VtblIndex(19)]
        HRESULT put_CompanyAddress(HSTRING value);

        [VtblIndex(20)]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(21)]
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CompanyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CompanyName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CompanyYomiName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CompanyYomiName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Department;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Department;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Manager;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Manager;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Office;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Office;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CompanyAddress;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CompanyAddress;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Description;
    }
}
