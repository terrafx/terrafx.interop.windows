// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0FC988D4-C935-4B97-A973-46282EA175C8")]
    [NativeTypeName("struct ICondition : IPersistStream")]
    public unsafe partial struct ICondition
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, Guid*, void**, int>)(lpVtbl[0]))((ICondition*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, uint>)(lpVtbl[1]))((ICondition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, uint>)(lpVtbl[2]))((ICondition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, Guid*, int>)(lpVtbl[3]))((ICondition*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, int>)(lpVtbl[4]))((ICondition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IStream *")] IStream* pStm)
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, IStream*, int>)(lpVtbl[5]))((ICondition*)Unsafe.AsPointer(ref this), pStm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty)
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, IStream*, int, int>)(lpVtbl[6]))((ICondition*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax([NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbSize)
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((ICondition*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConditionType([NativeTypeName("CONDITION_TYPE *")] CONDITION_TYPE* pNodeType)
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, CONDITION_TYPE*, int>)(lpVtbl[8]))((ICondition*)Unsafe.AsPointer(ref this), pNodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSubConditions([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, Guid*, void**, int>)(lpVtbl[9]))((ICondition*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComparisonInfo([NativeTypeName("LPWSTR *")] ushort** ppszPropertyName, [NativeTypeName("CONDITION_OPERATION *")] CONDITION_OPERATION* pcop, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, ushort**, CONDITION_OPERATION*, PROPVARIANT*, int>)(lpVtbl[10]))((ICondition*)Unsafe.AsPointer(ref this), ppszPropertyName, pcop, ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValueType([NativeTypeName("LPWSTR *")] ushort** ppszValueTypeName)
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, ushort**, int>)(lpVtbl[11]))((ICondition*)Unsafe.AsPointer(ref this), ppszValueTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValueNormalization([NativeTypeName("LPWSTR *")] ushort** ppszNormalization)
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, ushort**, int>)(lpVtbl[12]))((ICondition*)Unsafe.AsPointer(ref this), ppszNormalization);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputTerms([NativeTypeName("IRichChunk **")] IRichChunk** ppPropertyTerm, [NativeTypeName("IRichChunk **")] IRichChunk** ppOperationTerm, [NativeTypeName("IRichChunk **")] IRichChunk** ppValueTerm)
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, IRichChunk**, IRichChunk**, IRichChunk**, int>)(lpVtbl[13]))((ICondition*)Unsafe.AsPointer(ref this), ppPropertyTerm, ppOperationTerm, ppValueTerm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("ICondition **")] ICondition** ppc)
        {
            return ((delegate* unmanaged[Stdcall]<ICondition*, ICondition**, int>)(lpVtbl[14]))((ICondition*)Unsafe.AsPointer(ref this), ppc);
        }
    }
}
