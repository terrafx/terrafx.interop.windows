// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICameraCaptureUIVideoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIVideoCaptureSettings"]/*' />
[Guid("64E92D1F-A28D-425A-B84F-E568335FF24E")]
[NativeTypeName("struct ICameraCaptureUIVideoCaptureSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraCaptureUIVideoCaptureSettings : ICameraCaptureUIVideoCaptureSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICameraCaptureUIVideoCaptureSettings);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, Guid*, void**, int>)(lpVtbl[0]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, uint>)(lpVtbl[1]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, uint>)(lpVtbl[2]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, uint*, Guid**, int>)(lpVtbl[3]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, HSTRING*, int>)(lpVtbl[4]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, TrustLevel*, int>)(lpVtbl[5]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICameraCaptureUIVideoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIVideoCaptureSettings.get_Format"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Format([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIVideoFormat *")] CameraCaptureUIVideoFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, CameraCaptureUIVideoFormat*, int>)(lpVtbl[6]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIVideoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIVideoCaptureSettings.put_Format"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Format([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIVideoFormat")] CameraCaptureUIVideoFormat value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, CameraCaptureUIVideoFormat, int>)(lpVtbl[7]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIVideoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIVideoCaptureSettings.get_MaxResolution"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxResolution([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMaxVideoResolution *")] CameraCaptureUIMaxVideoResolution* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, CameraCaptureUIMaxVideoResolution*, int>)(lpVtbl[8]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIVideoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIVideoCaptureSettings.put_MaxResolution"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MaxResolution([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMaxVideoResolution")] CameraCaptureUIMaxVideoResolution value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, CameraCaptureUIMaxVideoResolution, int>)(lpVtbl[9]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIVideoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIVideoCaptureSettings.get_MaxDurationInSeconds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaxDurationInSeconds(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, float*, int>)(lpVtbl[10]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIVideoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIVideoCaptureSettings.put_MaxDurationInSeconds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_MaxDurationInSeconds(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, float, int>)(lpVtbl[11]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIVideoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIVideoCaptureSettings.get_AllowTrimming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AllowTrimming([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, byte*, int>)(lpVtbl[12]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUIVideoCaptureSettings.xml' path='doc/member[@name="ICameraCaptureUIVideoCaptureSettings.put_AllowTrimming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_AllowTrimming([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUIVideoCaptureSettings*, byte, int>)(lpVtbl[13]))((ICameraCaptureUIVideoCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Format([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIVideoFormat *")] CameraCaptureUIVideoFormat* value);

        [VtblIndex(7)]
        HRESULT put_Format([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIVideoFormat")] CameraCaptureUIVideoFormat value);

        [VtblIndex(8)]
        HRESULT get_MaxResolution([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMaxVideoResolution *")] CameraCaptureUIMaxVideoResolution* value);

        [VtblIndex(9)]
        HRESULT put_MaxResolution([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMaxVideoResolution")] CameraCaptureUIMaxVideoResolution value);

        [VtblIndex(10)]
        HRESULT get_MaxDurationInSeconds(float* value);

        [VtblIndex(11)]
        HRESULT put_MaxDurationInSeconds(float value);

        [VtblIndex(12)]
        HRESULT get_AllowTrimming([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_AllowTrimming([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIVideoFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CameraCaptureUIVideoFormat*, int> get_Format;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIVideoFormat) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CameraCaptureUIVideoFormat, int> put_Format;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIMaxVideoResolution *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CameraCaptureUIMaxVideoResolution*, int> get_MaxResolution;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIMaxVideoResolution) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CameraCaptureUIMaxVideoResolution, int> put_MaxResolution;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_MaxDurationInSeconds;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_MaxDurationInSeconds;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AllowTrimming;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllowTrimming;
    }
}
