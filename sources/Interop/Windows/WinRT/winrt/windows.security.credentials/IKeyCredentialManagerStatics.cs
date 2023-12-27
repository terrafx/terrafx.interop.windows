// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyCredentialManagerStatics.xml' path='doc/member[@name="IKeyCredentialManagerStatics"]/*' />
[Guid("6AAC468B-0EF1-4CE0-8290-4106DA6A63B5")]
[NativeTypeName("struct IKeyCredentialManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyCredentialManagerStatics : IKeyCredentialManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKeyCredentialManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKeyCredentialManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics*, uint>)(lpVtbl[1]))((IKeyCredentialManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics*, uint>)(lpVtbl[2]))((IKeyCredentialManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyCredentialManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IKeyCredentialManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKeyCredentialManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyCredentialManagerStatics.xml' path='doc/member[@name="IKeyCredentialManagerStatics.IsSupportedAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsSupportedAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics*, IAsyncOperation<bool>**, int>)(lpVtbl[6]))((IKeyCredentialManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyCredentialManagerStatics.xml' path='doc/member[@name="IKeyCredentialManagerStatics.RenewAttestationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RenewAttestationAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics*, IAsyncAction**, int>)(lpVtbl[7]))((IKeyCredentialManagerStatics*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IKeyCredentialManagerStatics.xml' path='doc/member[@name="IKeyCredentialManagerStatics.RequestCreateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestCreateAsync(HSTRING name, [NativeTypeName("ABI::Windows::Security::Credentials::KeyCredentialCreationOption")] KeyCredentialCreationOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **")] IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics*, HSTRING, KeyCredentialCreationOption, IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>**, int>)(lpVtbl[8]))((IKeyCredentialManagerStatics*)Unsafe.AsPointer(ref this), name, option, value);
    }

    /// <include file='IKeyCredentialManagerStatics.xml' path='doc/member[@name="IKeyCredentialManagerStatics.OpenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **")] IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics*, HSTRING, IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>**, int>)(lpVtbl[9]))((IKeyCredentialManagerStatics*)Unsafe.AsPointer(ref this), name, value);
    }

    /// <include file='IKeyCredentialManagerStatics.xml' path='doc/member[@name="IKeyCredentialManagerStatics.DeleteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeleteAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics*, HSTRING, IAsyncAction**, int>)(lpVtbl[10]))((IKeyCredentialManagerStatics*)Unsafe.AsPointer(ref this), name, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsSupportedAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** value);

        [VtblIndex(7)]
        HRESULT RenewAttestationAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(8)]
        HRESULT RequestCreateAsync(HSTRING name, [NativeTypeName("ABI::Windows::Security::Credentials::KeyCredentialCreationOption")] KeyCredentialCreationOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **")] IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>** value);

        [VtblIndex(9)]
        HRESULT OpenAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **")] IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>** value);

        [VtblIndex(10)]
        HRESULT DeleteAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<bool>**, int> IsSupportedAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> RenewAttestationAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Security::Credentials::KeyCredentialCreationOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, KeyCredentialCreationOption, IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>**, int> RequestCreateAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>**, int> OpenAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> DeleteAsync;
    }
}
