// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000116-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleInPlaceFrame : IOleInPlaceUIWindow")]
    public unsafe partial struct IOleInPlaceFrame
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, uint>)(lpVtbl[1]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, uint>)(lpVtbl[2]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, IntPtr*, int>)(lpVtbl[3]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, int, int>)(lpVtbl[4]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBorder([NativeTypeName("LPRECT")] RECT* lprectBorder)
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, RECT*, int>)(lpVtbl[5]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), lprectBorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, RECT*, int>)(lpVtbl[6]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pborderwidths);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, RECT*, int>)(lpVtbl[7]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pborderwidths);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetActiveObject([NativeTypeName("IOleInPlaceActiveObject *")] IOleInPlaceActiveObject* pActiveObject, [NativeTypeName("LPCOLESTR")] ushort* pszObjName)
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, IOleInPlaceActiveObject*, ushort*, int>)(lpVtbl[8]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pActiveObject, pszObjName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertMenus([NativeTypeName("HMENU")] IntPtr hmenuShared, [NativeTypeName("LPOLEMENUGROUPWIDTHS")] OLEMENUGROUPWIDTHS* lpMenuWidths)
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, IntPtr, OLEMENUGROUPWIDTHS*, int>)(lpVtbl[9]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), hmenuShared, lpMenuWidths);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMenu([NativeTypeName("HMENU")] IntPtr hmenuShared, [NativeTypeName("HOLEMENU")] IntPtr holemenu, [NativeTypeName("HWND")] IntPtr hwndActiveObject)
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, IntPtr, IntPtr, IntPtr, int>)(lpVtbl[10]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), hmenuShared, holemenu, hwndActiveObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveMenus([NativeTypeName("HMENU")] IntPtr hmenuShared)
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, IntPtr, int>)(lpVtbl[11]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), hmenuShared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStatusText([NativeTypeName("LPCOLESTR")] ushort* pszStatusText)
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, ushort*, int>)(lpVtbl[12]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), pszStatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableModeless([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, int, int>)(lpVtbl[13]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateAccelerator([NativeTypeName("LPMSG")] MSG* lpmsg, [NativeTypeName("WORD")] ushort wID)
        {
            return ((delegate* unmanaged<IOleInPlaceFrame*, MSG*, ushort, int>)(lpVtbl[14]))((IOleInPlaceFrame*)Unsafe.AsPointer(ref this), lpmsg, wID);
        }
    }
}
