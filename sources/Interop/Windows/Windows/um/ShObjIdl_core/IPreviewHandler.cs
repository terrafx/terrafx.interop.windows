// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPreviewHandler.xml' path='doc/member[@name="IPreviewHandler"]/*' />
[Guid("8895B1C6-B41F-4C1C-A562-0D564250836F")]
[NativeTypeName("struct IPreviewHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPreviewHandler : IPreviewHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPreviewHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPreviewHandler*, Guid*, void**, int>)(lpVtbl[0]))((IPreviewHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPreviewHandler*, uint>)(lpVtbl[1]))((IPreviewHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPreviewHandler*, uint>)(lpVtbl[2]))((IPreviewHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPreviewHandler.xml' path='doc/member[@name="IPreviewHandler.SetWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetWindow(HWND hwnd, [NativeTypeName("const RECT *")] RECT* prc)
    {
        return ((delegate* unmanaged[MemberFunction]<IPreviewHandler*, HWND, RECT*, int>)(lpVtbl[3]))((IPreviewHandler*)Unsafe.AsPointer(ref this), hwnd, prc);
    }

    /// <include file='IPreviewHandler.xml' path='doc/member[@name="IPreviewHandler.SetRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetRect([NativeTypeName("const RECT *")] RECT* prc)
    {
        return ((delegate* unmanaged[MemberFunction]<IPreviewHandler*, RECT*, int>)(lpVtbl[4]))((IPreviewHandler*)Unsafe.AsPointer(ref this), prc);
    }

    /// <include file='IPreviewHandler.xml' path='doc/member[@name="IPreviewHandler.DoPreview"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DoPreview()
    {
        return ((delegate* unmanaged[MemberFunction]<IPreviewHandler*, int>)(lpVtbl[5]))((IPreviewHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPreviewHandler.xml' path='doc/member[@name="IPreviewHandler.Unload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Unload()
    {
        return ((delegate* unmanaged[MemberFunction]<IPreviewHandler*, int>)(lpVtbl[6]))((IPreviewHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPreviewHandler.xml' path='doc/member[@name="IPreviewHandler.SetFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFocus()
    {
        return ((delegate* unmanaged[MemberFunction]<IPreviewHandler*, int>)(lpVtbl[7]))((IPreviewHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPreviewHandler.xml' path='doc/member[@name="IPreviewHandler.QueryFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT QueryFocus(HWND* phwnd)
    {
        return ((delegate* unmanaged[MemberFunction]<IPreviewHandler*, HWND*, int>)(lpVtbl[8]))((IPreviewHandler*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <include file='IPreviewHandler.xml' path='doc/member[@name="IPreviewHandler.TranslateAcceleratorW"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TranslateAcceleratorW(MSG* pmsg)
    {
        return ((delegate* unmanaged[MemberFunction]<IPreviewHandler*, MSG*, int>)(lpVtbl[9]))((IPreviewHandler*)Unsafe.AsPointer(ref this), pmsg);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetWindow(HWND hwnd, [NativeTypeName("const RECT *")] RECT* prc);

        [VtblIndex(4)]
        HRESULT SetRect([NativeTypeName("const RECT *")] RECT* prc);

        [VtblIndex(5)]
        HRESULT DoPreview();

        [VtblIndex(6)]
        HRESULT Unload();

        [VtblIndex(7)]
        HRESULT SetFocus();

        [VtblIndex(8)]
        HRESULT QueryFocus(HWND* phwnd);

        [VtblIndex(9)]
        HRESULT TranslateAcceleratorW(MSG* pmsg);
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

        [NativeTypeName("HRESULT (HWND, const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, RECT*, int> SetWindow;

        [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RECT*, int> SetRect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> DoPreview;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Unload;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SetFocus;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND*, int> QueryFocus;

        [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MSG*, int> TranslateAcceleratorW;
    }
}
