// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureVideoProfileMediaDescription.xml' path='doc/member[@name="IMediaCaptureVideoProfileMediaDescription"]/*' />
[Guid("8012AFEF-B691-49FF-83F2-C1E76EAAEA1B")]
[NativeTypeName("struct IMediaCaptureVideoProfileMediaDescription : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureVideoProfileMediaDescription : IMediaCaptureVideoProfileMediaDescription.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaCaptureVideoProfileMediaDescription);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfileMediaDescription*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureVideoProfileMediaDescription*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfileMediaDescription*, uint>)(lpVtbl[1]))((IMediaCaptureVideoProfileMediaDescription*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfileMediaDescription*, uint>)(lpVtbl[2]))((IMediaCaptureVideoProfileMediaDescription*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfileMediaDescription*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureVideoProfileMediaDescription*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfileMediaDescription*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureVideoProfileMediaDescription*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfileMediaDescription*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureVideoProfileMediaDescription*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureVideoProfileMediaDescription.xml' path='doc/member[@name="IMediaCaptureVideoProfileMediaDescription.get_Width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Width([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfileMediaDescription*, uint*, int>)(lpVtbl[6]))((IMediaCaptureVideoProfileMediaDescription*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureVideoProfileMediaDescription.xml' path='doc/member[@name="IMediaCaptureVideoProfileMediaDescription.get_Height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Height([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfileMediaDescription*, uint*, int>)(lpVtbl[7]))((IMediaCaptureVideoProfileMediaDescription*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureVideoProfileMediaDescription.xml' path='doc/member[@name="IMediaCaptureVideoProfileMediaDescription.get_FrameRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FrameRate(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfileMediaDescription*, double*, int>)(lpVtbl[8]))((IMediaCaptureVideoProfileMediaDescription*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureVideoProfileMediaDescription.xml' path='doc/member[@name="IMediaCaptureVideoProfileMediaDescription.get_IsVariablePhotoSequenceSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("IsVariablePhotoSequenceSupported might not be available in the next major update following Windows 10, version 1709")]
    public HRESULT get_IsVariablePhotoSequenceSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfileMediaDescription*, byte*, int>)(lpVtbl[9]))((IMediaCaptureVideoProfileMediaDescription*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureVideoProfileMediaDescription.xml' path='doc/member[@name="IMediaCaptureVideoProfileMediaDescription.get_IsHdrVideoSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("IsHdrVideoSupported might not be available in the next major update following Windows 10, version 1709")]
    public HRESULT get_IsHdrVideoSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfileMediaDescription*, byte*, int>)(lpVtbl[10]))((IMediaCaptureVideoProfileMediaDescription*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Width([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_Height([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_FrameRate(double* value);

        [VtblIndex(9)]
        [Obsolete("IsVariablePhotoSequenceSupported might not be available in the next major update following Windows 10, version 1709")]
        HRESULT get_IsVariablePhotoSequenceSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        [Obsolete("IsHdrVideoSupported might not be available in the next major update following Windows 10, version 1709")]
        HRESULT get_IsHdrVideoSupported([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Width;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Height;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_FrameRate;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("IsVariablePhotoSequenceSupported might not be available in the next major update following Windows 10, version 1709")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsVariablePhotoSequenceSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("IsHdrVideoSupported might not be available in the next major update following Windows 10, version 1709")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsHdrVideoSupported;
    }
}
