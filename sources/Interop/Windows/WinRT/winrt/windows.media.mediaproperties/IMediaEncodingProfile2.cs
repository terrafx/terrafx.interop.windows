// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaEncodingProfile2.xml' path='doc/member[@name="IMediaEncodingProfile2"]/*' />
[Guid("349B3E0A-4035-488E-9877-85632865ED10")]
[NativeTypeName("struct IMediaEncodingProfile2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaEncodingProfile2 : IMediaEncodingProfile2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEncodingProfile2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaEncodingProfile2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile2*, uint>)(lpVtbl[1]))((IMediaEncodingProfile2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile2*, uint>)(lpVtbl[2]))((IMediaEncodingProfile2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaEncodingProfile2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile2*, HSTRING*, int>)(lpVtbl[4]))((IMediaEncodingProfile2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaEncodingProfile2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaEncodingProfile2.xml' path='doc/member[@name="IMediaEncodingProfile2.SetAudioTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAudioTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CCore__CAudioStreamDescriptor_t *")] IIterable<Pointer<IAudioStreamDescriptor>>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile2*, IIterable<Pointer<IAudioStreamDescriptor>>*, int>)(lpVtbl[6]))((IMediaEncodingProfile2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingProfile2.xml' path='doc/member[@name="IMediaEncodingProfile2.GetAudioTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAudioTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCore__CAudioStreamDescriptor_t **")] IVector<Pointer<IAudioStreamDescriptor>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile2*, IVector<Pointer<IAudioStreamDescriptor>>**, int>)(lpVtbl[7]))((IMediaEncodingProfile2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingProfile2.xml' path='doc/member[@name="IMediaEncodingProfile2.SetVideoTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetVideoTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CCore__CVideoStreamDescriptor_t *")] IIterable<Pointer<IVideoStreamDescriptor>>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile2*, IIterable<Pointer<IVideoStreamDescriptor>>*, int>)(lpVtbl[8]))((IMediaEncodingProfile2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingProfile2.xml' path='doc/member[@name="IMediaEncodingProfile2.GetVideoTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetVideoTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCore__CVideoStreamDescriptor_t **")] IVector<Pointer<IVideoStreamDescriptor>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile2*, IVector<Pointer<IVideoStreamDescriptor>>**, int>)(lpVtbl[9]))((IMediaEncodingProfile2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetAudioTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CCore__CAudioStreamDescriptor_t *")] IIterable<Pointer<IAudioStreamDescriptor>>* value);

        [VtblIndex(7)]
        HRESULT GetAudioTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCore__CAudioStreamDescriptor_t **")] IVector<Pointer<IAudioStreamDescriptor>>** value);

        [VtblIndex(8)]
        HRESULT SetVideoTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CCore__CVideoStreamDescriptor_t *")] IIterable<Pointer<IVideoStreamDescriptor>>* value);

        [VtblIndex(9)]
        HRESULT GetVideoTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCore__CVideoStreamDescriptor_t **")] IVector<Pointer<IVideoStreamDescriptor>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CCore__CAudioStreamDescriptor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IAudioStreamDescriptor>>*, int> SetAudioTracks;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCore__CAudioStreamDescriptor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IAudioStreamDescriptor>>**, int> GetAudioTracks;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CCore__CVideoStreamDescriptor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IVideoStreamDescriptor>>*, int> SetVideoTracks;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCore__CVideoStreamDescriptor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IVideoStreamDescriptor>>**, int> GetVideoTracks;
    }
}
