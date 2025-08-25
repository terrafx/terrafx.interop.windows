// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaOverlay.xml' path='doc/member[@name="IMediaOverlay"]/*' />
[Guid("A902AE5D-7869-4830-8AB1-94DC01C05FA4")]
[NativeTypeName("struct IMediaOverlay : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaOverlay : IMediaOverlay.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaOverlay);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, Guid*, void**, int>)(lpVtbl[0]))((IMediaOverlay*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, uint>)(lpVtbl[1]))((IMediaOverlay*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, uint>)(lpVtbl[2]))((IMediaOverlay*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaOverlay*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, HSTRING*, int>)(lpVtbl[4]))((IMediaOverlay*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, TrustLevel*, int>)(lpVtbl[5]))((IMediaOverlay*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaOverlay.xml' path='doc/member[@name="IMediaOverlay.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, Rect*, int>)(lpVtbl[6]))((IMediaOverlay*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaOverlay.xml' path='doc/member[@name="IMediaOverlay.put_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, Rect, int>)(lpVtbl[7]))((IMediaOverlay*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaOverlay.xml' path='doc/member[@name="IMediaOverlay.put_Delay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Delay([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, TimeSpan, int>)(lpVtbl[8]))((IMediaOverlay*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaOverlay.xml' path='doc/member[@name="IMediaOverlay.get_Delay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Delay([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, TimeSpan*, int>)(lpVtbl[9]))((IMediaOverlay*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaOverlay.xml' path='doc/member[@name="IMediaOverlay.get_Opacity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Opacity(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, double*, int>)(lpVtbl[10]))((IMediaOverlay*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaOverlay.xml' path='doc/member[@name="IMediaOverlay.put_Opacity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Opacity(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, double, int>)(lpVtbl[11]))((IMediaOverlay*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaOverlay.xml' path='doc/member[@name="IMediaOverlay.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Clone([NativeTypeName("ABI::Windows::Media::Editing::IMediaOverlay **")] IMediaOverlay** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, IMediaOverlay**, int>)(lpVtbl[12]))((IMediaOverlay*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IMediaOverlay.xml' path='doc/member[@name="IMediaOverlay.get_Clip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Clip([NativeTypeName("ABI::Windows::Media::Editing::IMediaClip **")] IMediaClip** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, IMediaClip**, int>)(lpVtbl[13]))((IMediaOverlay*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaOverlay.xml' path='doc/member[@name="IMediaOverlay.get_AudioEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_AudioEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, byte*, int>)(lpVtbl[14]))((IMediaOverlay*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaOverlay.xml' path='doc/member[@name="IMediaOverlay.put_AudioEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_AudioEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlay*, byte, int>)(lpVtbl[15]))((IMediaOverlay*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(7)]
        HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value);

        [VtblIndex(8)]
        HRESULT put_Delay([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(9)]
        HRESULT get_Delay([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(10)]
        HRESULT get_Opacity(double* value);

        [VtblIndex(11)]
        HRESULT put_Opacity(double value);

        [VtblIndex(12)]
        HRESULT Clone([NativeTypeName("ABI::Windows::Media::Editing::IMediaOverlay **")] IMediaOverlay** result);

        [VtblIndex(13)]
        HRESULT get_Clip([NativeTypeName("ABI::Windows::Media::Editing::IMediaClip **")] IMediaClip** value);

        [VtblIndex(14)]
        HRESULT get_AudioEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_AudioEnabled([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, int> put_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_Delay;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Delay;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Opacity;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_Opacity;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Editing::IMediaOverlay **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaOverlay**, int> Clone;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Editing::IMediaClip **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaClip**, int> get_Clip;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AudioEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AudioEnabled;
    }
}
