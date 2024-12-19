// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPresentationSurface.xml' path='doc/member[@name="IPresentationSurface"]/*' />
[Guid("956710FB-EA40-4EBA-A3EB-4375A0EB4EDC")]
[NativeTypeName("struct IPresentationSurface : IPresentationContent")]
[NativeInheritance("IPresentationContent")]
public unsafe partial struct IPresentationSurface : IPresentationSurface.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPresentationSurface));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface*, Guid*, void**, int>)(lpVtbl[0]))((IPresentationSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface*, uint>)(lpVtbl[1]))((IPresentationSurface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface*, uint>)(lpVtbl[2]))((IPresentationSurface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPresentationContent.SetTag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetTag([NativeTypeName("UINT_PTR")] nuint tag)
    {
        ((delegate* unmanaged[MemberFunction]<IPresentationSurface*, nuint, void>)(lpVtbl[3]))((IPresentationSurface*)Unsafe.AsPointer(ref this), tag);
    }

    /// <include file='IPresentationSurface.xml' path='doc/member[@name="IPresentationSurface.SetBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetBuffer(IPresentationBuffer* presentationBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface*, IPresentationBuffer*, int>)(lpVtbl[4]))((IPresentationSurface*)Unsafe.AsPointer(ref this), presentationBuffer);
    }

    /// <include file='IPresentationSurface.xml' path='doc/member[@name="IPresentationSurface.SetColorSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface*, DXGI_COLOR_SPACE_TYPE, int>)(lpVtbl[5]))((IPresentationSurface*)Unsafe.AsPointer(ref this), colorSpace);
    }

    /// <include file='IPresentationSurface.xml' path='doc/member[@name="IPresentationSurface.SetAlphaMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAlphaMode(DXGI_ALPHA_MODE alphaMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface*, DXGI_ALPHA_MODE, int>)(lpVtbl[6]))((IPresentationSurface*)Unsafe.AsPointer(ref this), alphaMode);
    }

    /// <include file='IPresentationSurface.xml' path='doc/member[@name="IPresentationSurface.SetSourceRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetSourceRect([NativeTypeName("const RECT *")] RECT* sourceRect)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface*, RECT*, int>)(lpVtbl[7]))((IPresentationSurface*)Unsafe.AsPointer(ref this), sourceRect);
    }

    /// <include file='IPresentationSurface.xml' path='doc/member[@name="IPresentationSurface.SetTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTransform(PresentationTransform* transform)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface*, PresentationTransform*, int>)(lpVtbl[8]))((IPresentationSurface*)Unsafe.AsPointer(ref this), transform);
    }

    /// <include file='IPresentationSurface.xml' path='doc/member[@name="IPresentationSurface.RestrictToOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RestrictToOutput(IUnknown* output)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface*, IUnknown*, int>)(lpVtbl[9]))((IPresentationSurface*)Unsafe.AsPointer(ref this), output);
    }

    /// <include file='IPresentationSurface.xml' path='doc/member[@name="IPresentationSurface.SetDisableReadback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetDisableReadback([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface*, byte, int>)(lpVtbl[10]))((IPresentationSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPresentationSurface.xml' path='doc/member[@name="IPresentationSurface.SetLetterboxingMargins"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetLetterboxingMargins(float leftLetterboxSize, float topLetterboxSize, float rightLetterboxSize, float bottomLetterboxSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationSurface*, float, float, float, float, int>)(lpVtbl[11]))((IPresentationSurface*)Unsafe.AsPointer(ref this), leftLetterboxSize, topLetterboxSize, rightLetterboxSize, bottomLetterboxSize);
    }

    public interface Interface : IPresentationContent.Interface
    {
        [VtblIndex(4)]
        HRESULT SetBuffer(IPresentationBuffer* presentationBuffer);

        [VtblIndex(5)]
        HRESULT SetColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace);

        [VtblIndex(6)]
        HRESULT SetAlphaMode(DXGI_ALPHA_MODE alphaMode);

        [VtblIndex(7)]
        HRESULT SetSourceRect([NativeTypeName("const RECT *")] RECT* sourceRect);

        [VtblIndex(8)]
        HRESULT SetTransform(PresentationTransform* transform);

        [VtblIndex(9)]
        HRESULT RestrictToOutput(IUnknown* output);

        [VtblIndex(10)]
        HRESULT SetDisableReadback([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT SetLetterboxingMargins(float leftLetterboxSize, float topLetterboxSize, float rightLetterboxSize, float bottomLetterboxSize);
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
    }
}
