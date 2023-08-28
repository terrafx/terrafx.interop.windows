// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IOleInPlaceFrame.xml' path='doc/member[@name="IOleInPlaceFrame"]/*' />
[Guid("00000116-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleInPlaceFrame : IOleInPlaceUIWindow")]
[NativeInheritance("IOleInPlaceUIWindow")]
public unsafe partial struct IOleInPlaceFrame : IOleInPlaceFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleInPlaceFrame));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, uint>)(lpVtbl[1]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, uint>)(lpVtbl[2]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IOleWindow.GetWindow" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, HWND*, int>)(lpVtbl[3]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <inheritdoc cref="IOleWindow.ContextSensitiveHelp" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, BOOL, int>)(lpVtbl[4]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), fEnterMode);
    }

    /// <inheritdoc cref="IOleInPlaceUIWindow.GetBorder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBorder([NativeTypeName("LPRECT")] RECT* lprectBorder)
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, RECT*, int>)(lpVtbl[5]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), lprectBorder);
    }

    /// <inheritdoc cref="IOleInPlaceUIWindow.RequestBorderSpace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, RECT*, int>)(lpVtbl[6]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pborderwidths);
    }

    /// <inheritdoc cref="IOleInPlaceUIWindow.SetBorderSpace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, RECT*, int>)(lpVtbl[7]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pborderwidths);
    }

    /// <inheritdoc cref="IOleInPlaceUIWindow.SetActiveObject" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetActiveObject(IOleInPlaceActiveObject* pActiveObject, [NativeTypeName("LPCOLESTR")] char* pszObjName)
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, IOleInPlaceActiveObject*, char*, int>)(lpVtbl[8]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pActiveObject, pszObjName);
    }

    /// <include file='IOleInPlaceFrame.xml' path='doc/member[@name="IOleInPlaceFrame.InsertMenus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InsertMenus(HMENU hmenuShared, [NativeTypeName("LPOLEMENUGROUPWIDTHS")] OLEMENUGROUPWIDTHS* lpMenuWidths)
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, HMENU, OLEMENUGROUPWIDTHS*, int>)(lpVtbl[9]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), hmenuShared, lpMenuWidths);
    }

    /// <include file='IOleInPlaceFrame.xml' path='doc/member[@name="IOleInPlaceFrame.SetMenu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetMenu(HMENU hmenuShared, [NativeTypeName("HOLEMENU")] HGLOBAL holemenu, HWND hwndActiveObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, HMENU, HGLOBAL, HWND, int>)(lpVtbl[10]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), hmenuShared, holemenu, hwndActiveObject);
    }

    /// <include file='IOleInPlaceFrame.xml' path='doc/member[@name="IOleInPlaceFrame.RemoveMenus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RemoveMenus(HMENU hmenuShared)
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, HMENU, int>)(lpVtbl[11]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), hmenuShared);
    }

    /// <include file='IOleInPlaceFrame.xml' path='doc/member[@name="IOleInPlaceFrame.SetStatusText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetStatusText([NativeTypeName("LPCOLESTR")] char* pszStatusText)
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, char*, int>)(lpVtbl[12]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pszStatusText);
    }

    /// <include file='IOleInPlaceFrame.xml' path='doc/member[@name="IOleInPlaceFrame.EnableModeless"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnableModeless(BOOL fEnable)
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, BOOL, int>)(lpVtbl[13]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), fEnable);
    }

    /// <include file='IOleInPlaceFrame.xml' path='doc/member[@name="IOleInPlaceFrame.TranslateAccelerator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT TranslateAccelerator([NativeTypeName("LPMSG")] MSG* lpmsg, [NativeTypeName("WORD")] ushort wID)
    {
        return ((delegate* unmanaged[MemberFunction]<IOleInPlaceFrame*, MSG*, ushort, int>)(lpVtbl[14]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), lpmsg, wID);
    }

    public interface Interface : IOleInPlaceUIWindow.Interface
    {
        [VtblIndex(9)]
        HRESULT InsertMenus(HMENU hmenuShared, [NativeTypeName("LPOLEMENUGROUPWIDTHS")] OLEMENUGROUPWIDTHS* lpMenuWidths);

        [VtblIndex(10)]
        HRESULT SetMenu(HMENU hmenuShared, [NativeTypeName("HOLEMENU")] HGLOBAL holemenu, HWND hwndActiveObject);

        [VtblIndex(11)]
        HRESULT RemoveMenus(HMENU hmenuShared);

        [VtblIndex(12)]
        HRESULT SetStatusText([NativeTypeName("LPCOLESTR")] char* pszStatusText);

        [VtblIndex(13)]
        HRESULT EnableModeless(BOOL fEnable);

        [VtblIndex(14)]
        HRESULT TranslateAccelerator([NativeTypeName("LPMSG")] MSG* lpmsg, [NativeTypeName("WORD")] ushort wID);
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

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND*, int> GetWindow;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> ContextSensitiveHelp;

        [NativeTypeName("HRESULT (LPRECT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RECT*, int> GetBorder;

        [NativeTypeName("HRESULT (LPCBORDERWIDTHS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RECT*, int> RequestBorderSpace;

        [NativeTypeName("HRESULT (LPCBORDERWIDTHS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RECT*, int> SetBorderSpace;

        [NativeTypeName("HRESULT (IOleInPlaceActiveObject *, LPCOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IOleInPlaceActiveObject*, char*, int> SetActiveObject;

        [NativeTypeName("HRESULT (HMENU, LPOLEMENUGROUPWIDTHS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HMENU, OLEMENUGROUPWIDTHS*, int> InsertMenus;

        [NativeTypeName("HRESULT (HMENU, HOLEMENU, HWND) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HMENU, HGLOBAL, HWND, int> SetMenu;

        [NativeTypeName("HRESULT (HMENU) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HMENU, int> RemoveMenus;

        [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetStatusText;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> EnableModeless;

        [NativeTypeName("HRESULT (LPMSG, WORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MSG*, ushort, int> TranslateAccelerator;
    }
}
