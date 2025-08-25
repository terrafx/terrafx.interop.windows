// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICmsAttachedSignatureFactory.xml' path='doc/member[@name="ICmsAttachedSignatureFactory"]/*' />
[Guid("D0C8FC15-F757-4C64-A362-52CC1C77CFFB")]
[NativeTypeName("struct ICmsAttachedSignatureFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICmsAttachedSignatureFactory : ICmsAttachedSignatureFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICmsAttachedSignatureFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignatureFactory*, Guid*, void**, int>)(lpVtbl[0]))((ICmsAttachedSignatureFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignatureFactory*, uint>)(lpVtbl[1]))((ICmsAttachedSignatureFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignatureFactory*, uint>)(lpVtbl[2]))((ICmsAttachedSignatureFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignatureFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ICmsAttachedSignatureFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignatureFactory*, HSTRING*, int>)(lpVtbl[4]))((ICmsAttachedSignatureFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignatureFactory*, TrustLevel*, int>)(lpVtbl[5]))((ICmsAttachedSignatureFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICmsAttachedSignatureFactory.xml' path='doc/member[@name="ICmsAttachedSignatureFactory.CreateCmsAttachedSignature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateCmsAttachedSignature([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* inputBlob, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICmsAttachedSignature **")] ICmsAttachedSignature** cmsSignedData)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsAttachedSignatureFactory*, IBuffer*, ICmsAttachedSignature**, int>)(lpVtbl[6]))((ICmsAttachedSignatureFactory*)Unsafe.AsPointer(ref this), inputBlob, cmsSignedData);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateCmsAttachedSignature([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* inputBlob, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICmsAttachedSignature **")] ICmsAttachedSignature** cmsSignedData);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Certificates::ICmsAttachedSignature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, ICmsAttachedSignature**, int> CreateCmsAttachedSignature;
    }
}
