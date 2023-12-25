// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDefaultAudioDeviceChangedEventArgs.xml' path='doc/member[@name="IDefaultAudioDeviceChangedEventArgs"]/*' />
[Guid("110F882F-1C05-4657-A18E-47C9B69F07AB")]
[NativeTypeName("struct IDefaultAudioDeviceChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDefaultAudioDeviceChangedEventArgs : IDefaultAudioDeviceChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDefaultAudioDeviceChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDefaultAudioDeviceChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IDefaultAudioDeviceChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDefaultAudioDeviceChangedEventArgs*, uint>)(lpVtbl[1]))((IDefaultAudioDeviceChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDefaultAudioDeviceChangedEventArgs*, uint>)(lpVtbl[2]))((IDefaultAudioDeviceChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDefaultAudioDeviceChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IDefaultAudioDeviceChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDefaultAudioDeviceChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IDefaultAudioDeviceChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDefaultAudioDeviceChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IDefaultAudioDeviceChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDefaultAudioDeviceChangedEventArgs.xml' path='doc/member[@name="IDefaultAudioDeviceChangedEventArgs.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDefaultAudioDeviceChangedEventArgs*, HSTRING*, int>)(lpVtbl[6]))((IDefaultAudioDeviceChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDefaultAudioDeviceChangedEventArgs.xml' path='doc/member[@name="IDefaultAudioDeviceChangedEventArgs.get_Role"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Role([NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole *")] AudioDeviceRole* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDefaultAudioDeviceChangedEventArgs*, AudioDeviceRole*, int>)(lpVtbl[7]))((IDefaultAudioDeviceChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Role([NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole *")] AudioDeviceRole* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::AudioDeviceRole *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioDeviceRole*, int> get_Role;
    }
}
