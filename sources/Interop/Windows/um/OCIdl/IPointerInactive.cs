// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("55980BA0-35AA-11CF-B671-00AA004CD6D8")]
    [NativeTypeName("struct IPointerInactive : IUnknown")]
    public unsafe partial struct IPointerInactive
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPointerInactive*, Guid*, void**, int>)(lpVtbl[0]))((IPointerInactive*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPointerInactive*, uint>)(lpVtbl[1]))((IPointerInactive*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPointerInactive*, uint>)(lpVtbl[2]))((IPointerInactive*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetActivationPolicy([NativeTypeName("DWORD *")] uint* pdwPolicy)
        {
            return ((delegate* stdcall<IPointerInactive*, uint*, int>)(lpVtbl[3]))((IPointerInactive*)Unsafe.AsPointer(ref this), pdwPolicy);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInactiveMouseMove([NativeTypeName("LPCRECT")] RECT* pRectBounds, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("DWORD")] uint grfKeyState)
        {
            return ((delegate* stdcall<IPointerInactive*, RECT*, int, int, uint, int>)(lpVtbl[4]))((IPointerInactive*)Unsafe.AsPointer(ref this), pRectBounds, x, y, grfKeyState);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnInactiveSetCursor([NativeTypeName("LPCRECT")] RECT* pRectBounds, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("DWORD")] uint dwMouseMsg, [NativeTypeName("BOOL")] int fSetAlways)
        {
            return ((delegate* stdcall<IPointerInactive*, RECT*, int, int, uint, int, int>)(lpVtbl[5]))((IPointerInactive*)Unsafe.AsPointer(ref this), pRectBounds, x, y, dwMouseMsg, fSetAlways);
        }
    }
}
