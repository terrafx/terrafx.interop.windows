// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A7ABA9C1-8983-11CF-8F20-00805F2CD064")]
    public unsafe partial struct IProvideMultipleClassInfo
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IProvideMultipleClassInfo* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IProvideMultipleClassInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IProvideMultipleClassInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClassInfoA(IProvideMultipleClassInfo* pThis, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTI);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGUID(IProvideMultipleClassInfo* pThis, [NativeTypeName("DWORD")] uint dwGuidKind, [NativeTypeName("GUID *")] Guid* pGUID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMultiTypeInfoCount(IProvideMultipleClassInfo* pThis, [NativeTypeName("ULONG *")] uint* pcti);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetInfoOfIndex(IProvideMultipleClassInfo* pThis, [NativeTypeName("ULONG")] uint iti, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ITypeInfo **")] ITypeInfo** pptiCoClass, [NativeTypeName("DWORD *")] uint* pdwTIFlags, [NativeTypeName("ULONG *")] uint* pcdispidReserved, [NativeTypeName("IID *")] Guid* piidPrimary, [NativeTypeName("IID *")] Guid* piidSource);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassInfoA([NativeTypeName("ITypeInfo **")] ITypeInfo** ppTI)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClassInfoA>(lpVtbl->GetClassInfoA)((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), ppTI);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("DWORD")] uint dwGuidKind, [NativeTypeName("GUID *")] Guid* pGUID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGUID>(lpVtbl->GetGUID)((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), dwGuidKind, pGUID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMultiTypeInfoCount([NativeTypeName("ULONG *")] uint* pcti)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMultiTypeInfoCount>(lpVtbl->GetMultiTypeInfoCount)((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), pcti);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInfoOfIndex([NativeTypeName("ULONG")] uint iti, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ITypeInfo **")] ITypeInfo** pptiCoClass, [NativeTypeName("DWORD *")] uint* pdwTIFlags, [NativeTypeName("ULONG *")] uint* pcdispidReserved, [NativeTypeName("IID *")] Guid* piidPrimary, [NativeTypeName("IID *")] Guid* piidSource)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInfoOfIndex>(lpVtbl->GetInfoOfIndex)((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (ITypeInfo **) __attribute__((stdcall))")]
            public IntPtr GetClassInfoA;

            [NativeTypeName("HRESULT (DWORD, GUID *) __attribute__((stdcall))")]
            public IntPtr GetGUID;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public IntPtr GetMultiTypeInfoCount;

            [NativeTypeName("HRESULT (ULONG, DWORD, ITypeInfo **, DWORD *, ULONG *, IID *, IID *) __attribute__((stdcall))")]
            public IntPtr GetInfoOfIndex;
        }
    }
}
