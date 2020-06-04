// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000012-0000-0000-C000-000000000046")]
    public unsafe partial struct IRootStorage
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IRootStorage*, Guid*, void**, int>)(lpVtbl[0]))((IRootStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IRootStorage*, uint>)(lpVtbl[1]))((IRootStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IRootStorage*, uint>)(lpVtbl[2]))((IRootStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SwitchToFile([NativeTypeName("LPOLESTR")] ushort* pszFile)
        {
            return ((delegate* stdcall<IRootStorage*, ushort*, int>)(lpVtbl[3]))((IRootStorage*)Unsafe.AsPointer(ref this), pszFile);
        }
    }
}
