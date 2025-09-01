// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioNodeEmitterDecayModel.xml' path='doc/member[@name="IAudioNodeEmitterDecayModel"]/*' />
[Guid("1D1D5AF7-0D53-4FA9-BD84-D5816A86F3FF")]
[NativeTypeName("struct IAudioNodeEmitterDecayModel : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNodeEmitterDecayModel : IAudioNodeEmitterDecayModel.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAudioNodeEmitterDecayModel);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModel*, Guid*, void**, int>)(lpVtbl[0]))((IAudioNodeEmitterDecayModel*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModel*, uint>)(lpVtbl[1]))((IAudioNodeEmitterDecayModel*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModel*, uint>)(lpVtbl[2]))((IAudioNodeEmitterDecayModel*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModel*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioNodeEmitterDecayModel*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModel*, HSTRING*, int>)(lpVtbl[4]))((IAudioNodeEmitterDecayModel*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModel*, TrustLevel*, int>)(lpVtbl[5]))((IAudioNodeEmitterDecayModel*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioNodeEmitterDecayModel.xml' path='doc/member[@name="IAudioNodeEmitterDecayModel.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::Media::Audio::AudioNodeEmitterDecayKind *")] AudioNodeEmitterDecayKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModel*, AudioNodeEmitterDecayKind*, int>)(lpVtbl[6]))((IAudioNodeEmitterDecayModel*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeEmitterDecayModel.xml' path='doc/member[@name="IAudioNodeEmitterDecayModel.get_MinGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MinGain(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModel*, double*, int>)(lpVtbl[7]))((IAudioNodeEmitterDecayModel*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeEmitterDecayModel.xml' path='doc/member[@name="IAudioNodeEmitterDecayModel.get_MaxGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxGain(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModel*, double*, int>)(lpVtbl[8]))((IAudioNodeEmitterDecayModel*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeEmitterDecayModel.xml' path='doc/member[@name="IAudioNodeEmitterDecayModel.get_NaturalProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_NaturalProperties([NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterNaturalDecayModelProperties **")] IAudioNodeEmitterNaturalDecayModelProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModel*, IAudioNodeEmitterNaturalDecayModelProperties**, int>)(lpVtbl[9]))((IAudioNodeEmitterDecayModel*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::Media::Audio::AudioNodeEmitterDecayKind *")] AudioNodeEmitterDecayKind* value);

        [VtblIndex(7)]
        HRESULT get_MinGain(double* value);

        [VtblIndex(8)]
        HRESULT get_MaxGain(double* value);

        [VtblIndex(9)]
        HRESULT get_NaturalProperties([NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterNaturalDecayModelProperties **")] IAudioNodeEmitterNaturalDecayModelProperties** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::AudioNodeEmitterDecayKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioNodeEmitterDecayKind*, int> get_Kind;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MinGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MaxGain;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioNodeEmitterNaturalDecayModelProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioNodeEmitterNaturalDecayModelProperties**, int> get_NaturalProperties;
    }
}
