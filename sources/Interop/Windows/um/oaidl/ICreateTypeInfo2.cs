// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0002040E-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ICreateTypeInfo2 : ICreateTypeInfo")]
    [NativeInheritance("ICreateTypeInfo")]
    public unsafe partial struct ICreateTypeInfo2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, Guid*, void**, int>)(lpVtbl[0]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint>)(lpVtbl[1]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint>)(lpVtbl[2]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, Guid*, int>)(lpVtbl[3]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetTypeFlags([NativeTypeName("UINT")] uint uTypeFlags)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int>)(lpVtbl[4]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), uTypeFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetDocString([NativeTypeName("LPOLESTR")] ushort* pStrDoc)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, ushort*, int>)(lpVtbl[5]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pStrDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int>)(lpVtbl[6]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, ushort, ushort, int>)(lpVtbl[7]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT AddRefTypeInfo(ITypeInfo* pTInfo, [NativeTypeName("HREFTYPE *")] uint* phRefType)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, ITypeInfo*, uint*, int>)(lpVtbl[8]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pTInfo, phRefType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT AddFuncDesc([NativeTypeName("UINT")] uint index, FUNCDESC* pFuncDesc)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, FUNCDESC*, int>)(lpVtbl[9]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, pFuncDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT AddImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE")] uint hRefType)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, uint, int>)(lpVtbl[10]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, hRefType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT")] int implTypeFlags)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int, int>)(lpVtbl[11]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, implTypeFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetAlignment([NativeTypeName("WORD")] ushort cbAlignment)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, ushort, int>)(lpVtbl[12]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), cbAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetSchema([NativeTypeName("LPOLESTR")] ushort* pStrSchema)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, ushort*, int>)(lpVtbl[13]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pStrSchema);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT AddVarDesc([NativeTypeName("UINT")] uint index, VARDESC* pVarDesc)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, VARDESC*, int>)(lpVtbl[14]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, pVarDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetFuncAndParamNames([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, ushort**, uint, int>)(lpVtbl[15]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, rgszNames, cNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetVarName([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, ushort*, int>)(lpVtbl[16]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetTypeDescAlias(TYPEDESC* pTDescAlias)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, TYPEDESC*, int>)(lpVtbl[17]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pTDescAlias);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT DefineFuncAsDllEntry([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDllName, [NativeTypeName("LPOLESTR")] ushort* szProcName)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, ushort*, ushort*, int>)(lpVtbl[18]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDllName, szProcName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetFuncDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, ushort*, int>)(lpVtbl[19]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetVarDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, ushort*, int>)(lpVtbl[20]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetFuncHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, uint, int>)(lpVtbl[21]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetVarHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, uint, int>)(lpVtbl[22]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetMops([NativeTypeName("UINT")] uint index, [NativeTypeName("BSTR")] ushort* bstrMops)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, ushort*, int>)(lpVtbl[23]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, bstrMops);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetTypeIdldesc(IDLDESC* pIdlDesc)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, IDLDESC*, int>)(lpVtbl[24]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), pIdlDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT LayOut()
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, int>)(lpVtbl[25]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT DeleteFuncDesc([NativeTypeName("UINT")] uint index)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int>)(lpVtbl[26]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT DeleteFuncDescByMemId([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, int, INVOKEKIND, int>)(lpVtbl[27]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT DeleteVarDesc([NativeTypeName("UINT")] uint index)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int>)(lpVtbl[28]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT DeleteVarDescByMemId([NativeTypeName("MEMBERID")] int memid)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, int, int>)(lpVtbl[29]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), memid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT DeleteImplType([NativeTypeName("UINT")] uint index)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int>)(lpVtbl[30]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT SetCustData([NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, Guid*, VARIANT*, int>)(lpVtbl[31]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT SetFuncCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, Guid*, VARIANT*, int>)(lpVtbl[32]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT SetParamCustData([NativeTypeName("UINT")] uint indexFunc, [NativeTypeName("UINT")] uint indexParam, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, uint, Guid*, VARIANT*, int>)(lpVtbl[33]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), indexFunc, indexParam, guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT SetVarCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, Guid*, VARIANT*, int>)(lpVtbl[34]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT SetImplTypeCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, Guid*, VARIANT*, int>)(lpVtbl[35]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT SetHelpStringContext([NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, int>)(lpVtbl[36]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), dwHelpStringContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT SetFuncHelpStringContext([NativeTypeName("UINT")] uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, uint, int>)(lpVtbl[37]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpStringContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT SetVarHelpStringContext([NativeTypeName("UINT")] uint index, [NativeTypeName("ULONG")] uint dwHelpStringContext)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, uint, uint, int>)(lpVtbl[38]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), index, dwHelpStringContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT Invalidate()
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, int>)(lpVtbl[39]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT SetName([NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return ((delegate* unmanaged<ICreateTypeInfo2*, ushort*, int>)(lpVtbl[40]))((ICreateTypeInfo2*)Unsafe.AsPointer(ref this), szName);
        }
    }
}
