// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaStreamSourceSwitchStreamsRequestedEventArgs.xml' path='doc/member[@name="IMediaStreamSourceSwitchStreamsRequestedEventArgs"]/*' />
[Guid("42202B72-6EA1-4677-981E-350A0DA412AA")]
[NativeTypeName("struct IMediaStreamSourceSwitchStreamsRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaStreamSourceSwitchStreamsRequestedEventArgs : IMediaStreamSourceSwitchStreamsRequestedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaStreamSourceSwitchStreamsRequestedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IMediaStreamSourceSwitchStreamsRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestedEventArgs*, uint>)(lpVtbl[1]))((IMediaStreamSourceSwitchStreamsRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestedEventArgs*, uint>)(lpVtbl[2]))((IMediaStreamSourceSwitchStreamsRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaStreamSourceSwitchStreamsRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IMediaStreamSourceSwitchStreamsRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IMediaStreamSourceSwitchStreamsRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaStreamSourceSwitchStreamsRequestedEventArgs.xml' path='doc/member[@name="IMediaStreamSourceSwitchStreamsRequestedEventArgs.get_Request"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Request([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSourceSwitchStreamsRequest **")] IMediaStreamSourceSwitchStreamsRequest** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestedEventArgs*, IMediaStreamSourceSwitchStreamsRequest**, int>)(lpVtbl[6]))((IMediaStreamSourceSwitchStreamsRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Request([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSourceSwitchStreamsRequest **")] IMediaStreamSourceSwitchStreamsRequest** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamSourceSwitchStreamsRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamSourceSwitchStreamsRequest**, int> get_Request;
    }
}
