// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioPlaybackConnectionStatics.xml' path='doc/member[@name="IAudioPlaybackConnectionStatics"]/*' />
[Guid("E60963A2-69E6-5FFC-9E13-824A85213DAF")]
[NativeTypeName("struct IAudioPlaybackConnectionStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioPlaybackConnectionStatics : IAudioPlaybackConnectionStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAudioPlaybackConnectionStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnectionStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAudioPlaybackConnectionStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnectionStatics*, uint>)(lpVtbl[1]))((IAudioPlaybackConnectionStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnectionStatics*, uint>)(lpVtbl[2]))((IAudioPlaybackConnectionStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnectionStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioPlaybackConnectionStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnectionStatics*, HSTRING*, int>)(lpVtbl[4]))((IAudioPlaybackConnectionStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnectionStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAudioPlaybackConnectionStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioPlaybackConnectionStatics.xml' path='doc/member[@name="IAudioPlaybackConnectionStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelector(HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnectionStatics*, HSTRING*, int>)(lpVtbl[6]))((IAudioPlaybackConnectionStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAudioPlaybackConnectionStatics.xml' path='doc/member[@name="IAudioPlaybackConnectionStatics.TryCreateFromId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryCreateFromId(HSTRING id, [NativeTypeName("ABI::Windows::Media::Audio::IAudioPlaybackConnection **")] IAudioPlaybackConnection** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioPlaybackConnectionStatics*, HSTRING, IAudioPlaybackConnection**, int>)(lpVtbl[7]))((IAudioPlaybackConnectionStatics*)Unsafe.AsPointer(ref this), id, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelector(HSTRING* result);

        [VtblIndex(7)]
        HRESULT TryCreateFromId(HSTRING id, [NativeTypeName("ABI::Windows::Media::Audio::IAudioPlaybackConnection **")] IAudioPlaybackConnection** result);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Media::Audio::IAudioPlaybackConnection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAudioPlaybackConnection**, int> TryCreateFromId;
    }
}
