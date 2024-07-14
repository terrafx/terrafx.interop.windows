// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaExtensionManager.xml' path='doc/member[@name="IMediaExtensionManager"]/*' />
[Guid("4A25EAF5-242D-4DFB-97F4-69B7C42576FF")]
[NativeTypeName("struct IMediaExtensionManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaExtensionManager : IMediaExtensionManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaExtensionManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, Guid*, void**, int>)(lpVtbl[0]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, uint>)(lpVtbl[1]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, uint>)(lpVtbl[2]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, HSTRING*, int>)(lpVtbl[4]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, TrustLevel*, int>)(lpVtbl[5]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaExtensionManager.xml' path='doc/member[@name="IMediaExtensionManager.RegisterSchemeHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RegisterSchemeHandler(HSTRING activatableClassId, HSTRING scheme)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, HSTRING, HSTRING, int>)(lpVtbl[6]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), activatableClassId, scheme);
    }

    /// <include file='IMediaExtensionManager.xml' path='doc/member[@name="IMediaExtensionManager.RegisterSchemeHandlerWithSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RegisterSchemeHandlerWithSettings(HSTRING activatableClassId, HSTRING scheme, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, HSTRING, HSTRING, IPropertySet*, int>)(lpVtbl[7]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), activatableClassId, scheme, configuration);
    }

    /// <include file='IMediaExtensionManager.xml' path='doc/member[@name="IMediaExtensionManager.RegisterByteStreamHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RegisterByteStreamHandler(HSTRING activatableClassId, HSTRING fileExtension, HSTRING mimeType)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, HSTRING, HSTRING, HSTRING, int>)(lpVtbl[8]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), activatableClassId, fileExtension, mimeType);
    }

    /// <include file='IMediaExtensionManager.xml' path='doc/member[@name="IMediaExtensionManager.RegisterByteStreamHandlerWithSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RegisterByteStreamHandlerWithSettings(HSTRING activatableClassId, HSTRING fileExtension, HSTRING mimeType, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, HSTRING, HSTRING, HSTRING, IPropertySet*, int>)(lpVtbl[9]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), activatableClassId, fileExtension, mimeType, configuration);
    }

    /// <include file='IMediaExtensionManager.xml' path='doc/member[@name="IMediaExtensionManager.RegisterAudioDecoder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RegisterAudioDecoder(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, HSTRING, Guid, Guid, int>)(lpVtbl[10]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), activatableClassId, inputSubtype, outputSubtype);
    }

    /// <include file='IMediaExtensionManager.xml' path='doc/member[@name="IMediaExtensionManager.RegisterAudioDecoderWithSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RegisterAudioDecoderWithSettings(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, HSTRING, Guid, Guid, IPropertySet*, int>)(lpVtbl[11]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), activatableClassId, inputSubtype, outputSubtype, configuration);
    }

    /// <include file='IMediaExtensionManager.xml' path='doc/member[@name="IMediaExtensionManager.RegisterAudioEncoder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RegisterAudioEncoder(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, HSTRING, Guid, Guid, int>)(lpVtbl[12]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), activatableClassId, inputSubtype, outputSubtype);
    }

    /// <include file='IMediaExtensionManager.xml' path='doc/member[@name="IMediaExtensionManager.RegisterAudioEncoderWithSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RegisterAudioEncoderWithSettings(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, HSTRING, Guid, Guid, IPropertySet*, int>)(lpVtbl[13]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), activatableClassId, inputSubtype, outputSubtype, configuration);
    }

    /// <include file='IMediaExtensionManager.xml' path='doc/member[@name="IMediaExtensionManager.RegisterVideoDecoder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RegisterVideoDecoder(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, HSTRING, Guid, Guid, int>)(lpVtbl[14]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), activatableClassId, inputSubtype, outputSubtype);
    }

    /// <include file='IMediaExtensionManager.xml' path='doc/member[@name="IMediaExtensionManager.RegisterVideoDecoderWithSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT RegisterVideoDecoderWithSettings(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, HSTRING, Guid, Guid, IPropertySet*, int>)(lpVtbl[15]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), activatableClassId, inputSubtype, outputSubtype, configuration);
    }

    /// <include file='IMediaExtensionManager.xml' path='doc/member[@name="IMediaExtensionManager.RegisterVideoEncoder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RegisterVideoEncoder(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, HSTRING, Guid, Guid, int>)(lpVtbl[16]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), activatableClassId, inputSubtype, outputSubtype);
    }

    /// <include file='IMediaExtensionManager.xml' path='doc/member[@name="IMediaExtensionManager.RegisterVideoEncoderWithSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RegisterVideoEncoderWithSettings(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaExtensionManager*, HSTRING, Guid, Guid, IPropertySet*, int>)(lpVtbl[17]))((IMediaExtensionManager*)Unsafe.AsPointer(ref this), activatableClassId, inputSubtype, outputSubtype, configuration);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RegisterSchemeHandler(HSTRING activatableClassId, HSTRING scheme);

        [VtblIndex(7)]
        HRESULT RegisterSchemeHandlerWithSettings(HSTRING activatableClassId, HSTRING scheme, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration);

        [VtblIndex(8)]
        HRESULT RegisterByteStreamHandler(HSTRING activatableClassId, HSTRING fileExtension, HSTRING mimeType);

        [VtblIndex(9)]
        HRESULT RegisterByteStreamHandlerWithSettings(HSTRING activatableClassId, HSTRING fileExtension, HSTRING mimeType, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration);

        [VtblIndex(10)]
        HRESULT RegisterAudioDecoder(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype);

        [VtblIndex(11)]
        HRESULT RegisterAudioDecoderWithSettings(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration);

        [VtblIndex(12)]
        HRESULT RegisterAudioEncoder(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype);

        [VtblIndex(13)]
        HRESULT RegisterAudioEncoderWithSettings(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration);

        [VtblIndex(14)]
        HRESULT RegisterVideoDecoder(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype);

        [VtblIndex(15)]
        HRESULT RegisterVideoDecoderWithSettings(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration);

        [VtblIndex(16)]
        HRESULT RegisterVideoEncoder(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype);

        [VtblIndex(17)]
        HRESULT RegisterVideoEncoderWithSettings(HSTRING activatableClassId, Guid inputSubtype, Guid outputSubtype, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, int> RegisterSchemeHandler;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IPropertySet*, int> RegisterSchemeHandlerWithSettings;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, int> RegisterByteStreamHandler;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, IPropertySet*, int> RegisterByteStreamHandlerWithSettings;

        [NativeTypeName("HRESULT (HSTRING, GUID, GUID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Guid, Guid, int> RegisterAudioDecoder;

        [NativeTypeName("HRESULT (HSTRING, GUID, GUID, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Guid, Guid, IPropertySet*, int> RegisterAudioDecoderWithSettings;

        [NativeTypeName("HRESULT (HSTRING, GUID, GUID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Guid, Guid, int> RegisterAudioEncoder;

        [NativeTypeName("HRESULT (HSTRING, GUID, GUID, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Guid, Guid, IPropertySet*, int> RegisterAudioEncoderWithSettings;

        [NativeTypeName("HRESULT (HSTRING, GUID, GUID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Guid, Guid, int> RegisterVideoDecoder;

        [NativeTypeName("HRESULT (HSTRING, GUID, GUID, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Guid, Guid, IPropertySet*, int> RegisterVideoDecoderWithSettings;

        [NativeTypeName("HRESULT (HSTRING, GUID, GUID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Guid, Guid, int> RegisterVideoEncoder;

        [NativeTypeName("HRESULT (HSTRING, GUID, GUID, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Guid, Guid, IPropertySet*, int> RegisterVideoEncoderWithSettings;
    }
}
