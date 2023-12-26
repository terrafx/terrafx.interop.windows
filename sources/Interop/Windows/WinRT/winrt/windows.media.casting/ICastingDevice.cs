// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.casting.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICastingDevice.xml' path='doc/member[@name="ICastingDevice"]/*' />
[Guid("DE721C83-4A43-4AD1-A6D2-2492A796C3F2")]
[NativeTypeName("struct ICastingDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICastingDevice : ICastingDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICastingDevice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevice*, Guid*, void**, int>)(lpVtbl[0]))((ICastingDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevice*, uint>)(lpVtbl[1]))((ICastingDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevice*, uint>)(lpVtbl[2]))((ICastingDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevice*, uint*, Guid**, int>)(lpVtbl[3]))((ICastingDevice*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevice*, HSTRING*, int>)(lpVtbl[4]))((ICastingDevice*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevice*, TrustLevel*, int>)(lpVtbl[5]))((ICastingDevice*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICastingDevice.xml' path='doc/member[@name="ICastingDevice.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevice*, HSTRING*, int>)(lpVtbl[6]))((ICastingDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingDevice.xml' path='doc/member[@name="ICastingDevice.get_FriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_FriendlyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevice*, HSTRING*, int>)(lpVtbl[7]))((ICastingDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingDevice.xml' path='doc/member[@name="ICastingDevice.get_Icon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Icon([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType **")] IRandomAccessStreamWithContentType** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevice*, IRandomAccessStreamWithContentType**, int>)(lpVtbl[8]))((ICastingDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICastingDevice.xml' path='doc/member[@name="ICastingDevice.GetSupportedCastingPlaybackTypesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSupportedCastingPlaybackTypesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingPlaybackTypes_t **")] IAsyncOperation<CastingPlaybackTypes>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevice*, IAsyncOperation<CastingPlaybackTypes>**, int>)(lpVtbl[9]))((ICastingDevice*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='ICastingDevice.xml' path='doc/member[@name="ICastingDevice.CreateCastingConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateCastingConnection([NativeTypeName("ABI::Windows::Media::Casting::ICastingConnection **")] ICastingConnection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDevice*, ICastingConnection**, int>)(lpVtbl[10]))((ICastingDevice*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_FriendlyName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Icon([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType **")] IRandomAccessStreamWithContentType** value);

        [VtblIndex(9)]
        HRESULT GetSupportedCastingPlaybackTypesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingPlaybackTypes_t **")] IAsyncOperation<CastingPlaybackTypes>** operation);

        [VtblIndex(10)]
        HRESULT CreateCastingConnection([NativeTypeName("ABI::Windows::Media::Casting::ICastingConnection **")] ICastingConnection** value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FriendlyName;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamWithContentType**, int> get_Icon;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingPlaybackTypes_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<CastingPlaybackTypes>**, int> GetSupportedCastingPlaybackTypesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Casting::ICastingConnection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICastingConnection**, int> CreateCastingConnection;
    }
}
