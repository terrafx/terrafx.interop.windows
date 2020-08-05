// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("947990DE-CC28-11D2-A0F7-00805F858FB1")]
    [NativeTypeName("struct IDummyHICONIncluder : IUnknown")]
    public unsafe partial struct IDummyHICONIncluder
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDummyHICONIncluder*, Guid*, void**, int>)(lpVtbl[0]))((IDummyHICONIncluder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDummyHICONIncluder*, uint>)(lpVtbl[1]))((IDummyHICONIncluder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDummyHICONIncluder*, uint>)(lpVtbl[2]))((IDummyHICONIncluder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Dummy([NativeTypeName("HICON")] IntPtr h1, [NativeTypeName("HDC")] IntPtr h2)
        {
            return ((delegate* stdcall<IDummyHICONIncluder*, IntPtr, IntPtr, int>)(lpVtbl[3]))((IDummyHICONIncluder*)Unsafe.AsPointer(ref this), h1, h2);
        }
    }
}
