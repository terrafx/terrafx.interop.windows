// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0002040E-0000-0000-C000-000000000046")]
    public unsafe partial struct ICreateTypeInfo2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return lpVtbl->SetGuid((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), guid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypeFlags([NativeTypeName("UINT")] uint uTypeFlags)
        {
            return lpVtbl->SetTypeFlags((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), uTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDocString([NativeTypeName("LPOLESTR")] ushort* pStrDoc)
        {
            return lpVtbl->SetDocString((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pStrDoc);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return lpVtbl->SetHelpContext((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
        {
            return lpVtbl->SetVersion((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRefTypeInfo([NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfo, [NativeTypeName("HREFTYPE *")] uint* phRefType)
        {
            return lpVtbl->AddRefTypeInfo((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pTInfo, phRefType);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFuncDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc)
        {
            return lpVtbl->AddFuncDesc((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, pFuncDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE")] uint hRefType)
        {
            return lpVtbl->AddImplType((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, hRefType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT")] int implTypeFlags)
        {
            return lpVtbl->SetImplTypeFlags((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, implTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlignment([NativeTypeName("WORD")] ushort cbAlignment)
        {
            return lpVtbl->SetAlignment((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), cbAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSchema([NativeTypeName("LPOLESTR")] ushort* pStrSchema)
        {
            return lpVtbl->SetSchema((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pStrSchema);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddVarDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC *")] VARDESC* pVarDesc)
        {
            return lpVtbl->AddVarDesc((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, pVarDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncAndParamNames([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames)
        {
            return lpVtbl->SetFuncAndParamNames((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, rgszNames, cNames);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarName([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return lpVtbl->SetVarName((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypeDescAlias([NativeTypeName("TYPEDESC *")] TYPEDESC* pTDescAlias)
        {
            return lpVtbl->SetTypeDescAlias((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pTDescAlias);
        }

        [return: NativeTypeName("HRESULT")]
        public int DefineFuncAsDllEntry([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDllName, [NativeTypeName("LPOLESTR")] ushort* szProcName)
        {
            return lpVtbl->DefineFuncAsDllEntry((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDllName, szProcName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return lpVtbl->SetFuncDocString((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return lpVtbl->SetVarDocString((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return lpVtbl->SetFuncHelpContext((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return lpVtbl->SetVarHelpContext((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMops([NativeTypeName("UINT")] uint index, [NativeTypeName("BSTR")] ushort* bstrMops)
        {
            return lpVtbl->SetMops((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, bstrMops);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypeIdldesc([NativeTypeName("IDLDESC *")] IDLDESC* pIdlDesc)
        {
            return lpVtbl->SetTypeIdldesc((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pIdlDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int LayOut()
        {
            return lpVtbl->LayOut((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteFuncDesc([NativeTypeName("UINT")] uint index)
        {
            return lpVtbl->DeleteFuncDesc((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteFuncDescByMemId([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind)
        {
            return lpVtbl->DeleteFuncDescByMemId((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteVarDesc([NativeTypeName("UINT")] uint index)
        {
            return lpVtbl->DeleteVarDesc((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteVarDescByMemId([NativeTypeName("MEMBERID")] int memid)
        {
            return lpVtbl->DeleteVarDescByMemId((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), memid);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteImplType([NativeTypeName("UINT")] uint index)
        {
            return lpVtbl->DeleteImplType((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCustData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return lpVtbl->SetCustData((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return lpVtbl->SetFuncCustData((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParamCustData([NativeTypeName("UINT")] uint indexFunc, [NativeTypeName("UINT")] uint indexParam, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return lpVtbl->SetParamCustData((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), indexFunc, indexParam, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return lpVtbl->SetVarCustData((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetImplTypeCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return lpVtbl->SetImplTypeCustData((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpStringContext([NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return lpVtbl->SetHelpStringContext((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), dwHelpStringContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncHelpStringContext([NativeTypeName("UINT")] uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return lpVtbl->SetFuncHelpStringContext((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpStringContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarHelpStringContext([NativeTypeName("UINT")] uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return lpVtbl->SetVarHelpStringContext((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpStringContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invalidate()
        {
            return lpVtbl->Invalidate((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return lpVtbl->SetName((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), szName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, Guid*, int> SetGuid;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, int> SetTypeFlags;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, ushort*, int> SetDocString;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, int> SetHelpContext;

            [NativeTypeName("HRESULT (WORD, WORD) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, ushort, ushort, int> SetVersion;

            [NativeTypeName("HRESULT (ITypeInfo *, HREFTYPE *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, ITypeInfo*, uint*, int> AddRefTypeInfo;

            [NativeTypeName("HRESULT (UINT, FUNCDESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, FUNCDESC*, int> AddFuncDesc;

            [NativeTypeName("HRESULT (UINT, HREFTYPE) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, uint, int> AddImplType;

            [NativeTypeName("HRESULT (UINT, INT) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, int, int> SetImplTypeFlags;

            [NativeTypeName("HRESULT (WORD) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, ushort, int> SetAlignment;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, ushort*, int> SetSchema;

            [NativeTypeName("HRESULT (UINT, VARDESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, VARDESC*, int> AddVarDesc;

            [NativeTypeName("HRESULT (UINT, LPOLESTR *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, ushort**, uint, int> SetFuncAndParamNames;

            [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, ushort*, int> SetVarName;

            [NativeTypeName("HRESULT (TYPEDESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, TYPEDESC*, int> SetTypeDescAlias;

            [NativeTypeName("HRESULT (UINT, LPOLESTR, LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, ushort*, ushort*, int> DefineFuncAsDllEntry;

            [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, ushort*, int> SetFuncDocString;

            [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, ushort*, int> SetVarDocString;

            [NativeTypeName("HRESULT (UINT, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, uint, int> SetFuncHelpContext;

            [NativeTypeName("HRESULT (UINT, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, uint, int> SetVarHelpContext;

            [NativeTypeName("HRESULT (UINT, BSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, ushort*, int> SetMops;

            [NativeTypeName("HRESULT (IDLDESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, IDLDESC*, int> SetTypeIdldesc;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, int> LayOut;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, int> DeleteFuncDesc;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, int, INVOKEKIND, int> DeleteFuncDescByMemId;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, int> DeleteVarDesc;

            [NativeTypeName("HRESULT (MEMBERID) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, int, int> DeleteVarDescByMemId;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, int> DeleteImplType;

            [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, Guid*, VARIANT*, int> SetCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, Guid*, VARIANT*, int> SetFuncCustData;

            [NativeTypeName("HRESULT (UINT, UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, uint, Guid*, VARIANT*, int> SetParamCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, Guid*, VARIANT*, int> SetVarCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, Guid*, VARIANT*, int> SetImplTypeCustData;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, int> SetHelpStringContext;

            [NativeTypeName("HRESULT (UINT, ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, uint, int> SetFuncHelpStringContext;

            [NativeTypeName("HRESULT (UINT, ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, uint, uint, int> SetVarHelpStringContext;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, int> Invalidate;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo2*, ushort*, int> SetName;
        }
    }
}
