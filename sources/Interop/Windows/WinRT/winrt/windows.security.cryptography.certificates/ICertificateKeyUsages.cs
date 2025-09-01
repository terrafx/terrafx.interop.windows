// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages"]/*' />
[Guid("6AC6206F-E1CF-486A-B485-A69C83E46FD1")]
[NativeTypeName("struct ICertificateKeyUsages : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateKeyUsages : ICertificateKeyUsages.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICertificateKeyUsages);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, Guid*, void**, int>)(lpVtbl[0]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, uint>)(lpVtbl[1]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, uint>)(lpVtbl[2]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, HSTRING*, int>)(lpVtbl[4]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, TrustLevel*, int>)(lpVtbl[5]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.get_EncipherOnly"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EncipherOnly([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte*, int>)(lpVtbl[6]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.put_EncipherOnly"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_EncipherOnly([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte, int>)(lpVtbl[7]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.get_CrlSign"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CrlSign([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte*, int>)(lpVtbl[8]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.put_CrlSign"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CrlSign([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte, int>)(lpVtbl[9]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.get_KeyCertificateSign"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_KeyCertificateSign([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte*, int>)(lpVtbl[10]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.put_KeyCertificateSign"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_KeyCertificateSign([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte, int>)(lpVtbl[11]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.get_KeyAgreement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_KeyAgreement([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte*, int>)(lpVtbl[12]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.put_KeyAgreement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_KeyAgreement([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte, int>)(lpVtbl[13]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.get_DataEncipherment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DataEncipherment([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte*, int>)(lpVtbl[14]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.put_DataEncipherment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_DataEncipherment([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte, int>)(lpVtbl[15]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.get_KeyEncipherment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_KeyEncipherment([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte*, int>)(lpVtbl[16]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.put_KeyEncipherment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_KeyEncipherment([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte, int>)(lpVtbl[17]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.get_NonRepudiation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_NonRepudiation([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte*, int>)(lpVtbl[18]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.put_NonRepudiation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_NonRepudiation([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte, int>)(lpVtbl[19]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.get_DigitalSignature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_DigitalSignature([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte*, int>)(lpVtbl[20]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateKeyUsages.xml' path='doc/member[@name="ICertificateKeyUsages.put_DigitalSignature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_DigitalSignature([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateKeyUsages*, byte, int>)(lpVtbl[21]))((ICertificateKeyUsages*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EncipherOnly([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_EncipherOnly([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_CrlSign([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_CrlSign([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_KeyCertificateSign([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_KeyCertificateSign([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_KeyAgreement([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_KeyAgreement([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_DataEncipherment([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_DataEncipherment([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT get_KeyEncipherment([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT put_KeyEncipherment([NativeTypeName("boolean")] byte value);

        [VtblIndex(18)]
        HRESULT get_NonRepudiation([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT put_NonRepudiation([NativeTypeName("boolean")] byte value);

        [VtblIndex(20)]
        HRESULT get_DigitalSignature([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(21)]
        HRESULT put_DigitalSignature([NativeTypeName("boolean")] byte value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_EncipherOnly;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_EncipherOnly;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CrlSign;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CrlSign;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_KeyCertificateSign;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_KeyCertificateSign;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_KeyAgreement;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_KeyAgreement;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DataEncipherment;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_DataEncipherment;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_KeyEncipherment;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_KeyEncipherment;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_NonRepudiation;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_NonRepudiation;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DigitalSignature;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_DigitalSignature;
    }
}
