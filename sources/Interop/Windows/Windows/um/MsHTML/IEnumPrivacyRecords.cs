// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3050F844-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IEnumPrivacyRecords : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumPrivacyRecords : IEnumPrivacyRecords.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, Guid*, void**, int>)(lpVtbl[0]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, uint>)(lpVtbl[1]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, uint>)(lpVtbl[2]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, int>)(lpVtbl[3]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSize([NativeTypeName("ULONG *")] uint* pSize)
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, uint*, int>)(lpVtbl[4]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this), pSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPrivacyImpacted(BOOL* pState)
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, BOOL*, int>)(lpVtbl[5]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this), pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Next([NativeTypeName("BSTR *")] ushort** pbstrUrl, [NativeTypeName("BSTR *")] ushort** pbstrPolicyRef, [NativeTypeName("LONG *")] int* pdwReserved, [NativeTypeName("DWORD *")] uint* pdwPrivacyFlags)
        {
            return ((delegate* unmanaged<IEnumPrivacyRecords*, ushort**, ushort**, int*, uint*, int>)(lpVtbl[6]))((IEnumPrivacyRecords*)Unsafe.AsPointer(ref this), pbstrUrl, pbstrPolicyRef, pdwReserved, pdwPrivacyFlags);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Reset();

            [VtblIndex(4)]
            HRESULT GetSize([NativeTypeName("ULONG *")] uint* pSize);

            [VtblIndex(5)]
            HRESULT GetPrivacyImpacted(BOOL* pState);

            [VtblIndex(6)]
            HRESULT Next([NativeTypeName("BSTR *")] ushort** pbstrUrl, [NativeTypeName("BSTR *")] ushort** pbstrPolicyRef, [NativeTypeName("LONG *")] int* pdwReserved, [NativeTypeName("DWORD *")] uint* pdwPrivacyFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumPrivacyRecords*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumPrivacyRecords*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumPrivacyRecords*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumPrivacyRecords*, int> Reset;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumPrivacyRecords*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumPrivacyRecords*, BOOL*, int> GetPrivacyImpacted;

            [NativeTypeName("HRESULT (BSTR *, BSTR *, LONG *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumPrivacyRecords*, ushort**, ushort**, int*, uint*, int> Next;
        }
    }
}
