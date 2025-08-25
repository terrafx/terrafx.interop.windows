// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionDrawingSurface2.xml' path='doc/member[@name="ICompositionDrawingSurface2"]/*' />
[Guid("FAD0E88B-E354-44E8-8E3D-C4880D5A213F")]
[NativeTypeName("struct ICompositionDrawingSurface2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionDrawingSurface2 : ICompositionDrawingSurface2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICompositionDrawingSurface2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface2*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionDrawingSurface2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface2*, uint>)(lpVtbl[1]))((ICompositionDrawingSurface2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface2*, uint>)(lpVtbl[2]))((ICompositionDrawingSurface2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface2*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionDrawingSurface2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface2*, HSTRING*, int>)(lpVtbl[4]))((ICompositionDrawingSurface2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface2*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionDrawingSurface2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionDrawingSurface2.xml' path='doc/member[@name="ICompositionDrawingSurface2.get_SizeInt32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SizeInt32([NativeTypeName("ABI::Windows::Graphics::SizeInt32 *")] SizeInt32* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface2*, SizeInt32*, int>)(lpVtbl[6]))((ICompositionDrawingSurface2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionDrawingSurface2.xml' path='doc/member[@name="ICompositionDrawingSurface2.Resize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Resize([NativeTypeName("ABI::Windows::Graphics::SizeInt32")] SizeInt32 sizePixels)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface2*, SizeInt32, int>)(lpVtbl[7]))((ICompositionDrawingSurface2*)Unsafe.AsPointer(ref this), sizePixels);
    }

    /// <include file='ICompositionDrawingSurface2.xml' path='doc/member[@name="ICompositionDrawingSurface2.Scroll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Scroll([NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface2*, PointInt32, int>)(lpVtbl[8]))((ICompositionDrawingSurface2*)Unsafe.AsPointer(ref this), offset);
    }

    /// <include file='ICompositionDrawingSurface2.xml' path='doc/member[@name="ICompositionDrawingSurface2.ScrollRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ScrollRect([NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset, [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 scrollRect)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface2*, PointInt32, RectInt32, int>)(lpVtbl[9]))((ICompositionDrawingSurface2*)Unsafe.AsPointer(ref this), offset, scrollRect);
    }

    /// <include file='ICompositionDrawingSurface2.xml' path='doc/member[@name="ICompositionDrawingSurface2.ScrollWithClip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ScrollWithClip([NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset, [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 clipRect)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface2*, PointInt32, RectInt32, int>)(lpVtbl[10]))((ICompositionDrawingSurface2*)Unsafe.AsPointer(ref this), offset, clipRect);
    }

    /// <include file='ICompositionDrawingSurface2.xml' path='doc/member[@name="ICompositionDrawingSurface2.ScrollRectWithClip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ScrollRectWithClip([NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset, [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 clipRect, [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 scrollRect)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionDrawingSurface2*, PointInt32, RectInt32, RectInt32, int>)(lpVtbl[11]))((ICompositionDrawingSurface2*)Unsafe.AsPointer(ref this), offset, clipRect, scrollRect);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SizeInt32([NativeTypeName("ABI::Windows::Graphics::SizeInt32 *")] SizeInt32* value);

        [VtblIndex(7)]
        HRESULT Resize([NativeTypeName("ABI::Windows::Graphics::SizeInt32")] SizeInt32 sizePixels);

        [VtblIndex(8)]
        HRESULT Scroll([NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset);

        [VtblIndex(9)]
        HRESULT ScrollRect([NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset, [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 scrollRect);

        [VtblIndex(10)]
        HRESULT ScrollWithClip([NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset, [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 clipRect);

        [VtblIndex(11)]
        HRESULT ScrollRectWithClip([NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset, [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 clipRect, [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 scrollRect);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::SizeInt32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SizeInt32*, int> get_SizeInt32;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::SizeInt32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SizeInt32, int> Resize;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::PointInt32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PointInt32, int> Scroll;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::PointInt32, ABI::Windows::Graphics::RectInt32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PointInt32, RectInt32, int> ScrollRect;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::PointInt32, ABI::Windows::Graphics::RectInt32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PointInt32, RectInt32, int> ScrollWithClip;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::PointInt32, ABI::Windows::Graphics::RectInt32, ABI::Windows::Graphics::RectInt32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PointInt32, RectInt32, RectInt32, int> ScrollRectWithClip;
    }
}
