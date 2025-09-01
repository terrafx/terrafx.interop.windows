// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBasicVideoEffect.xml' path='doc/member[@name="IBasicVideoEffect"]/*' />
[Guid("8262C7EF-B360-40BE-949B-2FF42FF35693")]
[NativeTypeName("struct IBasicVideoEffect : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBasicVideoEffect : IBasicVideoEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBasicVideoEffect);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, Guid*, void**, int>)(lpVtbl[0]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, uint>)(lpVtbl[1]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, uint>)(lpVtbl[2]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, uint*, Guid**, int>)(lpVtbl[3]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, HSTRING*, int>)(lpVtbl[4]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, TrustLevel*, int>)(lpVtbl[5]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBasicVideoEffect.xml' path='doc/member[@name="IBasicVideoEffect.get_IsReadOnly"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsReadOnly([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, byte*, int>)(lpVtbl[6]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicVideoEffect.xml' path='doc/member[@name="IBasicVideoEffect.get_SupportedMemoryTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedMemoryTypes([NativeTypeName("ABI::Windows::Media::Effects::MediaMemoryTypes *")] MediaMemoryTypes* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, MediaMemoryTypes*, int>)(lpVtbl[7]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicVideoEffect.xml' path='doc/member[@name="IBasicVideoEffect.get_TimeIndependent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TimeIndependent([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, byte*, int>)(lpVtbl[8]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicVideoEffect.xml' path='doc/member[@name="IBasicVideoEffect.get_SupportedEncodingProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SupportedEncodingProperties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CVideoEncodingProperties_t **")] IVectorView<Pointer<IVideoEncodingProperties>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, IVectorView<Pointer<IVideoEncodingProperties>>**, int>)(lpVtbl[9]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicVideoEffect.xml' path='doc/member[@name="IBasicVideoEffect.SetEncodingProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *")] IVideoEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *")] IDirect3DDevice* device)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, IVideoEncodingProperties*, IDirect3DDevice*, int>)(lpVtbl[10]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this), encodingProperties, device);
    }

    /// <include file='IBasicVideoEffect.xml' path='doc/member[@name="IBasicVideoEffect.ProcessFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ProcessFrame([NativeTypeName("ABI::Windows::Media::Effects::IProcessVideoFrameContext *")] IProcessVideoFrameContext* context)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, IProcessVideoFrameContext*, int>)(lpVtbl[11]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this), context);
    }

    /// <include file='IBasicVideoEffect.xml' path='doc/member[@name="IBasicVideoEffect.Close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Close([NativeTypeName("ABI::Windows::Media::Effects::MediaEffectClosedReason")] MediaEffectClosedReason reason)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, MediaEffectClosedReason, int>)(lpVtbl[12]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this), reason);
    }

    /// <include file='IBasicVideoEffect.xml' path='doc/member[@name="IBasicVideoEffect.DiscardQueuedFrames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DiscardQueuedFrames()
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicVideoEffect*, int>)(lpVtbl[13]))((IBasicVideoEffect*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsReadOnly([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_SupportedMemoryTypes([NativeTypeName("ABI::Windows::Media::Effects::MediaMemoryTypes *")] MediaMemoryTypes* value);

        [VtblIndex(8)]
        HRESULT get_TimeIndependent([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_SupportedEncodingProperties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CVideoEncodingProperties_t **")] IVectorView<Pointer<IVideoEncodingProperties>>** value);

        [VtblIndex(10)]
        HRESULT SetEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *")] IVideoEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *")] IDirect3DDevice* device);

        [VtblIndex(11)]
        HRESULT ProcessFrame([NativeTypeName("ABI::Windows::Media::Effects::IProcessVideoFrameContext *")] IProcessVideoFrameContext* context);

        [VtblIndex(12)]
        HRESULT Close([NativeTypeName("ABI::Windows::Media::Effects::MediaEffectClosedReason")] MediaEffectClosedReason reason);

        [VtblIndex(13)]
        HRESULT DiscardQueuedFrames();
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsReadOnly;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Effects::MediaMemoryTypes *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaMemoryTypes*, int> get_SupportedMemoryTypes;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_TimeIndependent;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CVideoEncodingProperties_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IVideoEncodingProperties>>**, int> get_SupportedEncodingProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *, ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoEncodingProperties*, IDirect3DDevice*, int> SetEncodingProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Effects::IProcessVideoFrameContext *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProcessVideoFrameContext*, int> ProcessFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Effects::MediaEffectClosedReason) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaEffectClosedReason, int> Close;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> DiscardQueuedFrames;
    }
}
