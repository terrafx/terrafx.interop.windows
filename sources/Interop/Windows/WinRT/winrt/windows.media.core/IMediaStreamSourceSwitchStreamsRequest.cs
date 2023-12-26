// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaStreamSourceSwitchStreamsRequest.xml' path='doc/member[@name="IMediaStreamSourceSwitchStreamsRequest"]/*' />
[Guid("41B8808E-38A9-4EC3-9BA0-B69B85501E90")]
[NativeTypeName("struct IMediaStreamSourceSwitchStreamsRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaStreamSourceSwitchStreamsRequest : IMediaStreamSourceSwitchStreamsRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaStreamSourceSwitchStreamsRequest));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequest*, Guid*, void**, int>)(lpVtbl[0]))((IMediaStreamSourceSwitchStreamsRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequest*, uint>)(lpVtbl[1]))((IMediaStreamSourceSwitchStreamsRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequest*, uint>)(lpVtbl[2]))((IMediaStreamSourceSwitchStreamsRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequest*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaStreamSourceSwitchStreamsRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequest*, HSTRING*, int>)(lpVtbl[4]))((IMediaStreamSourceSwitchStreamsRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequest*, TrustLevel*, int>)(lpVtbl[5]))((IMediaStreamSourceSwitchStreamsRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaStreamSourceSwitchStreamsRequest.xml' path='doc/member[@name="IMediaStreamSourceSwitchStreamsRequest.get_OldStreamDescriptor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OldStreamDescriptor([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor **")] IMediaStreamDescriptor** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequest*, IMediaStreamDescriptor**, int>)(lpVtbl[6]))((IMediaStreamSourceSwitchStreamsRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSourceSwitchStreamsRequest.xml' path='doc/member[@name="IMediaStreamSourceSwitchStreamsRequest.get_NewStreamDescriptor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_NewStreamDescriptor([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor **")] IMediaStreamDescriptor** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequest*, IMediaStreamDescriptor**, int>)(lpVtbl[7]))((IMediaStreamSourceSwitchStreamsRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaStreamSourceSwitchStreamsRequest.xml' path='doc/member[@name="IMediaStreamSourceSwitchStreamsRequest.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSourceSwitchStreamsRequestDeferral **")] IMediaStreamSourceSwitchStreamsRequestDeferral** deferral)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequest*, IMediaStreamSourceSwitchStreamsRequestDeferral**, int>)(lpVtbl[8]))((IMediaStreamSourceSwitchStreamsRequest*)Unsafe.AsPointer(ref this), deferral);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OldStreamDescriptor([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor **")] IMediaStreamDescriptor** value);

        [VtblIndex(7)]
        HRESULT get_NewStreamDescriptor([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor **")] IMediaStreamDescriptor** value);

        [VtblIndex(8)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSourceSwitchStreamsRequestDeferral **")] IMediaStreamSourceSwitchStreamsRequestDeferral** deferral);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamDescriptor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamDescriptor**, int> get_OldStreamDescriptor;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamDescriptor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamDescriptor**, int> get_NewStreamDescriptor;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamSourceSwitchStreamsRequestDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamSourceSwitchStreamsRequestDeferral**, int> GetDeferral;
    }
}
