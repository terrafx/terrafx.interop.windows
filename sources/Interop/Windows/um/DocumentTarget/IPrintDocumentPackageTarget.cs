// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1B8EFEC4-3019-4C27-964E-367202156906")]
    public unsafe partial struct IPrintDocumentPackageTarget
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPrintDocumentPackageTarget* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPrintDocumentPackageTarget* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPrintDocumentPackageTarget* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPackageTargetTypes(IPrintDocumentPackageTarget* pThis, [NativeTypeName("UINT32 *")] uint* targetCount, [NativeTypeName("GUID **")] Guid** targetTypes);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPackageTarget(IPrintDocumentPackageTarget* pThis, [NativeTypeName("const GUID &")] Guid* guidTargetType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvTarget);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Cancel(IPrintDocumentPackageTarget* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPackageTargetTypes([NativeTypeName("UINT32 *")] uint* targetCount, [NativeTypeName("GUID **")] Guid** targetTypes)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPackageTargetTypes>(lpVtbl->GetPackageTargetTypes)((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), targetCount, targetTypes);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPackageTarget([NativeTypeName("const GUID &")] Guid* guidTargetType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvTarget)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPackageTarget>(lpVtbl->GetPackageTarget)((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), guidTargetType, riid, ppvTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int Cancel()
        {
            return Marshal.GetDelegateForFunctionPointer<_Cancel>(lpVtbl->Cancel)((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT32 *, GUID **) __attribute__((stdcall))")]
            public IntPtr GetPackageTargetTypes;

            [NativeTypeName("HRESULT (const GUID &, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetPackageTarget;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Cancel;
        }
    }
}
