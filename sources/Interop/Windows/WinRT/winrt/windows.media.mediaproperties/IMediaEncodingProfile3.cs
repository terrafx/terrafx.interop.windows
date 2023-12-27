// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaEncodingProfile3.xml' path='doc/member[@name="IMediaEncodingProfile3"]/*' />
[Guid("BA6EBE88-7570-4E69-ACCF-5611AD015F88")]
[NativeTypeName("struct IMediaEncodingProfile3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaEncodingProfile3 : IMediaEncodingProfile3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEncodingProfile3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile3*, Guid*, void**, int>)(lpVtbl[0]))((IMediaEncodingProfile3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile3*, uint>)(lpVtbl[1]))((IMediaEncodingProfile3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile3*, uint>)(lpVtbl[2]))((IMediaEncodingProfile3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile3*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaEncodingProfile3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile3*, HSTRING*, int>)(lpVtbl[4]))((IMediaEncodingProfile3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile3*, TrustLevel*, int>)(lpVtbl[5]))((IMediaEncodingProfile3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaEncodingProfile3.xml' path='doc/member[@name="IMediaEncodingProfile3.SetTimedMetadataTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTimedMetadataTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CCore__CTimedMetadataStreamDescriptor_t *")] IIterable<Pointer<ITimedMetadataStreamDescriptor>>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile3*, IIterable<Pointer<ITimedMetadataStreamDescriptor>>*, int>)(lpVtbl[6]))((IMediaEncodingProfile3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingProfile3.xml' path='doc/member[@name="IMediaEncodingProfile3.GetTimedMetadataTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTimedMetadataTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCore__CTimedMetadataStreamDescriptor_t **")] IVector<Pointer<ITimedMetadataStreamDescriptor>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile3*, IVector<Pointer<ITimedMetadataStreamDescriptor>>**, int>)(lpVtbl[7]))((IMediaEncodingProfile3*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetTimedMetadataTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CCore__CTimedMetadataStreamDescriptor_t *")] IIterable<Pointer<ITimedMetadataStreamDescriptor>>* value);

        [VtblIndex(7)]
        HRESULT GetTimedMetadataTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCore__CTimedMetadataStreamDescriptor_t **")] IVector<Pointer<ITimedMetadataStreamDescriptor>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CCore__CTimedMetadataStreamDescriptor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<ITimedMetadataStreamDescriptor>>*, int> SetTimedMetadataTracks;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCore__CTimedMetadataStreamDescriptor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<ITimedMetadataStreamDescriptor>>**, int> GetTimedMetadataTracks;
    }
}
