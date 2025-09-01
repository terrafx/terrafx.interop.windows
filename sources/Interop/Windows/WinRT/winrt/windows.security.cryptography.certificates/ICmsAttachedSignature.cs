// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICmsAttachedSignature.xml' path='doc/member[@name="ICmsAttachedSignature"]/*' />
[Guid("61899D9D-3757-4ECB-BDDC-0CA357D7A936")]
[NativeTypeName("struct ICmsAttachedSignature : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICmsAttachedSignature : ICmsAttachedSignature.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICmsAttachedSignature);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignature*, Guid*, void**, int>)(lpVtbl[0]))((ICmsAttachedSignature*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignature*, uint>)(lpVtbl[1]))((ICmsAttachedSignature*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignature*, uint>)(lpVtbl[2]))((ICmsAttachedSignature*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignature*, uint*, Guid**, int>)(lpVtbl[3]))((ICmsAttachedSignature*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignature*, HSTRING*, int>)(lpVtbl[4]))((ICmsAttachedSignature*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignature*, TrustLevel*, int>)(lpVtbl[5]))((ICmsAttachedSignature*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICmsAttachedSignature.xml' path='doc/member[@name="ICmsAttachedSignature.get_Certificates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Certificates([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IVectorView<Pointer<ICertificate>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignature*, IVectorView<Pointer<ICertificate>>**, int>)(lpVtbl[6]))((ICmsAttachedSignature*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICmsAttachedSignature.xml' path='doc/member[@name="ICmsAttachedSignature.get_Content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Content([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignature*, uint*, byte**, int>)(lpVtbl[7]))((ICmsAttachedSignature*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='ICmsAttachedSignature.xml' path='doc/member[@name="ICmsAttachedSignature.get_Signers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Signers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCmsSignerInfo_t **")] IVectorView<Pointer<ICmsSignerInfo>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignature*, IVectorView<Pointer<ICmsSignerInfo>>**, int>)(lpVtbl[8]))((ICmsAttachedSignature*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICmsAttachedSignature.xml' path='doc/member[@name="ICmsAttachedSignature.VerifySignature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT VerifySignature([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::SignatureValidationResult *")] SignatureValidationResult* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignature*, SignatureValidationResult*, int>)(lpVtbl[9]))((ICmsAttachedSignature*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Certificates([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IVectorView<Pointer<ICertificate>>** value);

        [VtblIndex(7)]
        HRESULT get_Content([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(8)]
        HRESULT get_Signers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCmsSignerInfo_t **")] IVectorView<Pointer<ICmsSignerInfo>>** value);

        [VtblIndex(9)]
        HRESULT VerifySignature([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::SignatureValidationResult *")] SignatureValidationResult* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<ICertificate>>**, int> get_Certificates;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> get_Content;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCmsSignerInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<ICmsSignerInfo>>**, int> get_Signers;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::SignatureValidationResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SignatureValidationResult*, int> VerifySignature;
    }
}
