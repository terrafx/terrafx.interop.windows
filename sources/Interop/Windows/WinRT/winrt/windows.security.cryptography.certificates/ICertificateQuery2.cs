// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificateQuery2.xml' path='doc/member[@name="ICertificateQuery2"]/*' />
[Guid("935A0AF7-0BD9-4F75-B8C2-E27A7F74EECD")]
[NativeTypeName("struct ICertificateQuery2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateQuery2 : ICertificateQuery2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificateQuery2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery2*, Guid*, void**, int>)(lpVtbl[0]))((ICertificateQuery2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery2*, uint>)(lpVtbl[1]))((ICertificateQuery2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery2*, uint>)(lpVtbl[2]))((ICertificateQuery2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery2*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificateQuery2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery2*, HSTRING*, int>)(lpVtbl[4]))((ICertificateQuery2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery2*, TrustLevel*, int>)(lpVtbl[5]))((ICertificateQuery2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificateQuery2.xml' path='doc/member[@name="ICertificateQuery2.get_IncludeDuplicates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IncludeDuplicates([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery2*, byte*, int>)(lpVtbl[6]))((ICertificateQuery2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateQuery2.xml' path='doc/member[@name="ICertificateQuery2.put_IncludeDuplicates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IncludeDuplicates([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery2*, byte, int>)(lpVtbl[7]))((ICertificateQuery2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateQuery2.xml' path='doc/member[@name="ICertificateQuery2.get_IncludeExpiredCertificates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IncludeExpiredCertificates([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery2*, byte*, int>)(lpVtbl[8]))((ICertificateQuery2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateQuery2.xml' path='doc/member[@name="ICertificateQuery2.put_IncludeExpiredCertificates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IncludeExpiredCertificates([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery2*, byte, int>)(lpVtbl[9]))((ICertificateQuery2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateQuery2.xml' path='doc/member[@name="ICertificateQuery2.get_StoreName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_StoreName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery2*, HSTRING*, int>)(lpVtbl[10]))((ICertificateQuery2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateQuery2.xml' path='doc/member[@name="ICertificateQuery2.put_StoreName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_StoreName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery2*, HSTRING, int>)(lpVtbl[11]))((ICertificateQuery2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IncludeDuplicates([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IncludeDuplicates([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_IncludeExpiredCertificates([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IncludeExpiredCertificates([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_StoreName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_StoreName(HSTRING value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IncludeDuplicates;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IncludeDuplicates;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IncludeExpiredCertificates;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IncludeExpiredCertificates;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_StoreName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_StoreName;
    }
}
