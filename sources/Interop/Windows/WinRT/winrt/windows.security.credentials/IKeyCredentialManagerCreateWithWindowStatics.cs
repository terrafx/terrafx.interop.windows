// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyCredentialManagerCreateWithWindowStatics.xml' path='doc/member[@name="IKeyCredentialManagerCreateWithWindowStatics"]/*' />
[Guid("30B1B9C9-61EF-43E8-88AC-CC433B38D1A6")]
[NativeTypeName("struct IKeyCredentialManagerCreateWithWindowStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyCredentialManagerCreateWithWindowStatics : IKeyCredentialManagerCreateWithWindowStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKeyCredentialManagerCreateWithWindowStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerCreateWithWindowStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKeyCredentialManagerCreateWithWindowStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerCreateWithWindowStatics*, uint>)(lpVtbl[1]))((IKeyCredentialManagerCreateWithWindowStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerCreateWithWindowStatics*, uint>)(lpVtbl[2]))((IKeyCredentialManagerCreateWithWindowStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerCreateWithWindowStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyCredentialManagerCreateWithWindowStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerCreateWithWindowStatics*, HSTRING*, int>)(lpVtbl[4]))((IKeyCredentialManagerCreateWithWindowStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerCreateWithWindowStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKeyCredentialManagerCreateWithWindowStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyCredentialManagerCreateWithWindowStatics.xml' path='doc/member[@name="IKeyCredentialManagerCreateWithWindowStatics.RequestCreateForWindowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestCreateForWindowAsync([NativeTypeName("ABI::Windows::UI::WindowId")] WindowId window, HSTRING name, [NativeTypeName("ABI::Windows::Security::Credentials::KeyCredentialCreationOption")] KeyCredentialCreationOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **")] IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerCreateWithWindowStatics*, WindowId, HSTRING, KeyCredentialCreationOption, IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>**, int>)(lpVtbl[6]))((IKeyCredentialManagerCreateWithWindowStatics*)Unsafe.AsPointer(ref this), window, name, option, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestCreateForWindowAsync([NativeTypeName("ABI::Windows::UI::WindowId")] WindowId window, HSTRING name, [NativeTypeName("ABI::Windows::Security::Credentials::KeyCredentialCreationOption")] KeyCredentialCreationOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **")] IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowId, HSTRING, ABI::Windows::Security::Credentials::KeyCredentialCreationOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WindowId, HSTRING, KeyCredentialCreationOption, IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>**, int> RequestCreateForWindowAsync;
    }
}
