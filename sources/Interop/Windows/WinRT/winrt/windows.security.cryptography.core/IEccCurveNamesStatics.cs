// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics"]/*' />
[Guid("B3FF930C-AEEB-409E-B7D4-9B95295AAECF")]
[NativeTypeName("struct IEccCurveNamesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEccCurveNamesStatics : IEccCurveNamesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEccCurveNamesStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, uint>)(lpVtbl[1]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, uint>)(lpVtbl[2]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[4]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP160r1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BrainpoolP160r1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[6]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP160t1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BrainpoolP160t1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[7]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP192r1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BrainpoolP192r1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[8]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP192t1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BrainpoolP192t1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[9]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP224r1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BrainpoolP224r1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[10]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP224t1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_BrainpoolP224t1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[11]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP256r1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_BrainpoolP256r1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[12]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP256t1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_BrainpoolP256t1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[13]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP320r1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_BrainpoolP320r1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[14]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP320t1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_BrainpoolP320t1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[15]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP384r1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_BrainpoolP384r1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[16]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP384t1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_BrainpoolP384t1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[17]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP512r1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_BrainpoolP512r1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[18]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_BrainpoolP512t1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_BrainpoolP512t1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[19]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_Curve25519"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Curve25519(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[20]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_Ec192wapi"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Ec192wapi(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[21]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_NistP192"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_NistP192(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[22]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_NistP224"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_NistP224(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[23]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_NistP256"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_NistP256(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[24]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_NistP384"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_NistP384(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[25]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_NistP521"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_NistP521(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[26]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_NumsP256t1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_NumsP256t1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[27]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_NumsP384t1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_NumsP384t1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[28]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_NumsP512t1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_NumsP512t1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[29]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_SecP160k1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_SecP160k1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[30]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_SecP160r1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_SecP160r1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[31]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_SecP160r2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_SecP160r2(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[32]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_SecP192k1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_SecP192k1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[33]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_SecP192r1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_SecP192r1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[34]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_SecP224k1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_SecP224k1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[35]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_SecP224r1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_SecP224r1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[36]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_SecP256k1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_SecP256k1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[37]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_SecP256r1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_SecP256r1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[38]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_SecP384r1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_SecP384r1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[39]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_SecP521r1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_SecP521r1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[40]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_Wtls7"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_Wtls7(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[41]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_Wtls9"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_Wtls9(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[42]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_Wtls12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_Wtls12(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[43]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_X962P192v1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_X962P192v1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[44]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_X962P192v2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_X962P192v2(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[45]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_X962P192v3"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_X962P192v3(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[46]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_X962P239v1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_X962P239v1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[47]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_X962P239v2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_X962P239v2(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[48]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_X962P239v3"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_X962P239v3(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[49]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_X962P256v1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_X962P256v1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, HSTRING*, int>)(lpVtbl[50]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEccCurveNamesStatics.xml' path='doc/member[@name="IEccCurveNamesStatics.get_AllEccCurveNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_AllEccCurveNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEccCurveNamesStatics*, IVectorView<HSTRING>**, int>)(lpVtbl[51]))((IEccCurveNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BrainpoolP160r1(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_BrainpoolP160t1(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_BrainpoolP192r1(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_BrainpoolP192t1(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_BrainpoolP224r1(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_BrainpoolP224t1(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_BrainpoolP256r1(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_BrainpoolP256t1(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_BrainpoolP320r1(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_BrainpoolP320t1(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_BrainpoolP384r1(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_BrainpoolP384t1(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_BrainpoolP512r1(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_BrainpoolP512t1(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_Curve25519(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_Ec192wapi(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_NistP192(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_NistP224(HSTRING* value);

        [VtblIndex(24)]
        HRESULT get_NistP256(HSTRING* value);

        [VtblIndex(25)]
        HRESULT get_NistP384(HSTRING* value);

        [VtblIndex(26)]
        HRESULT get_NistP521(HSTRING* value);

        [VtblIndex(27)]
        HRESULT get_NumsP256t1(HSTRING* value);

        [VtblIndex(28)]
        HRESULT get_NumsP384t1(HSTRING* value);

        [VtblIndex(29)]
        HRESULT get_NumsP512t1(HSTRING* value);

        [VtblIndex(30)]
        HRESULT get_SecP160k1(HSTRING* value);

        [VtblIndex(31)]
        HRESULT get_SecP160r1(HSTRING* value);

        [VtblIndex(32)]
        HRESULT get_SecP160r2(HSTRING* value);

        [VtblIndex(33)]
        HRESULT get_SecP192k1(HSTRING* value);

        [VtblIndex(34)]
        HRESULT get_SecP192r1(HSTRING* value);

        [VtblIndex(35)]
        HRESULT get_SecP224k1(HSTRING* value);

        [VtblIndex(36)]
        HRESULT get_SecP224r1(HSTRING* value);

        [VtblIndex(37)]
        HRESULT get_SecP256k1(HSTRING* value);

        [VtblIndex(38)]
        HRESULT get_SecP256r1(HSTRING* value);

        [VtblIndex(39)]
        HRESULT get_SecP384r1(HSTRING* value);

        [VtblIndex(40)]
        HRESULT get_SecP521r1(HSTRING* value);

        [VtblIndex(41)]
        HRESULT get_Wtls7(HSTRING* value);

        [VtblIndex(42)]
        HRESULT get_Wtls9(HSTRING* value);

        [VtblIndex(43)]
        HRESULT get_Wtls12(HSTRING* value);

        [VtblIndex(44)]
        HRESULT get_X962P192v1(HSTRING* value);

        [VtblIndex(45)]
        HRESULT get_X962P192v2(HSTRING* value);

        [VtblIndex(46)]
        HRESULT get_X962P192v3(HSTRING* value);

        [VtblIndex(47)]
        HRESULT get_X962P239v1(HSTRING* value);

        [VtblIndex(48)]
        HRESULT get_X962P239v2(HSTRING* value);

        [VtblIndex(49)]
        HRESULT get_X962P239v3(HSTRING* value);

        [VtblIndex(50)]
        HRESULT get_X962P256v1(HSTRING* value);

        [VtblIndex(51)]
        HRESULT get_AllEccCurveNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP160r1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP160t1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP192r1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP192t1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP224r1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP224t1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP256r1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP256t1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP320r1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP320t1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP384r1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP384t1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP512r1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BrainpoolP512t1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Curve25519;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Ec192wapi;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NistP192;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NistP224;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NistP256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NistP384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NistP521;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NumsP256t1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NumsP384t1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NumsP512t1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SecP160k1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SecP160r1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SecP160r2;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SecP192k1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SecP192r1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SecP224k1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SecP224r1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SecP256k1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SecP256r1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SecP384r1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SecP521r1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Wtls7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Wtls9;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Wtls12;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_X962P192v1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_X962P192v2;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_X962P192v3;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_X962P239v1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_X962P239v2;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_X962P239v3;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_X962P256v1;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_AllEccCurveNames;
    }
}
