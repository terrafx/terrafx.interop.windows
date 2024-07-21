// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioNodeEmitterDecayModelStatics.xml' path='doc/member[@name="IAudioNodeEmitterDecayModelStatics"]/*' />
[Guid("C7787CA8-F178-462F-BC81-8DD5CBE5DAE8")]
[NativeTypeName("struct IAudioNodeEmitterDecayModelStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNodeEmitterDecayModelStatics : IAudioNodeEmitterDecayModelStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioNodeEmitterDecayModelStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModelStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAudioNodeEmitterDecayModelStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModelStatics*, uint>)(lpVtbl[1]))((IAudioNodeEmitterDecayModelStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModelStatics*, uint>)(lpVtbl[2]))((IAudioNodeEmitterDecayModelStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModelStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioNodeEmitterDecayModelStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModelStatics*, HSTRING*, int>)(lpVtbl[4]))((IAudioNodeEmitterDecayModelStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModelStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAudioNodeEmitterDecayModelStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioNodeEmitterDecayModelStatics.xml' path='doc/member[@name="IAudioNodeEmitterDecayModelStatics.CreateNatural"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateNatural(double minGain, double maxGain, double unityGainDistance, double cutoffDistance, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **")] IAudioNodeEmitterDecayModel** decayModel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModelStatics*, double, double, double, double, IAudioNodeEmitterDecayModel**, int>)(lpVtbl[6]))((IAudioNodeEmitterDecayModelStatics*)Unsafe.AsPointer(ref this), minGain, maxGain, unityGainDistance, cutoffDistance, decayModel);
    }

    /// <include file='IAudioNodeEmitterDecayModelStatics.xml' path='doc/member[@name="IAudioNodeEmitterDecayModelStatics.CreateCustom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateCustom(double minGain, double maxGain, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **")] IAudioNodeEmitterDecayModel** decayModel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterDecayModelStatics*, double, double, IAudioNodeEmitterDecayModel**, int>)(lpVtbl[7]))((IAudioNodeEmitterDecayModelStatics*)Unsafe.AsPointer(ref this), minGain, maxGain, decayModel);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateNatural(double minGain, double maxGain, double unityGainDistance, double cutoffDistance, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **")] IAudioNodeEmitterDecayModel** decayModel);

        [VtblIndex(7)]
        HRESULT CreateCustom(double minGain, double maxGain, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **")] IAudioNodeEmitterDecayModel** decayModel);
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

        [NativeTypeName("HRESULT (DOUBLE, DOUBLE, DOUBLE, DOUBLE, ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, double, double, double, IAudioNodeEmitterDecayModel**, int> CreateNatural;

        [NativeTypeName("HRESULT (DOUBLE, DOUBLE, ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, double, IAudioNodeEmitterDecayModel**, int> CreateCustom;
    }
}
