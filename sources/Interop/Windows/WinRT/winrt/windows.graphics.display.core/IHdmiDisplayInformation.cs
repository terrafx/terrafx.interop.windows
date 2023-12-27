// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHdmiDisplayInformation.xml' path='doc/member[@name="IHdmiDisplayInformation"]/*' />
[Guid("130B3C0A-F565-476E-ABD5-EA05AEE74C69")]
[NativeTypeName("struct IHdmiDisplayInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHdmiDisplayInformation : IHdmiDisplayInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHdmiDisplayInformation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, Guid*, void**, int>)(lpVtbl[0]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, uint>)(lpVtbl[1]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, uint>)(lpVtbl[2]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, uint*, Guid**, int>)(lpVtbl[3]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, HSTRING*, int>)(lpVtbl[4]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, TrustLevel*, int>)(lpVtbl[5]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHdmiDisplayInformation.xml' path='doc/member[@name="IHdmiDisplayInformation.GetSupportedDisplayModes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSupportedDisplayModes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CDisplay__CCore__CHdmiDisplayMode_t **")] IVectorView<Pointer<IHdmiDisplayMode>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, IVectorView<Pointer<IHdmiDisplayMode>>**, int>)(lpVtbl[6]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IHdmiDisplayInformation.xml' path='doc/member[@name="IHdmiDisplayInformation.GetCurrentDisplayMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentDisplayMode([NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode **")] IHdmiDisplayMode** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, IHdmiDisplayMode**, int>)(lpVtbl[7]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IHdmiDisplayInformation.xml' path='doc/member[@name="IHdmiDisplayInformation.SetDefaultDisplayModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDefaultDisplayModeAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, IAsyncAction**, int>)(lpVtbl[8]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IHdmiDisplayInformation.xml' path='doc/member[@name="IHdmiDisplayInformation.RequestSetCurrentDisplayModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestSetCurrentDisplayModeAsync([NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")] IHdmiDisplayMode* mode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, IHdmiDisplayMode*, IAsyncOperation<bool>**, int>)(lpVtbl[9]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this), mode, operation);
    }

    /// <include file='IHdmiDisplayInformation.xml' path='doc/member[@name="IHdmiDisplayInformation.RequestSetCurrentDisplayModeWithHdrAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestSetCurrentDisplayModeWithHdrAsync([NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")] IHdmiDisplayMode* mode, [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayHdrOption")] HdmiDisplayHdrOption hdrOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, IHdmiDisplayMode*, HdmiDisplayHdrOption, IAsyncOperation<bool>**, int>)(lpVtbl[10]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this), mode, hdrOption, operation);
    }

    /// <include file='IHdmiDisplayInformation.xml' path='doc/member[@name="IHdmiDisplayInformation.RequestSetCurrentDisplayModeWithHdrAndMetadataAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RequestSetCurrentDisplayModeWithHdrAndMetadataAsync([NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")] IHdmiDisplayMode* mode, [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayHdrOption")] HdmiDisplayHdrOption hdrOption, [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayHdr2086Metadata")] HdmiDisplayHdr2086Metadata hdrMetadata, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, IHdmiDisplayMode*, HdmiDisplayHdrOption, HdmiDisplayHdr2086Metadata, IAsyncOperation<bool>**, int>)(lpVtbl[11]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this), mode, hdrOption, hdrMetadata, operation);
    }

    /// <include file='IHdmiDisplayInformation.xml' path='doc/member[@name="IHdmiDisplayInformation.add_DisplayModesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_DisplayModesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CCore__CHdmiDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IHdmiDisplayInformation>, Pointer<IInspectable>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, ITypedEventHandler<Pointer<IHdmiDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IHdmiDisplayInformation.xml' path='doc/member[@name="IHdmiDisplayInformation.remove_DisplayModesChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_DisplayModesChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IHdmiDisplayInformation*, EventRegistrationToken, int>)(lpVtbl[13]))((IHdmiDisplayInformation*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetSupportedDisplayModes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CDisplay__CCore__CHdmiDisplayMode_t **")] IVectorView<Pointer<IHdmiDisplayMode>>** result);

        [VtblIndex(7)]
        HRESULT GetCurrentDisplayMode([NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode **")] IHdmiDisplayMode** result);

        [VtblIndex(8)]
        HRESULT SetDefaultDisplayModeAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(9)]
        HRESULT RequestSetCurrentDisplayModeAsync([NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")] IHdmiDisplayMode* mode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(10)]
        HRESULT RequestSetCurrentDisplayModeWithHdrAsync([NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")] IHdmiDisplayMode* mode, [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayHdrOption")] HdmiDisplayHdrOption hdrOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(11)]
        HRESULT RequestSetCurrentDisplayModeWithHdrAndMetadataAsync([NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")] IHdmiDisplayMode* mode, [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayHdrOption")] HdmiDisplayHdrOption hdrOption, [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayHdr2086Metadata")] HdmiDisplayHdr2086Metadata hdrMetadata, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(12)]
        HRESULT add_DisplayModesChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CCore__CHdmiDisplayInformation_IInspectable_t *")] ITypedEventHandler<Pointer<IHdmiDisplayInformation>, Pointer<IInspectable>>* value, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_DisplayModesChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CDisplay__CCore__CHdmiDisplayMode_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IHdmiDisplayMode>>**, int> GetSupportedDisplayModes;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHdmiDisplayMode**, int> GetCurrentDisplayMode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> SetDefaultDisplayModeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHdmiDisplayMode*, IAsyncOperation<bool>**, int> RequestSetCurrentDisplayModeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *, ABI::Windows::Graphics::Display::Core::HdmiDisplayHdrOption, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHdmiDisplayMode*, HdmiDisplayHdrOption, IAsyncOperation<bool>**, int> RequestSetCurrentDisplayModeWithHdrAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *, ABI::Windows::Graphics::Display::Core::HdmiDisplayHdrOption, ABI::Windows::Graphics::Display::Core::HdmiDisplayHdr2086Metadata, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHdmiDisplayMode*, HdmiDisplayHdrOption, HdmiDisplayHdr2086Metadata, IAsyncOperation<bool>**, int> RequestSetCurrentDisplayModeWithHdrAndMetadataAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CCore__CHdmiDisplayInformation_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IHdmiDisplayInformation>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_DisplayModesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DisplayModesChanged;
    }
}
