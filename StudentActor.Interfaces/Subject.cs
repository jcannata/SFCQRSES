﻿using System.Runtime.Serialization;

namespace StudentActor.Interfaces
{
    [DataContract]
    public enum Subject
    {
        [EnumMember]
        Math = 1,
        [EnumMember]
        Physics = 2,
        [EnumMember]
        Language = 3,
        [EnumMember]
        IT = 4
    }
}