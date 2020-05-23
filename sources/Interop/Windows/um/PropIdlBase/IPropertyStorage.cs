// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000138-0000-0000-C000-000000000046")]
    public unsafe partial struct IPropertyStorage
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPropertyStorage* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPropertyStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPropertyStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReadMultiple(IPropertyStorage* pThis, [NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec, [NativeTypeName("PROPVARIANT []")] PROPVARIANT* rgpropvar);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteMultiple(IPropertyStorage* pThis, [NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec, [NativeTypeName("const PROPVARIANT []")] PROPVARIANT* rgpropvar, [NativeTypeName("PROPID")] uint propidNameFirst);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DeleteMultiple(IPropertyStorage* pThis, [NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReadPropertyNames(IPropertyStorage* pThis, [NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid, [NativeTypeName("LPOLESTR []")] ushort** rglpwstrName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WritePropertyNames(IPropertyStorage* pThis, [NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid, [NativeTypeName("const LPOLESTR []")] ushort** rglpwstrName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DeletePropertyNames(IPropertyStorage* pThis, [NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Commit(IPropertyStorage* pThis, [NativeTypeName("DWORD")] uint grfCommitFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Revert(IPropertyStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Enum(IPropertyStorage* pThis, [NativeTypeName("IEnumSTATPROPSTG **")] IEnumSTATPROPSTG** ppenum);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTimes(IPropertyStorage* pThis, [NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetClass(IPropertyStorage* pThis, [NativeTypeName("const IID &")] Guid* clsid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Stat(IPropertyStorage* pThis, [NativeTypeName("STATPROPSETSTG *")] STATPROPSETSTG* pstatpsstg);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPropertyStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec, [NativeTypeName("PROPVARIANT []")] PROPVARIANT* rgpropvar)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReadMultiple>(lpVtbl->ReadMultiple)((IPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec, rgpropvar);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec, [NativeTypeName("const PROPVARIANT []")] PROPVARIANT* rgpropvar, [NativeTypeName("PROPID")] uint propidNameFirst)
        {
            return Marshal.GetDelegateForFunctionPointer<_WriteMultiple>(lpVtbl->WriteMultiple)((IPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec, rgpropvar, propidNameFirst);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec)
        {
            return Marshal.GetDelegateForFunctionPointer<_DeleteMultiple>(lpVtbl->DeleteMultiple)((IPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadPropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid, [NativeTypeName("LPOLESTR []")] ushort** rglpwstrName)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReadPropertyNames>(lpVtbl->ReadPropertyNames)((IPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid, rglpwstrName);
        }

        [return: NativeTypeName("HRESULT")]
        public int WritePropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid, [NativeTypeName("const LPOLESTR []")] ushort** rglpwstrName)
        {
            return Marshal.GetDelegateForFunctionPointer<_WritePropertyNames>(lpVtbl->WritePropertyNames)((IPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid, rglpwstrName);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeletePropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid)
        {
            return Marshal.GetDelegateForFunctionPointer<_DeletePropertyNames>(lpVtbl->DeletePropertyNames)((IPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)((IPropertyStorage*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return Marshal.GetDelegateForFunctionPointer<_Revert>(lpVtbl->Revert)((IPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Enum([NativeTypeName("IEnumSTATPROPSTG **")] IEnumSTATPROPSTG** ppenum)
        {
            return Marshal.GetDelegateForFunctionPointer<_Enum>(lpVtbl->Enum)((IPropertyStorage*)Unsafe.AsPointer(ref this), ppenum);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTimes([NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTimes>(lpVtbl->SetTimes)((IPropertyStorage*)Unsafe.AsPointer(ref this), pctime, patime, pmtime);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClass([NativeTypeName("const IID &")] Guid* clsid)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetClass>(lpVtbl->SetClass)((IPropertyStorage*)Unsafe.AsPointer(ref this), clsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATPROPSETSTG *")] STATPROPSETSTG* pstatpsstg)
        {
            return Marshal.GetDelegateForFunctionPointer<_Stat>(lpVtbl->Stat)((IPropertyStorage*)Unsafe.AsPointer(ref this), pstatpsstg);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (ULONG, const PROPSPEC *, PROPVARIANT *) __attribute__((stdcall))")]
            public IntPtr ReadMultiple;

            [NativeTypeName("HRESULT (ULONG, const PROPSPEC *, const PROPVARIANT *, PROPID) __attribute__((stdcall))")]
            public IntPtr WriteMultiple;

            [NativeTypeName("HRESULT (ULONG, const PROPSPEC *) __attribute__((stdcall))")]
            public IntPtr DeleteMultiple;

            [NativeTypeName("HRESULT (ULONG, const PROPID *, LPOLESTR *) __attribute__((stdcall))")]
            public IntPtr ReadPropertyNames;

            [NativeTypeName("HRESULT (ULONG, const PROPID *, const LPOLESTR *) __attribute__((stdcall))")]
            public IntPtr WritePropertyNames;

            [NativeTypeName("HRESULT (ULONG, const PROPID *) __attribute__((stdcall))")]
            public IntPtr DeletePropertyNames;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr Commit;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Revert;

            [NativeTypeName("HRESULT (IEnumSTATPROPSTG **) __attribute__((stdcall))")]
            public IntPtr Enum;

            [NativeTypeName("HRESULT (const FILETIME *, const FILETIME *, const FILETIME *) __attribute__((stdcall))")]
            public IntPtr SetTimes;

            [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
            public IntPtr SetClass;

            [NativeTypeName("HRESULT (STATPROPSETSTG *) __attribute__((stdcall))")]
            public IntPtr Stat;
        }
    }
}
