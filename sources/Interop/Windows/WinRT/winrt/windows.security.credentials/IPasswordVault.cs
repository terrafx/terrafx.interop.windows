// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPasswordVault.xml' path='doc/member[@name="IPasswordVault"]/*' />
[Guid("61FD2C0B-C8D4-48C1-A54F-BC5A64205AF2")]
[NativeTypeName("struct IPasswordVault : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPasswordVault : IPasswordVault.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPasswordVault));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordVault*, Guid*, void**, int>)(lpVtbl[0]))((IPasswordVault*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordVault*, uint>)(lpVtbl[1]))((IPasswordVault*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordVault*, uint>)(lpVtbl[2]))((IPasswordVault*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordVault*, uint*, Guid**, int>)(lpVtbl[3]))((IPasswordVault*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordVault*, HSTRING*, int>)(lpVtbl[4]))((IPasswordVault*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordVault*, TrustLevel*, int>)(lpVtbl[5]))((IPasswordVault*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPasswordVault.xml' path='doc/member[@name="IPasswordVault.Add"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Add([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* credential)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordVault*, IPasswordCredential*, int>)(lpVtbl[6]))((IPasswordVault*)Unsafe.AsPointer(ref this), credential);
    }

    /// <include file='IPasswordVault.xml' path='doc/member[@name="IPasswordVault.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Remove([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* credential)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordVault*, IPasswordCredential*, int>)(lpVtbl[7]))((IPasswordVault*)Unsafe.AsPointer(ref this), credential);
    }

    /// <include file='IPasswordVault.xml' path='doc/member[@name="IPasswordVault.Retrieve"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Retrieve(HSTRING resource, HSTRING userName, [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")] IPasswordCredential** credential)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordVault*, HSTRING, HSTRING, IPasswordCredential**, int>)(lpVtbl[8]))((IPasswordVault*)Unsafe.AsPointer(ref this), resource, userName, credential);
    }

    /// <include file='IPasswordVault.xml' path='doc/member[@name="IPasswordVault.FindAllByResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindAllByResource(HSTRING resource, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **")] IVectorView<IntPtr>** credentials)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordVault*, HSTRING, IVectorView<IntPtr>**, int>)(lpVtbl[9]))((IPasswordVault*)Unsafe.AsPointer(ref this), resource, credentials);
    }

    /// <include file='IPasswordVault.xml' path='doc/member[@name="IPasswordVault.FindAllByUserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindAllByUserName(HSTRING userName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **")] IVectorView<IntPtr>** credentials)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordVault*, HSTRING, IVectorView<IntPtr>**, int>)(lpVtbl[10]))((IPasswordVault*)Unsafe.AsPointer(ref this), userName, credentials);
    }

    /// <include file='IPasswordVault.xml' path='doc/member[@name="IPasswordVault.RetrieveAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RetrieveAll([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **")] IVectorView<IntPtr>** credentials)
    {
        return ((delegate* unmanaged[MemberFunction]<IPasswordVault*, IVectorView<IntPtr>**, int>)(lpVtbl[11]))((IPasswordVault*)Unsafe.AsPointer(ref this), credentials);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Add([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* credential);

        [VtblIndex(7)]
        HRESULT Remove([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* credential);

        [VtblIndex(8)]
        HRESULT Retrieve(HSTRING resource, HSTRING userName, [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")] IPasswordCredential** credential);

        [VtblIndex(9)]
        HRESULT FindAllByResource(HSTRING resource, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **")] IVectorView<IntPtr>** credentials);

        [VtblIndex(10)]
        HRESULT FindAllByUserName(HSTRING userName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **")] IVectorView<IntPtr>** credentials);

        [VtblIndex(11)]
        HRESULT RetrieveAll([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **")] IVectorView<IntPtr>** credentials);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPasswordCredential*, int> Add;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPasswordCredential*, int> Remove;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::Credentials::IPasswordCredential **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IPasswordCredential**, int> Retrieve;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IVectorView<IntPtr>**, int> FindAllByResource;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IVectorView<IntPtr>**, int> FindAllByUserName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> RetrieveAll;
    }
}
