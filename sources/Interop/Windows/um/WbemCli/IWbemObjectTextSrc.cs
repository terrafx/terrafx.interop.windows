// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BFBF883A-CAD7-11D3-A11B-00105A1F515A")]
    [NativeTypeName("struct IWbemObjectTextSrc : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWbemObjectTextSrc
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemObjectTextSrc*, Guid*, void**, int>)(lpVtbl[0]))((IWbemObjectTextSrc*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemObjectTextSrc*, uint>)(lpVtbl[1]))((IWbemObjectTextSrc*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemObjectTextSrc*, uint>)(lpVtbl[2]))((IWbemObjectTextSrc*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetText([NativeTypeName("long")] int lFlags, IWbemClassObject* pObj, [NativeTypeName("ULONG")] uint uObjTextFormat, IWbemContext* pCtx, [NativeTypeName("BSTR *")] ushort** strText)
        {
            return ((delegate* unmanaged<IWbemObjectTextSrc*, int, IWbemClassObject*, uint, IWbemContext*, ushort**, int>)(lpVtbl[3]))((IWbemObjectTextSrc*)Unsafe.AsPointer(ref this), lFlags, pObj, uObjTextFormat, pCtx, strText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateFromText([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR")] ushort* strText, [NativeTypeName("ULONG")] uint uObjTextFormat, IWbemContext* pCtx, IWbemClassObject** pNewObj)
        {
            return ((delegate* unmanaged<IWbemObjectTextSrc*, int, ushort*, uint, IWbemContext*, IWbemClassObject**, int>)(lpVtbl[4]))((IWbemObjectTextSrc*)Unsafe.AsPointer(ref this), lFlags, strText, uObjTextFormat, pCtx, pNewObj);
        }
    }
}
