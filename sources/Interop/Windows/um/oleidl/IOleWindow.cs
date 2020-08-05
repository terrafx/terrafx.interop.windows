// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000114-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleWindow : IUnknown")]
    public unsafe partial struct IOleWindow
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IOleWindow*, Guid*, void**, int>)(lpVtbl[0]))((IOleWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IOleWindow*, uint>)(lpVtbl[1]))((IOleWindow*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IOleWindow*, uint>)(lpVtbl[2]))((IOleWindow*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* stdcall<IOleWindow*, IntPtr*, int>)(lpVtbl[3]))((IOleWindow*)Unsafe.AsPointer(ref this), phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int ContextSensitiveHelp([NativeTypeName("BOOL")] int fEnterMode)
        {
            return ((delegate* stdcall<IOleWindow*, int, int>)(lpVtbl[4]))((IOleWindow*)Unsafe.AsPointer(ref this), fEnterMode);
        }
    }
}
