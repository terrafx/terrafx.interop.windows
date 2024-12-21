// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPresentationSurface2.xml' path='doc/member[@name="IPresentationSurface2"]/*' />
[Guid("95609569-C5F0-47F9-8804-5345F2E2767E")]
[NativeTypeName("struct IPresentationSurface2 : IPresentationSurface")]
[NativeInheritance("IPresentationSurface")]
public unsafe partial struct IPresentationSurface2 : IPresentationSurface2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPresentationSurface2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface2*, Guid*, void**, int>)(lpVtbl[0]))((IPresentationSurface2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface2*, uint>)(lpVtbl[1]))((IPresentationSurface2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface2*, uint>)(lpVtbl[2]))((IPresentationSurface2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPresentationContent.SetTag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetTag([NativeTypeName("UINT_PTR")] nuint tag)
    {
        ((delegate* unmanaged[MemberFunction]<IPresentationSurface2*, nuint, void>)(lpVtbl[3]))((IPresentationSurface2*)Unsafe.AsPointer(ref this), tag);
    }

    /// <inheritdoc cref="IPresentationSurface.SetBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetBuffer(IPresentationBuffer* presentationBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface2*, IPresentationBuffer*, int>)(lpVtbl[4]))((IPresentationSurface2*)Unsafe.AsPointer(ref this), presentationBuffer);
    }

    /// <inheritdoc cref="IPresentationSurface.SetColorSpace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface2*, DXGI_COLOR_SPACE_TYPE, int>)(lpVtbl[5]))((IPresentationSurface2*)Unsafe.AsPointer(ref this), colorSpace);
    }

    /// <inheritdoc cref="IPresentationSurface.SetAlphaMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAlphaMode(DXGI_ALPHA_MODE alphaMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface2*, DXGI_ALPHA_MODE, int>)(lpVtbl[6]))((IPresentationSurface2*)Unsafe.AsPointer(ref this), alphaMode);
    }

    /// <inheritdoc cref="IPresentationSurface.SetSourceRect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetSourceRect([NativeTypeName("const RECT *")] RECT* sourceRect)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface2*, RECT*, int>)(lpVtbl[7]))((IPresentationSurface2*)Unsafe.AsPointer(ref this), sourceRect);
    }

    /// <inheritdoc cref="IPresentationSurface.SetTransform" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTransform(PresentationTransform* transform)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface2*, PresentationTransform*, int>)(lpVtbl[8]))((IPresentationSurface2*)Unsafe.AsPointer(ref this), transform);
    }

    /// <inheritdoc cref="IPresentationSurface.RestrictToOutput" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RestrictToOutput(IUnknown* output)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface2*, IUnknown*, int>)(lpVtbl[9]))((IPresentationSurface2*)Unsafe.AsPointer(ref this), output);
    }

    /// <inheritdoc cref="IPresentationSurface.SetDisableReadback" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetDisableReadback([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface2*, byte, int>)(lpVtbl[10]))((IPresentationSurface2*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref="IPresentationSurface.SetLetterboxingMargins" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetLetterboxingMargins(float leftLetterboxSize, float topLetterboxSize, float rightLetterboxSize, float bottomLetterboxSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface2*, float, float, float, float, int>)(lpVtbl[11]))((IPresentationSurface2*)Unsafe.AsPointer(ref this), leftLetterboxSize, topLetterboxSize, rightLetterboxSize, bottomLetterboxSize);
    }

    /// <include file='IPresentationSurface2.xml' path='doc/member[@name="IPresentationSurface2.SetIsHdrContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void SetIsHdrContent([NativeTypeName("boolean")] byte isHdrContent)
    {
        ((delegate* unmanaged[MemberFunction]<IPresentationSurface2*, byte, void>)(lpVtbl[12]))((IPresentationSurface2*)Unsafe.AsPointer(ref this), isHdrContent);
    }

    public interface Interface : IPresentationSurface.Interface
    {
        [VtblIndex(12)]
        void SetIsHdrContent([NativeTypeName("boolean")] byte isHdrContent);
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

        [NativeTypeName("void (UINT_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, void> SetTag;

        [NativeTypeName("HRESULT (IPresentationBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPresentationBuffer*, int> SetBuffer;

        [NativeTypeName("HRESULT (DXGI_COLOR_SPACE_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXGI_COLOR_SPACE_TYPE, int> SetColorSpace;

        [NativeTypeName("HRESULT (DXGI_ALPHA_MODE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXGI_ALPHA_MODE, int> SetAlphaMode;

        [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RECT*, int> SetSourceRect;

        [NativeTypeName("HRESULT (PresentationTransform *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PresentationTransform*, int> SetTransform;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, int> RestrictToOutput;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> SetDisableReadback;

        [NativeTypeName("HRESULT (float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, float, float, int> SetLetterboxingMargins;

        [NativeTypeName("void (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, void> SetIsHdrContent;
    }
}
