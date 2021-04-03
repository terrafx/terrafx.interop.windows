// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020405-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ICreateTypeInfo : IUnknown")]
    public unsafe partial struct ICreateTypeInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint>)(lpVtbl[1]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint>)(lpVtbl[2]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, Guid*, int>)(lpVtbl[3]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTypeFlags([NativeTypeName("UINT")] uint uTypeFlags)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, int>)(lpVtbl[4]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), uTypeFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDocString([NativeTypeName("LPOLESTR")] ushort* pStrDoc)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, ushort*, int>)(lpVtbl[5]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pStrDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, int>)(lpVtbl[6]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, ushort, ushort, int>)(lpVtbl[7]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddRefTypeInfo(ITypeInfo* pTInfo, [NativeTypeName("HREFTYPE *")] uint* phRefType)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, ITypeInfo*, uint*, int>)(lpVtbl[8]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pTInfo, phRefType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddFuncDesc([NativeTypeName("UINT")] uint index, FUNCDESC* pFuncDesc)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, FUNCDESC*, int>)(lpVtbl[9]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, pFuncDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE")] uint hRefType)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, uint, int>)(lpVtbl[10]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, hRefType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT")] int implTypeFlags)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, int, int>)(lpVtbl[11]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, implTypeFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlignment([NativeTypeName("WORD")] ushort cbAlignment)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, ushort, int>)(lpVtbl[12]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), cbAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSchema([NativeTypeName("LPOLESTR")] ushort* pStrSchema)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, ushort*, int>)(lpVtbl[13]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pStrSchema);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddVarDesc([NativeTypeName("UINT")] uint index, VARDESC* pVarDesc)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, VARDESC*, int>)(lpVtbl[14]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, pVarDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFuncAndParamNames([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, ushort**, uint, int>)(lpVtbl[15]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, rgszNames, cNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVarName([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, int>)(lpVtbl[16]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTypeDescAlias(TYPEDESC* pTDescAlias)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, TYPEDESC*, int>)(lpVtbl[17]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pTDescAlias);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DefineFuncAsDllEntry([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDllName, [NativeTypeName("LPOLESTR")] ushort* szProcName)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, ushort*, int>)(lpVtbl[18]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDllName, szProcName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFuncDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, int>)(lpVtbl[19]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVarDocString([NativeTypeName("UINT")] uint index, [NativeTypeName("LPOLESTR")] ushort* szDocString)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, int>)(lpVtbl[20]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDocString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFuncHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, uint, int>)(lpVtbl[21]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVarHelpContext([NativeTypeName("UINT")] uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, uint, int>)(lpVtbl[22]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMops([NativeTypeName("UINT")] uint index, [NativeTypeName("BSTR")] ushort* bstrMops)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, uint, ushort*, int>)(lpVtbl[23]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, bstrMops);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTypeIdldesc(IDLDESC* pIdlDesc)
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, IDLDESC*, int>)(lpVtbl[24]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pIdlDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LayOut()
        {
            return ((delegate* unmanaged<ICreateTypeInfo*, int>)(lpVtbl[25]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
        }
    }
}
