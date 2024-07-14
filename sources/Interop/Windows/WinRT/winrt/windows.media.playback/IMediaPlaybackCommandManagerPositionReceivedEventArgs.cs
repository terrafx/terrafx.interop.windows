// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackCommandManagerPositionReceivedEventArgs.xml' path='doc/member[@name="IMediaPlaybackCommandManagerPositionReceivedEventArgs"]/*' />
[Guid("5591A754-D627-4BDD-A90D-86A015B24902")]
[NativeTypeName("struct IMediaPlaybackCommandManagerPositionReceivedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackCommandManagerPositionReceivedEventArgs : IMediaPlaybackCommandManagerPositionReceivedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackCommandManagerPositionReceivedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerPositionReceivedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackCommandManagerPositionReceivedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerPositionReceivedEventArgs*, uint>)(lpVtbl[1]))((IMediaPlaybackCommandManagerPositionReceivedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerPositionReceivedEventArgs*, uint>)(lpVtbl[2]))((IMediaPlaybackCommandManagerPositionReceivedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerPositionReceivedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackCommandManagerPositionReceivedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerPositionReceivedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackCommandManagerPositionReceivedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerPositionReceivedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackCommandManagerPositionReceivedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackCommandManagerPositionReceivedEventArgs.xml' path='doc/member[@name="IMediaPlaybackCommandManagerPositionReceivedEventArgs.get_Handled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Handled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerPositionReceivedEventArgs*, byte*, int>)(lpVtbl[6]))((IMediaPlaybackCommandManagerPositionReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManagerPositionReceivedEventArgs.xml' path='doc/member[@name="IMediaPlaybackCommandManagerPositionReceivedEventArgs.put_Handled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Handled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerPositionReceivedEventArgs*, byte, int>)(lpVtbl[7]))((IMediaPlaybackCommandManagerPositionReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManagerPositionReceivedEventArgs.xml' path='doc/member[@name="IMediaPlaybackCommandManagerPositionReceivedEventArgs.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerPositionReceivedEventArgs*, TimeSpan*, int>)(lpVtbl[8]))((IMediaPlaybackCommandManagerPositionReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManagerPositionReceivedEventArgs.xml' path='doc/member[@name="IMediaPlaybackCommandManagerPositionReceivedEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManagerPositionReceivedEventArgs*, IDeferral**, int>)(lpVtbl[9]))((IMediaPlaybackCommandManagerPositionReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Handled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_Handled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Handled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_Handled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
