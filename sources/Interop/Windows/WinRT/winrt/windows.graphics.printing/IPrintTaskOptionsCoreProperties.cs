// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties"]/*' />
[Guid("C1B71832-9E93-4E55-814B-3326A59EFCE1")]
[NativeTypeName("struct IPrintTaskOptionsCoreProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTaskOptionsCoreProperties : IPrintTaskOptionsCoreProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintTaskOptionsCoreProperties);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, uint>)(lpVtbl[1]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, uint>)(lpVtbl[2]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, HSTRING*, int>)(lpVtbl[4]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.put_MediaSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_MediaSize([NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaSize")] PrintMediaSize value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintMediaSize, int>)(lpVtbl[6]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.get_MediaSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MediaSize([NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaSize *")] PrintMediaSize* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintMediaSize*, int>)(lpVtbl[7]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.put_MediaType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_MediaType([NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaType")] PrintMediaType value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintMediaType, int>)(lpVtbl[8]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.get_MediaType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MediaType([NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaType *")] PrintMediaType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintMediaType*, int>)(lpVtbl[9]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.put_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Orientation([NativeTypeName("ABI::Windows::Graphics::Printing::PrintOrientation")] PrintOrientation value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintOrientation, int>)(lpVtbl[10]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.get_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Orientation([NativeTypeName("ABI::Windows::Graphics::Printing::PrintOrientation *")] PrintOrientation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintOrientation*, int>)(lpVtbl[11]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.put_PrintQuality"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_PrintQuality([NativeTypeName("ABI::Windows::Graphics::Printing::PrintQuality")] PrintQuality value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintQuality, int>)(lpVtbl[12]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.get_PrintQuality"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PrintQuality([NativeTypeName("ABI::Windows::Graphics::Printing::PrintQuality *")] PrintQuality* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintQuality*, int>)(lpVtbl[13]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.put_ColorMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_ColorMode([NativeTypeName("ABI::Windows::Graphics::Printing::PrintColorMode")] PrintColorMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintColorMode, int>)(lpVtbl[14]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.get_ColorMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ColorMode([NativeTypeName("ABI::Windows::Graphics::Printing::PrintColorMode *")] PrintColorMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintColorMode*, int>)(lpVtbl[15]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.put_Duplex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_Duplex([NativeTypeName("ABI::Windows::Graphics::Printing::PrintDuplex")] PrintDuplex value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintDuplex, int>)(lpVtbl[16]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.get_Duplex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Duplex([NativeTypeName("ABI::Windows::Graphics::Printing::PrintDuplex *")] PrintDuplex* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintDuplex*, int>)(lpVtbl[17]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.put_Collation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_Collation([NativeTypeName("ABI::Windows::Graphics::Printing::PrintCollation")] PrintCollation value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintCollation, int>)(lpVtbl[18]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.get_Collation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Collation([NativeTypeName("ABI::Windows::Graphics::Printing::PrintCollation *")] PrintCollation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintCollation*, int>)(lpVtbl[19]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.put_Staple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_Staple([NativeTypeName("ABI::Windows::Graphics::Printing::PrintStaple")] PrintStaple value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintStaple, int>)(lpVtbl[20]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.get_Staple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Staple([NativeTypeName("ABI::Windows::Graphics::Printing::PrintStaple *")] PrintStaple* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintStaple*, int>)(lpVtbl[21]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.put_HolePunch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_HolePunch([NativeTypeName("ABI::Windows::Graphics::Printing::PrintHolePunch")] PrintHolePunch value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintHolePunch, int>)(lpVtbl[22]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.get_HolePunch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_HolePunch([NativeTypeName("ABI::Windows::Graphics::Printing::PrintHolePunch *")] PrintHolePunch* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintHolePunch*, int>)(lpVtbl[23]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.put_Binding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_Binding([NativeTypeName("ABI::Windows::Graphics::Printing::PrintBinding")] PrintBinding value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintBinding, int>)(lpVtbl[24]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.get_Binding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Binding([NativeTypeName("ABI::Windows::Graphics::Printing::PrintBinding *")] PrintBinding* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, PrintBinding*, int>)(lpVtbl[25]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.get_MinCopies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_MinCopies([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, uint*, int>)(lpVtbl[26]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.get_MaxCopies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_MaxCopies([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, uint*, int>)(lpVtbl[27]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.put_NumberOfCopies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_NumberOfCopies([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, uint, int>)(lpVtbl[28]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskOptionsCoreProperties.xml' path='doc/member[@name="IPrintTaskOptionsCoreProperties.get_NumberOfCopies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_NumberOfCopies([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskOptionsCoreProperties*, uint*, int>)(lpVtbl[29]))((IPrintTaskOptionsCoreProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_MediaSize([NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaSize")] PrintMediaSize value);

        [VtblIndex(7)]
        HRESULT get_MediaSize([NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaSize *")] PrintMediaSize* value);

        [VtblIndex(8)]
        HRESULT put_MediaType([NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaType")] PrintMediaType value);

        [VtblIndex(9)]
        HRESULT get_MediaType([NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaType *")] PrintMediaType* value);

        [VtblIndex(10)]
        HRESULT put_Orientation([NativeTypeName("ABI::Windows::Graphics::Printing::PrintOrientation")] PrintOrientation value);

        [VtblIndex(11)]
        HRESULT get_Orientation([NativeTypeName("ABI::Windows::Graphics::Printing::PrintOrientation *")] PrintOrientation* value);

        [VtblIndex(12)]
        HRESULT put_PrintQuality([NativeTypeName("ABI::Windows::Graphics::Printing::PrintQuality")] PrintQuality value);

        [VtblIndex(13)]
        HRESULT get_PrintQuality([NativeTypeName("ABI::Windows::Graphics::Printing::PrintQuality *")] PrintQuality* value);

        [VtblIndex(14)]
        HRESULT put_ColorMode([NativeTypeName("ABI::Windows::Graphics::Printing::PrintColorMode")] PrintColorMode value);

        [VtblIndex(15)]
        HRESULT get_ColorMode([NativeTypeName("ABI::Windows::Graphics::Printing::PrintColorMode *")] PrintColorMode* value);

        [VtblIndex(16)]
        HRESULT put_Duplex([NativeTypeName("ABI::Windows::Graphics::Printing::PrintDuplex")] PrintDuplex value);

        [VtblIndex(17)]
        HRESULT get_Duplex([NativeTypeName("ABI::Windows::Graphics::Printing::PrintDuplex *")] PrintDuplex* value);

        [VtblIndex(18)]
        HRESULT put_Collation([NativeTypeName("ABI::Windows::Graphics::Printing::PrintCollation")] PrintCollation value);

        [VtblIndex(19)]
        HRESULT get_Collation([NativeTypeName("ABI::Windows::Graphics::Printing::PrintCollation *")] PrintCollation* value);

        [VtblIndex(20)]
        HRESULT put_Staple([NativeTypeName("ABI::Windows::Graphics::Printing::PrintStaple")] PrintStaple value);

        [VtblIndex(21)]
        HRESULT get_Staple([NativeTypeName("ABI::Windows::Graphics::Printing::PrintStaple *")] PrintStaple* value);

        [VtblIndex(22)]
        HRESULT put_HolePunch([NativeTypeName("ABI::Windows::Graphics::Printing::PrintHolePunch")] PrintHolePunch value);

        [VtblIndex(23)]
        HRESULT get_HolePunch([NativeTypeName("ABI::Windows::Graphics::Printing::PrintHolePunch *")] PrintHolePunch* value);

        [VtblIndex(24)]
        HRESULT put_Binding([NativeTypeName("ABI::Windows::Graphics::Printing::PrintBinding")] PrintBinding value);

        [VtblIndex(25)]
        HRESULT get_Binding([NativeTypeName("ABI::Windows::Graphics::Printing::PrintBinding *")] PrintBinding* value);

        [VtblIndex(26)]
        HRESULT get_MinCopies([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(27)]
        HRESULT get_MaxCopies([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(28)]
        HRESULT put_NumberOfCopies([NativeTypeName("UINT32")] uint value);

        [VtblIndex(29)]
        HRESULT get_NumberOfCopies([NativeTypeName("UINT32 *")] uint* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintMediaSize) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintMediaSize, int> put_MediaSize;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintMediaSize *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintMediaSize*, int> get_MediaSize;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintMediaType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintMediaType, int> put_MediaType;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintMediaType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintMediaType*, int> get_MediaType;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintOrientation) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintOrientation, int> put_Orientation;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintOrientation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintOrientation*, int> get_Orientation;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintQuality) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintQuality, int> put_PrintQuality;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintQuality *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintQuality*, int> get_PrintQuality;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintColorMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintColorMode, int> put_ColorMode;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintColorMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintColorMode*, int> get_ColorMode;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintDuplex) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintDuplex, int> put_Duplex;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintDuplex *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintDuplex*, int> get_Duplex;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintCollation) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintCollation, int> put_Collation;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintCollation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintCollation*, int> get_Collation;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintStaple) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintStaple, int> put_Staple;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintStaple *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintStaple*, int> get_Staple;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintHolePunch) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintHolePunch, int> put_HolePunch;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintHolePunch *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintHolePunch*, int> get_HolePunch;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintBinding) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintBinding, int> put_Binding;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintBinding *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintBinding*, int> get_Binding;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MinCopies;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaxCopies;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_NumberOfCopies;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_NumberOfCopies;
    }
}
