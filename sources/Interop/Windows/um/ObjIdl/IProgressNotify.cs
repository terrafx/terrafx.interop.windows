// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A9D758A0-4617-11CF-95FC-00AA00680DB4")]
    public unsafe partial struct IProgressNotify
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IProgressNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IProgressNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IProgressNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnProgress([NativeTypeName("DWORD")] uint dwProgressCurrent, [NativeTypeName("DWORD")] uint dwProgressMaximum, [NativeTypeName("BOOL")] int fAccurate, [NativeTypeName("BOOL")] int fOwner)
        {
            return lpVtbl->OnProgress((IProgressNotify*)Unsafe.AsPointer(ref this), dwProgressCurrent, dwProgressMaximum, fAccurate, fOwner);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IProgressNotify*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IProgressNotify*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IProgressNotify*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, DWORD, BOOL, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IProgressNotify*, uint, uint, int, int, int> OnProgress;
        }
    }
}
