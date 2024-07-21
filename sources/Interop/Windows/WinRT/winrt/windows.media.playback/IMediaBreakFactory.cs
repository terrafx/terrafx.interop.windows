// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaBreakFactory.xml' path='doc/member[@name="IMediaBreakFactory"]/*' />
[Guid("4516E002-18E0-4079-8B5F-D33495C15D2E")]
[NativeTypeName("struct IMediaBreakFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaBreakFactory : IMediaBreakFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaBreakFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMediaBreakFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakFactory*, uint>)(lpVtbl[1]))((IMediaBreakFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakFactory*, uint>)(lpVtbl[2]))((IMediaBreakFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaBreakFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakFactory*, HSTRING*, int>)(lpVtbl[4]))((IMediaBreakFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakFactory*, TrustLevel*, int>)(lpVtbl[5]))((IMediaBreakFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaBreakFactory.xml' path='doc/member[@name="IMediaBreakFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Media::Playback::MediaBreakInsertionMethod")] MediaBreakInsertionMethod insertionMethod, [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakFactory*, MediaBreakInsertionMethod, IMediaBreak**, int>)(lpVtbl[6]))((IMediaBreakFactory*)Unsafe.AsPointer(ref this), insertionMethod, result);
    }

    /// <include file='IMediaBreakFactory.xml' path='doc/member[@name="IMediaBreakFactory.CreateWithPresentationPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithPresentationPosition([NativeTypeName("ABI::Windows::Media::Playback::MediaBreakInsertionMethod")] MediaBreakInsertionMethod insertionMethod, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan presentationPosition, [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakFactory*, MediaBreakInsertionMethod, TimeSpan, IMediaBreak**, int>)(lpVtbl[7]))((IMediaBreakFactory*)Unsafe.AsPointer(ref this), insertionMethod, presentationPosition, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Media::Playback::MediaBreakInsertionMethod")] MediaBreakInsertionMethod insertionMethod, [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak** result);

        [VtblIndex(7)]
        HRESULT CreateWithPresentationPosition([NativeTypeName("ABI::Windows::Media::Playback::MediaBreakInsertionMethod")] MediaBreakInsertionMethod insertionMethod, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan presentationPosition, [NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::MediaBreakInsertionMethod, ABI::Windows::Media::Playback::IMediaBreak **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaBreakInsertionMethod, IMediaBreak**, int> Create;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::MediaBreakInsertionMethod, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Media::Playback::IMediaBreak **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaBreakInsertionMethod, TimeSpan, IMediaBreak**, int> CreateWithPresentationPosition;
    }
}
