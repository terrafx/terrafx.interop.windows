// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D1E7AFEB-6A2E-11D0-8C78-00C04FD918B4")]
    [NativeTypeName("struct IMenuPopup : IDeskBar")]
    [NativeInheritance("IDeskBar")]
    public unsafe partial struct IMenuPopup
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMenuPopup*, Guid*, void**, int>)(lpVtbl[0]))((IMenuPopup*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMenuPopup*, uint>)(lpVtbl[1]))((IMenuPopup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMenuPopup*, uint>)(lpVtbl[2]))((IMenuPopup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IMenuPopup*, IntPtr*, int>)(lpVtbl[3]))((IMenuPopup*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
        {
            return ((delegate* unmanaged<IMenuPopup*, BOOL, int>)(lpVtbl[4]))((IMenuPopup*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetClient(IUnknown* punkClient)
        {
            return ((delegate* unmanaged<IMenuPopup*, IUnknown*, int>)(lpVtbl[5]))((IMenuPopup*)Unsafe.AsPointer(ref this), punkClient);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetClient(IUnknown** ppunkClient)
        {
            return ((delegate* unmanaged<IMenuPopup*, IUnknown**, int>)(lpVtbl[6]))((IMenuPopup*)Unsafe.AsPointer(ref this), ppunkClient);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnPosRectChangeDB(RECT* prc)
        {
            return ((delegate* unmanaged<IMenuPopup*, RECT*, int>)(lpVtbl[7]))((IMenuPopup*)Unsafe.AsPointer(ref this), prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Popup(POINTL* ppt, RECTL* prcExclude, [NativeTypeName("MP_POPUPFLAGS")] int dwFlags)
        {
            return ((delegate* unmanaged<IMenuPopup*, POINTL*, RECTL*, int, int>)(lpVtbl[8]))((IMenuPopup*)Unsafe.AsPointer(ref this), ppt, prcExclude, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT OnSelect([NativeTypeName("DWORD")] uint dwSelectType)
        {
            return ((delegate* unmanaged<IMenuPopup*, uint, int>)(lpVtbl[9]))((IMenuPopup*)Unsafe.AsPointer(ref this), dwSelectType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetSubMenu(IMenuPopup* pmp, BOOL fSet)
        {
            return ((delegate* unmanaged<IMenuPopup*, IMenuPopup*, BOOL, int>)(lpVtbl[10]))((IMenuPopup*)Unsafe.AsPointer(ref this), pmp, fSet);
        }
    }
}
