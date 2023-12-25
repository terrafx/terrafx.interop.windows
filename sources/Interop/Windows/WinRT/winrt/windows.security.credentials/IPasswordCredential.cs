// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPasswordCredential.xml' path='doc/member[@name="IPasswordCredential"]/*' />
[Guid("6AB18989-C720-41A7-A6C1-FEADB36329A0")]
[NativeTypeName("struct IPasswordCredential : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPasswordCredential : IPasswordCredential.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPasswordCredential));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, Guid*, void**, int>)(lpVtbl[0]))((IPasswordCredential*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, uint>)(lpVtbl[1]))((IPasswordCredential*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, uint>)(lpVtbl[2]))((IPasswordCredential*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, uint*, Guid**, int>)(lpVtbl[3]))((IPasswordCredential*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, HSTRING*, int>)(lpVtbl[4]))((IPasswordCredential*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, TrustLevel*, int>)(lpVtbl[5]))((IPasswordCredential*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPasswordCredential.xml' path='doc/member[@name="IPasswordCredential.get_Resource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Resource(HSTRING* resource)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, HSTRING*, int>)(lpVtbl[6]))((IPasswordCredential*)Unsafe.AsPointer(ref this), resource);
    }

    /// <include file='IPasswordCredential.xml' path='doc/member[@name="IPasswordCredential.put_Resource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Resource(HSTRING resource)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, HSTRING, int>)(lpVtbl[7]))((IPasswordCredential*)Unsafe.AsPointer(ref this), resource);
    }

    /// <include file='IPasswordCredential.xml' path='doc/member[@name="IPasswordCredential.get_UserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UserName(HSTRING* userName)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, HSTRING*, int>)(lpVtbl[8]))((IPasswordCredential*)Unsafe.AsPointer(ref this), userName);
    }

    /// <include file='IPasswordCredential.xml' path='doc/member[@name="IPasswordCredential.put_UserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_UserName(HSTRING userName)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, HSTRING, int>)(lpVtbl[9]))((IPasswordCredential*)Unsafe.AsPointer(ref this), userName);
    }

    /// <include file='IPasswordCredential.xml' path='doc/member[@name="IPasswordCredential.get_Password"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Password(HSTRING* password)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, HSTRING*, int>)(lpVtbl[10]))((IPasswordCredential*)Unsafe.AsPointer(ref this), password);
    }

    /// <include file='IPasswordCredential.xml' path='doc/member[@name="IPasswordCredential.put_Password"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Password(HSTRING password)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, HSTRING, int>)(lpVtbl[11]))((IPasswordCredential*)Unsafe.AsPointer(ref this), password);
    }

    /// <include file='IPasswordCredential.xml' path='doc/member[@name="IPasswordCredential.RetrievePassword"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RetrievePassword()
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, int>)(lpVtbl[12]))((IPasswordCredential*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPasswordCredential.xml' path='doc/member[@name="IPasswordCredential.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** props)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordCredential*, IPropertySet**, int>)(lpVtbl[13]))((IPasswordCredential*)Unsafe.AsPointer(ref this), props);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Resource(HSTRING* resource);

        [VtblIndex(7)]
        HRESULT put_Resource(HSTRING resource);

        [VtblIndex(8)]
        HRESULT get_UserName(HSTRING* userName);

        [VtblIndex(9)]
        HRESULT put_UserName(HSTRING userName);

        [VtblIndex(10)]
        HRESULT get_Password(HSTRING* password);

        [VtblIndex(11)]
        HRESULT put_Password(HSTRING password);

        [VtblIndex(12)]
        HRESULT RetrievePassword();

        [VtblIndex(13)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** props);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Resource;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Resource;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_UserName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Password;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Password;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RetrievePassword;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_Properties;
    }
}
