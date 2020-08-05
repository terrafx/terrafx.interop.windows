// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000019-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IExternalConnection : IUnknown")]
    public unsafe partial struct IExternalConnection
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IExternalConnection*, Guid*, void**, int>)(lpVtbl[0]))((IExternalConnection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IExternalConnection*, uint>)(lpVtbl[1]))((IExternalConnection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IExternalConnection*, uint>)(lpVtbl[2]))((IExternalConnection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("DWORD")]
        public uint AddConnection([NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved)
        {
            return ((delegate* stdcall<IExternalConnection*, uint, uint, uint>)(lpVtbl[3]))((IExternalConnection*)Unsafe.AsPointer(ref this), extconn, reserved);
        }

        [return: NativeTypeName("DWORD")]
        public uint ReleaseConnection([NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved, [NativeTypeName("BOOL")] int fLastReleaseCloses)
        {
            return ((delegate* stdcall<IExternalConnection*, uint, uint, int, uint>)(lpVtbl[4]))((IExternalConnection*)Unsafe.AsPointer(ref this), extconn, reserved, fLastReleaseCloses);
        }
    }
}
