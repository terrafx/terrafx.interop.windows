// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020403-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeComp
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ITypeComp* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ITypeComp* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ITypeComp* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Bind(ITypeComp* This, [NativeTypeName("LPOLESTR")] ushort* szName, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("WORD")] ushort wFlags, ITypeInfo** ppTInfo, DESCKIND* pDescKind, BINDPTR* pBindPtr);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindType(ITypeComp* This, [NativeTypeName("LPOLESTR")] ushort* szName, [NativeTypeName("ULONG")] uint lHashVal, ITypeInfo** ppTInfo, ITypeComp** ppTComp);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ITypeComp* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ITypeComp* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ITypeComp* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Bind([NativeTypeName("LPOLESTR")] ushort* szName, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("WORD")] ushort wFlags, ITypeInfo** ppTInfo, DESCKIND* pDescKind, BINDPTR* pBindPtr)
        {
            fixed (ITypeComp* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Bind>(lpVtbl->Bind)(This, szName, lHashVal, wFlags, ppTInfo, pDescKind, pBindPtr);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int BindType([NativeTypeName("LPOLESTR")] ushort* szName, [NativeTypeName("ULONG")] uint lHashVal, ITypeInfo** ppTInfo, ITypeComp** ppTComp
        )
        {
            fixed (ITypeComp* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_BindType>(lpVtbl->BindType)(This, szName, lHashVal, ppTInfo, ppTComp);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr Bind;

            public IntPtr BindType;
        }
    }
}
