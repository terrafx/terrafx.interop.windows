// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialAudioFormatSubtypeStatics.xml' path='doc/member[@name="ISpatialAudioFormatSubtypeStatics"]/*' />
[Guid("B3DE8A47-83EE-4266-A945-BEDF507AFEED")]
[NativeTypeName("struct ISpatialAudioFormatSubtypeStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialAudioFormatSubtypeStatics : ISpatialAudioFormatSubtypeStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioFormatSubtypeStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatSubtypeStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioFormatSubtypeStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatSubtypeStatics*, uint>)(lpVtbl[1]))((ISpatialAudioFormatSubtypeStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatSubtypeStatics*, uint>)(lpVtbl[2]))((ISpatialAudioFormatSubtypeStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatSubtypeStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialAudioFormatSubtypeStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatSubtypeStatics*, HSTRING*, int>)(lpVtbl[4]))((ISpatialAudioFormatSubtypeStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatSubtypeStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialAudioFormatSubtypeStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialAudioFormatSubtypeStatics.xml' path='doc/member[@name="ISpatialAudioFormatSubtypeStatics.get_WindowsSonic"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_WindowsSonic(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatSubtypeStatics*, HSTRING*, int>)(lpVtbl[6]))((ISpatialAudioFormatSubtypeStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAudioFormatSubtypeStatics.xml' path='doc/member[@name="ISpatialAudioFormatSubtypeStatics.get_DolbyAtmosForHeadphones"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DolbyAtmosForHeadphones(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatSubtypeStatics*, HSTRING*, int>)(lpVtbl[7]))((ISpatialAudioFormatSubtypeStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAudioFormatSubtypeStatics.xml' path='doc/member[@name="ISpatialAudioFormatSubtypeStatics.get_DolbyAtmosForHomeTheater"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DolbyAtmosForHomeTheater(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatSubtypeStatics*, HSTRING*, int>)(lpVtbl[8]))((ISpatialAudioFormatSubtypeStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAudioFormatSubtypeStatics.xml' path='doc/member[@name="ISpatialAudioFormatSubtypeStatics.get_DolbyAtmosForSpeakers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DolbyAtmosForSpeakers(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatSubtypeStatics*, HSTRING*, int>)(lpVtbl[9]))((ISpatialAudioFormatSubtypeStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAudioFormatSubtypeStatics.xml' path='doc/member[@name="ISpatialAudioFormatSubtypeStatics.get_DTSHeadphoneX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DTSHeadphoneX(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatSubtypeStatics*, HSTRING*, int>)(lpVtbl[10]))((ISpatialAudioFormatSubtypeStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAudioFormatSubtypeStatics.xml' path='doc/member[@name="ISpatialAudioFormatSubtypeStatics.get_DTSXUltra"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DTSXUltra(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAudioFormatSubtypeStatics*, HSTRING*, int>)(lpVtbl[11]))((ISpatialAudioFormatSubtypeStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_WindowsSonic(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DolbyAtmosForHeadphones(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_DolbyAtmosForHomeTheater(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_DolbyAtmosForSpeakers(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_DTSHeadphoneX(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_DTSXUltra(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_WindowsSonic;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DolbyAtmosForHeadphones;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DolbyAtmosForHomeTheater;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DolbyAtmosForSpeakers;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DTSHeadphoneX;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DTSXUltra;
    }
}
