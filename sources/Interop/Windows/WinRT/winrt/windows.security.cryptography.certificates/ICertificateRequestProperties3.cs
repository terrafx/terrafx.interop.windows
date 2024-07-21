// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificateRequestProperties3.xml' path='doc/member[@name="ICertificateRequestProperties3"]/*' />
[Guid("E687F616-734D-46B1-9D4C-6EDFDBFC845B")]
[NativeTypeName("struct ICertificateRequestProperties3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateRequestProperties3 : ICertificateRequestProperties3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificateRequestProperties3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, Guid*, void**, int>)(lpVtbl[0]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, uint>)(lpVtbl[1]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, uint>)(lpVtbl[2]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, HSTRING*, int>)(lpVtbl[4]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, TrustLevel*, int>)(lpVtbl[5]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificateRequestProperties3.xml' path='doc/member[@name="ICertificateRequestProperties3.get_CurveName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CurveName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, HSTRING*, int>)(lpVtbl[6]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties3.xml' path='doc/member[@name="ICertificateRequestProperties3.put_CurveName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CurveName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, HSTRING, int>)(lpVtbl[7]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties3.xml' path='doc/member[@name="ICertificateRequestProperties3.get_CurveParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CurveParameters([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, uint*, byte**, int>)(lpVtbl[8]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='ICertificateRequestProperties3.xml' path='doc/member[@name="ICertificateRequestProperties3.put_CurveParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CurveParameters([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, uint, byte*, int>)(lpVtbl[9]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='ICertificateRequestProperties3.xml' path='doc/member[@name="ICertificateRequestProperties3.get_ContainerNamePrefix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ContainerNamePrefix(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, HSTRING*, int>)(lpVtbl[10]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties3.xml' path='doc/member[@name="ICertificateRequestProperties3.put_ContainerNamePrefix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ContainerNamePrefix(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, HSTRING, int>)(lpVtbl[11]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties3.xml' path='doc/member[@name="ICertificateRequestProperties3.get_ContainerName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ContainerName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, HSTRING*, int>)(lpVtbl[12]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties3.xml' path='doc/member[@name="ICertificateRequestProperties3.put_ContainerName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ContainerName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, HSTRING, int>)(lpVtbl[13]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties3.xml' path='doc/member[@name="ICertificateRequestProperties3.get_UseExistingKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_UseExistingKey([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, byte*, int>)(lpVtbl[14]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties3.xml' path='doc/member[@name="ICertificateRequestProperties3.put_UseExistingKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_UseExistingKey([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties3*, byte, int>)(lpVtbl[15]))((ICertificateRequestProperties3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CurveName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_CurveName(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_CurveParameters([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(9)]
        HRESULT put_CurveParameters([NativeTypeName("UINT32")] uint valueLength, byte* value);

        [VtblIndex(10)]
        HRESULT get_ContainerNamePrefix(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_ContainerNamePrefix(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_ContainerName(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_ContainerName(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_UseExistingKey([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_UseExistingKey([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CurveName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CurveName;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> get_CurveParameters;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> put_CurveParameters;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContainerNamePrefix;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContainerNamePrefix;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContainerName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContainerName;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UseExistingKey;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_UseExistingKey;
    }
}
