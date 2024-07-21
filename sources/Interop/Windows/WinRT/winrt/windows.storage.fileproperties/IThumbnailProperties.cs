// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IThumbnailProperties.xml' path='doc/member[@name="IThumbnailProperties"]/*' />
[Guid("693DD42F-DBE7-49B5-B3B3-2893AC5D3423")]
[NativeTypeName("struct IThumbnailProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IThumbnailProperties : IThumbnailProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IThumbnailProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IThumbnailProperties*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IThumbnailProperties*, uint>)(lpVtbl[1]))((IThumbnailProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IThumbnailProperties*, uint>)(lpVtbl[2]))((IThumbnailProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IThumbnailProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IThumbnailProperties*, HSTRING*, int>)(lpVtbl[4]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IThumbnailProperties*, TrustLevel*, int>)(lpVtbl[5]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IThumbnailProperties.xml' path='doc/member[@name="IThumbnailProperties.get_OriginalWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OriginalWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IThumbnailProperties*, uint*, int>)(lpVtbl[6]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IThumbnailProperties.xml' path='doc/member[@name="IThumbnailProperties.get_OriginalHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_OriginalHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IThumbnailProperties*, uint*, int>)(lpVtbl[7]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IThumbnailProperties.xml' path='doc/member[@name="IThumbnailProperties.get_ReturnedSmallerCachedSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ReturnedSmallerCachedSize([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IThumbnailProperties*, byte*, int>)(lpVtbl[8]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IThumbnailProperties.xml' path='doc/member[@name="IThumbnailProperties.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailType *")] ThumbnailType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IThumbnailProperties*, ThumbnailType*, int>)(lpVtbl[9]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OriginalWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_OriginalHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_ReturnedSmallerCachedSize([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailType *")] ThumbnailType* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_OriginalWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_OriginalHeight;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ReturnedSmallerCachedSize;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::FileProperties::ThumbnailType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ThumbnailType*, int> get_Type;
    }
}
