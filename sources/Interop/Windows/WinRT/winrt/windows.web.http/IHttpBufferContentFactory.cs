// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpBufferContentFactory.xml' path='doc/member[@name="IHttpBufferContentFactory"]/*' />
[Guid("BC20C193-C41F-4FF7-9123-6435736EADC2")]
[NativeTypeName("struct IHttpBufferContentFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpBufferContentFactory : IHttpBufferContentFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpBufferContentFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBufferContentFactory*, Guid*, void**, int>)(lpVtbl[0]))((IHttpBufferContentFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBufferContentFactory*, uint>)(lpVtbl[1]))((IHttpBufferContentFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBufferContentFactory*, uint>)(lpVtbl[2]))((IHttpBufferContentFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBufferContentFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpBufferContentFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBufferContentFactory*, HSTRING*, int>)(lpVtbl[4]))((IHttpBufferContentFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBufferContentFactory*, TrustLevel*, int>)(lpVtbl[5]))((IHttpBufferContentFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpBufferContentFactory.xml' path='doc/member[@name="IHttpBufferContentFactory.CreateFromBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* content, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBufferContentFactory*, IBuffer*, IHttpContent**, int>)(lpVtbl[6]))((IHttpBufferContentFactory*)Unsafe.AsPointer(ref this), content, value);
    }

    /// <include file='IHttpBufferContentFactory.xml' path='doc/member[@name="IHttpBufferContentFactory.CreateFromBufferWithOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromBufferWithOffset([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* content, [NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint count, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBufferContentFactory*, IBuffer*, uint, uint, IHttpContent**, int>)(lpVtbl[7]))((IHttpBufferContentFactory*)Unsafe.AsPointer(ref this), content, offset, count, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* content, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value);

        [VtblIndex(7)]
        HRESULT CreateFromBufferWithOffset([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* content, [NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint count, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Web::Http::IHttpContent **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IHttpContent**, int> CreateFromBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, UINT32, UINT32, ABI::Windows::Web::Http::IHttpContent **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, uint, uint, IHttpContent**, int> CreateFromBufferWithOffset;
    }
}
