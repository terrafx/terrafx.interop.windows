// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics"]/*' />
[Guid("A5C662C3-68C9-4D3D-B765-972029E21DEC")]
[NativeTypeName("struct INumeralSystemIdentifiersStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INumeralSystemIdentifiersStatics : INumeralSystemIdentifiersStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INumeralSystemIdentifiersStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, Guid*, void**, int>)(lpVtbl[0]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, uint>)(lpVtbl[1]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, uint>)(lpVtbl[2]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, uint*, Guid**, int>)(lpVtbl[3]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[4]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, TrustLevel*, int>)(lpVtbl[5]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Arab"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Arab(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[6]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_ArabExt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ArabExt(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[7]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Bali"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Bali(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[8]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Beng"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Beng(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[9]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Cham"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Cham(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[10]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Deva"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Deva(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[11]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_FullWide"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FullWide(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[12]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Gujr"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Gujr(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[13]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Guru"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Guru(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[14]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_HaniDec"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_HaniDec(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[15]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Java"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Java(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[16]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Kali"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Kali(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[17]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Khmr"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Khmr(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[18]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Knda"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Knda(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[19]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Lana"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Lana(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[20]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_LanaTham"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_LanaTham(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[21]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Laoo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Laoo(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[22]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Latn"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_Latn(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[23]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Lepc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Lepc(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[24]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Limb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Limb(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[25]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Mlym"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Mlym(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[26]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Mong"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_Mong(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[27]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Mtei"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_Mtei(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[28]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Mymr"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_Mymr(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[29]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_MymrShan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_MymrShan(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[30]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Nkoo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_Nkoo(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[31]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Olck"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_Olck(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[32]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Orya"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_Orya(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[33]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Saur"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_Saur(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[34]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Sund"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_Sund(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[35]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Talu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_Talu(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[36]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_TamlDec"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_TamlDec(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[37]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Telu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_Telu(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[38]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Thai"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_Thai(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[39]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Tibt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_Tibt(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[40]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics.get_Vaii"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_Vaii(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics*, HSTRING*, int>)(lpVtbl[41]))((INumeralSystemIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Arab(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ArabExt(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Bali(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Beng(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Cham(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Deva(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_FullWide(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Gujr(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_Guru(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_HaniDec(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_Java(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_Kali(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_Khmr(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_Knda(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_Lana(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_LanaTham(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_Laoo(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_Latn(HSTRING* value);

        [VtblIndex(24)]
        HRESULT get_Lepc(HSTRING* value);

        [VtblIndex(25)]
        HRESULT get_Limb(HSTRING* value);

        [VtblIndex(26)]
        HRESULT get_Mlym(HSTRING* value);

        [VtblIndex(27)]
        HRESULT get_Mong(HSTRING* value);

        [VtblIndex(28)]
        HRESULT get_Mtei(HSTRING* value);

        [VtblIndex(29)]
        HRESULT get_Mymr(HSTRING* value);

        [VtblIndex(30)]
        HRESULT get_MymrShan(HSTRING* value);

        [VtblIndex(31)]
        HRESULT get_Nkoo(HSTRING* value);

        [VtblIndex(32)]
        HRESULT get_Olck(HSTRING* value);

        [VtblIndex(33)]
        HRESULT get_Orya(HSTRING* value);

        [VtblIndex(34)]
        HRESULT get_Saur(HSTRING* value);

        [VtblIndex(35)]
        HRESULT get_Sund(HSTRING* value);

        [VtblIndex(36)]
        HRESULT get_Talu(HSTRING* value);

        [VtblIndex(37)]
        HRESULT get_TamlDec(HSTRING* value);

        [VtblIndex(38)]
        HRESULT get_Telu(HSTRING* value);

        [VtblIndex(39)]
        HRESULT get_Thai(HSTRING* value);

        [VtblIndex(40)]
        HRESULT get_Tibt(HSTRING* value);

        [VtblIndex(41)]
        HRESULT get_Vaii(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Arab;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ArabExt;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Bali;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Beng;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Cham;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Deva;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FullWide;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Gujr;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Guru;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HaniDec;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Java;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Kali;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Khmr;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Knda;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Lana;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LanaTham;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Laoo;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Latn;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Lepc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Limb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Mlym;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Mong;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Mtei;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Mymr;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MymrShan;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Nkoo;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Olck;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Orya;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Saur;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sund;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Talu;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TamlDec;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Telu;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Thai;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Tibt;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Vaii;
    }
}
