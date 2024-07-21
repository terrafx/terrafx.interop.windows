// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificate.xml' path='doc/member[@name="ICertificate"]/*' />
[Guid("333F740C-04D8-43B3-B278-8C5FCC9BE5A0")]
[NativeTypeName("struct ICertificate : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificate : ICertificate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificate));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, Guid*, void**, int>)(lpVtbl[0]))((ICertificate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, uint>)(lpVtbl[1]))((ICertificate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, uint>)(lpVtbl[2]))((ICertificate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificate*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, HSTRING*, int>)(lpVtbl[4]))((ICertificate*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, TrustLevel*, int>)(lpVtbl[5]))((ICertificate*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.BuildChainAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BuildChainAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *")] IIterable<Pointer<ICertificate>>* certificates, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateChain_t **")] IAsyncOperation<Pointer<ICertificateChain>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, IIterable<Pointer<ICertificate>>*, IAsyncOperation<Pointer<ICertificateChain>>**, int>)(lpVtbl[6]))((ICertificate*)Unsafe.AsPointer(ref this), certificates, value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.BuildChainWithParametersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BuildChainWithParametersAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *")] IIterable<Pointer<ICertificate>>* certificates, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::IChainBuildingParameters *")] IChainBuildingParameters* parameters, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateChain_t **")] IAsyncOperation<Pointer<ICertificateChain>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, IIterable<Pointer<ICertificate>>*, IChainBuildingParameters*, IAsyncOperation<Pointer<ICertificateChain>>**, int>)(lpVtbl[7]))((ICertificate*)Unsafe.AsPointer(ref this), certificates, parameters, value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.get_SerialNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SerialNumber([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, uint*, byte**, int>)(lpVtbl[8]))((ICertificate*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.GetHashValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetHashValue([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, uint*, byte**, int>)(lpVtbl[9]))((ICertificate*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.GetHashValueWithAlgorithm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetHashValueWithAlgorithm(HSTRING hashAlgorithmName, [NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, HSTRING, uint*, byte**, int>)(lpVtbl[10]))((ICertificate*)Unsafe.AsPointer(ref this), hashAlgorithmName, valueLength, value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.GetCertificateBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCertificateBlob([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, IBuffer**, int>)(lpVtbl[11]))((ICertificate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.get_Subject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Subject(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, HSTRING*, int>)(lpVtbl[12]))((ICertificate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.get_Issuer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Issuer(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, HSTRING*, int>)(lpVtbl[13]))((ICertificate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.get_HasPrivateKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_HasPrivateKey([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, byte*, int>)(lpVtbl[14]))((ICertificate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.get_IsStronglyProtected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsStronglyProtected([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, byte*, int>)(lpVtbl[15]))((ICertificate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.get_ValidFrom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ValidFrom([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, WinRTDateTime*, int>)(lpVtbl[16]))((ICertificate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.get_ValidTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ValidTo([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, WinRTDateTime*, int>)(lpVtbl[17]))((ICertificate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.get_EnhancedKeyUsages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_EnhancedKeyUsages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, IVectorView<HSTRING>**, int>)(lpVtbl[18]))((ICertificate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.put_FriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_FriendlyName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, HSTRING, int>)(lpVtbl[19]))((ICertificate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate.xml' path='doc/member[@name="ICertificate.get_FriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_FriendlyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate*, HSTRING*, int>)(lpVtbl[20]))((ICertificate*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT BuildChainAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *")] IIterable<Pointer<ICertificate>>* certificates, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateChain_t **")] IAsyncOperation<Pointer<ICertificateChain>>** value);

        [VtblIndex(7)]
        HRESULT BuildChainWithParametersAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *")] IIterable<Pointer<ICertificate>>* certificates, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::IChainBuildingParameters *")] IChainBuildingParameters* parameters, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateChain_t **")] IAsyncOperation<Pointer<ICertificateChain>>** value);

        [VtblIndex(8)]
        HRESULT get_SerialNumber([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(9)]
        HRESULT GetHashValue([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(10)]
        HRESULT GetHashValueWithAlgorithm(HSTRING hashAlgorithmName, [NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(11)]
        HRESULT GetCertificateBlob([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(12)]
        HRESULT get_Subject(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Issuer(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_HasPrivateKey([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT get_IsStronglyProtected([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT get_ValidFrom([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(17)]
        HRESULT get_ValidTo([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(18)]
        HRESULT get_EnhancedKeyUsages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);

        [VtblIndex(19)]
        HRESULT put_FriendlyName(HSTRING value);

        [VtblIndex(20)]
        HRESULT get_FriendlyName(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateChain_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<ICertificate>>*, IAsyncOperation<Pointer<ICertificateChain>>**, int> BuildChainAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *, ABI::Windows::Security::Cryptography::Certificates::IChainBuildingParameters *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateChain_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<ICertificate>>*, IChainBuildingParameters*, IAsyncOperation<Pointer<ICertificateChain>>**, int> BuildChainWithParametersAsync;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> get_SerialNumber;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> GetHashValue;

        [NativeTypeName("HRESULT (HSTRING, UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, uint*, byte**, int> GetHashValueWithAlgorithm;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> GetCertificateBlob;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Subject;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Issuer;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasPrivateKey;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsStronglyProtected;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_ValidFrom;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_ValidTo;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_EnhancedKeyUsages;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_FriendlyName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FriendlyName;
    }
}
