// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices"]/*' />
[Guid("8660B4D6-969B-4E3C-AC3A-8B042EE4EE63")]
[NativeTypeName("struct IAppBroadcastServices : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastServices : IAppBroadcastServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppBroadcastServices);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, uint>)(lpVtbl[1]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, uint>)(lpVtbl[2]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.get_CaptureTargetType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CaptureTargetType([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCaptureTargetType *")] AppBroadcastCaptureTargetType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, AppBroadcastCaptureTargetType*, int>)(lpVtbl[6]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.put_CaptureTargetType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CaptureTargetType([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCaptureTargetType")] AppBroadcastCaptureTargetType value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, AppBroadcastCaptureTargetType, int>)(lpVtbl[7]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.get_BroadcastTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BroadcastTitle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, HSTRING*, int>)(lpVtbl[8]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.put_BroadcastTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BroadcastTitle(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, HSTRING, int>)(lpVtbl[9]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.get_BroadcastLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BroadcastLanguage(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, HSTRING*, int>)(lpVtbl[10]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.put_BroadcastLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_BroadcastLanguage(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, HSTRING, int>)(lpVtbl[11]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.get_UserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_UserName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, HSTRING*, int>)(lpVtbl[12]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.get_CanCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_CanCapture([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, byte*, int>)(lpVtbl[13]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.EnterBroadcastModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnterBroadcastModeAsync([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPlugIn *")] IAppBroadcastPlugIn* plugIn, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, IAppBroadcastPlugIn*, IAsyncOperation<uint>**, int>)(lpVtbl[14]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), plugIn, operation);
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.ExitBroadcastMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ExitBroadcastMode([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastExitBroadcastModeReason")] AppBroadcastExitBroadcastModeReason reason)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, AppBroadcastExitBroadcastModeReason, int>)(lpVtbl[15]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), reason);
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.StartBroadcast"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT StartBroadcast()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, int>)(lpVtbl[16]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.PauseBroadcast"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PauseBroadcast()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, int>)(lpVtbl[17]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.ResumeBroadcast"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ResumeBroadcast()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, int>)(lpVtbl[18]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.StartPreview"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT StartPreview([NativeTypeName("ABI::Windows::Foundation::Size")] Size desiredSize, [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPreview **")] IAppBroadcastPreview** preview)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, Size, IAppBroadcastPreview**, int>)(lpVtbl[19]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), desiredSize, preview);
    }

    /// <include file='IAppBroadcastServices.xml' path='doc/member[@name="IAppBroadcastServices.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastState **")] IAppBroadcastState** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastServices*, IAppBroadcastState**, int>)(lpVtbl[20]))((IAppBroadcastServices*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CaptureTargetType([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCaptureTargetType *")] AppBroadcastCaptureTargetType* value);

        [VtblIndex(7)]
        HRESULT put_CaptureTargetType([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCaptureTargetType")] AppBroadcastCaptureTargetType value);

        [VtblIndex(8)]
        HRESULT get_BroadcastTitle(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_BroadcastTitle(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_BroadcastLanguage(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_BroadcastLanguage(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_UserName(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_CanCapture([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT EnterBroadcastModeAsync([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPlugIn *")] IAppBroadcastPlugIn* plugIn, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation);

        [VtblIndex(15)]
        HRESULT ExitBroadcastMode([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastExitBroadcastModeReason")] AppBroadcastExitBroadcastModeReason reason);

        [VtblIndex(16)]
        HRESULT StartBroadcast();

        [VtblIndex(17)]
        HRESULT PauseBroadcast();

        [VtblIndex(18)]
        HRESULT ResumeBroadcast();

        [VtblIndex(19)]
        HRESULT StartPreview([NativeTypeName("ABI::Windows::Foundation::Size")] Size desiredSize, [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPreview **")] IAppBroadcastPreview** preview);

        [VtblIndex(20)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastState **")] IAppBroadcastState** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastCaptureTargetType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastCaptureTargetType*, int> get_CaptureTargetType;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastCaptureTargetType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastCaptureTargetType, int> put_CaptureTargetType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BroadcastTitle;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_BroadcastTitle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BroadcastLanguage;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_BroadcastLanguage;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserName;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanCapture;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastPlugIn *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastPlugIn*, IAsyncOperation<uint>**, int> EnterBroadcastModeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastExitBroadcastModeReason) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastExitBroadcastModeReason, int> ExitBroadcastMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StartBroadcast;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> PauseBroadcast;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ResumeBroadcast;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size, ABI::Windows::Media::Capture::IAppBroadcastPreview **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, IAppBroadcastPreview**, int> StartPreview;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastState **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastState**, int> get_State;
    }
}
