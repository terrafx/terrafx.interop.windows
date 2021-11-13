// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("B196B289-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IOleControlSite : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IOleControlSite : IOleControlSite.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleControlSite*, Guid*, void**, int>)(lpVtbl[0]))((IOleControlSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleControlSite*, uint>)(lpVtbl[1]))((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleControlSite*, uint>)(lpVtbl[2]))((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnControlInfoChanged()
        {
            return ((delegate* unmanaged<IOleControlSite*, int>)(lpVtbl[3]))((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT LockInPlaceActive(BOOL fLock)
        {
            return ((delegate* unmanaged<IOleControlSite*, BOOL, int>)(lpVtbl[4]))((IOleControlSite*)Unsafe.AsPointer(ref this), fLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetExtendedControl(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IOleControlSite*, IDispatch**, int>)(lpVtbl[5]))((IOleControlSite*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT TransformCoords(POINTL* pPtlHimetric, POINTF* pPtfContainer, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IOleControlSite*, POINTL*, POINTF*, uint, int>)(lpVtbl[6]))((IOleControlSite*)Unsafe.AsPointer(ref this), pPtlHimetric, pPtfContainer, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT TranslateAccelerator(MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers)
        {
            return ((delegate* unmanaged<IOleControlSite*, MSG*, uint, int>)(lpVtbl[7]))((IOleControlSite*)Unsafe.AsPointer(ref this), pMsg, grfModifiers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT OnFocus(BOOL fGotFocus)
        {
            return ((delegate* unmanaged<IOleControlSite*, BOOL, int>)(lpVtbl[8]))((IOleControlSite*)Unsafe.AsPointer(ref this), fGotFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT ShowPropertyFrame()
        {
            return ((delegate* unmanaged<IOleControlSite*, int>)(lpVtbl[9]))((IOleControlSite*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnControlInfoChanged();

            [VtblIndex(4)]
            HRESULT LockInPlaceActive(BOOL fLock);

            [VtblIndex(5)]
            HRESULT GetExtendedControl(IDispatch** ppDisp);

            [VtblIndex(6)]
            HRESULT TransformCoords(POINTL* pPtlHimetric, POINTF* pPtfContainer, [NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(7)]
            HRESULT TranslateAccelerator(MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers);

            [VtblIndex(8)]
            HRESULT OnFocus(BOOL fGotFocus);

            [VtblIndex(9)]
            HRESULT ShowPropertyFrame();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleControlSite*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleControlSite*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleControlSite*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleControlSite*, int> OnControlInfoChanged;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleControlSite*, BOOL, int> LockInPlaceActive;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleControlSite*, IDispatch**, int> GetExtendedControl;

            [NativeTypeName("HRESULT (POINTL *, POINTF *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleControlSite*, POINTL*, POINTF*, uint, int> TransformCoords;

            [NativeTypeName("HRESULT (MSG *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleControlSite*, MSG*, uint, int> TranslateAccelerator;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleControlSite*, BOOL, int> OnFocus;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleControlSite*, int> ShowPropertyFrame;
        }
    }
}
