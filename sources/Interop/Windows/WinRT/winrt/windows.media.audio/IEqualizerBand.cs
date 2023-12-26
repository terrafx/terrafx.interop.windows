// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEqualizerBand.xml' path='doc/member[@name="IEqualizerBand"]/*' />
[Guid("C00A5A6A-262D-4B85-9BB7-43280B62ED0C")]
[NativeTypeName("struct IEqualizerBand : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEqualizerBand : IEqualizerBand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEqualizerBand));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerBand*, Guid*, void**, int>)(lpVtbl[0]))((IEqualizerBand*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerBand*, uint>)(lpVtbl[1]))((IEqualizerBand*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerBand*, uint>)(lpVtbl[2]))((IEqualizerBand*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerBand*, uint*, Guid**, int>)(lpVtbl[3]))((IEqualizerBand*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerBand*, HSTRING*, int>)(lpVtbl[4]))((IEqualizerBand*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerBand*, TrustLevel*, int>)(lpVtbl[5]))((IEqualizerBand*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEqualizerBand.xml' path='doc/member[@name="IEqualizerBand.get_Bandwidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Bandwidth(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerBand*, double*, int>)(lpVtbl[6]))((IEqualizerBand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEqualizerBand.xml' path='doc/member[@name="IEqualizerBand.put_Bandwidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Bandwidth(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerBand*, double, int>)(lpVtbl[7]))((IEqualizerBand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEqualizerBand.xml' path='doc/member[@name="IEqualizerBand.get_FrequencyCenter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FrequencyCenter(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerBand*, double*, int>)(lpVtbl[8]))((IEqualizerBand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEqualizerBand.xml' path='doc/member[@name="IEqualizerBand.put_FrequencyCenter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_FrequencyCenter(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerBand*, double, int>)(lpVtbl[9]))((IEqualizerBand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEqualizerBand.xml' path='doc/member[@name="IEqualizerBand.get_Gain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Gain(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerBand*, double*, int>)(lpVtbl[10]))((IEqualizerBand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEqualizerBand.xml' path='doc/member[@name="IEqualizerBand.put_Gain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Gain(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerBand*, double, int>)(lpVtbl[11]))((IEqualizerBand*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Bandwidth(double* value);

        [VtblIndex(7)]
        HRESULT put_Bandwidth(double value);

        [VtblIndex(8)]
        HRESULT get_FrequencyCenter(double* value);

        [VtblIndex(9)]
        HRESULT put_FrequencyCenter(double value);

        [VtblIndex(10)]
        HRESULT get_Gain(double* value);

        [VtblIndex(11)]
        HRESULT put_Gain(double value);
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

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Bandwidth;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_Bandwidth;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_FrequencyCenter;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_FrequencyCenter;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Gain;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_Gain;
    }
}
