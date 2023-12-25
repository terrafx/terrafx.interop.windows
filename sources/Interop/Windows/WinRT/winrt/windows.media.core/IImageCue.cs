// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IImageCue.xml' path='doc/member[@name="IImageCue"]/*' />
[Guid("52828282-367B-440B-9116-3C84570DD270")]
[NativeTypeName("struct IImageCue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IImageCue : IImageCue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IImageCue));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageCue*, Guid*, void**, int>)(lpVtbl[0]))((IImageCue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IImageCue*, uint>)(lpVtbl[1]))((IImageCue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IImageCue*, uint>)(lpVtbl[2]))((IImageCue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageCue*, uint*, Guid**, int>)(lpVtbl[3]))((IImageCue*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageCue*, HSTRING*, int>)(lpVtbl[4]))((IImageCue*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageCue*, TrustLevel*, int>)(lpVtbl[5]))((IImageCue*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IImageCue.xml' path='doc/member[@name="IImageCue.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Media::Core::TimedTextPoint *")] TimedTextPoint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageCue*, TimedTextPoint*, int>)(lpVtbl[6]))((IImageCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageCue.xml' path='doc/member[@name="IImageCue.put_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Position([NativeTypeName("ABI::Windows::Media::Core::TimedTextPoint")] TimedTextPoint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageCue*, TimedTextPoint, int>)(lpVtbl[7]))((IImageCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageCue.xml' path='doc/member[@name="IImageCue.get_Extent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Extent([NativeTypeName("ABI::Windows::Media::Core::TimedTextSize *")] TimedTextSize* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageCue*, TimedTextSize*, int>)(lpVtbl[8]))((IImageCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageCue.xml' path='doc/member[@name="IImageCue.put_Extent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Extent([NativeTypeName("ABI::Windows::Media::Core::TimedTextSize")] TimedTextSize value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageCue*, TimedTextSize, int>)(lpVtbl[9]))((IImageCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageCue.xml' path='doc/member[@name="IImageCue.put_SoftwareBitmap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_SoftwareBitmap([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")] ISoftwareBitmap* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageCue*, ISoftwareBitmap*, int>)(lpVtbl[10]))((IImageCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageCue.xml' path='doc/member[@name="IImageCue.get_SoftwareBitmap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SoftwareBitmap([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageCue*, ISoftwareBitmap**, int>)(lpVtbl[11]))((IImageCue*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Media::Core::TimedTextPoint *")] TimedTextPoint* value);

        [VtblIndex(7)]
        HRESULT put_Position([NativeTypeName("ABI::Windows::Media::Core::TimedTextPoint")] TimedTextPoint value);

        [VtblIndex(8)]
        HRESULT get_Extent([NativeTypeName("ABI::Windows::Media::Core::TimedTextSize *")] TimedTextSize* value);

        [VtblIndex(9)]
        HRESULT put_Extent([NativeTypeName("ABI::Windows::Media::Core::TimedTextSize")] TimedTextSize value);

        [VtblIndex(10)]
        HRESULT put_SoftwareBitmap([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")] ISoftwareBitmap* value);

        [VtblIndex(11)]
        HRESULT get_SoftwareBitmap([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextPoint *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextPoint*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextPoint) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextPoint, int> put_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextSize *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextSize*, int> get_Extent;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextSize) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextSize, int> put_Extent;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISoftwareBitmap*, int> put_SoftwareBitmap;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISoftwareBitmap**, int> get_SoftwareBitmap;
    }
}
