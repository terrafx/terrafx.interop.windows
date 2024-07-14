// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureRelativePanelWatcher.xml' path='doc/member[@name="IMediaCaptureRelativePanelWatcher"]/*' />
[Guid("7D896566-04BE-5B89-B30E-BD34A9F12DB0")]
[NativeTypeName("struct IMediaCaptureRelativePanelWatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureRelativePanelWatcher : IMediaCaptureRelativePanelWatcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureRelativePanelWatcher));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureRelativePanelWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureRelativePanelWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureRelativePanelWatcher*, uint>)(lpVtbl[1]))((IMediaCaptureRelativePanelWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureRelativePanelWatcher*, uint>)(lpVtbl[2]))((IMediaCaptureRelativePanelWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureRelativePanelWatcher*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureRelativePanelWatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureRelativePanelWatcher*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureRelativePanelWatcher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureRelativePanelWatcher*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureRelativePanelWatcher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureRelativePanelWatcher.xml' path='doc/member[@name="IMediaCaptureRelativePanelWatcher.get_RelativePanel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RelativePanel([NativeTypeName("ABI::Windows::Devices::Enumeration::Panel *")] Panel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureRelativePanelWatcher*, Panel*, int>)(lpVtbl[6]))((IMediaCaptureRelativePanelWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureRelativePanelWatcher.xml' path='doc/member[@name="IMediaCaptureRelativePanelWatcher.add_Changed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_Changed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCaptureRelativePanelWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaCaptureRelativePanelWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureRelativePanelWatcher*, ITypedEventHandler<Pointer<IMediaCaptureRelativePanelWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IMediaCaptureRelativePanelWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaCaptureRelativePanelWatcher.xml' path='doc/member[@name="IMediaCaptureRelativePanelWatcher.remove_Changed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_Changed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureRelativePanelWatcher*, EventRegistrationToken, int>)(lpVtbl[8]))((IMediaCaptureRelativePanelWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaCaptureRelativePanelWatcher.xml' path='doc/member[@name="IMediaCaptureRelativePanelWatcher.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureRelativePanelWatcher*, int>)(lpVtbl[9]))((IMediaCaptureRelativePanelWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaCaptureRelativePanelWatcher.xml' path='doc/member[@name="IMediaCaptureRelativePanelWatcher.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureRelativePanelWatcher*, int>)(lpVtbl[10]))((IMediaCaptureRelativePanelWatcher*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RelativePanel([NativeTypeName("ABI::Windows::Devices::Enumeration::Panel *")] Panel* value);

        [VtblIndex(7)]
        HRESULT add_Changed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCaptureRelativePanelWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaCaptureRelativePanelWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_Changed(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT Start();

        [VtblIndex(10)]
        HRESULT Stop();
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::Panel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Panel*, int> get_RelativePanel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CMediaCaptureRelativePanelWatcher_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaCaptureRelativePanelWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Changed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Changed;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;
    }
}
