// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaFrameSource.xml' path='doc/member[@name="IMediaFrameSource"]/*' />
[Guid("D6782953-90DB-46A8-8ADD-2AA884A8D253")]
[NativeTypeName("struct IMediaFrameSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaFrameSource : IMediaFrameSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFrameSource));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, Guid*, void**, int>)(lpVtbl[0]))((IMediaFrameSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, uint>)(lpVtbl[1]))((IMediaFrameSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, uint>)(lpVtbl[2]))((IMediaFrameSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaFrameSource*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, HSTRING*, int>)(lpVtbl[4]))((IMediaFrameSource*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, TrustLevel*, int>)(lpVtbl[5]))((IMediaFrameSource*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaFrameSource.xml' path='doc/member[@name="IMediaFrameSource.get_Info"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Info([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceInfo **")] IMediaFrameSourceInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, IMediaFrameSourceInfo**, int>)(lpVtbl[6]))((IMediaFrameSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameSource.xml' path='doc/member[@name="IMediaFrameSource.get_Controller"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Controller([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceController **")] IMediaFrameSourceController** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, IMediaFrameSourceController**, int>)(lpVtbl[7]))((IMediaFrameSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameSource.xml' path='doc/member[@name="IMediaFrameSource.get_SupportedFormats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SupportedFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CFrames__CMediaFrameFormat_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, IVectorView<IntPtr>**, int>)(lpVtbl[8]))((IMediaFrameSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameSource.xml' path='doc/member[@name="IMediaFrameSource.get_CurrentFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CurrentFormat([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **")] IMediaFrameFormat** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, IMediaFrameFormat**, int>)(lpVtbl[9]))((IMediaFrameSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameSource.xml' path='doc/member[@name="IMediaFrameSource.SetFormatAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetFormatAsync([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat *")] IMediaFrameFormat* format, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, IMediaFrameFormat*, IAsyncAction**, int>)(lpVtbl[10]))((IMediaFrameSource*)Unsafe.AsPointer(ref this), format, value);
    }

    /// <include file='IMediaFrameSource.xml' path='doc/member[@name="IMediaFrameSource.add_FormatChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_FormatChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IMediaFrameSource*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaFrameSource.xml' path='doc/member[@name="IMediaFrameSource.remove_FormatChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_FormatChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, EventRegistrationToken, int>)(lpVtbl[12]))((IMediaFrameSource*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaFrameSource.xml' path='doc/member[@name="IMediaFrameSource.TryGetCameraIntrinsics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT TryGetCameraIntrinsics([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat *")] IMediaFrameFormat* format, [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics **")] ICameraIntrinsics** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSource*, IMediaFrameFormat*, ICameraIntrinsics**, int>)(lpVtbl[13]))((IMediaFrameSource*)Unsafe.AsPointer(ref this), format, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Info([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceInfo **")] IMediaFrameSourceInfo** value);

        [VtblIndex(7)]
        HRESULT get_Controller([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceController **")] IMediaFrameSourceController** value);

        [VtblIndex(8)]
        HRESULT get_SupportedFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CFrames__CMediaFrameFormat_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(9)]
        HRESULT get_CurrentFormat([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **")] IMediaFrameFormat** value);

        [VtblIndex(10)]
        HRESULT SetFormatAsync([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat *")] IMediaFrameFormat* format, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(11)]
        HRESULT add_FormatChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_FormatChanged(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT TryGetCameraIntrinsics([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat *")] IMediaFrameFormat* format, [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics **")] ICameraIntrinsics** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSourceInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameSourceInfo**, int> get_Info;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSourceController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameSourceController**, int> get_Controller;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CFrames__CMediaFrameFormat_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_SupportedFormats;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameFormat**, int> get_CurrentFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameFormat *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameFormat*, IAsyncAction**, int> SetFormatAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_FormatChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_FormatChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameFormat *, ABI::Windows::Media::Devices::Core::ICameraIntrinsics **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameFormat*, ICameraIntrinsics**, int> TryGetCameraIntrinsics;
    }
}
