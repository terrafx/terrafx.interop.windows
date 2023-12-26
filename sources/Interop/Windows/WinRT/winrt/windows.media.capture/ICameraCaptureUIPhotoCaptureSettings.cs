// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICameraCaptureUIPhotoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIPhotoCaptureSettings"]/*' />
[Guid("B9F5BE97-3472-46A8-8A9E-04CE42CCC97D")]
[NativeTypeName("struct ICameraCaptureUIPhotoCaptureSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraCaptureUIPhotoCaptureSettings : ICameraCaptureUIPhotoCaptureSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICameraCaptureUIPhotoCaptureSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, Guid*, void**, int>)(lpVtbl[0]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, uint>)(lpVtbl[1]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, uint>)(lpVtbl[2]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, uint*, Guid**, int>)(lpVtbl[3]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, HSTRING*, int>)(lpVtbl[4]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, TrustLevel*, int>)(lpVtbl[5]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICameraCaptureUIPhotoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIPhotoCaptureSettings.get_Format"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Format([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIPhotoFormat *")] CameraCaptureUIPhotoFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, CameraCaptureUIPhotoFormat*, int>)(lpVtbl[6]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIPhotoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIPhotoCaptureSettings.put_Format"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Format([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIPhotoFormat")] CameraCaptureUIPhotoFormat value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, CameraCaptureUIPhotoFormat, int>)(lpVtbl[7]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIPhotoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIPhotoCaptureSettings.get_MaxResolution"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxResolution([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMaxPhotoResolution *")] CameraCaptureUIMaxPhotoResolution* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, CameraCaptureUIMaxPhotoResolution*, int>)(lpVtbl[8]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIPhotoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIPhotoCaptureSettings.put_MaxResolution"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MaxResolution([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMaxPhotoResolution")] CameraCaptureUIMaxPhotoResolution value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, CameraCaptureUIMaxPhotoResolution, int>)(lpVtbl[9]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIPhotoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIPhotoCaptureSettings.get_CroppedSizeInPixels"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CroppedSizeInPixels([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, Size*, int>)(lpVtbl[10]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIPhotoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIPhotoCaptureSettings.put_CroppedSizeInPixels"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CroppedSizeInPixels([NativeTypeName("ABI::Windows::Foundation::Size")] Size value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, Size, int>)(lpVtbl[11]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIPhotoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIPhotoCaptureSettings.get_CroppedAspectRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CroppedAspectRatio([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, Size*, int>)(lpVtbl[12]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIPhotoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIPhotoCaptureSettings.put_CroppedAspectRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CroppedAspectRatio([NativeTypeName("ABI::Windows::Foundation::Size")] Size value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, Size, int>)(lpVtbl[13]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIPhotoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIPhotoCaptureSettings.get_AllowCropping"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_AllowCropping([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, byte*, int>)(lpVtbl[14]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIPhotoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIPhotoCaptureSettings.put_AllowCropping"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_AllowCropping([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIPhotoCaptureSettings*, byte, int>)(lpVtbl[15]))((ICameraCaptureUIPhotoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Format([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIPhotoFormat *")] CameraCaptureUIPhotoFormat* value);

        [VtblIndex(7)]
        HRESULT put_Format([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIPhotoFormat")] CameraCaptureUIPhotoFormat value);

        [VtblIndex(8)]
        HRESULT get_MaxResolution([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMaxPhotoResolution *")] CameraCaptureUIMaxPhotoResolution* value);

        [VtblIndex(9)]
        HRESULT put_MaxResolution([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMaxPhotoResolution")] CameraCaptureUIMaxPhotoResolution value);

        [VtblIndex(10)]
        HRESULT get_CroppedSizeInPixels([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(11)]
        HRESULT put_CroppedSizeInPixels([NativeTypeName("ABI::Windows::Foundation::Size")] Size value);

        [VtblIndex(12)]
        HRESULT get_CroppedAspectRatio([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(13)]
        HRESULT put_CroppedAspectRatio([NativeTypeName("ABI::Windows::Foundation::Size")] Size value);

        [VtblIndex(14)]
        HRESULT get_AllowCropping([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_AllowCropping([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIPhotoFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CameraCaptureUIPhotoFormat*, int> get_Format;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIPhotoFormat) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CameraCaptureUIPhotoFormat, int> put_Format;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIMaxPhotoResolution *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CameraCaptureUIMaxPhotoResolution*, int> get_MaxResolution;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIMaxPhotoResolution) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CameraCaptureUIMaxPhotoResolution, int> put_MaxResolution;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size*, int> get_CroppedSizeInPixels;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, int> put_CroppedSizeInPixels;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size*, int> get_CroppedAspectRatio;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, int> put_CroppedAspectRatio;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AllowCropping;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllowCropping;
    }
}
