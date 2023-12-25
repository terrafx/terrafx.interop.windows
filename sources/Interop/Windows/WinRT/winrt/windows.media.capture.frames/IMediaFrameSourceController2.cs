// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaFrameSourceController2.xml' path='doc/member[@name="IMediaFrameSourceController2"]/*' />
[Guid("EFC49FD4-FCF2-4A03-B4E4-AC9628739BEE")]
[NativeTypeName("struct IMediaFrameSourceController2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaFrameSourceController2 : IMediaFrameSourceController2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFrameSourceController2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaFrameSourceController2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController2*, uint>)(lpVtbl[1]))((IMediaFrameSourceController2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController2*, uint>)(lpVtbl[2]))((IMediaFrameSourceController2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaFrameSourceController2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController2*, HSTRING*, int>)(lpVtbl[4]))((IMediaFrameSourceController2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaFrameSourceController2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaFrameSourceController2.xml' path='doc/member[@name="IMediaFrameSourceController2.GetPropertyByExtendedIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPropertyByExtendedIdAsync([NativeTypeName("UINT32")] uint extendedPropertyIdLength, byte* extendedPropertyId, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* maxPropertyValueSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceGetPropertyResult_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController2*, uint, byte*, IReference<uint>*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IMediaFrameSourceController2*)Unsafe.AsPointer(ref this), extendedPropertyIdLength, extendedPropertyId, maxPropertyValueSize, operation);
    }

    /// <include file='IMediaFrameSourceController2.xml' path='doc/member[@name="IMediaFrameSourceController2.SetPropertyByExtendedIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPropertyByExtendedIdAsync([NativeTypeName("UINT32")] uint extendedPropertyIdLength, byte* extendedPropertyId, [NativeTypeName("UINT32")] uint propertyValueLength, byte* propertyValue, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceSetPropertyStatus_t **")] IAsyncOperation<MediaFrameSourceSetPropertyStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceController2*, uint, byte*, uint, byte*, IAsyncOperation<MediaFrameSourceSetPropertyStatus>**, int>)(lpVtbl[7]))((IMediaFrameSourceController2*)Unsafe.AsPointer(ref this), extendedPropertyIdLength, extendedPropertyId, propertyValueLength, propertyValue, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetPropertyByExtendedIdAsync([NativeTypeName("UINT32")] uint extendedPropertyIdLength, byte* extendedPropertyId, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* maxPropertyValueSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceGetPropertyResult_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(7)]
        HRESULT SetPropertyByExtendedIdAsync([NativeTypeName("UINT32")] uint extendedPropertyIdLength, byte* extendedPropertyId, [NativeTypeName("UINT32")] uint propertyValueLength, byte* propertyValue, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceSetPropertyStatus_t **")] IAsyncOperation<MediaFrameSourceSetPropertyStatus>** operation);
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

        [NativeTypeName("HRESULT (UINT32, BYTE *, ABI::Windows::Foundation::__FIReference_1_UINT32_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceGetPropertyResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, IReference<uint>*, IAsyncOperation<IntPtr>**, int> GetPropertyByExtendedIdAsync;

        [NativeTypeName("HRESULT (UINT32, BYTE *, UINT32, BYTE *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceSetPropertyStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint, byte*, IAsyncOperation<MediaFrameSourceSetPropertyStatus>**, int> SetPropertyByExtendedIdAsync;
    }
}
