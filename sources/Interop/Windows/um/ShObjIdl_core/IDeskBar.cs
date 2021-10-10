// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EB0FE173-1A3A-11D0-89B3-00A0C90A90AC")]
    [NativeTypeName("struct IDeskBar : IOleWindow")]
    [NativeInheritance("IOleWindow")]
    public unsafe partial struct IDeskBar
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDeskBar*, Guid*, void**, int>)(lpVtbl[0]))((IDeskBar*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDeskBar*, uint>)(lpVtbl[1]))((IDeskBar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDeskBar*, uint>)(lpVtbl[2]))((IDeskBar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IDeskBar*, IntPtr*, int>)(lpVtbl[3]))((IDeskBar*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* unmanaged<IDeskBar*, int, int>)(lpVtbl[4]))((IDeskBar*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetClient(IUnknown* punkClient)
        {
            return ((delegate* unmanaged<IDeskBar*, IUnknown*, int>)(lpVtbl[5]))((IDeskBar*)Unsafe.AsPointer(ref this), punkClient);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetClient(IUnknown** ppunkClient)
        {
            return ((delegate* unmanaged<IDeskBar*, IUnknown**, int>)(lpVtbl[6]))((IDeskBar*)Unsafe.AsPointer(ref this), ppunkClient);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int OnPosRectChangeDB(RECT* prc)
        {
            return ((delegate* unmanaged<IDeskBar*, RECT*, int>)(lpVtbl[7]))((IDeskBar*)Unsafe.AsPointer(ref this), prc);
        }
    }
}
