// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54133220-1CE8-43D3-8236-9855C5CEECFF")]
    public unsafe partial struct ID3D11FunctionLinkingGraph
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11FunctionLinkingGraph* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11FunctionLinkingGraph* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11FunctionLinkingGraph* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateModuleInstance(ID3D11FunctionLinkingGraph* pThis, [NativeTypeName("struct ID3D11ModuleInstance **")] ID3D11ModuleInstance** ppModuleInstance, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorBuffer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInputSignature(ID3D11FunctionLinkingGraph* pThis, [NativeTypeName("const D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pInputParameters, [NativeTypeName("UINT")] uint cInputParameters, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppInputNode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOutputSignature(ID3D11FunctionLinkingGraph* pThis, [NativeTypeName("const D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pOutputParameters, [NativeTypeName("UINT")] uint cOutputParameters, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppOutputNode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CallFunction(ID3D11FunctionLinkingGraph* pThis, [NativeTypeName("LPCSTR")] sbyte* pModuleInstanceNamespace, [NativeTypeName("struct ID3D11Module *")] ID3D11Module* pModuleWithFunctionPrototype, [NativeTypeName("LPCSTR")] sbyte* pFunctionName, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppCallNode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PassValue(ID3D11FunctionLinkingGraph* pThis, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pSrcNode, [NativeTypeName("INT")] int SrcParameterIndex, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pDstNode, [NativeTypeName("INT")] int DstParameterIndex);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PassValueWithSwizzle(ID3D11FunctionLinkingGraph* pThis, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pSrcNode, [NativeTypeName("INT")] int SrcParameterIndex, [NativeTypeName("LPCSTR")] sbyte* pSrcSwizzle, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pDstNode, [NativeTypeName("INT")] int DstParameterIndex, [NativeTypeName("LPCSTR")] sbyte* pDstSwizzle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLastError(ID3D11FunctionLinkingGraph* pThis, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorBuffer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GenerateHlsl(ID3D11FunctionLinkingGraph* pThis, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppBuffer);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateModuleInstance([NativeTypeName("struct ID3D11ModuleInstance **")] ID3D11ModuleInstance** ppModuleInstance, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorBuffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateModuleInstance>(lpVtbl->CreateModuleInstance)((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), ppModuleInstance, ppErrorBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputSignature([NativeTypeName("const D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pInputParameters, [NativeTypeName("UINT")] uint cInputParameters, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppInputNode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetInputSignature>(lpVtbl->SetInputSignature)((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pInputParameters, cInputParameters, ppInputNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputSignature([NativeTypeName("const D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pOutputParameters, [NativeTypeName("UINT")] uint cOutputParameters, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppOutputNode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOutputSignature>(lpVtbl->SetOutputSignature)((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pOutputParameters, cOutputParameters, ppOutputNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int CallFunction([NativeTypeName("LPCSTR")] sbyte* pModuleInstanceNamespace, [NativeTypeName("struct ID3D11Module *")] ID3D11Module* pModuleWithFunctionPrototype, [NativeTypeName("LPCSTR")] sbyte* pFunctionName, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppCallNode)
        {
            return Marshal.GetDelegateForFunctionPointer<_CallFunction>(lpVtbl->CallFunction)((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int PassValue([NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pSrcNode, [NativeTypeName("INT")] int SrcParameterIndex, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pDstNode, [NativeTypeName("INT")] int DstParameterIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_PassValue>(lpVtbl->PassValue)((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pSrcNode, SrcParameterIndex, pDstNode, DstParameterIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int PassValueWithSwizzle([NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pSrcNode, [NativeTypeName("INT")] int SrcParameterIndex, [NativeTypeName("LPCSTR")] sbyte* pSrcSwizzle, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pDstNode, [NativeTypeName("INT")] int DstParameterIndex, [NativeTypeName("LPCSTR")] sbyte* pDstSwizzle)
        {
            return Marshal.GetDelegateForFunctionPointer<_PassValueWithSwizzle>(lpVtbl->PassValueWithSwizzle)((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastError([NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorBuffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLastError>(lpVtbl->GetLastError)((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), ppErrorBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GenerateHlsl([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppBuffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GenerateHlsl>(lpVtbl->GenerateHlsl)((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), uFlags, ppBuffer);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (struct ID3D11ModuleInstance **, ID3DBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateModuleInstance;

            [NativeTypeName("HRESULT (const D3D11_PARAMETER_DESC *, UINT, struct ID3D11LinkingNode **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetInputSignature;

            [NativeTypeName("HRESULT (const D3D11_PARAMETER_DESC *, UINT, struct ID3D11LinkingNode **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOutputSignature;

            [NativeTypeName("HRESULT (LPCSTR, struct ID3D11Module *, LPCSTR, struct ID3D11LinkingNode **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CallFunction;

            [NativeTypeName("HRESULT (struct ID3D11LinkingNode *, INT, struct ID3D11LinkingNode *, INT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr PassValue;

            [NativeTypeName("HRESULT (struct ID3D11LinkingNode *, INT, LPCSTR, struct ID3D11LinkingNode *, INT, LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr PassValueWithSwizzle;

            [NativeTypeName("HRESULT (ID3DBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLastError;

            [NativeTypeName("HRESULT (UINT, ID3DBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GenerateHlsl;
        }
    }
}
