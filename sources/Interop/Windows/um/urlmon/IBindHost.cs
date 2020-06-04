// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FC4801A1-2BA9-11CF-A229-00AA003D7352")]
    public unsafe partial struct IBindHost
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IBindHost*, Guid*, void**, int>)(lpVtbl[0]))((IBindHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IBindHost*, uint>)(lpVtbl[1]))((IBindHost*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IBindHost*, uint>)(lpVtbl[2]))((IBindHost*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMoniker([NativeTypeName("LPOLESTR")] ushort* szName, [NativeTypeName("IBindCtx *")] IBindCtx* pBC, [NativeTypeName("IMoniker **")] IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IBindHost*, ushort*, IBindCtx*, IMoniker**, uint, int>)(lpVtbl[3]))((IBindHost*)Unsafe.AsPointer(ref this), szName, pBC, ppmk, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int MonikerBindToStorage([NativeTypeName("IMoniker *")] IMoniker* pMk, [NativeTypeName("IBindCtx *")] IBindCtx* pBC, [NativeTypeName("IBindStatusCallback *")] IBindStatusCallback* pBSC, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObj)
        {
            return ((delegate* stdcall<IBindHost*, IMoniker*, IBindCtx*, IBindStatusCallback*, Guid*, void**, int>)(lpVtbl[4]))((IBindHost*)Unsafe.AsPointer(ref this), pMk, pBC, pBSC, riid, ppvObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int MonikerBindToObject([NativeTypeName("IMoniker *")] IMoniker* pMk, [NativeTypeName("IBindCtx *")] IBindCtx* pBC, [NativeTypeName("IBindStatusCallback *")] IBindStatusCallback* pBSC, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObj)
        {
            return ((delegate* stdcall<IBindHost*, IMoniker*, IBindCtx*, IBindStatusCallback*, Guid*, void**, int>)(lpVtbl[5]))((IBindHost*)Unsafe.AsPointer(ref this), pMk, pBC, pBSC, riid, ppvObj);
        }
    }
}
