// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("55980BA0-35AA-11CF-B671-00AA004CD6D8")]
    public unsafe partial struct IPointerInactive
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPointerInactive*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPointerInactive*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPointerInactive*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetActivationPolicy([NativeTypeName("DWORD *")] uint* pdwPolicy)
        {
            return lpVtbl->GetActivationPolicy((IPointerInactive*)Unsafe.AsPointer(ref this), pdwPolicy);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInactiveMouseMove([NativeTypeName("LPCRECT")] RECT* pRectBounds, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("DWORD")] uint grfKeyState)
        {
            return lpVtbl->OnInactiveMouseMove((IPointerInactive*)Unsafe.AsPointer(ref this), pRectBounds, x, y, grfKeyState);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInactiveSetCursor([NativeTypeName("LPCRECT")] RECT* pRectBounds, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("DWORD")] uint dwMouseMsg, [NativeTypeName("BOOL")] int fSetAlways)
        {
            return lpVtbl->OnInactiveSetCursor((IPointerInactive*)Unsafe.AsPointer(ref this), pRectBounds, x, y, dwMouseMsg, fSetAlways);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPointerInactive*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPointerInactive*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPointerInactive*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IPointerInactive*, uint*, int> GetActivationPolicy;

            [NativeTypeName("HRESULT (LPCRECT, LONG, LONG, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IPointerInactive*, RECT*, int, int, uint, int> OnInactiveMouseMove;

            [NativeTypeName("HRESULT (LPCRECT, LONG, LONG, DWORD, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IPointerInactive*, RECT*, int, int, uint, int, int> OnInactiveSetCursor;
        }
    }
}
