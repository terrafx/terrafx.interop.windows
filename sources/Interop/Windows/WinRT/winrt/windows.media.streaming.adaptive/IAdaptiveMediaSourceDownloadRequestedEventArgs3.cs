// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdaptiveMediaSourceDownloadRequestedEventArgs3.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadRequestedEventArgs3"]/*' />
[Guid("333C50FD-4F62-4481-AB44-1E47B0574225")]
[NativeTypeName("struct IAdaptiveMediaSourceDownloadRequestedEventArgs3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSourceDownloadRequestedEventArgs3 : IAdaptiveMediaSourceDownloadRequestedEventArgs3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdaptiveMediaSourceDownloadRequestedEventArgs3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs3*, Guid*, void**, int>)(lpVtbl[0]))((IAdaptiveMediaSourceDownloadRequestedEventArgs3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs3*, uint>)(lpVtbl[1]))((IAdaptiveMediaSourceDownloadRequestedEventArgs3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs3*, uint>)(lpVtbl[2]))((IAdaptiveMediaSourceDownloadRequestedEventArgs3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs3*, uint*, Guid**, int>)(lpVtbl[3]))((IAdaptiveMediaSourceDownloadRequestedEventArgs3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs3*, HSTRING*, int>)(lpVtbl[4]))((IAdaptiveMediaSourceDownloadRequestedEventArgs3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs3*, TrustLevel*, int>)(lpVtbl[5]))((IAdaptiveMediaSourceDownloadRequestedEventArgs3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdaptiveMediaSourceDownloadRequestedEventArgs3.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadRequestedEventArgs3.get_ResourceDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResourceDuration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs3*, IReference<TimeSpan>**, int>)(lpVtbl[6]))((IAdaptiveMediaSourceDownloadRequestedEventArgs3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDownloadRequestedEventArgs3.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadRequestedEventArgs3.get_ResourceContentType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ResourceContentType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadRequestedEventArgs3*, HSTRING*, int>)(lpVtbl[7]))((IAdaptiveMediaSourceDownloadRequestedEventArgs3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResourceDuration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(7)]
        HRESULT get_ResourceContentType(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_ResourceDuration;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ResourceContentType;
    }
}
