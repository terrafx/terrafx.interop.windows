// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVariablePhotoSequenceController.xml' path='doc/member[@name="IVariablePhotoSequenceController"]/*' />
[Guid("7FBFF880-ED8C-43FD-A7C3-B35809E4229A")]
[NativeTypeName("struct IVariablePhotoSequenceController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVariablePhotoSequenceController : IVariablePhotoSequenceController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVariablePhotoSequenceController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, Guid*, void**, int>)(lpVtbl[0]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, uint>)(lpVtbl[1]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, uint>)(lpVtbl[2]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, uint*, Guid**, int>)(lpVtbl[3]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, HSTRING*, int>)(lpVtbl[4]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, TrustLevel*, int>)(lpVtbl[5]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVariablePhotoSequenceController.xml' path='doc/member[@name="IVariablePhotoSequenceController.get_Supported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, byte*, int>)(lpVtbl[6]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVariablePhotoSequenceController.xml' path='doc/member[@name="IVariablePhotoSequenceController.get_MaxPhotosPerSecond"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MaxPhotosPerSecond(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, float*, int>)(lpVtbl[7]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVariablePhotoSequenceController.xml' path='doc/member[@name="IVariablePhotoSequenceController.get_PhotosPerSecondLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PhotosPerSecondLimit(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, float*, int>)(lpVtbl[8]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVariablePhotoSequenceController.xml' path='doc/member[@name="IVariablePhotoSequenceController.put_PhotosPerSecondLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_PhotosPerSecondLimit(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, float, int>)(lpVtbl[9]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVariablePhotoSequenceController.xml' path='doc/member[@name="IVariablePhotoSequenceController.GetHighestConcurrentFrameRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetHighestConcurrentFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")] IMediaEncodingProperties* captureProperties, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, IMediaEncodingProperties*, IMediaRatio**, int>)(lpVtbl[10]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this), captureProperties, value);
    }

    /// <include file='IVariablePhotoSequenceController.xml' path='doc/member[@name="IVariablePhotoSequenceController.GetCurrentFrameRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCurrentFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, IMediaRatio**, int>)(lpVtbl[11]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVariablePhotoSequenceController.xml' path='doc/member[@name="IVariablePhotoSequenceController.get_FrameCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FrameCapabilities([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameControlCapabilities **")] IFrameControlCapabilities** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, IFrameControlCapabilities**, int>)(lpVtbl[12]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVariablePhotoSequenceController.xml' path='doc/member[@name="IVariablePhotoSequenceController.get_DesiredFrameControllers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_DesiredFrameControllers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CDevices__CCore__CFrameController_t **")] IVector<Pointer<IFrameController>>** items)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoSequenceController*, IVector<Pointer<IFrameController>>**, int>)(lpVtbl[13]))((IVariablePhotoSequenceController*)Unsafe.AsPointer(ref this), items);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_MaxPhotosPerSecond(float* value);

        [VtblIndex(8)]
        HRESULT get_PhotosPerSecondLimit(float* value);

        [VtblIndex(9)]
        HRESULT put_PhotosPerSecondLimit(float value);

        [VtblIndex(10)]
        HRESULT GetHighestConcurrentFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")] IMediaEncodingProperties* captureProperties, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value);

        [VtblIndex(11)]
        HRESULT GetCurrentFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value);

        [VtblIndex(12)]
        HRESULT get_FrameCapabilities([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameControlCapabilities **")] IFrameControlCapabilities** value);

        [VtblIndex(13)]
        HRESULT get_DesiredFrameControllers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CDevices__CCore__CFrameController_t **")] IVector<Pointer<IFrameController>>** items);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Supported;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_MaxPhotosPerSecond;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_PhotosPerSecondLimit;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_PhotosPerSecondLimit;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *, ABI::Windows::Media::MediaProperties::IMediaRatio **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProperties*, IMediaRatio**, int> GetHighestConcurrentFrameRate;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaRatio **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaRatio**, int> GetCurrentFrameRate;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::IFrameControlCapabilities **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFrameControlCapabilities**, int> get_FrameCapabilities;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CDevices__CCore__CFrameController_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IFrameController>>**, int> get_DesiredFrameControllers;
    }
}
