// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8D536CA1-0CCA-4956-A837-786963755584")]
    public unsafe partial struct ID3D11ShaderReflection
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11ShaderReflection* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11ShaderReflection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11ShaderReflection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D11ShaderReflection* pThis, [NativeTypeName("D3D11_SHADER_DESC *")] D3D11_SHADER_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public delegate ID3D11ShaderReflectionConstantBuffer* _GetConstantBufferByIndex(ID3D11ShaderReflection* pThis, [NativeTypeName("UINT")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public delegate ID3D11ShaderReflectionConstantBuffer* _GetConstantBufferByName(ID3D11ShaderReflection* pThis, [NativeTypeName("LPCSTR")] sbyte* Name);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResourceBindingDesc(ID3D11ShaderReflection* pThis, [NativeTypeName("UINT")] uint ResourceIndex, [NativeTypeName("D3D11_SHADER_INPUT_BIND_DESC *")] D3D11_SHADER_INPUT_BIND_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetInputParameterDesc(ID3D11ShaderReflection* pThis, [NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D11_SIGNATURE_PARAMETER_DESC *")] D3D11_SIGNATURE_PARAMETER_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetOutputParameterDesc(ID3D11ShaderReflection* pThis, [NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D11_SIGNATURE_PARAMETER_DESC *")] D3D11_SIGNATURE_PARAMETER_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPatchConstantParameterDesc(ID3D11ShaderReflection* pThis, [NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D11_SIGNATURE_PARAMETER_DESC *")] D3D11_SIGNATURE_PARAMETER_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ID3D11ShaderReflectionVariable *")]
        public delegate ID3D11ShaderReflectionVariable* _GetVariableByName(ID3D11ShaderReflection* pThis, [NativeTypeName("LPCSTR")] sbyte* Name);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResourceBindingDescByName(ID3D11ShaderReflection* pThis, [NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("D3D11_SHADER_INPUT_BIND_DESC *")] D3D11_SHADER_INPUT_BIND_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetMovInstructionCount(ID3D11ShaderReflection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetMovcInstructionCount(ID3D11ShaderReflection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetConversionInstructionCount(ID3D11ShaderReflection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetBitwiseInstructionCount(ID3D11ShaderReflection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D3D_PRIMITIVE _GetGSInputPrimitive(ID3D11ShaderReflection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsSampleFrequencyShader(ID3D11ShaderReflection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetNumInterfaceSlots(ID3D11ShaderReflection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMinFeatureLevel(ID3D11ShaderReflection* pThis, [NativeTypeName("enum D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pLevel);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetThreadGroupSize(ID3D11ShaderReflection* pThis, [NativeTypeName("UINT *")] uint* pSizeX, [NativeTypeName("UINT *")] uint* pSizeY, [NativeTypeName("UINT *")] uint* pSizeZ);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetRequiresFlags(ID3D11ShaderReflection* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D11_SHADER_DESC *")] D3D11_SHADER_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint Index)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetConstantBufferByIndex>(lpVtbl->GetConstantBufferByIndex)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetConstantBufferByName>(lpVtbl->GetConstantBufferByName)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, [NativeTypeName("D3D11_SHADER_INPUT_BIND_DESC *")] D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetResourceBindingDesc>(lpVtbl->GetResourceBindingDesc)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D11_SIGNATURE_PARAMETER_DESC *")] D3D11_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInputParameterDesc>(lpVtbl->GetInputParameterDesc)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D11_SIGNATURE_PARAMETER_DESC *")] D3D11_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOutputParameterDesc>(lpVtbl->GetOutputParameterDesc)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPatchConstantParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D11_SIGNATURE_PARAMETER_DESC *")] D3D11_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPatchConstantParameterDesc>(lpVtbl->GetPatchConstantParameterDesc)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [return: NativeTypeName("ID3D11ShaderReflectionVariable *")]
        public ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVariableByName>(lpVtbl->GetVariableByName)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("D3D11_SHADER_INPUT_BIND_DESC *")] D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetResourceBindingDescByName>(lpVtbl->GetResourceBindingDescByName)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [return: NativeTypeName("UINT")]
        public uint GetMovInstructionCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMovInstructionCount>(lpVtbl->GetMovInstructionCount)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetMovcInstructionCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMovcInstructionCount>(lpVtbl->GetMovcInstructionCount)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetConversionInstructionCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetConversionInstructionCount>(lpVtbl->GetConversionInstructionCount)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetBitwiseInstructionCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBitwiseInstructionCount>(lpVtbl->GetBitwiseInstructionCount)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        public D3D_PRIMITIVE GetGSInputPrimitive()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGSInputPrimitive>(lpVtbl->GetGSInputPrimitive)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsSampleFrequencyShader()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsSampleFrequencyShader>(lpVtbl->IsSampleFrequencyShader)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetNumInterfaceSlots()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumInterfaceSlots>(lpVtbl->GetNumInterfaceSlots)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pLevel)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMinFeatureLevel>(lpVtbl->GetMinFeatureLevel)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pLevel);
        }

        [return: NativeTypeName("UINT")]
        public uint GetThreadGroupSize([NativeTypeName("UINT *")] uint* pSizeX, [NativeTypeName("UINT *")] uint* pSizeY, [NativeTypeName("UINT *")] uint* pSizeZ)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetThreadGroupSize>(lpVtbl->GetThreadGroupSize)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pSizeX, pSizeY, pSizeZ);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetRequiresFlags()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRequiresFlags>(lpVtbl->GetRequiresFlags)((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (D3D11_SHADER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("ID3D11ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetConstantBufferByIndex;

            [NativeTypeName("ID3D11ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetConstantBufferByName;

            [NativeTypeName("HRESULT (UINT, D3D11_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetResourceBindingDesc;

            [NativeTypeName("HRESULT (UINT, D3D11_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetInputParameterDesc;

            [NativeTypeName("HRESULT (UINT, D3D11_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetOutputParameterDesc;

            [NativeTypeName("HRESULT (UINT, D3D11_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPatchConstantParameterDesc;

            [NativeTypeName("ID3D11ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetVariableByName;

            [NativeTypeName("HRESULT (LPCSTR, D3D11_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetResourceBindingDescByName;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMovInstructionCount;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMovcInstructionCount;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetConversionInstructionCount;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetBitwiseInstructionCount;

            [NativeTypeName("D3D_PRIMITIVE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGSInputPrimitive;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr IsSampleFrequencyShader;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetNumInterfaceSlots;

            [NativeTypeName("HRESULT (enum D3D_FEATURE_LEVEL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMinFeatureLevel;

            [NativeTypeName("UINT (UINT *, UINT *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetThreadGroupSize;

            [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetRequiresFlags;
        }
    }
}
