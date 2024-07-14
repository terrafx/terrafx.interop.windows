// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpChallengeHeaderValue.xml' path='doc/member[@name="IHttpChallengeHeaderValue"]/*' />
[Guid("393361AF-0F7D-4820-9FDD-A2B956EEAEAB")]
[NativeTypeName("struct IHttpChallengeHeaderValue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpChallengeHeaderValue : IHttpChallengeHeaderValue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpChallengeHeaderValue));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValue*, Guid*, void**, int>)(lpVtbl[0]))((IHttpChallengeHeaderValue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValue*, uint>)(lpVtbl[1]))((IHttpChallengeHeaderValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValue*, uint>)(lpVtbl[2]))((IHttpChallengeHeaderValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValue*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpChallengeHeaderValue*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValue*, HSTRING*, int>)(lpVtbl[4]))((IHttpChallengeHeaderValue*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValue*, TrustLevel*, int>)(lpVtbl[5]))((IHttpChallengeHeaderValue*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpChallengeHeaderValue.xml' path='doc/member[@name="IHttpChallengeHeaderValue.get_Parameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Parameters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **")] IVector<Pointer<IHttpNameValueHeaderValue>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValue*, IVector<Pointer<IHttpNameValueHeaderValue>>**, int>)(lpVtbl[6]))((IHttpChallengeHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpChallengeHeaderValue.xml' path='doc/member[@name="IHttpChallengeHeaderValue.get_Scheme"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Scheme(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValue*, HSTRING*, int>)(lpVtbl[7]))((IHttpChallengeHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpChallengeHeaderValue.xml' path='doc/member[@name="IHttpChallengeHeaderValue.get_Token"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Token(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValue*, HSTRING*, int>)(lpVtbl[8]))((IHttpChallengeHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Parameters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **")] IVector<Pointer<IHttpNameValueHeaderValue>>** value);

        [VtblIndex(7)]
        HRESULT get_Scheme(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Token(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IHttpNameValueHeaderValue>>**, int> get_Parameters;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Scheme;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Token;
    }
}
