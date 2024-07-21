// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICreateAudioDeviceInputNodeResult.xml' path='doc/member[@name="ICreateAudioDeviceInputNodeResult"]/*' />
[Guid("16EEC7A8-1CA7-40EF-91A4-D346E0AA1BBA")]
[NativeTypeName("struct ICreateAudioDeviceInputNodeResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICreateAudioDeviceInputNodeResult : ICreateAudioDeviceInputNodeResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICreateAudioDeviceInputNodeResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioDeviceInputNodeResult*, Guid*, void**, int>)(lpVtbl[0]))((ICreateAudioDeviceInputNodeResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioDeviceInputNodeResult*, uint>)(lpVtbl[1]))((ICreateAudioDeviceInputNodeResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioDeviceInputNodeResult*, uint>)(lpVtbl[2]))((ICreateAudioDeviceInputNodeResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioDeviceInputNodeResult*, uint*, Guid**, int>)(lpVtbl[3]))((ICreateAudioDeviceInputNodeResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioDeviceInputNodeResult*, HSTRING*, int>)(lpVtbl[4]))((ICreateAudioDeviceInputNodeResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioDeviceInputNodeResult*, TrustLevel*, int>)(lpVtbl[5]))((ICreateAudioDeviceInputNodeResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICreateAudioDeviceInputNodeResult.xml' path='doc/member[@name="ICreateAudioDeviceInputNodeResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Audio::AudioDeviceNodeCreationStatus *")] AudioDeviceNodeCreationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioDeviceInputNodeResult*, AudioDeviceNodeCreationStatus*, int>)(lpVtbl[6]))((ICreateAudioDeviceInputNodeResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICreateAudioDeviceInputNodeResult.xml' path='doc/member[@name="ICreateAudioDeviceInputNodeResult.get_DeviceInputNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DeviceInputNode([NativeTypeName("ABI::Windows::Media::Audio::IAudioDeviceInputNode **")] IAudioDeviceInputNode** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateAudioDeviceInputNodeResult*, IAudioDeviceInputNode**, int>)(lpVtbl[7]))((ICreateAudioDeviceInputNodeResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Audio::AudioDeviceNodeCreationStatus *")] AudioDeviceNodeCreationStatus* value);

        [VtblIndex(7)]
        HRESULT get_DeviceInputNode([NativeTypeName("ABI::Windows::Media::Audio::IAudioDeviceInputNode **")] IAudioDeviceInputNode** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::AudioDeviceNodeCreationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioDeviceNodeCreationStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioDeviceInputNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioDeviceInputNode**, int> get_DeviceInputNode;
    }
}
