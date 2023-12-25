// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioNodeEmitterShape.xml' path='doc/member[@name="IAudioNodeEmitterShape"]/*' />
[Guid("EA0311C5-E73D-44BC-859C-45553BBC4828")]
[NativeTypeName("struct IAudioNodeEmitterShape : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNodeEmitterShape : IAudioNodeEmitterShape.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioNodeEmitterShape));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShape*, Guid*, void**, int>)(lpVtbl[0]))((IAudioNodeEmitterShape*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShape*, uint>)(lpVtbl[1]))((IAudioNodeEmitterShape*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShape*, uint>)(lpVtbl[2]))((IAudioNodeEmitterShape*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShape*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioNodeEmitterShape*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShape*, HSTRING*, int>)(lpVtbl[4]))((IAudioNodeEmitterShape*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShape*, TrustLevel*, int>)(lpVtbl[5]))((IAudioNodeEmitterShape*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioNodeEmitterShape.xml' path='doc/member[@name="IAudioNodeEmitterShape.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::Media::Audio::AudioNodeEmitterShapeKind *")] AudioNodeEmitterShapeKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShape*, AudioNodeEmitterShapeKind*, int>)(lpVtbl[6]))((IAudioNodeEmitterShape*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeEmitterShape.xml' path='doc/member[@name="IAudioNodeEmitterShape.get_ConeProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConeProperties([NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterConeProperties **")] IAudioNodeEmitterConeProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShape*, IAudioNodeEmitterConeProperties**, int>)(lpVtbl[7]))((IAudioNodeEmitterShape*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::Media::Audio::AudioNodeEmitterShapeKind *")] AudioNodeEmitterShapeKind* value);

        [VtblIndex(7)]
        HRESULT get_ConeProperties([NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterConeProperties **")] IAudioNodeEmitterConeProperties** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::AudioNodeEmitterShapeKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioNodeEmitterShapeKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioNodeEmitterConeProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioNodeEmitterConeProperties**, int> get_ConeProperties;
    }
}
