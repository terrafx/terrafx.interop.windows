// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A4D055A6-F9E3-4E25-93B7-9E309F3AF8E9")]
    public unsafe partial struct IDWriteFontCollection3
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontCollection3* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontCollection3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontCollection3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontFamilyCount(IDWriteFontCollection3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamily(IDWriteFontCollection3* pThis, [NativeTypeName("UINT32")] uint index, [NativeTypeName("IDWriteFontFamily **")] IDWriteFontFamily** fontFamily);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindFamilyName(IDWriteFontCollection3* pThis, [NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("UINT32 *")] uint* index, [NativeTypeName("BOOL *")] int* exists);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFromFontFace(IDWriteFontCollection3* pThis, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("IDWriteFont **")] IDWriteFont** font);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontSet(IDWriteFontCollection3* pThis, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** fontSet);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamily1(IDWriteFontCollection3* pThis, [NativeTypeName("UINT32")] uint index, [NativeTypeName("IDWriteFontFamily1 **")] IDWriteFontFamily1** fontFamily);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamily2(IDWriteFontCollection3* pThis, [NativeTypeName("UINT32")] uint index, [NativeTypeName("IDWriteFontFamily2 **")] IDWriteFontFamily2** fontFamily);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMatchingFonts(IDWriteFontCollection3* pThis, [NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("IDWriteFontList2 **")] IDWriteFontList2** fontList);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_FONT_FAMILY_MODEL _GetFontFamilyModel(IDWriteFontCollection3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontSet1(IDWriteFontCollection3* pThis, [NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** fontSet);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HANDLE")]
        public delegate IntPtr _GetExpirationEvent(IDWriteFontCollection3* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyCount>(lpVtbl->GetFontFamilyCount)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("UINT32")] uint index, [NativeTypeName("IDWriteFontFamily **")] IDWriteFontFamily** fontFamily)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamily>(lpVtbl->GetFontFamily)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFamilyName([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("UINT32 *")] uint* index, [NativeTypeName("BOOL *")] int* exists)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindFamilyName>(lpVtbl->FindFamilyName)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), familyName, index, exists);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFromFontFace([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("IDWriteFont **")] IDWriteFont** font)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFromFontFace>(lpVtbl->GetFontFromFontFace)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontFace, font);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSet([NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** fontSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontSet>(lpVtbl->GetFontSet)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("UINT32")] uint index, [NativeTypeName("IDWriteFontFamily1 **")] IDWriteFontFamily1** fontFamily)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamily1>(lpVtbl->GetFontFamily1)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("UINT32")] uint index, [NativeTypeName("IDWriteFontFamily2 **")] IDWriteFontFamily2** fontFamily)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamily2>(lpVtbl->GetFontFamily2)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("IDWriteFontList2 **")] IDWriteFontList2** fontList)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMatchingFonts>(lpVtbl->GetMatchingFonts)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), familyName, fontAxisValues, fontAxisValueCount, fontList);
        }

        public DWRITE_FONT_FAMILY_MODEL GetFontFamilyModel()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyModel>(lpVtbl->GetFontFamilyModel)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSet([NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** fontSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontSet1>(lpVtbl->GetFontSet1)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontSet);
        }

        [return: NativeTypeName("HANDLE")]
        public IntPtr GetExpirationEvent()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetExpirationEvent>(lpVtbl->GetExpirationEvent)((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
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
            public IntPtr GetFontFamilyCount;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFamily;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FindFamilyName;

            [NativeTypeName("HRESULT (IDWriteFontFace *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFromFontFace;

            [NativeTypeName("HRESULT (IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontSet;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFamily1;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFamily2;

            [NativeTypeName("HRESULT (const WCHAR *, const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontList2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMatchingFonts;

            [NativeTypeName("DWRITE_FONT_FAMILY_MODEL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontFamilyModel;

            [NativeTypeName("HRESULT (IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontSet1;

            [NativeTypeName("HANDLE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetExpirationEvent;
        }
    }
}
