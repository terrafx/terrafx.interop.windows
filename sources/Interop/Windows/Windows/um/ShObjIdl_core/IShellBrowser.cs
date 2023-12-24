// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser"]/*' />
[Guid("000214E2-0000-0000-C000-000000000046")]
[NativeTypeName("struct IShellBrowser : IOleWindow")]
[NativeInheritance("IOleWindow")]
public unsafe partial struct IShellBrowser : IShellBrowser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellBrowser));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, Guid*, void**, int>)(lpVtbl[0]))((IShellBrowser*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, uint>)(lpVtbl[1]))((IShellBrowser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, uint>)(lpVtbl[2]))((IShellBrowser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IOleWindow.GetWindow" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, HWND*, int>)(lpVtbl[3]))((IShellBrowser*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <inheritdoc cref="IOleWindow.ContextSensitiveHelp" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, BOOL, int>)(lpVtbl[4]))((IShellBrowser*)Unsafe.AsPointer(ref this), fEnterMode);
    }

    /// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser.InsertMenusSB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InsertMenusSB(HMENU hmenuShared, [NativeTypeName("LPOLEMENUGROUPWIDTHS")] OLEMENUGROUPWIDTHS* lpMenuWidths)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, HMENU, OLEMENUGROUPWIDTHS*, int>)(lpVtbl[5]))((IShellBrowser*)Unsafe.AsPointer(ref this), hmenuShared, lpMenuWidths);
    }

    /// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser.SetMenuSB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetMenuSB(HMENU hmenuShared, [NativeTypeName("HOLEMENU")] HGLOBAL holemenuRes, HWND hwndActiveObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, HMENU, HGLOBAL, HWND, int>)(lpVtbl[6]))((IShellBrowser*)Unsafe.AsPointer(ref this), hmenuShared, holemenuRes, hwndActiveObject);
    }

    /// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser.RemoveMenusSB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveMenusSB(HMENU hmenuShared)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, HMENU, int>)(lpVtbl[7]))((IShellBrowser*)Unsafe.AsPointer(ref this), hmenuShared);
    }

    /// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser.SetStatusTextSB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetStatusTextSB([NativeTypeName("LPCWSTR")] char* pszStatusText)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, char*, int>)(lpVtbl[8]))((IShellBrowser*)Unsafe.AsPointer(ref this), pszStatusText);
    }

    /// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser.EnableModelessSB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnableModelessSB(BOOL fEnable)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, BOOL, int>)(lpVtbl[9]))((IShellBrowser*)Unsafe.AsPointer(ref this), fEnable);
    }

    /// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser.TranslateAcceleratorSB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TranslateAcceleratorSB(MSG* pmsg, [NativeTypeName("WORD")] ushort wID)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, MSG*, ushort, int>)(lpVtbl[10]))((IShellBrowser*)Unsafe.AsPointer(ref this), pmsg, wID);
    }

    /// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser.BrowseObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT BrowseObject([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint wFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, ITEMIDLIST*, uint, int>)(lpVtbl[11]))((IShellBrowser*)Unsafe.AsPointer(ref this), pidl, wFlags);
    }

    /// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser.GetViewStateStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetViewStateStream([NativeTypeName("DWORD")] uint grfMode, IStream** ppStrm)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, uint, IStream**, int>)(lpVtbl[12]))((IShellBrowser*)Unsafe.AsPointer(ref this), grfMode, ppStrm);
    }

    /// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser.GetControlWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetControlWindow(uint id, HWND* phwnd)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, uint, HWND*, int>)(lpVtbl[13]))((IShellBrowser*)Unsafe.AsPointer(ref this), id, phwnd);
    }

    /// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser.SendControlMsg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SendControlMsg(uint id, uint uMsg, WPARAM wParam, LPARAM lParam, LRESULT* pret)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, uint, uint, WPARAM, LPARAM, LRESULT*, int>)(lpVtbl[14]))((IShellBrowser*)Unsafe.AsPointer(ref this), id, uMsg, wParam, lParam, pret);
    }

    /// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser.QueryActiveShellView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT QueryActiveShellView(IShellView** ppshv)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, IShellView**, int>)(lpVtbl[15]))((IShellBrowser*)Unsafe.AsPointer(ref this), ppshv);
    }

    /// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser.OnViewWindowActive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT OnViewWindowActive(IShellView* pshv)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, IShellView*, int>)(lpVtbl[16]))((IShellBrowser*)Unsafe.AsPointer(ref this), pshv);
    }

    /// <include file='IShellBrowser.xml' path='doc/member[@name="IShellBrowser.SetToolbarItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetToolbarItems([NativeTypeName("LPTBBUTTONSB")] TBBUTTON* lpButtons, uint nButtons, uint uFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellBrowser*, TBBUTTON*, uint, uint, int>)(lpVtbl[17]))((IShellBrowser*)Unsafe.AsPointer(ref this), lpButtons, nButtons, uFlags);
    }

    public interface Interface : IOleWindow.Interface
    {
        [VtblIndex(5)]
        HRESULT InsertMenusSB(HMENU hmenuShared, [NativeTypeName("LPOLEMENUGROUPWIDTHS")] OLEMENUGROUPWIDTHS* lpMenuWidths);

        [VtblIndex(6)]
        HRESULT SetMenuSB(HMENU hmenuShared, [NativeTypeName("HOLEMENU")] HGLOBAL holemenuRes, HWND hwndActiveObject);

        [VtblIndex(7)]
        HRESULT RemoveMenusSB(HMENU hmenuShared);

        [VtblIndex(8)]
        HRESULT SetStatusTextSB([NativeTypeName("LPCWSTR")] char* pszStatusText);

        [VtblIndex(9)]
        HRESULT EnableModelessSB(BOOL fEnable);

        [VtblIndex(10)]
        HRESULT TranslateAcceleratorSB(MSG* pmsg, [NativeTypeName("WORD")] ushort wID);

        [VtblIndex(11)]
        HRESULT BrowseObject([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint wFlags);

        [VtblIndex(12)]
        HRESULT GetViewStateStream([NativeTypeName("DWORD")] uint grfMode, IStream** ppStrm);

        [VtblIndex(13)]
        HRESULT GetControlWindow(uint id, HWND* phwnd);

        [VtblIndex(14)]
        HRESULT SendControlMsg(uint id, uint uMsg, WPARAM wParam, LPARAM lParam, LRESULT* pret);

        [VtblIndex(15)]
        HRESULT QueryActiveShellView(IShellView** ppshv);

        [VtblIndex(16)]
        HRESULT OnViewWindowActive(IShellView* pshv);

        [VtblIndex(17)]
        HRESULT SetToolbarItems([NativeTypeName("LPTBBUTTONSB")] TBBUTTON* lpButtons, uint nButtons, uint uFlags);
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

        [NativeTypeName("HRESULT (HMENU, LPOLEMENUGROUPWIDTHS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HMENU, OLEMENUGROUPWIDTHS*, int> InsertMenusSB;

        [NativeTypeName("HRESULT (HMENU, HOLEMENU, HWND) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HMENU, HGLOBAL, HWND, int> SetMenuSB;

        [NativeTypeName("HRESULT (HMENU) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HMENU, int> RemoveMenusSB;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetStatusTextSB;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> EnableModelessSB;

        [NativeTypeName("HRESULT (MSG *, WORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MSG*, ushort, int> TranslateAcceleratorSB;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITEMIDLIST*, uint, int> BrowseObject;

        [NativeTypeName("HRESULT (DWORD, IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IStream**, int> GetViewStateStream;

        [NativeTypeName("HRESULT (UINT, HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, HWND*, int> GetControlWindow;

        [NativeTypeName("HRESULT (UINT, UINT, WPARAM, LPARAM, LRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, WPARAM, LPARAM, LRESULT*, int> SendControlMsg;

        [NativeTypeName("HRESULT (IShellView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellView**, int> QueryActiveShellView;

        [NativeTypeName("HRESULT (IShellView *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellView*, int> OnViewWindowActive;

        [NativeTypeName("HRESULT (LPTBBUTTONSB, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TBBUTTON*, uint, uint, int> SetToolbarItems;
    }
}
