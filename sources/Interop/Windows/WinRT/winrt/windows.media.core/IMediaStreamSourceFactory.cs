// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaStreamSourceFactory.xml' path='doc/member[@name="IMediaStreamSourceFactory"]/*' />
[Guid("EF77E0D9-D158-4B7A-863F-203342FBFD41")]
[NativeTypeName("struct IMediaStreamSourceFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaStreamSourceFactory : IMediaStreamSourceFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaStreamSourceFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMediaStreamSourceFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceFactory*, uint>)(lpVtbl[1]))((IMediaStreamSourceFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceFactory*, uint>)(lpVtbl[2]))((IMediaStreamSourceFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaStreamSourceFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceFactory*, HSTRING*, int>)(lpVtbl[4]))((IMediaStreamSourceFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceFactory*, TrustLevel*, int>)(lpVtbl[5]))((IMediaStreamSourceFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaStreamSourceFactory.xml' path='doc/member[@name="IMediaStreamSourceFactory.CreateFromDescriptor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromDescriptor([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")] IMediaStreamDescriptor* descriptor, [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceFactory*, IMediaStreamDescriptor*, IMediaStreamSource**, int>)(lpVtbl[6]))((IMediaStreamSourceFactory*)Unsafe.AsPointer(ref this), descriptor, result);
    }

    /// <include file='IMediaStreamSourceFactory.xml' path='doc/member[@name="IMediaStreamSourceFactory.CreateFromDescriptors"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromDescriptors([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")] IMediaStreamDescriptor* descriptor, [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")] IMediaStreamDescriptor* descriptor2, [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceFactory*, IMediaStreamDescriptor*, IMediaStreamDescriptor*, IMediaStreamSource**, int>)(lpVtbl[7]))((IMediaStreamSourceFactory*)Unsafe.AsPointer(ref this), descriptor, descriptor2, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromDescriptor([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")] IMediaStreamDescriptor* descriptor, [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** result);

        [VtblIndex(7)]
        HRESULT CreateFromDescriptors([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")] IMediaStreamDescriptor* descriptor, [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamDescriptor *")] IMediaStreamDescriptor* descriptor2, [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamDescriptor *, ABI::Windows::Media::Core::IMediaStreamSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamDescriptor*, IMediaStreamSource**, int> CreateFromDescriptor;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamDescriptor *, ABI::Windows::Media::Core::IMediaStreamDescriptor *, ABI::Windows::Media::Core::IMediaStreamSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamDescriptor*, IMediaStreamDescriptor*, IMediaStreamSource**, int> CreateFromDescriptors;
    }
}
