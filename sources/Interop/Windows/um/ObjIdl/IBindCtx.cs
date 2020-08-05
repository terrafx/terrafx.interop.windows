// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000E-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IBindCtx : IUnknown")]
    public unsafe partial struct IBindCtx
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IBindCtx*, Guid*, void**, int>)(lpVtbl[0]))((IBindCtx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IBindCtx*, uint>)(lpVtbl[1]))((IBindCtx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IBindCtx*, uint>)(lpVtbl[2]))((IBindCtx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterObjectBound([NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return ((delegate* stdcall<IBindCtx*, IUnknown*, int>)(lpVtbl[3]))((IBindCtx*)Unsafe.AsPointer(ref this), punk);
        }

        [return: NativeTypeName("HRESULT")]
        public int RevokeObjectBound([NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return ((delegate* stdcall<IBindCtx*, IUnknown*, int>)(lpVtbl[4]))((IBindCtx*)Unsafe.AsPointer(ref this), punk);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseBoundObjects()
        {
            return ((delegate* stdcall<IBindCtx*, int>)(lpVtbl[5]))((IBindCtx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBindOptions([NativeTypeName("BIND_OPTS *")] BIND_OPTS* pbindopts)
        {
            return ((delegate* stdcall<IBindCtx*, BIND_OPTS*, int>)(lpVtbl[6]))((IBindCtx*)Unsafe.AsPointer(ref this), pbindopts);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBindOptions([NativeTypeName("BIND_OPTS *")] BIND_OPTS* pbindopts)
        {
            return ((delegate* stdcall<IBindCtx*, BIND_OPTS*, int>)(lpVtbl[7]))((IBindCtx*)Unsafe.AsPointer(ref this), pbindopts);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRunningObjectTable([NativeTypeName("IRunningObjectTable **")] IRunningObjectTable** pprot)
        {
            return ((delegate* stdcall<IBindCtx*, IRunningObjectTable**, int>)(lpVtbl[8]))((IBindCtx*)Unsafe.AsPointer(ref this), pprot);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, [NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return ((delegate* stdcall<IBindCtx*, ushort*, IUnknown*, int>)(lpVtbl[9]))((IBindCtx*)Unsafe.AsPointer(ref this), pszKey, punk);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, [NativeTypeName("IUnknown **")] IUnknown** ppunk)
        {
            return ((delegate* stdcall<IBindCtx*, ushort*, IUnknown**, int>)(lpVtbl[10]))((IBindCtx*)Unsafe.AsPointer(ref this), pszKey, ppunk);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumObjectParam([NativeTypeName("IEnumString **")] IEnumString** ppenum)
        {
            return ((delegate* stdcall<IBindCtx*, IEnumString**, int>)(lpVtbl[11]))((IBindCtx*)Unsafe.AsPointer(ref this), ppenum);
        }

        [return: NativeTypeName("HRESULT")]
        public int RevokeObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey)
        {
            return ((delegate* stdcall<IBindCtx*, ushort*, int>)(lpVtbl[12]))((IBindCtx*)Unsafe.AsPointer(ref this), pszKey);
        }
    }
}
