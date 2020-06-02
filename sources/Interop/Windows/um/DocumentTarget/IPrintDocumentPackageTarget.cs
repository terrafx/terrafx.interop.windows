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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPackageTargetTypes([NativeTypeName("UINT32 *")] uint* targetCount, [NativeTypeName("GUID **")] Guid** targetTypes)
        {
            return lpVtbl->GetPackageTargetTypes((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), targetCount, targetTypes);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPackageTarget([NativeTypeName("const GUID &")] Guid* guidTargetType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvTarget)
        {
            return lpVtbl->GetPackageTarget((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), guidTargetType, riid, ppvTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int Cancel()
        {
            return lpVtbl->Cancel((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPrintDocumentPackageTarget*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPrintDocumentPackageTarget*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPrintDocumentPackageTarget*, uint> Release;

            [NativeTypeName("HRESULT (UINT32 *, GUID **) __attribute__((stdcall))")]
            public delegate* stdcall<IPrintDocumentPackageTarget*, uint*, Guid**, int> GetPackageTargetTypes;

            [NativeTypeName("HRESULT (const GUID &, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int> GetPackageTarget;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPrintDocumentPackageTarget*, int> Cancel;
        }
    }
}
