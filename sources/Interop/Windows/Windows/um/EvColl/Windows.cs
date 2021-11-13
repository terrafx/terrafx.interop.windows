// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("wecapi", ExactSpelling = true, SetLastError = true)]
        public static extern EC_HANDLE EcOpenSubscriptionEnum([NativeTypeName("DWORD")] uint Flags);

        [DllImport("wecapi", ExactSpelling = true)]
        public static extern BOOL EcEnumNextSubscription(EC_HANDLE SubscriptionEnum, [NativeTypeName("DWORD")] uint SubscriptionNameBufferSize, [NativeTypeName("LPWSTR")] ushort* SubscriptionNameBuffer, [NativeTypeName("PDWORD")] uint* SubscriptionNameBufferUsed);

        [DllImport("wecapi", ExactSpelling = true, SetLastError = true)]
        public static extern EC_HANDLE EcOpenSubscription([NativeTypeName("LPCWSTR")] ushort* SubscriptionName, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("wecapi", ExactSpelling = true)]
        public static extern BOOL EcSetSubscriptionProperty(EC_HANDLE Subscription, EC_SUBSCRIPTION_PROPERTY_ID PropertyId, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* PropertyValue);

        [DllImport("wecapi", ExactSpelling = true)]
        public static extern BOOL EcGetSubscriptionProperty(EC_HANDLE Subscription, EC_SUBSCRIPTION_PROPERTY_ID PropertyId, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint PropertyValueBufferSize, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* PropertyValueBuffer, [NativeTypeName("PDWORD")] uint* PropertyValueBufferUsed);

        [DllImport("wecapi", ExactSpelling = true)]
        public static extern BOOL EcSaveSubscription(EC_HANDLE Subscription, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("wecapi", ExactSpelling = true)]
        public static extern BOOL EcDeleteSubscription([NativeTypeName("LPCWSTR")] ushort* SubscriptionName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("wecapi", ExactSpelling = true)]
        public static extern BOOL EcGetObjectArraySize(EC_OBJECT_ARRAY_PROPERTY_HANDLE ObjectArray, [NativeTypeName("PDWORD")] uint* ObjectArraySize);

        [DllImport("wecapi", ExactSpelling = true)]
        public static extern BOOL EcSetObjectArrayProperty(EC_OBJECT_ARRAY_PROPERTY_HANDLE ObjectArray, EC_SUBSCRIPTION_PROPERTY_ID PropertyId, [NativeTypeName("DWORD")] uint ArrayIndex, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* PropertyValue);

        [DllImport("wecapi", ExactSpelling = true)]
        public static extern BOOL EcGetObjectArrayProperty(EC_OBJECT_ARRAY_PROPERTY_HANDLE ObjectArray, EC_SUBSCRIPTION_PROPERTY_ID PropertyId, [NativeTypeName("DWORD")] uint ArrayIndex, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint PropertyValueBufferSize, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* PropertyValueBuffer, [NativeTypeName("PDWORD")] uint* PropertyValueBufferUsed);

        [DllImport("wecapi", ExactSpelling = true)]
        public static extern BOOL EcInsertObjectArrayElement(EC_OBJECT_ARRAY_PROPERTY_HANDLE ObjectArray, [NativeTypeName("DWORD")] uint ArrayIndex);

        [DllImport("wecapi", ExactSpelling = true)]
        public static extern BOOL EcRemoveObjectArrayElement(EC_OBJECT_ARRAY_PROPERTY_HANDLE ObjectArray, [NativeTypeName("DWORD")] uint ArrayIndex);

        [DllImport("wecapi", ExactSpelling = true)]
        public static extern BOOL EcGetSubscriptionRunTimeStatus([NativeTypeName("LPCWSTR")] ushort* SubscriptionName, EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID StatusInfoId, [NativeTypeName("LPCWSTR")] ushort* EventSourceName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint StatusValueBufferSize, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* StatusValueBuffer, [NativeTypeName("PDWORD")] uint* StatusValueBufferUsed);

        [DllImport("wecapi", ExactSpelling = true)]
        public static extern BOOL EcRetrySubscription([NativeTypeName("LPCWSTR")] ushort* SubscriptionName, [NativeTypeName("LPCWSTR")] ushort* EventSourceName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("wecapi", ExactSpelling = true)]
        public static extern BOOL EcClose(EC_HANDLE Object);

        [NativeTypeName("#define EC_VARIANT_TYPE_MASK 0x7f")]
        public const int EC_VARIANT_TYPE_MASK = 0x7f;

        [NativeTypeName("#define EC_VARIANT_TYPE_ARRAY 128")]
        public const int EC_VARIANT_TYPE_ARRAY = 128;

        [NativeTypeName("#define EC_READ_ACCESS 1")]
        public const int EC_READ_ACCESS = 1;

        [NativeTypeName("#define EC_WRITE_ACCESS 2")]
        public const int EC_WRITE_ACCESS = 2;

        [NativeTypeName("#define EC_OPEN_ALWAYS 0")]
        public const int EC_OPEN_ALWAYS = 0;

        [NativeTypeName("#define EC_CREATE_NEW 1")]
        public const int EC_CREATE_NEW = 1;

        [NativeTypeName("#define EC_OPEN_EXISTING 2")]
        public const int EC_OPEN_EXISTING = 2;
    }
}
