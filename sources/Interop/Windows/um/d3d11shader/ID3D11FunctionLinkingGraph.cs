// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54133220-1CE8-43D3-8236-9855C5CEECFF")]
    [NativeTypeName("struct ID3D11FunctionLinkingGraph : IUnknown")]
    public unsafe partial struct ID3D11FunctionLinkingGraph
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D11FunctionLinkingGraph*, uint>)(lpVtbl[1]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D11FunctionLinkingGraph*, uint>)(lpVtbl[2]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateModuleInstance([NativeTypeName("struct ID3D11ModuleInstance **")] ID3D11ModuleInstance** ppModuleInstance, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorBuffer)
        {
            return ((delegate* stdcall<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, ID3DBlob**, int>)(lpVtbl[3]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), ppModuleInstance, ppErrorBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInputSignature([NativeTypeName("const D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pInputParameters, [NativeTypeName("UINT")] uint cInputParameters, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppInputNode)
        {
            return ((delegate* stdcall<ID3D11FunctionLinkingGraph*, D3D11_PARAMETER_DESC*, uint, ID3D11LinkingNode**, int>)(lpVtbl[4]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pInputParameters, cInputParameters, ppInputNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputSignature([NativeTypeName("const D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pOutputParameters, [NativeTypeName("UINT")] uint cOutputParameters, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppOutputNode)
        {
            return ((delegate* stdcall<ID3D11FunctionLinkingGraph*, D3D11_PARAMETER_DESC*, uint, ID3D11LinkingNode**, int>)(lpVtbl[5]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pOutputParameters, cOutputParameters, ppOutputNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CallFunction([NativeTypeName("LPCSTR")] sbyte* pModuleInstanceNamespace, [NativeTypeName("struct ID3D11Module *")] ID3D11Module* pModuleWithFunctionPrototype, [NativeTypeName("LPCSTR")] sbyte* pFunctionName, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppCallNode)
        {
            return ((delegate* stdcall<ID3D11FunctionLinkingGraph*, sbyte*, ID3D11Module*, sbyte*, ID3D11LinkingNode**, int>)(lpVtbl[6]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PassValue([NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pSrcNode, [NativeTypeName("INT")] int SrcParameterIndex, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pDstNode, [NativeTypeName("INT")] int DstParameterIndex)
        {
            return ((delegate* stdcall<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)(lpVtbl[7]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pSrcNode, SrcParameterIndex, pDstNode, DstParameterIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PassValueWithSwizzle([NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pSrcNode, [NativeTypeName("INT")] int SrcParameterIndex, [NativeTypeName("LPCSTR")] sbyte* pSrcSwizzle, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pDstNode, [NativeTypeName("INT")] int DstParameterIndex, [NativeTypeName("LPCSTR")] sbyte* pDstSwizzle)
        {
            return ((delegate* stdcall<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, sbyte*, ID3D11LinkingNode*, int, sbyte*, int>)(lpVtbl[8]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLastError([NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorBuffer)
        {
            return ((delegate* stdcall<ID3D11FunctionLinkingGraph*, ID3DBlob**, int>)(lpVtbl[9]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), ppErrorBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GenerateHlsl([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppBuffer)
        {
            return ((delegate* stdcall<ID3D11FunctionLinkingGraph*, uint, ID3DBlob**, int>)(lpVtbl[10]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), uFlags, ppBuffer);
        }
    }
}
