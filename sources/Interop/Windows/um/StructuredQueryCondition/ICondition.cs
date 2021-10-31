// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0FC988D4-C935-4B97-A973-46282EA175C8")]
    [NativeTypeName("struct ICondition : IPersistStream")]
    [NativeInheritance("IPersistStream")]
    public unsafe partial struct ICondition
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICondition*, Guid*, void**, int>)(lpVtbl[0]))((ICondition*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICondition*, uint>)(lpVtbl[1]))((ICondition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICondition*, uint>)(lpVtbl[2]))((ICondition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<ICondition*, Guid*, int>)(lpVtbl[3]))((ICondition*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* unmanaged<ICondition*, int>)(lpVtbl[4]))((ICondition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Load(IStream* pStm)
        {
            return ((delegate* unmanaged<ICondition*, IStream*, int>)(lpVtbl[5]))((ICondition*)Unsafe.AsPointer(ref this), pStm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Save(IStream* pStm, BOOL fClearDirty)
        {
            return ((delegate* unmanaged<ICondition*, IStream*, BOOL, int>)(lpVtbl[6]))((ICondition*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax(ULARGE_INTEGER* pcbSize)
        {
            return ((delegate* unmanaged<ICondition*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((ICondition*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetConditionType(CONDITION_TYPE* pNodeType)
        {
            return ((delegate* unmanaged<ICondition*, CONDITION_TYPE*, int>)(lpVtbl[8]))((ICondition*)Unsafe.AsPointer(ref this), pNodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetSubConditions([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ICondition*, Guid*, void**, int>)(lpVtbl[9]))((ICondition*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetComparisonInfo([NativeTypeName("LPWSTR *")] ushort** ppszPropertyName, CONDITION_OPERATION* pcop, PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged<ICondition*, ushort**, CONDITION_OPERATION*, PROPVARIANT*, int>)(lpVtbl[10]))((ICondition*)Unsafe.AsPointer(ref this), ppszPropertyName, pcop, ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetValueType([NativeTypeName("LPWSTR *")] ushort** ppszValueTypeName)
        {
            return ((delegate* unmanaged<ICondition*, ushort**, int>)(lpVtbl[11]))((ICondition*)Unsafe.AsPointer(ref this), ppszValueTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetValueNormalization([NativeTypeName("LPWSTR *")] ushort** ppszNormalization)
        {
            return ((delegate* unmanaged<ICondition*, ushort**, int>)(lpVtbl[12]))((ICondition*)Unsafe.AsPointer(ref this), ppszNormalization);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputTerms(IRichChunk** ppPropertyTerm, IRichChunk** ppOperationTerm, IRichChunk** ppValueTerm)
        {
            return ((delegate* unmanaged<ICondition*, IRichChunk**, IRichChunk**, IRichChunk**, int>)(lpVtbl[13]))((ICondition*)Unsafe.AsPointer(ref this), ppPropertyTerm, ppOperationTerm, ppValueTerm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(ICondition** ppc)
        {
            return ((delegate* unmanaged<ICondition*, ICondition**, int>)(lpVtbl[14]))((ICondition*)Unsafe.AsPointer(ref this), ppc);
        }
    }
}
