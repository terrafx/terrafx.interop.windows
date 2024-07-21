// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppCaptureServices.xml' path='doc/member[@name="IAppCaptureServices"]/*' />
[Guid("44FEC0B5-34F5-4F18-AE8C-B9123ABBFC0D")]
[NativeTypeName("struct IAppCaptureServices : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureServices : IAppCaptureServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureServices));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureServices*, Guid*, void**, int>)(lpVtbl[0]))((IAppCaptureServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureServices*, uint>)(lpVtbl[1]))((IAppCaptureServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureServices*, uint>)(lpVtbl[2]))((IAppCaptureServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureServices*, uint*, Guid**, int>)(lpVtbl[3]))((IAppCaptureServices*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureServices*, HSTRING*, int>)(lpVtbl[4]))((IAppCaptureServices*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureServices*, TrustLevel*, int>)(lpVtbl[5]))((IAppCaptureServices*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppCaptureServices.xml' path='doc/member[@name="IAppCaptureServices.Record"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Record([NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureRecordOperation **")] IAppCaptureRecordOperation** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureServices*, IAppCaptureRecordOperation**, int>)(lpVtbl[6]))((IAppCaptureServices*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAppCaptureServices.xml' path='doc/member[@name="IAppCaptureServices.RecordTimeSpan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RecordTimeSpan([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration, [NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureRecordOperation **")] IAppCaptureRecordOperation** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureServices*, WinRTDateTime, TimeSpan, IAppCaptureRecordOperation**, int>)(lpVtbl[7]))((IAppCaptureServices*)Unsafe.AsPointer(ref this), startTime, duration, operation);
    }

    /// <include file='IAppCaptureServices.xml' path='doc/member[@name="IAppCaptureServices.get_CanCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CanCapture([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureServices*, byte*, int>)(lpVtbl[8]))((IAppCaptureServices*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureServices.xml' path='doc/member[@name="IAppCaptureServices.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureState **")] IAppCaptureState** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureServices*, IAppCaptureState**, int>)(lpVtbl[9]))((IAppCaptureServices*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Record([NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureRecordOperation **")] IAppCaptureRecordOperation** operation);

        [VtblIndex(7)]
        HRESULT RecordTimeSpan([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime startTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration, [NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureRecordOperation **")] IAppCaptureRecordOperation** operation);

        [VtblIndex(8)]
        HRESULT get_CanCapture([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureState **")] IAppCaptureState** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppCaptureRecordOperation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppCaptureRecordOperation**, int> Record;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Media::Capture::IAppCaptureRecordOperation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, TimeSpan, IAppCaptureRecordOperation**, int> RecordTimeSpan;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanCapture;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppCaptureState **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppCaptureState**, int> get_State;
    }
}
