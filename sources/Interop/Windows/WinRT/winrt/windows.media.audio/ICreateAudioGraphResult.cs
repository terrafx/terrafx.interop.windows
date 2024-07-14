// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICreateAudioGraphResult.xml' path='doc/member[@name="ICreateAudioGraphResult"]/*' />
[Guid("5453EF7E-7BDE-4B76-BB5D-48F79CFC8C0B")]
[NativeTypeName("struct ICreateAudioGraphResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICreateAudioGraphResult : ICreateAudioGraphResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICreateAudioGraphResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioGraphResult*, Guid*, void**, int>)(lpVtbl[0]))((ICreateAudioGraphResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioGraphResult*, uint>)(lpVtbl[1]))((ICreateAudioGraphResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioGraphResult*, uint>)(lpVtbl[2]))((ICreateAudioGraphResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioGraphResult*, uint*, Guid**, int>)(lpVtbl[3]))((ICreateAudioGraphResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioGraphResult*, HSTRING*, int>)(lpVtbl[4]))((ICreateAudioGraphResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioGraphResult*, TrustLevel*, int>)(lpVtbl[5]))((ICreateAudioGraphResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICreateAudioGraphResult.xml' path='doc/member[@name="ICreateAudioGraphResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Audio::AudioGraphCreationStatus *")] AudioGraphCreationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioGraphResult*, AudioGraphCreationStatus*, int>)(lpVtbl[6]))((ICreateAudioGraphResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICreateAudioGraphResult.xml' path='doc/member[@name="ICreateAudioGraphResult.get_Graph"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Graph([NativeTypeName("ABI::Windows::Media::Audio::IAudioGraph **")] IAudioGraph** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioGraphResult*, IAudioGraph**, int>)(lpVtbl[7]))((ICreateAudioGraphResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Audio::AudioGraphCreationStatus *")] AudioGraphCreationStatus* value);

        [VtblIndex(7)]
        HRESULT get_Graph([NativeTypeName("ABI::Windows::Media::Audio::IAudioGraph **")] IAudioGraph** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::AudioGraphCreationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioGraphCreationStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioGraph **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioGraph**, int> get_Graph;
    }
}
