// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBasicAudioEffect.xml' path='doc/member[@name="IBasicAudioEffect"]/*' />
[Guid("8C062C53-6BC0-48B8-A99A-4B41550F1359")]
[NativeTypeName("struct IBasicAudioEffect : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBasicAudioEffect : IBasicAudioEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBasicAudioEffect));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicAudioEffect*, Guid*, void**, int>)(lpVtbl[0]))((IBasicAudioEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicAudioEffect*, uint>)(lpVtbl[1]))((IBasicAudioEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicAudioEffect*, uint>)(lpVtbl[2]))((IBasicAudioEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicAudioEffect*, uint*, Guid**, int>)(lpVtbl[3]))((IBasicAudioEffect*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicAudioEffect*, HSTRING*, int>)(lpVtbl[4]))((IBasicAudioEffect*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicAudioEffect*, TrustLevel*, int>)(lpVtbl[5]))((IBasicAudioEffect*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBasicAudioEffect.xml' path='doc/member[@name="IBasicAudioEffect.get_UseInputFrameForOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UseInputFrameForOutput([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicAudioEffect*, byte*, int>)(lpVtbl[6]))((IBasicAudioEffect*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicAudioEffect.xml' path='doc/member[@name="IBasicAudioEffect.get_SupportedEncodingProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedEncodingProperties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CAudioEncodingProperties_t **")] IVectorView<Pointer<IAudioEncodingProperties>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicAudioEffect*, IVectorView<Pointer<IAudioEncodingProperties>>**, int>)(lpVtbl[7]))((IBasicAudioEffect*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBasicAudioEffect.xml' path='doc/member[@name="IBasicAudioEffect.SetEncodingProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicAudioEffect*, IAudioEncodingProperties*, int>)(lpVtbl[8]))((IBasicAudioEffect*)Unsafe.AsPointer(ref this), encodingProperties);
    }

    /// <include file='IBasicAudioEffect.xml' path='doc/member[@name="IBasicAudioEffect.ProcessFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ProcessFrame([NativeTypeName("ABI::Windows::Media::Effects::IProcessAudioFrameContext *")] IProcessAudioFrameContext* context)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicAudioEffect*, IProcessAudioFrameContext*, int>)(lpVtbl[9]))((IBasicAudioEffect*)Unsafe.AsPointer(ref this), context);
    }

    /// <include file='IBasicAudioEffect.xml' path='doc/member[@name="IBasicAudioEffect.Close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Close([NativeTypeName("ABI::Windows::Media::Effects::MediaEffectClosedReason")] MediaEffectClosedReason reason)
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicAudioEffect*, MediaEffectClosedReason, int>)(lpVtbl[10]))((IBasicAudioEffect*)Unsafe.AsPointer(ref this), reason);
    }

    /// <include file='IBasicAudioEffect.xml' path='doc/member[@name="IBasicAudioEffect.DiscardQueuedFrames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DiscardQueuedFrames()
    {
        return ((delegate* unmanaged[MemberFunction]<IBasicAudioEffect*, int>)(lpVtbl[11]))((IBasicAudioEffect*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UseInputFrameForOutput([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_SupportedEncodingProperties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CAudioEncodingProperties_t **")] IVectorView<Pointer<IAudioEncodingProperties>>** value);

        [VtblIndex(8)]
        HRESULT SetEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties);

        [VtblIndex(9)]
        HRESULT ProcessFrame([NativeTypeName("ABI::Windows::Media::Effects::IProcessAudioFrameContext *")] IProcessAudioFrameContext* context);

        [VtblIndex(10)]
        HRESULT Close([NativeTypeName("ABI::Windows::Media::Effects::MediaEffectClosedReason")] MediaEffectClosedReason reason);

        [VtblIndex(11)]
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UseInputFrameForOutput;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CAudioEncodingProperties_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IAudioEncodingProperties>>**, int> get_SupportedEncodingProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties*, int> SetEncodingProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Effects::IProcessAudioFrameContext *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProcessAudioFrameContext*, int> ProcessFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Effects::MediaEffectClosedReason) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaEffectClosedReason, int> Close;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> DiscardQueuedFrames;
    }
}
