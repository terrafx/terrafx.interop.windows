// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioNodeEmitter2.xml' path='doc/member[@name="IAudioNodeEmitter2"]/*' />
[Guid("4AB6EECB-EC29-47F8-818C-B6B660A5AEB1")]
[NativeTypeName("struct IAudioNodeEmitter2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNodeEmitter2 : IAudioNodeEmitter2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioNodeEmitter2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitter2*, Guid*, void**, int>)(lpVtbl[0]))((IAudioNodeEmitter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitter2*, uint>)(lpVtbl[1]))((IAudioNodeEmitter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitter2*, uint>)(lpVtbl[2]))((IAudioNodeEmitter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitter2*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioNodeEmitter2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitter2*, HSTRING*, int>)(lpVtbl[4]))((IAudioNodeEmitter2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitter2*, TrustLevel*, int>)(lpVtbl[5]))((IAudioNodeEmitter2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioNodeEmitter2.xml' path='doc/member[@name="IAudioNodeEmitter2.get_SpatialAudioModel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SpatialAudioModel([NativeTypeName("ABI::Windows::Media::Audio::SpatialAudioModel *")] SpatialAudioModel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitter2*, SpatialAudioModel*, int>)(lpVtbl[6]))((IAudioNodeEmitter2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeEmitter2.xml' path='doc/member[@name="IAudioNodeEmitter2.put_SpatialAudioModel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SpatialAudioModel([NativeTypeName("ABI::Windows::Media::Audio::SpatialAudioModel")] SpatialAudioModel value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitter2*, SpatialAudioModel, int>)(lpVtbl[7]))((IAudioNodeEmitter2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SpatialAudioModel([NativeTypeName("ABI::Windows::Media::Audio::SpatialAudioModel *")] SpatialAudioModel* value);

        [VtblIndex(7)]
        HRESULT put_SpatialAudioModel([NativeTypeName("ABI::Windows::Media::Audio::SpatialAudioModel")] SpatialAudioModel value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::SpatialAudioModel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpatialAudioModel*, int> get_SpatialAudioModel;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::SpatialAudioModel) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpatialAudioModel, int> put_SpatialAudioModel;
    }
}
