// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificateQuery.xml' path='doc/member[@name="ICertificateQuery"]/*' />
[Guid("5B082A31-A728-4916-B5EE-FFCB8ACF2417")]
[NativeTypeName("struct ICertificateQuery : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateQuery : ICertificateQuery.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificateQuery));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, Guid*, void**, int>)(lpVtbl[0]))((ICertificateQuery*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, uint>)(lpVtbl[1]))((ICertificateQuery*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, uint>)(lpVtbl[2]))((ICertificateQuery*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificateQuery*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, HSTRING*, int>)(lpVtbl[4]))((ICertificateQuery*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, TrustLevel*, int>)(lpVtbl[5]))((ICertificateQuery*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificateQuery.xml' path='doc/member[@name="ICertificateQuery.get_EnhancedKeyUsages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EnhancedKeyUsages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, IVector<HSTRING>**, int>)(lpVtbl[6]))((ICertificateQuery*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateQuery.xml' path='doc/member[@name="ICertificateQuery.get_IssuerName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IssuerName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, HSTRING*, int>)(lpVtbl[7]))((ICertificateQuery*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateQuery.xml' path='doc/member[@name="ICertificateQuery.put_IssuerName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_IssuerName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, HSTRING, int>)(lpVtbl[8]))((ICertificateQuery*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateQuery.xml' path='doc/member[@name="ICertificateQuery.get_FriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_FriendlyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, HSTRING*, int>)(lpVtbl[9]))((ICertificateQuery*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateQuery.xml' path='doc/member[@name="ICertificateQuery.put_FriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_FriendlyName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, HSTRING, int>)(lpVtbl[10]))((ICertificateQuery*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateQuery.xml' path='doc/member[@name="ICertificateQuery.get_Thumbprint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Thumbprint([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, uint*, byte**, int>)(lpVtbl[11]))((ICertificateQuery*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='ICertificateQuery.xml' path='doc/member[@name="ICertificateQuery.put_Thumbprint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Thumbprint([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, uint, byte*, int>)(lpVtbl[12]))((ICertificateQuery*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='ICertificateQuery.xml' path='doc/member[@name="ICertificateQuery.get_HardwareOnly"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_HardwareOnly([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, byte*, int>)(lpVtbl[13]))((ICertificateQuery*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateQuery.xml' path='doc/member[@name="ICertificateQuery.put_HardwareOnly"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_HardwareOnly([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateQuery*, byte, int>)(lpVtbl[14]))((ICertificateQuery*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EnhancedKeyUsages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(7)]
        HRESULT get_IssuerName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_IssuerName(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_FriendlyName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT put_FriendlyName(HSTRING value);

        [VtblIndex(11)]
        HRESULT get_Thumbprint([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(12)]
        HRESULT put_Thumbprint([NativeTypeName("UINT32")] uint valueLength, byte* value);

        [VtblIndex(13)]
        HRESULT get_HardwareOnly([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_HardwareOnly([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_EnhancedKeyUsages;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_IssuerName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_IssuerName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FriendlyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_FriendlyName;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> get_Thumbprint;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> put_Thumbprint;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HardwareOnly;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_HardwareOnly;
    }
}
