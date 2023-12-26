// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICmsSignerInfo.xml' path='doc/member[@name="ICmsSignerInfo"]/*' />
[Guid("50D020DB-1D2F-4C1A-B5C5-D0188FF91F47")]
[NativeTypeName("struct ICmsSignerInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICmsSignerInfo : ICmsSignerInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICmsSignerInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsSignerInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICmsSignerInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsSignerInfo*, uint>)(lpVtbl[1]))((ICmsSignerInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsSignerInfo*, uint>)(lpVtbl[2]))((ICmsSignerInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsSignerInfo*, uint*, Guid**, int>)(lpVtbl[3]))((ICmsSignerInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsSignerInfo*, HSTRING*, int>)(lpVtbl[4]))((ICmsSignerInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsSignerInfo*, TrustLevel*, int>)(lpVtbl[5]))((ICmsSignerInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICmsSignerInfo.xml' path='doc/member[@name="ICmsSignerInfo.get_Certificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Certificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")] ICertificate** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsSignerInfo*, ICertificate**, int>)(lpVtbl[6]))((ICmsSignerInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICmsSignerInfo.xml' path='doc/member[@name="ICmsSignerInfo.put_Certificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Certificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")] ICertificate* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsSignerInfo*, ICertificate*, int>)(lpVtbl[7]))((ICmsSignerInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICmsSignerInfo.xml' path='doc/member[@name="ICmsSignerInfo.get_HashAlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_HashAlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsSignerInfo*, HSTRING*, int>)(lpVtbl[8]))((ICmsSignerInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICmsSignerInfo.xml' path='doc/member[@name="ICmsSignerInfo.put_HashAlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_HashAlgorithmName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsSignerInfo*, HSTRING, int>)(lpVtbl[9]))((ICmsSignerInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICmsSignerInfo.xml' path='doc/member[@name="ICmsSignerInfo.get_TimestampInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_TimestampInfo([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICmsTimestampInfo **")] ICmsTimestampInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsSignerInfo*, ICmsTimestampInfo**, int>)(lpVtbl[10]))((ICmsSignerInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Certificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")] ICertificate** value);

        [VtblIndex(7)]
        HRESULT put_Certificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")] ICertificate* value);

        [VtblIndex(8)]
        HRESULT get_HashAlgorithmName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_HashAlgorithmName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_TimestampInfo([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICmsTimestampInfo **")] ICmsTimestampInfo** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificate**, int> get_Certificate;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificate*, int> put_Certificate;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HashAlgorithmName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_HashAlgorithmName;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICmsTimestampInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICmsTimestampInfo**, int> get_TimestampInfo;
    }
}
