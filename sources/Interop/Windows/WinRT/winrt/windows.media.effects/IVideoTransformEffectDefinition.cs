// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoTransformEffectDefinition.xml' path='doc/member[@name="IVideoTransformEffectDefinition"]/*' />
[Guid("9664BB6A-1EA6-4AA6-8074-ABE8851ECAE2")]
[NativeTypeName("struct IVideoTransformEffectDefinition : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoTransformEffectDefinition : IVideoTransformEffectDefinition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoTransformEffectDefinition));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, Guid*, void**, int>)(lpVtbl[0]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, uint>)(lpVtbl[1]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, uint>)(lpVtbl[2]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, HSTRING*, int>)(lpVtbl[4]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, TrustLevel*, int>)(lpVtbl[5]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoTransformEffectDefinition.xml' path='doc/member[@name="IVideoTransformEffectDefinition.get_PaddingColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PaddingColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, Color*, int>)(lpVtbl[6]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTransformEffectDefinition.xml' path='doc/member[@name="IVideoTransformEffectDefinition.put_PaddingColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_PaddingColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, Color, int>)(lpVtbl[7]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTransformEffectDefinition.xml' path='doc/member[@name="IVideoTransformEffectDefinition.get_OutputSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OutputSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, Size*, int>)(lpVtbl[8]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTransformEffectDefinition.xml' path='doc/member[@name="IVideoTransformEffectDefinition.put_OutputSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_OutputSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, Size, int>)(lpVtbl[9]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTransformEffectDefinition.xml' path='doc/member[@name="IVideoTransformEffectDefinition.get_CropRectangle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CropRectangle([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, Rect*, int>)(lpVtbl[10]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTransformEffectDefinition.xml' path='doc/member[@name="IVideoTransformEffectDefinition.put_CropRectangle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CropRectangle([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, Rect, int>)(lpVtbl[11]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTransformEffectDefinition.xml' path='doc/member[@name="IVideoTransformEffectDefinition.get_Rotation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Rotation([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation *")] MediaRotation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, MediaRotation*, int>)(lpVtbl[12]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTransformEffectDefinition.xml' path='doc/member[@name="IVideoTransformEffectDefinition.put_Rotation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Rotation([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation")] MediaRotation value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, MediaRotation, int>)(lpVtbl[13]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTransformEffectDefinition.xml' path='doc/member[@name="IVideoTransformEffectDefinition.get_Mirror"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Mirror([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaMirroringOptions *")] MediaMirroringOptions* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, MediaMirroringOptions*, int>)(lpVtbl[14]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTransformEffectDefinition.xml' path='doc/member[@name="IVideoTransformEffectDefinition.put_Mirror"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Mirror([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaMirroringOptions")] MediaMirroringOptions value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, MediaMirroringOptions, int>)(lpVtbl[15]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTransformEffectDefinition.xml' path='doc/member[@name="IVideoTransformEffectDefinition.put_ProcessingAlgorithm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_ProcessingAlgorithm([NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm")] MediaVideoProcessingAlgorithm value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, MediaVideoProcessingAlgorithm, int>)(lpVtbl[16]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTransformEffectDefinition.xml' path='doc/member[@name="IVideoTransformEffectDefinition.get_ProcessingAlgorithm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ProcessingAlgorithm([NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm *")] MediaVideoProcessingAlgorithm* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTransformEffectDefinition*, MediaVideoProcessingAlgorithm*, int>)(lpVtbl[17]))((IVideoTransformEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PaddingColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(7)]
        HRESULT put_PaddingColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(8)]
        HRESULT get_OutputSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(9)]
        HRESULT put_OutputSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size value);

        [VtblIndex(10)]
        HRESULT get_CropRectangle([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(11)]
        HRESULT put_CropRectangle([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value);

        [VtblIndex(12)]
        HRESULT get_Rotation([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation *")] MediaRotation* value);

        [VtblIndex(13)]
        HRESULT put_Rotation([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation")] MediaRotation value);

        [VtblIndex(14)]
        HRESULT get_Mirror([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaMirroringOptions *")] MediaMirroringOptions* value);

        [VtblIndex(15)]
        HRESULT put_Mirror([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaMirroringOptions")] MediaMirroringOptions value);

        [VtblIndex(16)]
        HRESULT put_ProcessingAlgorithm([NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm")] MediaVideoProcessingAlgorithm value);

        [VtblIndex(17)]
        HRESULT get_ProcessingAlgorithm([NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm *")] MediaVideoProcessingAlgorithm* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_PaddingColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_PaddingColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size*, int> get_OutputSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, int> put_OutputSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_CropRectangle;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect, int> put_CropRectangle;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::MediaRotation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaRotation*, int> get_Rotation;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::MediaRotation) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaRotation, int> put_Rotation;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::MediaMirroringOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaMirroringOptions*, int> get_Mirror;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::MediaMirroringOptions) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaMirroringOptions, int> put_Mirror;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaVideoProcessingAlgorithm, int> put_ProcessingAlgorithm;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaVideoProcessingAlgorithm*, int> get_ProcessingAlgorithm;
    }
}
