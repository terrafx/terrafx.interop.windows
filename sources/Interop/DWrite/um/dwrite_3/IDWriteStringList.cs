// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CFEE3140-1157-47CA-8B85-31BFCF3F2D0E")]
    public unsafe partial struct IDWriteStringList
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteStringList* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteStringList* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteStringList* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetCount(IDWriteStringList* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleNameLength(IDWriteStringList* pThis, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32 *")] uint* length);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleName(IDWriteStringList* pThis, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint size);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetStringLength(IDWriteStringList* pThis, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32 *")] uint* length);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetString(IDWriteStringList* pThis, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* stringBuffer, [NativeTypeName("UINT32")] uint stringBufferSize);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteStringList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteStringList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteStringList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCount>(lpVtbl->GetCount)((IDWriteStringList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleNameLength([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32 *")] uint* length)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocaleNameLength>(lpVtbl->GetLocaleNameLength)((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, length);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint size)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLocaleName>(lpVtbl->GetLocaleName)((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, localeName, size);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32 *")] uint* length)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStringLength>(lpVtbl->GetStringLength)((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, length);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* stringBuffer, [NativeTypeName("UINT32")] uint stringBufferSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetString>(lpVtbl->GetString)((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, stringBuffer, stringBufferSize);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetCount;

            [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocaleNameLength;

            [NativeTypeName("HRESULT (UINT32, WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetLocaleName;

            [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetStringLength;

            [NativeTypeName("HRESULT (UINT32, WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetString;
        }
    }
}
