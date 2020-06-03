// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020405-0000-0000-C000-000000000046")]
    public unsafe partial struct ICreateTypeInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint>)(lpVtbl[1]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint>)(lpVtbl[2]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, Guid*, int>)(lpVtbl[3]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), guid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypeFlags([NativeTypeName("UINT")] uint uTypeFlags)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, int>)(lpVtbl[4]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), uTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDocString([NativeTypeName("LPOLESTR")] ushort* pStrDoc)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, ushort*, int>)(lpVtbl[5]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pStrDoc);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, int>)(lpVtbl[6]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, ushort, ushort, int>)(lpVtbl[7]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRefTypeInfo([NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfo, [NativeTypeName("HREFTYPE *")] uint* phRefType)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, ITypeInfo*, uint*, int>)(lpVtbl[8]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pTInfo, phRefType);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFuncDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, FUNCDESC*, int>)(lpVtbl[9]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, pFuncDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE")] uint hRefType)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, uint, int>)(lpVtbl[10]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, hRefType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT")] int implTypeFlags)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, int, int>)(lpVtbl[11]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, implTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlignment([NativeTypeName("WORD")] ushort cbAlignment)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, ushort, int>)(lpVtbl[12]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), cbAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSchema([NativeTypeName("LPOLESTR")] ushort* pStrSchema)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, ushort*, int>)(lpVtbl[13]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pStrSchema);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddVarDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC *")] VARDESC* pVarDesc)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, VARDESC*, int>)(lpVtbl[14]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, pVarDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncAndParamNames([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, ushort**, uint, int>)(lpVtbl[15]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, rgszNames, cNames);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarName([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, ushort*, int>)(lpVtbl[16]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypeDescAlias([NativeTypeName("TYPEDESC *")] TYPEDESC* pTDescAlias)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, TYPEDESC*, int>)(lpVtbl[17]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pTDescAlias);
        }

        [return: NativeTypeName("HRESULT")]
        public int DefineFuncAsDllEntry([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDllName, [NativeTypeName("LPOLESTR")] ushort* szProcName)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, ushort*, ushort*, int>)(lpVtbl[18]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDllName, szProcName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, ushort*, int>)(lpVtbl[19]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, ushort*, int>)(lpVtbl[20]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, uint, int>)(lpVtbl[21]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, uint, int>)(lpVtbl[22]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMops([NativeTypeName("UINT")] uint index, [NativeTypeName("BSTR")] ushort* bstrMops)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, uint, ushort*, int>)(lpVtbl[23]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, bstrMops);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypeIdldesc([NativeTypeName("IDLDESC *")] IDLDESC* pIdlDesc)
        {
            return ((delegate* stdcall<ICreateTypeInfo*, IDLDESC*, int>)(lpVtbl[24]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pIdlDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int LayOut()
        {
            return ((delegate* stdcall<ICreateTypeInfo*, int>)(lpVtbl[25]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
        }
    }
}
