// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings"]/*' />
[Guid("C30BDF62-9948-458F-AD50-AA06EC03DA08")]
[NativeTypeName("struct IAppBroadcastProviderSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastProviderSettings : IAppBroadcastProviderSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppBroadcastProviderSettings);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, uint>)(lpVtbl[1]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, uint>)(lpVtbl[2]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.put_DefaultBroadcastTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_DefaultBroadcastTitle(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, HSTRING, int>)(lpVtbl[6]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.get_DefaultBroadcastTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DefaultBroadcastTitle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, HSTRING*, int>)(lpVtbl[7]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.put_AudioEncodingBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_AudioEncodingBitrate([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, uint, int>)(lpVtbl[8]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.get_AudioEncodingBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AudioEncodingBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, uint*, int>)(lpVtbl[9]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.put_CustomVideoEncodingBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_CustomVideoEncodingBitrate([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, uint, int>)(lpVtbl[10]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.get_CustomVideoEncodingBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CustomVideoEncodingBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, uint*, int>)(lpVtbl[11]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.put_CustomVideoEncodingHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_CustomVideoEncodingHeight([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, uint, int>)(lpVtbl[12]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.get_CustomVideoEncodingHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_CustomVideoEncodingHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, uint*, int>)(lpVtbl[13]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.put_CustomVideoEncodingWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_CustomVideoEncodingWidth([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, uint, int>)(lpVtbl[14]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.get_CustomVideoEncodingWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_CustomVideoEncodingWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, uint*, int>)(lpVtbl[15]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.put_VideoEncodingBitrateMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_VideoEncodingBitrateMode([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingBitrateMode")] AppBroadcastVideoEncodingBitrateMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, AppBroadcastVideoEncodingBitrateMode, int>)(lpVtbl[16]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.get_VideoEncodingBitrateMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_VideoEncodingBitrateMode([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingBitrateMode *")] AppBroadcastVideoEncodingBitrateMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, AppBroadcastVideoEncodingBitrateMode*, int>)(lpVtbl[17]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.put_VideoEncodingResolutionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_VideoEncodingResolutionMode([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingResolutionMode")] AppBroadcastVideoEncodingResolutionMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, AppBroadcastVideoEncodingResolutionMode, int>)(lpVtbl[18]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastProviderSettings.xml' path='doc/member[@name="IAppBroadcastProviderSettings.get_VideoEncodingResolutionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_VideoEncodingResolutionMode([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingResolutionMode *")] AppBroadcastVideoEncodingResolutionMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastProviderSettings*, AppBroadcastVideoEncodingResolutionMode*, int>)(lpVtbl[19]))((IAppBroadcastProviderSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_DefaultBroadcastTitle(HSTRING value);

        [VtblIndex(7)]
        HRESULT get_DefaultBroadcastTitle(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_AudioEncodingBitrate([NativeTypeName("UINT32")] uint value);

        [VtblIndex(9)]
        HRESULT get_AudioEncodingBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT put_CustomVideoEncodingBitrate([NativeTypeName("UINT32")] uint value);

        [VtblIndex(11)]
        HRESULT get_CustomVideoEncodingBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT put_CustomVideoEncodingHeight([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT get_CustomVideoEncodingHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT put_CustomVideoEncodingWidth([NativeTypeName("UINT32")] uint value);

        [VtblIndex(15)]
        HRESULT get_CustomVideoEncodingWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT put_VideoEncodingBitrateMode([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingBitrateMode")] AppBroadcastVideoEncodingBitrateMode value);

        [VtblIndex(17)]
        HRESULT get_VideoEncodingBitrateMode([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingBitrateMode *")] AppBroadcastVideoEncodingBitrateMode* value);

        [VtblIndex(18)]
        HRESULT put_VideoEncodingResolutionMode([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingResolutionMode")] AppBroadcastVideoEncodingResolutionMode value);

        [VtblIndex(19)]
        HRESULT get_VideoEncodingResolutionMode([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastVideoEncodingResolutionMode *")] AppBroadcastVideoEncodingResolutionMode* value);
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

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DefaultBroadcastTitle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DefaultBroadcastTitle;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_AudioEncodingBitrate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_AudioEncodingBitrate;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_CustomVideoEncodingBitrate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_CustomVideoEncodingBitrate;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_CustomVideoEncodingHeight;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_CustomVideoEncodingHeight;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_CustomVideoEncodingWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_CustomVideoEncodingWidth;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastVideoEncodingBitrateMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastVideoEncodingBitrateMode, int> put_VideoEncodingBitrateMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastVideoEncodingBitrateMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastVideoEncodingBitrateMode*, int> get_VideoEncodingBitrateMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastVideoEncodingResolutionMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastVideoEncodingResolutionMode, int> put_VideoEncodingResolutionMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastVideoEncodingResolutionMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastVideoEncodingResolutionMode*, int> get_VideoEncodingResolutionMode;
    }
}
