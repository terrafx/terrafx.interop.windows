// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastPlugIn.xml' path='doc/member[@name="IAppBroadcastPlugIn"]/*' />
[Guid("520C1E66-6513-4574-AC54-23B79729615B")]
[NativeTypeName("struct IAppBroadcastPlugIn : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastPlugIn : IAppBroadcastPlugIn.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppBroadcastPlugIn);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugIn*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastPlugIn*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugIn*, uint>)(lpVtbl[1]))((IAppBroadcastPlugIn*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugIn*, uint>)(lpVtbl[2]))((IAppBroadcastPlugIn*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugIn*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastPlugIn*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugIn*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastPlugIn*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugIn*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastPlugIn*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastPlugIn.xml' path='doc/member[@name="IAppBroadcastPlugIn.get_AppId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugIn*, HSTRING*, int>)(lpVtbl[6]))((IAppBroadcastPlugIn*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastPlugIn.xml' path='doc/member[@name="IAppBroadcastPlugIn.get_ProviderSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ProviderSettings([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastProviderSettings **")] IAppBroadcastProviderSettings** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugIn*, IAppBroadcastProviderSettings**, int>)(lpVtbl[7]))((IAppBroadcastPlugIn*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastPlugIn.xml' path='doc/member[@name="IAppBroadcastPlugIn.get_Logo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Logo([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugIn*, IRandomAccessStreamReference**, int>)(lpVtbl[8]))((IAppBroadcastPlugIn*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastPlugIn.xml' path='doc/member[@name="IAppBroadcastPlugIn.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPlugIn*, HSTRING*, int>)(lpVtbl[9]))((IAppBroadcastPlugIn*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ProviderSettings([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastProviderSettings **")] IAppBroadcastProviderSettings** value);

        [VtblIndex(8)]
        HRESULT get_Logo([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(9)]
        HRESULT get_DisplayName(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AppId;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastProviderSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastProviderSettings**, int> get_ProviderSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Logo;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;
    }
}
