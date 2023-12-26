// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaClipStatics.xml' path='doc/member[@name="IMediaClipStatics"]/*' />
[Guid("FA402B68-928F-43C4-BC6E-783A1A359656")]
[NativeTypeName("struct IMediaClipStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaClipStatics : IMediaClipStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaClipStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClipStatics*, Guid*, void**, int>)(lpVtbl[0]))((IMediaClipStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClipStatics*, uint>)(lpVtbl[1]))((IMediaClipStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClipStatics*, uint>)(lpVtbl[2]))((IMediaClipStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClipStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaClipStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClipStatics*, HSTRING*, int>)(lpVtbl[4]))((IMediaClipStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClipStatics*, TrustLevel*, int>)(lpVtbl[5]))((IMediaClipStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaClipStatics.xml' path='doc/member[@name="IMediaClipStatics.CreateFromColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromColor([NativeTypeName("ABI::Windows::UI::Color")] Color color, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan originalDuration, [NativeTypeName("ABI::Windows::Media::Editing::IMediaClip **")] IMediaClip** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClipStatics*, Color, TimeSpan, IMediaClip**, int>)(lpVtbl[6]))((IMediaClipStatics*)Unsafe.AsPointer(ref this), color, originalDuration, value);
    }

    /// <include file='IMediaClipStatics.xml' path='doc/member[@name="IMediaClipStatics.CreateFromFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CEditing__CMediaClip_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClipStatics*, IStorageFile*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IMediaClipStatics*)Unsafe.AsPointer(ref this), file, operation);
    }

    /// <include file='IMediaClipStatics.xml' path='doc/member[@name="IMediaClipStatics.CreateFromImageFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromImageFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan originalDuration, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CEditing__CMediaClip_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClipStatics*, IStorageFile*, TimeSpan, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IMediaClipStatics*)Unsafe.AsPointer(ref this), file, originalDuration, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromColor([NativeTypeName("ABI::Windows::UI::Color")] Color color, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan originalDuration, [NativeTypeName("ABI::Windows::Media::Editing::IMediaClip **")] IMediaClip** value);

        [VtblIndex(7)]
        HRESULT CreateFromFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CEditing__CMediaClip_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(8)]
        HRESULT CreateFromImageFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan originalDuration, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CEditing__CMediaClip_t **")] IAsyncOperation<IntPtr>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Media::Editing::IMediaClip **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, TimeSpan, IMediaClip**, int> CreateFromColor;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CEditing__CMediaClip_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<IntPtr>**, int> CreateFromFileAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CEditing__CMediaClip_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, TimeSpan, IAsyncOperation<IntPtr>**, int> CreateFromImageFileAsync;
    }
}
