// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54384F1B-5B3E-4BB7-AE01-60BA3097CBB6")]
    public unsafe partial struct ID3D11LibraryReflection
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11LibraryReflection* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11LibraryReflection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11LibraryReflection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D11LibraryReflection* pThis, [NativeTypeName("D3D11_LIBRARY_DESC *")] D3D11_LIBRARY_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ID3D11FunctionReflection *")]
        public delegate ID3D11FunctionReflection* _GetFunctionByIndex(ID3D11LibraryReflection* pThis, [NativeTypeName("INT")] int FunctionIndex);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D11_LIBRARY_DESC *")] D3D11_LIBRARY_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D11FunctionReflection *")]
        public ID3D11FunctionReflection* GetFunctionByIndex([NativeTypeName("INT")] int FunctionIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFunctionByIndex>(lpVtbl->GetFunctionByIndex)((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), FunctionIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (D3D11_LIBRARY_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("ID3D11FunctionReflection *(INT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFunctionByIndex;
        }
    }
}
