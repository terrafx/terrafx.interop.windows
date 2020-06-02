// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("742B0E01-14E6-101B-914E-00AA00300CAB")]
    public unsafe partial struct ISimpleFrameSite
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ISimpleFrameSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ISimpleFrameSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ISimpleFrameSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PreMessageFilter([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wp, [NativeTypeName("LPARAM")] nint lp, [NativeTypeName("LRESULT *")] nint* plResult, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return lpVtbl->PreMessageFilter((ISimpleFrameSite*)Unsafe.AsPointer(ref this), hWnd, msg, wp, lp, plResult, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int PostMessageFilter([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wp, [NativeTypeName("LPARAM")] nint lp, [NativeTypeName("LRESULT *")] nint* plResult, [NativeTypeName("DWORD")] uint dwCookie)
        {
            return lpVtbl->PostMessageFilter((ISimpleFrameSite*)Unsafe.AsPointer(ref this), hWnd, msg, wp, lp, plResult, dwCookie);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ISimpleFrameSite*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ISimpleFrameSite*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ISimpleFrameSite*, uint> Release;

            [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM, LRESULT *, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<ISimpleFrameSite*, IntPtr, uint, nuint, nint, nint*, uint*, int> PreMessageFilter;

            [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM, LRESULT *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<ISimpleFrameSite*, IntPtr, uint, nuint, nint, nint*, uint, int> PostMessageFilter;
        }
    }
}
