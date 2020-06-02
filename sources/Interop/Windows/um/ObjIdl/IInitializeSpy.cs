// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000034-0000-0000-C000-000000000046")]
    public unsafe partial struct IInitializeSpy
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInitializeSpy*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInitializeSpy*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInitializeSpy*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PreInitialize([NativeTypeName("DWORD")] uint dwCoInit, [NativeTypeName("DWORD")] uint dwCurThreadAptRefs)
        {
            return lpVtbl->PreInitialize((IInitializeSpy*)Unsafe.AsPointer(ref this), dwCoInit, dwCurThreadAptRefs);
        }

        [return: NativeTypeName("HRESULT")]
        public int PostInitialize([NativeTypeName("HRESULT")] int hrCoInit, [NativeTypeName("DWORD")] uint dwCoInit, [NativeTypeName("DWORD")] uint dwNewThreadAptRefs)
        {
            return lpVtbl->PostInitialize((IInitializeSpy*)Unsafe.AsPointer(ref this), hrCoInit, dwCoInit, dwNewThreadAptRefs);
        }

        [return: NativeTypeName("HRESULT")]
        public int PreUninitialize([NativeTypeName("DWORD")] uint dwCurThreadAptRefs)
        {
            return lpVtbl->PreUninitialize((IInitializeSpy*)Unsafe.AsPointer(ref this), dwCurThreadAptRefs);
        }

        [return: NativeTypeName("HRESULT")]
        public int PostUninitialize([NativeTypeName("DWORD")] uint dwNewThreadAptRefs)
        {
            return lpVtbl->PostUninitialize((IInitializeSpy*)Unsafe.AsPointer(ref this), dwNewThreadAptRefs);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IInitializeSpy*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IInitializeSpy*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IInitializeSpy*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInitializeSpy*, uint, uint, int> PreInitialize;

            [NativeTypeName("HRESULT (HRESULT, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInitializeSpy*, int, uint, uint, int> PostInitialize;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInitializeSpy*, uint, int> PreUninitialize;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IInitializeSpy*, uint, int> PostUninitialize;
        }
    }
}
