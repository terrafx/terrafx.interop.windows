// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define RESOURCE_MANAGER_VOLATILE 0x00000001")]
        public const int RESOURCE_MANAGER_VOLATILE = 0x00000001;

        [NativeTypeName("#define RESOURCE_MANAGER_COMMUNICATION 0x00000002")]
        public const int RESOURCE_MANAGER_COMMUNICATION = 0x00000002;

        [NativeTypeName("#define RESOURCE_MANAGER_MAXIMUM_OPTION 0x00000003")]
        public const int RESOURCE_MANAGER_MAXIMUM_OPTION = 0x00000003;

        [NativeTypeName("#define CRM_PROTOCOL_EXPLICIT_MARSHAL_ONLY 0x00000001")]
        public const int CRM_PROTOCOL_EXPLICIT_MARSHAL_ONLY = 0x00000001;

        [NativeTypeName("#define CRM_PROTOCOL_DYNAMIC_MARSHAL_INFO 0x00000002")]
        public const int CRM_PROTOCOL_DYNAMIC_MARSHAL_INFO = 0x00000002;

        [NativeTypeName("#define CRM_PROTOCOL_MAXIMUM_OPTION 0x00000003")]
        public const int CRM_PROTOCOL_MAXIMUM_OPTION = 0x00000003;

        [NativeTypeName("#define ENLISTMENT_SUPERIOR 0x00000001")]
        public const int ENLISTMENT_SUPERIOR = 0x00000001;

        [NativeTypeName("#define ENLISTMENT_MAXIMUM_OPTION 0x00000001")]
        public const int ENLISTMENT_MAXIMUM_OPTION = 0x00000001;

        [NativeTypeName("#define TRANSACTIONMANAGER_OBJECT_PATH L\"\\\\TransactionManager\\\\\"")]
        public const string TRANSACTIONMANAGER_OBJECT_PATH = "\\TransactionManager\\";

        [NativeTypeName("#define ENLISTMENT_OBJECT_PATH L\"\\\\Enlistment\\\\\"")]
        public const string ENLISTMENT_OBJECT_PATH = "\\Enlistment\\";

        [NativeTypeName("#define RESOURCE_MANAGER_OBJECT_PATH L\"\\\\ResourceManager\\\\\"")]
        public const string RESOURCE_MANAGER_OBJECT_PATH = "\\ResourceManager\\";

        [NativeTypeName("#define TRANSACTIONMANAGER_OBJECT_NAME_LENGTH_IN_BYTES (sizeof(TRANSACTIONMANAGER_OBJECT_PATH)+(38*sizeof(WCHAR)))")]
        public const uint TRANSACTIONMANAGER_OBJECT_NAME_LENGTH_IN_BYTES = (42 + (38 * 2));

        [NativeTypeName("#define ENLISTMENT_OBJECT_NAME_LENGTH_IN_BYTES (sizeof(ENLISTMENT_OBJECT_PATH)+(38*sizeof(WCHAR)))")]
        public const uint ENLISTMENT_OBJECT_NAME_LENGTH_IN_BYTES = (26 + (38 * 2));

        [NativeTypeName("#define RESOURCE_MANAGER_OBJECT_NAME_LENGTH_IN_BYTES (sizeof(RESOURCE_MANAGER_OBJECT_PATH)+(38*sizeof(WCHAR)))")]
        public const uint RESOURCE_MANAGER_OBJECT_NAME_LENGTH_IN_BYTES = (36 + (38 * 2));

        [NativeTypeName("#define KTM_MARSHAL_BLOB_VERSION_MAJOR 1")]
        public const int KTM_MARSHAL_BLOB_VERSION_MAJOR = 1;

        [NativeTypeName("#define KTM_MARSHAL_BLOB_VERSION_MINOR 1")]
        public const int KTM_MARSHAL_BLOB_VERSION_MINOR = 1;
    }
}
