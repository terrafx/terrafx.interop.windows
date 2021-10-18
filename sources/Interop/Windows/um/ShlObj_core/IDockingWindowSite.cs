// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2A342FC2-7B26-11D0-8CA9-00A0C92DBFE8")]
    [NativeTypeName("struct IDockingWindowSite : IOleWindow")]
    [NativeInheritance("IOleWindow")]
    public unsafe partial struct IDockingWindowSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDockingWindowSite*, Guid*, void**, int>)(lpVtbl[0]))((IDockingWindowSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDockingWindowSite*, uint>)(lpVtbl[1]))((IDockingWindowSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDockingWindowSite*, uint>)(lpVtbl[2]))((IDockingWindowSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IDockingWindowSite*, IntPtr*, int>)(lpVtbl[3]))((IDockingWindowSite*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* unmanaged<IDockingWindowSite*, int, int>)(lpVtbl[4]))((IDockingWindowSite*)Unsafe.AsPointer(ref this), fEnterMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetBorderDW(IUnknown* punkObj, RECT* prcBorder)
        {
            return ((delegate* unmanaged<IDockingWindowSite*, IUnknown*, RECT*, int>)(lpVtbl[5]))((IDockingWindowSite*)Unsafe.AsPointer(ref this), punkObj, prcBorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int RequestBorderSpaceDW(IUnknown* punkObj, [NativeTypeName("LPCBORDERWIDTHS")] RECT* pbw)
        {
            return ((delegate* unmanaged<IDockingWindowSite*, IUnknown*, RECT*, int>)(lpVtbl[6]))((IDockingWindowSite*)Unsafe.AsPointer(ref this), punkObj, pbw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetBorderSpaceDW(IUnknown* punkObj, [NativeTypeName("LPCBORDERWIDTHS")] RECT* pbw)
        {
            return ((delegate* unmanaged<IDockingWindowSite*, IUnknown*, RECT*, int>)(lpVtbl[7]))((IDockingWindowSite*)Unsafe.AsPointer(ref this), punkObj, pbw);
        }
    }
}
