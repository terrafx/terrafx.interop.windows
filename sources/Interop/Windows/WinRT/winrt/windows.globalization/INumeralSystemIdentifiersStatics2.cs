// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='INumeralSystemIdentifiersStatics2.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics2"]/*' />
[Guid("7F003228-9DDB-4A34-9104-0260C091A7C7")]
[NativeTypeName("struct INumeralSystemIdentifiersStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INumeralSystemIdentifiersStatics2 : INumeralSystemIdentifiersStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_INumeralSystemIdentifiersStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, Guid*, void**, int>)(lpVtbl[0]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, uint>)(lpVtbl[1]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, uint>)(lpVtbl[2]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, HSTRING*, int>)(lpVtbl[4]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, TrustLevel*, int>)(lpVtbl[5]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='INumeralSystemIdentifiersStatics2.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics2.get_Brah"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Brah(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, HSTRING*, int>)(lpVtbl[6]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics2.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics2.get_Osma"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Osma(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, HSTRING*, int>)(lpVtbl[7]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics2.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics2.get_MathBold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MathBold(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, HSTRING*, int>)(lpVtbl[8]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics2.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics2.get_MathDbl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MathDbl(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, HSTRING*, int>)(lpVtbl[9]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics2.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics2.get_MathSans"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MathSans(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, HSTRING*, int>)(lpVtbl[10]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics2.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics2.get_MathSanb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MathSanb(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, HSTRING*, int>)(lpVtbl[11]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics2.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics2.get_MathMono"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MathMono(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, HSTRING*, int>)(lpVtbl[12]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics2.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics2.get_ZmthBold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ZmthBold(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, HSTRING*, int>)(lpVtbl[13]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics2.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics2.get_ZmthDbl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ZmthDbl(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, HSTRING*, int>)(lpVtbl[14]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics2.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics2.get_ZmthSans"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ZmthSans(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, HSTRING*, int>)(lpVtbl[15]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics2.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics2.get_ZmthSanb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ZmthSanb(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, HSTRING*, int>)(lpVtbl[16]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INumeralSystemIdentifiersStatics2.xml' path='doc/member[@name="INumeralSystemIdentifiersStatics2.get_ZmthMono"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ZmthMono(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INumeralSystemIdentifiersStatics2*, HSTRING*, int>)(lpVtbl[17]))((INumeralSystemIdentifiersStatics2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Brah(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Osma(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_MathBold(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_MathDbl(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_MathSans(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_MathSanb(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_MathMono(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_ZmthBold(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_ZmthDbl(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_ZmthSans(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_ZmthSanb(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_ZmthMono(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Brah;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Osma;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MathBold;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MathDbl;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MathSans;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MathSanb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MathMono;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ZmthBold;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ZmthDbl;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ZmthSans;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ZmthSanb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ZmthMono;
    }
}
