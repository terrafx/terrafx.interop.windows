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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ICreateTypeInfo2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ICreateTypeInfo2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ICreateTypeInfo2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGuid(ICreateTypeInfo2* pThis, [NativeTypeName("const GUID &")] Guid* guid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTypeFlags(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint uTypeFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDocString(ICreateTypeInfo2* pThis, [NativeTypeName("LPOLESTR")] ushort* pStrDoc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetHelpContext(ICreateTypeInfo2* pThis, [NativeTypeName("DWORD")] uint dwHelpContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVersion(ICreateTypeInfo2* pThis, [NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddRefTypeInfo(ICreateTypeInfo2* pThis, [NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfo, [NativeTypeName("HREFTYPE *")] uint* phRefType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddFuncDesc(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddImplType(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE")] uint hRefType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetImplTypeFlags(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("INT")] int implTypeFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAlignment(ICreateTypeInfo2* pThis, [NativeTypeName("WORD")] ushort cbAlignment);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSchema(ICreateTypeInfo2* pThis, [NativeTypeName("LPOLESTR")] ushort* pStrSchema);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddVarDesc(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC *")] VARDESC* pVarDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFuncAndParamNames(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVarName(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTypeDescAlias(ICreateTypeInfo2* pThis, [NativeTypeName("TYPEDESC *")] TYPEDESC* pTDescAlias);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DefineFuncAsDllEntry(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDllName, [NativeTypeName("LPOLESTR")] ushort* szProcName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFuncDocString(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVarDocString(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFuncHelpContext(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVarHelpContext(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMops(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("BSTR")] ushort* bstrMops);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTypeIdldesc(ICreateTypeInfo2* pThis, [NativeTypeName("IDLDESC *")] IDLDESC* pIdlDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LayOut(ICreateTypeInfo2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DeleteFuncDesc(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DeleteFuncDescByMemId(ICreateTypeInfo2* pThis, [NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DeleteVarDesc(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DeleteVarDescByMemId(ICreateTypeInfo2* pThis, [NativeTypeName("MEMBERID")] int memid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DeleteImplType(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCustData(ICreateTypeInfo2* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFuncCustData(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetParamCustData(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint indexFunc, [NativeTypeName("UINT")] uint indexParam, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVarCustData(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetImplTypeCustData(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetHelpStringContext(ICreateTypeInfo2* pThis, [NativeTypeName("ULONG")] uint dwHelpStringContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFuncHelpStringContext(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVarHelpStringContext(ICreateTypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Invalidate(ICreateTypeInfo2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ICreateTypeInfo2* pThis, [NativeTypeName("LPOLESTR")] ushort* szName);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGuid>(lpVtbl->SetGuid)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), guid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypeFlags([NativeTypeName("UINT")] uint uTypeFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTypeFlags>(lpVtbl->SetTypeFlags)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), uTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDocString([NativeTypeName("LPOLESTR")] ushort* pStrDoc)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetDocString>(lpVtbl->SetDocString)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pStrDoc);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetHelpContext>(lpVtbl->SetHelpContext)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetVersion>(lpVtbl->SetVersion)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRefTypeInfo([NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfo, [NativeTypeName("HREFTYPE *")] uint* phRefType)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRefTypeInfo>(lpVtbl->AddRefTypeInfo)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pTInfo, phRefType);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFuncDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddFuncDesc>(lpVtbl->AddFuncDesc)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, pFuncDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE")] uint hRefType)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddImplType>(lpVtbl->AddImplType)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, hRefType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT")] int implTypeFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetImplTypeFlags>(lpVtbl->SetImplTypeFlags)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, implTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAlignment([NativeTypeName("WORD")] ushort cbAlignment)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAlignment>(lpVtbl->SetAlignment)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), cbAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSchema([NativeTypeName("LPOLESTR")] ushort* pStrSchema)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSchema>(lpVtbl->SetSchema)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pStrSchema);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddVarDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC *")] VARDESC* pVarDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddVarDesc>(lpVtbl->AddVarDesc)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, pVarDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncAndParamNames([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFuncAndParamNames>(lpVtbl->SetFuncAndParamNames)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, rgszNames, cNames);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarName([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetVarName>(lpVtbl->SetVarName)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypeDescAlias([NativeTypeName("TYPEDESC *")] TYPEDESC* pTDescAlias)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTypeDescAlias>(lpVtbl->SetTypeDescAlias)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pTDescAlias);
        }

        [return: NativeTypeName("HRESULT")]
        public int DefineFuncAsDllEntry([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDllName, [NativeTypeName("LPOLESTR")] ushort* szProcName)
        {
            return Marshal.GetDelegateForFunctionPointer<_DefineFuncAsDllEntry>(lpVtbl->DefineFuncAsDllEntry)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDllName, szProcName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFuncDocString>(lpVtbl->SetFuncDocString)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetVarDocString>(lpVtbl->SetVarDocString)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFuncHelpContext>(lpVtbl->SetFuncHelpContext)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetVarHelpContext>(lpVtbl->SetVarHelpContext)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMops([NativeTypeName("UINT")] uint index, [NativeTypeName("BSTR")] ushort* bstrMops)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMops>(lpVtbl->SetMops)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, bstrMops);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypeIdldesc([NativeTypeName("IDLDESC *")] IDLDESC* pIdlDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTypeIdldesc>(lpVtbl->SetTypeIdldesc)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pIdlDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int LayOut()
        {
            return Marshal.GetDelegateForFunctionPointer<_LayOut>(lpVtbl->LayOut)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteFuncDesc([NativeTypeName("UINT")] uint index)
        {
            return Marshal.GetDelegateForFunctionPointer<_DeleteFuncDesc>(lpVtbl->DeleteFuncDesc)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteFuncDescByMemId([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind)
        {
            return Marshal.GetDelegateForFunctionPointer<_DeleteFuncDescByMemId>(lpVtbl->DeleteFuncDescByMemId)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteVarDesc([NativeTypeName("UINT")] uint index)
        {
            return Marshal.GetDelegateForFunctionPointer<_DeleteVarDesc>(lpVtbl->DeleteVarDesc)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteVarDescByMemId([NativeTypeName("MEMBERID")] int memid)
        {
            return Marshal.GetDelegateForFunctionPointer<_DeleteVarDescByMemId>(lpVtbl->DeleteVarDescByMemId)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), memid);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteImplType([NativeTypeName("UINT")] uint index)
        {
            return Marshal.GetDelegateForFunctionPointer<_DeleteImplType>(lpVtbl->DeleteImplType)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCustData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCustData>(lpVtbl->SetCustData)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFuncCustData>(lpVtbl->SetFuncCustData)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParamCustData([NativeTypeName("UINT")] uint indexFunc, [NativeTypeName("UINT")] uint indexParam, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetParamCustData>(lpVtbl->SetParamCustData)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), indexFunc, indexParam, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetVarCustData>(lpVtbl->SetVarCustData)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetImplTypeCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetImplTypeCustData>(lpVtbl->SetImplTypeCustData)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpStringContext([NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetHelpStringContext>(lpVtbl->SetHelpStringContext)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), dwHelpStringContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFuncHelpStringContext([NativeTypeName("UINT")] uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFuncHelpStringContext>(lpVtbl->SetFuncHelpStringContext)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpStringContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVarHelpStringContext([NativeTypeName("UINT")] uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetVarHelpStringContext>(lpVtbl->SetVarHelpStringContext)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpStringContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invalidate()
        {
            return Marshal.GetDelegateForFunctionPointer<_Invalidate>(lpVtbl->Invalidate)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), szName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public IntPtr SetGuid;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr SetTypeFlags;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public IntPtr SetDocString;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr SetHelpContext;

            [NativeTypeName("HRESULT (WORD, WORD) __attribute__((stdcall))")]
            public IntPtr SetVersion;

            [NativeTypeName("HRESULT (ITypeInfo *, HREFTYPE *) __attribute__((stdcall))")]
            public IntPtr AddRefTypeInfo;

            [NativeTypeName("HRESULT (UINT, FUNCDESC *) __attribute__((stdcall))")]
            public IntPtr AddFuncDesc;

            [NativeTypeName("HRESULT (UINT, HREFTYPE) __attribute__((stdcall))")]
            public IntPtr AddImplType;

            [NativeTypeName("HRESULT (UINT, INT) __attribute__((stdcall))")]
            public IntPtr SetImplTypeFlags;

            [NativeTypeName("HRESULT (WORD) __attribute__((stdcall))")]
            public IntPtr SetAlignment;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public IntPtr SetSchema;

            [NativeTypeName("HRESULT (UINT, VARDESC *) __attribute__((stdcall))")]
            public IntPtr AddVarDesc;

            [NativeTypeName("HRESULT (UINT, LPOLESTR *, UINT) __attribute__((stdcall))")]
            public IntPtr SetFuncAndParamNames;

            [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
            public IntPtr SetVarName;

            [NativeTypeName("HRESULT (TYPEDESC *) __attribute__((stdcall))")]
            public IntPtr SetTypeDescAlias;

            [NativeTypeName("HRESULT (UINT, LPOLESTR, LPOLESTR) __attribute__((stdcall))")]
            public IntPtr DefineFuncAsDllEntry;

            [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
            public IntPtr SetFuncDocString;

            [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
            public IntPtr SetVarDocString;

            [NativeTypeName("HRESULT (UINT, DWORD) __attribute__((stdcall))")]
            public IntPtr SetFuncHelpContext;

            [NativeTypeName("HRESULT (UINT, DWORD) __attribute__((stdcall))")]
            public IntPtr SetVarHelpContext;

            [NativeTypeName("HRESULT (UINT, BSTR) __attribute__((stdcall))")]
            public IntPtr SetMops;

            [NativeTypeName("HRESULT (IDLDESC *) __attribute__((stdcall))")]
            public IntPtr SetTypeIdldesc;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr LayOut;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr DeleteFuncDesc;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND) __attribute__((stdcall))")]
            public IntPtr DeleteFuncDescByMemId;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr DeleteVarDesc;

            [NativeTypeName("HRESULT (MEMBERID) __attribute__((stdcall))")]
            public IntPtr DeleteVarDescByMemId;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr DeleteImplType;

            [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((stdcall))")]
            public IntPtr SetCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public IntPtr SetFuncCustData;

            [NativeTypeName("HRESULT (UINT, UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public IntPtr SetParamCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public IntPtr SetVarCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public IntPtr SetImplTypeCustData;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public IntPtr SetHelpStringContext;

            [NativeTypeName("HRESULT (UINT, ULONG) __attribute__((stdcall))")]
            public IntPtr SetFuncHelpStringContext;

            [NativeTypeName("HRESULT (UINT, ULONG) __attribute__((stdcall))")]
            public IntPtr SetVarHelpStringContext;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Invalidate;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public IntPtr SetName;
        }
    }
}
