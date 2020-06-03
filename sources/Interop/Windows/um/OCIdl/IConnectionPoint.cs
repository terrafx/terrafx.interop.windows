// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B286-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IConnectionPoint
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IConnectionPoint*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionPoint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IConnectionPoint*, uint>)(lpVtbl[1]))((IConnectionPoint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IConnectionPoint*, uint>)(lpVtbl[2]))((IConnectionPoint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetConnectionInterface([NativeTypeName("IID *")] Guid* pIID)
        {
            return ((delegate* stdcall<IConnectionPoint*, Guid*, int>)(lpVtbl[3]))((IConnectionPoint*)Unsafe.AsPointer(ref this), pIID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetConnectionPointContainer([NativeTypeName("IConnectionPointContainer **")] IConnectionPointContainer** ppCPC)
        {
            return ((delegate* stdcall<IConnectionPoint*, IConnectionPointContainer**, int>)(lpVtbl[4]))((IConnectionPoint*)Unsafe.AsPointer(ref this), ppCPC);
        }

        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IUnknown *")] IUnknown* pUnkSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* stdcall<IConnectionPoint*, IUnknown*, uint*, int>)(lpVtbl[5]))((IConnectionPoint*)Unsafe.AsPointer(ref this), pUnkSink, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* stdcall<IConnectionPoint*, uint, int>)(lpVtbl[6]))((IConnectionPoint*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumConnections([NativeTypeName("IEnumConnections **")] IEnumConnections** ppEnum)
        {
            return ((delegate* stdcall<IConnectionPoint*, IEnumConnections**, int>)(lpVtbl[7]))((IConnectionPoint*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
