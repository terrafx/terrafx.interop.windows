// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000115-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleInPlaceUIWindow : IOleWindow")]
    public unsafe partial struct IOleInPlaceUIWindow
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleInPlaceUIWindow*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleInPlaceUIWindow*, uint>)(lpVtbl[1]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleInPlaceUIWindow*, uint>)(lpVtbl[2]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IOleInPlaceUIWindow*, IntPtr*, int>)(lpVtbl[3]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* unmanaged<IOleInPlaceUIWindow*, int, int>)(lpVtbl[4]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBorder([NativeTypeName("LPRECT")] RECT* lprectBorder)
        {
            return ((delegate* unmanaged<IOleInPlaceUIWindow*, RECT*, int>)(lpVtbl[5]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), lprectBorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
        {
            return ((delegate* unmanaged<IOleInPlaceUIWindow*, RECT*, int>)(lpVtbl[6]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), pborderwidths);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
        {
            return ((delegate* unmanaged<IOleInPlaceUIWindow*, RECT*, int>)(lpVtbl[7]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), pborderwidths);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetActiveObject(IOleInPlaceActiveObject* pActiveObject, [NativeTypeName("LPCOLESTR")] ushort* pszObjName)
        {
            return ((delegate* unmanaged<IOleInPlaceUIWindow*, IOleInPlaceActiveObject*, ushort*, int>)(lpVtbl[8]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), pActiveObject, pszObjName);
        }
    }
}
