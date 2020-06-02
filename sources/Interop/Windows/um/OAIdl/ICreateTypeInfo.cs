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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ICreateTypeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return lpVtbl->SetGuid((ICreateTypeInfo*)Unsafe.AsPointer(ref this), guid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypeFlags([NativeTypeName("UINT")] uint uTypeFlags)
        {
            return lpVtbl->SetTypeFlags((ICreateTypeInfo*)Unsafe.AsPointer(ref this), uTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDocString([NativeTypeName("LPOLESTR")] ushort* pStrDoc)
        {
            return lpVtbl->SetDocString((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pStrDoc);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return lpVtbl->SetHelpContext((ICreateTypeInfo*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
        {
            return lpVtbl->SetVersion((ICreateTypeInfo*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRefTypeInfo([NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfo, [NativeTypeName("HREFTYPE *")] uint* phRefType)
        {
            return lpVtbl->AddRefTypeInfo((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pTInfo, phRefType);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFuncDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc)
        {
            return lpVtbl->AddFuncDesc((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, pFuncDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE")] uint hRefType)
        {
            return lpVtbl->AddImplType((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, hRefType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT")] int implTypeFlags)
        {
            return lpVtbl->SetImplTypeFlags((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, implTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlignment([NativeTypeName("WORD")] ushort cbAlignment)
        {
            return lpVtbl->SetAlignment((ICreateTypeInfo*)Unsafe.AsPointer(ref this), cbAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSchema([NativeTypeName("LPOLESTR")] ushort* pStrSchema)
        {
            return lpVtbl->SetSchema((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pStrSchema);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddVarDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC *")] VARDESC* pVarDesc)
        {
            return lpVtbl->AddVarDesc((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, pVarDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncAndParamNames([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames)
        {
            return lpVtbl->SetFuncAndParamNames((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, rgszNames, cNames);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarName([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return lpVtbl->SetVarName((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypeDescAlias([NativeTypeName("TYPEDESC *")] TYPEDESC* pTDescAlias)
        {
            return lpVtbl->SetTypeDescAlias((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pTDescAlias);
        }

        [return: NativeTypeName("HRESULT")]
        public int DefineFuncAsDllEntry([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDllName, [NativeTypeName("LPOLESTR")] ushort* szProcName)
        {
            return lpVtbl->DefineFuncAsDllEntry((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDllName, szProcName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return lpVtbl->SetFuncDocString((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return lpVtbl->SetVarDocString((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return lpVtbl->SetFuncHelpContext((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return lpVtbl->SetVarHelpContext((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMops([NativeTypeName("UINT")] uint index, [NativeTypeName("BSTR")] ushort* bstrMops)
        {
            return lpVtbl->SetMops((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, bstrMops);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypeIdldesc([NativeTypeName("IDLDESC *")] IDLDESC* pIdlDesc)
        {
            return lpVtbl->SetTypeIdldesc((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pIdlDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int LayOut()
        {
            return lpVtbl->LayOut((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, Guid*, int> SetGuid;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, int> SetTypeFlags;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, ushort*, int> SetDocString;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, int> SetHelpContext;

            [NativeTypeName("HRESULT (WORD, WORD) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, ushort, ushort, int> SetVersion;

            [NativeTypeName("HRESULT (ITypeInfo *, HREFTYPE *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, ITypeInfo*, uint*, int> AddRefTypeInfo;

            [NativeTypeName("HRESULT (UINT, FUNCDESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, FUNCDESC*, int> AddFuncDesc;

            [NativeTypeName("HRESULT (UINT, HREFTYPE) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, uint, int> AddImplType;

            [NativeTypeName("HRESULT (UINT, INT) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, int, int> SetImplTypeFlags;

            [NativeTypeName("HRESULT (WORD) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, ushort, int> SetAlignment;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, ushort*, int> SetSchema;

            [NativeTypeName("HRESULT (UINT, VARDESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, VARDESC*, int> AddVarDesc;

            [NativeTypeName("HRESULT (UINT, LPOLESTR *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, ushort**, uint, int> SetFuncAndParamNames;

            [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, ushort*, int> SetVarName;

            [NativeTypeName("HRESULT (TYPEDESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, TYPEDESC*, int> SetTypeDescAlias;

            [NativeTypeName("HRESULT (UINT, LPOLESTR, LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, ushort*, ushort*, int> DefineFuncAsDllEntry;

            [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, ushort*, int> SetFuncDocString;

            [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, ushort*, int> SetVarDocString;

            [NativeTypeName("HRESULT (UINT, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, uint, int> SetFuncHelpContext;

            [NativeTypeName("HRESULT (UINT, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, uint, int> SetVarHelpContext;

            [NativeTypeName("HRESULT (UINT, BSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, uint, ushort*, int> SetMops;

            [NativeTypeName("HRESULT (IDLDESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, IDLDESC*, int> SetTypeIdldesc;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeInfo*, int> LayOut;
        }
    }
}
